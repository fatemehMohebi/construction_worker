using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace Construction_workers.Business
{
    public class Architects
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
        public string mani { get; set; }
        public string projects { get; set; }
        #endregion
        #region CRUD
        public void insert() {
            #region add person to db
            SqlCeConnection myConnection = new SqlCeConnection();
            myConnection.ConnectionString = @"Data Source=C:\Users\YAS\Desktop\Construction_workers\DBconstructionworkers.sdf;Password=!123admin;Persist Security Info=True";

            SqlCeCommand myComment = new SqlCeCommand();
            myComment.Connection = myConnection;

            myComment.CommandText = "INSERT INTO [Architects](name,lastname,tell,cell,tepy,time,mani,projects,Ntiolecode) values(@name,@lastname,@tell,@cell,@tepy,@time,@mani,@projects,@Ntiolecode)";
            myComment.Parameters.AddWithValue("@name", this.FirstName);
            myComment.Parameters.AddWithValue("@lastname", this.Lastname);
            myComment.Parameters.AddWithValue("@tell", this.Tell);
            myComment.Parameters.AddWithValue("@cell", this.Call);
            myComment.Parameters.AddWithValue("@tepy", this.type);
            myComment.Parameters.AddWithValue("@time", this.time);
            myComment.Parameters.AddWithValue("@mani", this.mani);
            myComment.Parameters.AddWithValue("@projects", this.projects);
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

            myComment.CommandText = "select * from [Architects]";
            DataTable myDataTable = new DataTable();
            SqlCeDataAdapter myDataAdapter = new SqlCeDataAdapter();

            myDataAdapter.SelectCommand = myComment;
            myDataAdapter.Fill(myDataTable);

            return myDataTable;
            #endregion
        }

        #endregion
        #region Serch

        #endregion
    }
}
