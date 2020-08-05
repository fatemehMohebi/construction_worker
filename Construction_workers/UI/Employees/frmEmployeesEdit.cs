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
    public partial class frmEmployeesEdit : Form
    {
        public frmEmployeesEdit()
        {
            InitializeComponent();
        }
        #region propertes
        public int ID { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        public string tell { get; set; }
        public string cell { get; set; }
        public string type { get; set; }
        public string time { get; set; }
        public string NC { get; set; }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ویرایش این کاربر هتسید؟", "اطلاع", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Business.Employees EmployeesEdit = new Business.Employees();
                #region sent
                EmployeesEdit.ID = this.ID;
                EmployeesEdit.FirstName = txtName.Text;
                EmployeesEdit. Lastname = txtLname.Text;
                EmployeesEdit.Tell = txtTell.Text;
                EmployeesEdit.Call = txtCall.Text;
                EmployeesEdit.type = txtType.Text;
                EmployeesEdit.time = txtTime.Text;
                EmployeesEdit.Ntiolecode = txtNtionalcode.Text;
                #endregion
                EmployeesEdit.update();

                MessageBox.Show("ویرایش با موفقیت انجام شد ");
                UI.Employees.frmEmployeesList list = new frmEmployeesList();

                this.Close();
            }
        }

        private void frmEmployeesEdit_Load(object sender, EventArgs e)
        {
   
            #region read data to business>Employees
            txtName.Text= this.name;
            txtLname.Text = this.lname;
            txtCall.Text=this.cell ;
            txtTell.Text = this.tell;
            txtTime.Text = this.time;
            txtType.Text = this.type;
            txtNtionalcode.Text=this.NC;
            #endregion
            
        }

      
    }
}
