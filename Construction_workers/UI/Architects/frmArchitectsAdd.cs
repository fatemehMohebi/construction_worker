using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers.UI.Architects
{
    public partial class frmArchitectsAdd : Form
    {
        public frmArchitectsAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" && txtlname.Text == "" && txtNtionalcode.Text == "" && txtTell.Text == "" && txtCall.Text == "" && txtTime.Text == "" && txtType.Text == "")
            {
                MessageBox.Show("لطفا فیلد هایی خالی را پر کنید");
            }
            Business.Architects insart = new Business.Architects();
            insart.Ntiolecode = txtNtionalcode.Text;
            insart.FirstName = txtname.Text;
            insart.Lastname = txtlname.Text;
            insart.Tell = txtTell.Text;
            insart.Call = txtCall.Text;
            insart.time = txtTime.Text;
            insart.type = txtType.Text;
            insart.mani = txtmani.Text;
            insart.projects = txtProgict.Text;
            insart.insert();
            MessageBox.Show("ثبت با موفقیت انجام شد");
            this.Close();

        }
    }
}
