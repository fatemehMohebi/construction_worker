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
    public partial class frmEmployeesAdd : Form
    {
        #region properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Tell { get; set; }
        public string Cell { get; set; }
        public string NationalCode { get; set; }

        #endregion
        public frmEmployeesAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" && txtlname.Text == "" && txtNtionalcode.Text == "" && txtTell.Text == "" && txtCall.Text == "" && txtTime.Text == "" && txtType.Text == "")
            {
                MessageBox.Show("لطفا فیلد هایی خالی را پر کنید");
            }
            Business.Employees insart = new Business.Employees();
            insart.Ntiolecode = txtNtionalcode.Text;
            insart.FirstName = txtname.Text;
            insart.Lastname = txtlname.Text;
            insart.Tell = txtTell.Text;
            insart.Call = txtCall.Text;
            insart.time = txtTime.Text;
            insart.type = txtType.Text;
            insart.insert();
            MessageBox.Show("ثبت با موفقیت انجام شد");
            this.Close();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
