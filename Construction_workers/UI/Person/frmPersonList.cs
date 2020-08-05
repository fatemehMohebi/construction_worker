using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers.UI
{
    public partial class frmPersonList : Form
    {
        public frmPersonList()
        {
            InitializeComponent();
        }

        private void frmPersonList_Load(object sender, EventArgs e)
        {
            Business.Person Person = new Business.Person();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Person.Read();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            
            Business.Person Personlist = new Business.Person();
            Personlist.Ntiolecode=txtSerch.Text;
            Personlist.FirstName = txtSerchName.Text;
            if (txtSerch.Text == "" && txtSerchName.Text == "") {
                MessageBox.Show("لطفا یکی ار فیلد هارا برای جستجو پر کنید.");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Personlist.Read();
            }
            if (txtSerch.Text != string.Empty)
            {
             
               Personlist.serch();
               dataGridView1.AutoGenerateColumns = true;
               dataGridView1.DataSource = Personlist.serch();


            }
     
        if(txtSerchName.Text != string.Empty){
            Personlist.serchName();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Personlist.serchName();
        
        }
        }
        private void btnDelet_Click(object sender, EventArgs e)
        {
            Business.Person Personlist = new Business.Person();
            var result = MessageBox.Show("آیا مایل به حذف این کاربر هتسید؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Personlist.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value);
                Personlist.Deleat();
                dataGridView1.AutoGenerateColumns = true;
               
                MessageBox.Show("حذف با موفقیت انجام شد");
                dataGridView1.DataSource = Personlist.Read();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UI.frmPerson insert = new UI.frmPerson();
             Business.Person Personlist = new Business.Person();

            insert.Show();
        
            dataGridView1.DataSource = Personlist.Read();
        
            
            //ReadFromDatabase();

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Business.Person Personlist = new Business.Person();
            var result = MessageBox.Show("آیا مایل به حذف این کاربر هتسید؟", "هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Personlist.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value);
                Personlist.Deleat();
                dataGridView1.AutoGenerateColumns = true;

                MessageBox.Show("حذف با موفقیت انجام شد");
                dataGridView1.DataSource = Personlist.Read();
            }
              MessageBox.Show("!از لیست کاربری انتخاب کنید!", "هشدار");

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
             Business.Person editperson=new Business.Person();
            UI.frmPersonEdit personEdit =new UI.frmPersonEdit();
            #region setProperties

             personEdit.Name= dataGridView1.CurrentRow.Cells["clmnFirstName"].Value.ToString();
             personEdit.lastName = dataGridView1.CurrentRow.Cells["clmnLastname"].Value.ToString();
             personEdit.Tell = dataGridView1.CurrentRow.Cells["clmnTell"].Value.ToString();
             personEdit.Cell = dataGridView1.CurrentRow.Cells["clmnCell"].Value.ToString();
             personEdit.NationalCode = dataGridView1.CurrentRow.Cells["clmnNationalCode"].Value.ToString();
             personEdit.ID= Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value.ToString());
             personEdit.ShowDialog();

             MessageBox.Show("ویرایش با موفقیت انجام شد");
           
             dataGridView1.DataSource = editperson.Read();
            #endregion
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        }
    }

