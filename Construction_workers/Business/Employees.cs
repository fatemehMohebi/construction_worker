using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_workers.Business
{
    public class Employees
    {
        
        #region peroperties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Tell { get; set; }
        public string Call { get; set; }
        public string Ntiolecode { get; set; }
        public string type { get; set; }
        public string time { get; set; }
        #endregion
       
        #region CRUD
        /// <summary>
        /// این متد کار اضافه کردن کارمند به دیتابیس را دارد
        /// </summary>
        public void insert()
        { 
            #region add person to db 
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            //insert into tabelname() valu('',''.'');
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "INSERT INTO [Employees](name,lastname,tELL,cell,type,time,Ntiolecode) values(@name,@fname,@tELL,@cell,@type,@time,@Ntiolecode)";
            myComment.Parameters.AddWithValue("@name",this.FirstName);
            myComment.Parameters.AddWithValue("@fname",this.Lastname);
            myComment.Parameters.AddWithValue("@tELL",this.Tell );
            myComment.Parameters.AddWithValue("@cell",this.Call);
            myComment.Parameters.AddWithValue("@type",this.type);
            myComment.Parameters.AddWithValue("@time",this.time);
            myComment.Parameters.AddWithValue("@Ntiolecode", this.Ntiolecode);

            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
           
            #endregion
        }
        public void update()
        {
            #region conect to db and update as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "update [Employees] set [name]=@name,[lastname]=@Lastname,[tell]=@tell,[cell]=@cell,[time]=@time,[type]=@type,[Ntiolecode]=@Ntiolecode where ID=@id";
            myComment.Parameters.AddWithValue("@name", this.FirstName);
            myComment.Parameters.AddWithValue("@Lastname", this.Lastname);
            myComment.Parameters.AddWithValue("@tell", this.Tell);
            myComment.Parameters.AddWithValue("@cell", this.Call);
            myComment.Parameters.AddWithValue("@type", this.type);
            myComment.Parameters.AddWithValue("@time", this.time);
            myComment.Parameters.AddWithValue("@Ntiolecode", this.Ntiolecode);
            myComment.Parameters.AddWithValue("@id", this.ID);





            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();

            #endregion
        
        }
        public void deleat()
        {
            #region conect to db and deleat as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;
            myComment.CommandText = "delete from [Employees] where ID=@id";
            myComment.Parameters.AddWithValue("@id", this.ID);

            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            #endregion
        }
        public DataTable read()
        {

            #region conect to db sentax sql read db and view to gridview
            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            //insert into tabelname() valu('',''.'');
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "select * from [Employees]";
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);

            return myDataTable;
            #endregion
         
        }
        #endregion
        #region sercher
        public DataTable serch()
        {
            #region conect to db sentax sql serch nationalCode
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "select * from [Employees] where Ntiolecode like @nationalCode";

            myComment.Parameters.AddWithValue("@nationalCode", "%" + this.Ntiolecode + "%");
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);
            //dataGridView1.AutoGenerateColumns = true;
            return myDataTable;
            #endregion
        }
        public DataTable serchName()
        {
            #region conect to db sentax sql serch FirstName&LastName
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "select * from [Employees] where name like @FirstName or lastname like @FirstName";

            myComment.Parameters.AddWithValue("@FirstName", "%" + this.FirstName + "%");
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);
            //dataGridView1.AutoGenerateColumns = true;
            return myDataTable;
            #endregion
        }
        #endregion
    }
}
