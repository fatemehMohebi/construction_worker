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
    public partial class frmPersonEdit : Form
    {
        #region properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Tell { get; set; }
        public string Cell { get; set; }
        public string NationalCode { get; set; }

        #endregion
        public frmPersonEdit()
        {
            InitializeComponent();
        }

        private void frmPersonEdit_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstName;
            txtLastName.Text = lastName;
            txtTell.Text =  Tell;
            txtCall.Text = Cell;
            txtNationalCode.Text = NationalCode;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ویرایش این کاربر هتسید؟", "اطلاع", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Business.Person personEdit = new Business.Person();
                #region send data to business>person
                personEdit.ID=this.ID;
                personEdit.FirstName=txtFirstName.Text;
                personEdit.Lastname=txtLastName.Text;
                personEdit.Call=txtCall.Text;
                personEdit.Tell=txtTell.Text;
                personEdit.Ntiolecode=txtNationalCode.Text;
                #endregion

                
                personEdit.Update();

                MessageBox.Show("ویرایش با موفقیت انجام شد ");
                this.Hide();
               
            }
        }
    }
}
