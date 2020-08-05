using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
namespace Construction_workers.Business
{
    public class Person
    {
        #region peroperties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Tell { get; set; }
        public string Call { get; set; }
        public string Ntiolecode { get; set; }

        #endregion

        //عملیات روی کارگران
        #region CRUD 
        /// <summary>
        /// این متد کار اضافه کردن کارگر به دیتابیس را دارد
        ///</summary>
        public void Insert()
        {
            #region add person to db 
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
           
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "INSERT INTO [Person](FirstName,LastName,tell,cell,nationalCode) values(@FirstName,@LastName,@Tell,@Cell,@nationalCode)";
            myComment.Parameters.AddWithValue("@FirstName", this.FirstName);
            myComment.Parameters.AddWithValue("@Lastname", this.Lastname);
            myComment.Parameters.AddWithValue("@Tell", this.Tell);
            myComment.Parameters.AddWithValue("@Cell", this.Call);
            myComment.Parameters.AddWithValue("@nationalCode", this.Ntiolecode);


            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
 
            #endregion
            
      
        }
        public void Update() 
        {
      
            #region conect to db and update as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "update [Person] set [FirstName]=@FirstName,[LastName]=@Lastname,[tell]=@tell,[cell]=@cell,[nationalCode]=@nationalCode where IdPerson=@ID";
            myComment.Parameters.AddWithValue("@FirstName", this.FirstName);
            myComment.Parameters.AddWithValue("@Lastname", this.Lastname);
            myComment.Parameters.AddWithValue("@Tell", this.Tell);
            myComment.Parameters.AddWithValue("@Cell", this.Call);
            myComment.Parameters.AddWithValue("@nationalCode", this.Ntiolecode);
            myComment.Parameters.AddWithValue("@id",this.ID);
            




            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            
            #endregion
        
        }
        public void Deleat() 
        {
            #region conect to db and deleat as list

            //اتصال به بانک اطلاعاتی
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
            //insert into tabelname() valu('',''.'');
            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;
            myComment.CommandText = "delete from [Person] where IdPerson=@id";
            myComment.Parameters.AddWithValue("@id", this.ID);


            myConnection.Open();
            myComment.ExecuteNonQuery();
            myConnection.Close();
            #endregion
        }
        public DataTable Read() 
        {
       
            #region conect to db sentax sql read db and view to gridview
                    //اتصال به بانک اطلاعاتی
                    SqlCeConnection myConnection = new SqlCeConnection();
                    myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";
                    //insert into tabelname() valu('',''.'');
                    SqlCeCommand myComment = new SqlCeCommand();
                    myComment.Connection = myConnection;

                    myComment.CommandText = "select * from [Person]";
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

            myComment.CommandText = "select * from [Person] where nationalCode like @nationalCode";

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

            myComment.CommandText = "select * from [Person] where FirstName like @FirstName or LastName like @FirstName";

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
		 
	