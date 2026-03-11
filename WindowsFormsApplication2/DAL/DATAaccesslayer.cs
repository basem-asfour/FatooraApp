using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication2.DAL
{
    class DATAaccesslayer
    {
        SqlConnection sqlconnection;
        //this constractor intialies the connection opjects
        public DATAaccesslayer()
        {

          sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FatooraDB"].ConnectionString);

            }

        //.\SQLEXPRESS
        //./
        //method to open connection 
        public void open()
        { 
            
                    if (sqlconnection.State != ConnectionState.Open)
                    {
                        sqlconnection.Open();
                    }
             
        }
        //method to close connectin
        public void close()
        {
            if(sqlconnection.State==ConnectionState.Open)
            {
                sqlconnection.Close(); 
            }
        }
        //method to read data from database
        public DataTable selectData(string stored_procedure , SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            
            if(param!=null)
            {
                for(int i =0 ; i<param.Length;i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da=new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
        }
        //method to insert ,update and delete data from database
        public void executecommand (string stored_procedure , SqlParameter[] param )
        {
            SqlCommand sqlcmd =new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                try
                {
                    sqlcmd.Parameters.AddRange(param);
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception c)
                {

                    MessageBox.Show(Convert.ToString(c));
                }
                

            }
            
        }
        // عشان اقرا حاجه من غير امر مخزن
        public DataTable ExecSelect(string query)
        {
            SqlCommand cmd = new SqlCommand(query,sqlconnection);
            open();        // فتح الاتصال
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr); // قراءة البيانات الى كائن الجدول .
            close();  // اغلاق الاتصال 
            return dt; // ارجاع الجدول.
        }
    }
}
