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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        public bool SerchDatabase()
        {
            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "select * from [user] where [Username]=@username and [Password]=@password";
            myComment.Parameters.AddWithValue("@username", txtUser.Text);
            myComment.Parameters.AddWithValue("@password", txtPass.Text);
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);
            //dataGridView1.AutoGenerateColumns = true;

            if (myDataTable.Rows.Count == 0)//کاربر معتبر نیس
            {
                return false;
            }
            else
                return true;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             if (SerchDatabase()==true) {
                this.Hide();
               
            }
            else
                MessageBox.Show("اطلاعات درست را وارد کنید");
             }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("در صورت فراموشی رمز با پشتیبانی تماس بگیرید");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

