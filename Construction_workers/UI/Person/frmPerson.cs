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
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="" && txtLastName.Text=="" &&txtNationalCode.Text==""&&txtTell.Text==""&&txtCall.Text==""){
                MessageBox.Show("لطفا فیلد هایی خالی را پر کنید");
            }
            Business.Person insart =new Business.Person();
            insart.Ntiolecode=txtNationalCode.Text;
            insart.FirstName=txtFirstName.Text;
            insart.Lastname=txtLastName.Text;
            insart.Tell =txtTell.Text;
            insart.Call=txtCall.Text;
            insart.Insert();
            MessageBox.Show("ثبت با موفقیت انجام شد");
            this.Close();
            
        }
        }
    }

