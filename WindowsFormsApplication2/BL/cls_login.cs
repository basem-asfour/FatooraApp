using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2.PL
{
    class cls_login
    {
        public DataTable get_system_type()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();

            DataTable dt = new DataTable();
            dt = DAL.selectData("get_system_type",null);
            DAL.close();
            return dt;

        }
        public void add_system_type(DateTime firstDate, int months, string status)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@firstDate", SqlDbType.Date);
            param[0].Value = firstDate;
            param[1] = new SqlParameter("@months", SqlDbType.Int);
            param[1].Value = months;
            param[2] = new SqlParameter("@status", SqlDbType.VarChar, 50);
            param[2].Value = status;


            DAL.executecommand("add_system_type", param);
            DAL.close();
        }
        public void edit_system_type(int id, int months, string status, bool isValid)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@months", SqlDbType.Int);
            param[1].Value = months;
            param[2] = new SqlParameter("@status", SqlDbType.VarChar, 50);
            param[2].Value = status;
            param[3] = new SqlParameter("@isValid", SqlDbType.Bit);
            param[3].Value = isValid;

            DAL.executecommand("edit_system_type", param);
            DAL.close();
        }
        public DataTable login(string id, string pwd)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            Param[0].Value = id;

            Param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            Param[1].Value = pwd;
            DataTable dt = new DataTable();
            dt = DAL.selectData("sp_login", Param);
            DAL.close();
            return dt;

        }
        public void add_users(string id, string pwd, string totalnme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;
            param[2] = new SqlParameter("@totalnme", SqlDbType.VarChar, 50);
            param[2].Value = totalnme;


            DAL.executecommand("add_users", param);
            DAL.close();
        }
        public DataTable search_users(string dscrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrpshn", SqlDbType.VarChar, 50);
            param[0].Value = dscrpshn;

            dt = DAL.selectData("search_users", param);
            DAL.close();
            return dt;

        }
        public void update_users(string id, string pwd, string fullnme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;
            param[2] = new SqlParameter("@fullnme", SqlDbType.VarChar, 50);
            param[2].Value = fullnme;


            DAL.executecommand("update_users", param);
            DAL.close();
        }
        public void delete_users(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.executecommand("delete_users", param);
            DAL.close();
        }
    }
}
