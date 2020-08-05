using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers.UI.Employees
{
    public partial class frmEmployeesList : Form
    {
        public frmEmployeesList()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            Business.Employees Employeeslist = new Business.Employees();
            Employeeslist.Ntiolecode = txtSerch.Text;
            Employeeslist.FirstName = txtSerchName.Text;
            if (txtSerch.Text == "" && txtSerchName.Text == "")
            {
                MessageBox.Show("لطفا یکی ار فیلد هارا برای جستجو پر کنید.");
               
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Employeeslist.read();
            }
            if (txtSerch.Text != string.Empty)
            {

                Employeeslist.serch();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Employeeslist.serch();


            }

            if (txtSerchName.Text != string.Empty)
            {
                Employeeslist.serchName();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Employeeslist.serchName();

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            Business.Employees EmployeesDeleat = new Business.Employees();
            var result = MessageBox.Show("آیا مایل به حذف این کاربر هتسید؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EmployeesDeleat.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value);
                EmployeesDeleat.deleat();
                dataGridView1.AutoGenerateColumns = true;

                MessageBox.Show("حذف با موفقیت انجام شد");
                dataGridView1.DataSource = EmployeesDeleat.read();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UI.Employees.frmEmployeesAdd insert = new UI.Employees.frmEmployeesAdd();
            insert.ShowDialog();
            Business.Employees Employeesread = new Business.Employees();
            dataGridView1.DataSource = Employeesread.read();
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UI.Employees.frmEmployeesEdit frmEdit = new UI.Employees.frmEmployeesEdit();
            #region setProperties

            Business.Employees Employeesread = new Business.Employees();
            frmEdit.name = dataGridView1.CurrentRow.Cells["clmnFIrstName"].Value.ToString();

            frmEdit.lname = dataGridView1.CurrentRow.Cells["clmnLastname"].Value.ToString();
            frmEdit.tell = dataGridView1.CurrentRow.Cells["clmnTell"].Value.ToString();
            frmEdit.cell = dataGridView1.CurrentRow.Cells["clmnCell"].Value.ToString();
            frmEdit.type = dataGridView1.CurrentRow.Cells["clmntype"].Value.ToString();
            frmEdit.time = dataGridView1.CurrentRow.Cells["clmnTime"].Value.ToString();
            frmEdit.NC = dataGridView1.CurrentRow.Cells["clmnNationalCode"].Value.ToString();
            frmEdit.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value);
            frmEdit.ShowDialog();
            dataGridView1.DataSource = Employeesread.read();
          
            #endregion
        
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmployeesList_Shown(object sender, EventArgs e)
        {
            Business.Employees Employees = new Business.Employees();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Employees.read();
        }

        private void frmEmployeesList_Load(object sender, EventArgs e)
        {

        }
    }
}
