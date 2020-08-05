using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers
{
    public partial class frmuserEdit : Form
    {
        #region properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }        
        #endregion
       

        public void UpdateFromDatabase()
        {
            #region conect to db and delet as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;
           
            myComment.CommandText = "update [User] set [name]=@name,[family]=@family,[email]=@email,[username]=@username,[password]=@password,[role]=@role where id=@ID";
            myComment.Parameters.AddWithValue("@name", txtNmae.Text);
            myComment.Parameters.AddWithValue("@family", txtLname.Text);
            myComment.Parameters.AddWithValue("@email", txtEmail.Text);
            myComment.Parameters.AddWithValue("@username", txtUser.Text);
            myComment.Parameters.AddWithValue("@password", txtPass.Text);
            myComment.Parameters.AddWithValue("@role", txtRole.Text);
            myComment.Parameters.AddWithValue("@id",this.Id);
            




            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("ثبت با موفقیت انجام شد");
            this.Close();
            #endregion
        }
        public frmuserEdit()
        {
            InitializeComponent();
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ویرایش این کاربر هتسید؟", "اطلاع", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateFromDatabase();
               
            }

        }

        private void frmuserEdit_Load(object sender, EventArgs e)
        {
            txtNmae.Text = FirstName;
            txtLname.Text = lastName;
            txtEmail.Text = Email;
            txtUser.Text = Username;
            txtPass.Text = Password;
            txtRole.Text = Role;

        }
          
        }
}

