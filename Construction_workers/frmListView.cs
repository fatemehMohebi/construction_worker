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
    public partial class frmListView : Form
    {
        public int ID { set; get; }

        public void CreatUser() { 
          SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString= @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
                //insert into tabelname() valu('',''.'');
            SqlCeCommand myComment  =new SqlCeCommand();
            myComment.Connection = myConnection;
     
            myComment.CommandText= "INSERT INTO [User](name,family,email,username,password,role) values(@name,@fname,@email,@username,@pass,@role)";
            myComment.Parameters.AddWithValue("@name", txtName.Text);
            myComment.Parameters.AddWithValue("@fname", txtLname.Text);
            myComment.Parameters.AddWithValue("@email", txtEmail.Text);
            myComment.Parameters.AddWithValue("@username", txtUser.Text);
            myComment.Parameters.AddWithValue("@pass", txtPass.Text);
            myComment.Parameters.AddWithValue("@role", txtRole.Text);

            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("ثبت با موفقیت انجام شد");
        }
        /// <summary>
        /// جستجو در کاربران بر اساس نام و نام خانوادگی
        /// </summary>
        public void SerchDatabase()
        {
            #region conect to db sentax sql serch name&family
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "select * from [user] where Family like @family or [Name] like @name";

            myComment.Parameters.AddWithValue("@family", "%" + txtSerch.Text + "%");
            myComment.Parameters.AddWithValue("@name", "%" + txtSerch.Text + "%");
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);
            //dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = myDataTable; 
            #endregion
           
        }
        public void ReadFromDatabase()
        {
            #region conect to db sentax sql read db and view to gridview
                    //اتصال به بانک اطلاعاتی
                    SqlCeConnection myConnection = new SqlCeConnection();
                    myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
                    //insert into tabelname() valu('',''.'');
                    SqlCeCommand myComment = new SqlCeCommand();
                    myComment.Connection = myConnection;

                    myComment.CommandText = "select * from [user]";
                    DataTable myDataTable = new DataTable();
                    SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

                    myDataAdapter.SelectCommand = myComment;
                    myDataAdapter.Fill(myDataTable);

            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = myDataTable;
                }   
            #endregion
         
        public void DeleteFromDatabase()
        {
            #region conect to db and delet as list
            
            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            //insert into tabelname() valu('',''.'');
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;
            myComment.CommandText = "delete from [User] where ID=@id";
            myComment.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["clmnID"].Value);


            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("حذف با موفقیت انجام شد");
            #endregion
        }
        public void UpdateFromDatabase()
        {
            #region conect to db and delet as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;
           
            myComment.CommandText = "update  [User] set (name,family,email,username,password,role) values(@name,@fname,@email,@username,@pass,@role) where id=@id";
            myComment.Parameters.AddWithValue("@name", txtName.Text);
            myComment.Parameters.AddWithValue("@family", txtLname.Text);
            myComment.Parameters.AddWithValue("@email", txtEmail.Text);
            myComment.Parameters.AddWithValue("@username", txtUser.Text);
            myComment.Parameters.AddWithValue("@password", txtPass.Text);
            myComment.Parameters.AddWithValue("@role", txtRole.Text);
            myComment.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["clmnID"].Value);

            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("ثبت با موفقیت انجام شد");
            this.Close();
            #endregion
        }
      
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            ReadFromDatabase();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_Main = new frmMain();
            frm_Main.Show();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test
            MessageBox.Show(dataGridView1.CurrentRow.Cells["clmnID"].Value.ToString());
        }

        private void btnDeleat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به حذف این کاربر هستید؟","هشدار",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteFromDatabase();
                ReadFromDatabase();
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (txtSerch.Text != string.Empty)
                SerchDatabase();
            else
                ReadFromDatabase();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {///برای ثبت کاربر جدید 
       
            if(txtName.Text=="" && txtPass.Text=="" &&txtLname.Text==""&&txtEmail.Text==""&&txtUser.Text==""&&txtRole.Text==""){
                MessageBox.Show("لطفا فیلد هایی خالی را پر کنید");
            }
            CreatUser();
            ReadFromDatabase();
        }
        /// <summary>
        /// برای ادیت یوزها از این متد و رویداد کلیک استفاده شد.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnUserEdit_Click_1(object sender, EventArgs e)
        //{
        //    ///مقدار داده از دیتا گرید گرفته شده و به خاصیت تکست تکست باکس باری هر  
        //    #region setProperties

        //    this.txtName.Text = dataGridView1.CurrentRow.Cells["clmnName"].Value.ToString();
        //    this.txtLname.Text = dataGridView1.CurrentRow.Cells["clmnFamily"].Value.ToString();
        //    this.txtEmail.Text = dataGridView1.CurrentRow.Cells["clmnEmail"].Value.ToString();
        //    this.txtUser.Text = dataGridView1.CurrentRow.Cells["clmnUserName"].Value.ToString();
        //    this.txtPass.Text = dataGridView1.CurrentRow.Cells["clmnPassword"].Value.ToString();
        //    this.txtRole.Text = dataGridView1.CurrentRow.Cells["clmnRole"].Value.ToString();
            

        //    #endregion
           
            
        //}

        //private void btnEdituser_Click(object sender, EventArgs e)
        //{
        //     var result = MessageBox.Show("آیا مایل به ویرایش این کاربر هتسید؟", "اطلاع", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        UpdateFromDatabase();
        //        ReadFromDatabase();
        //    }
        //}

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            ///مقدار داده از دیتا گرید گرفته شده و به خاصیت تکست تکست باکس باری هر  
            #region setProperties

            this.txtName.Text = dataGridView1.CurrentRow.Cells["clmnName"].Value.ToString();
            this.txtLname.Text = dataGridView1.CurrentRow.Cells["clmnFamily"].Value.ToString();
            this.txtEmail.Text = dataGridView1.CurrentRow.Cells["clmnEmail"].Value.ToString();
            this.txtUser.Text = dataGridView1.CurrentRow.Cells["clmnUserName"].Value.ToString();
            this.txtPass.Text = dataGridView1.CurrentRow.Cells["clmnPassword"].Value.ToString();
            this.txtRole.Text = dataGridView1.CurrentRow.Cells["clmnRole"].Value.ToString();
            this.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value.ToString());

            #endregion
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmuserEdit frmUserPredaim =new frmuserEdit();
            frmUserPredaim.FirstName= dataGridView1.CurrentRow.Cells["clmnName"].Value.ToString();
            frmUserPredaim.lastName = dataGridView1.CurrentRow.Cells["clmnFamily"].Value.ToString();
            frmUserPredaim.Email=dataGridView1.CurrentRow.Cells["clmnEmail"].Value.ToString();
            frmUserPredaim.Username=dataGridView1.CurrentRow.Cells["clmnUserName"].Value.ToString();
            frmUserPredaim.Password=dataGridView1.CurrentRow.Cells["clmnPassword"].Value.ToString();
            frmUserPredaim.Role=dataGridView1.CurrentRow.Cells["clmnRole"].Value.ToString();
            frmUserPredaim.Id =Convert.ToInt32( dataGridView1.CurrentRow.Cells["clmnID"].Value);
            frmUserPredaim.ShowDialog();
            ReadFromDatabase();
        }



        
       
    }
}
