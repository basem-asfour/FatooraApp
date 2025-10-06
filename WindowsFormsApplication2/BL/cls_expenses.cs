using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.BL
{
    class cls_expenses
    {

        public DataTable get_single_expenses(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_single_expenses", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_expenses_for_specific_date(DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.Date);
            param[0].Value = dte;

            dt = DAL.selectData("get_all_expenses_for_specific_date", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_expenses_for_kind_by_date(string kind,DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@kind", SqlDbType.VarChar, 50);
            param[0].Value = kind;

            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = dte;

            dt = DAL.selectData("get_all_expenses_for_kind_by_date", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_expenses_for_details(string kind)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@kind", SqlDbType.VarChar, 50);
            param[0].Value = kind;

            dt = DAL.selectData("get_all_expenses_for_details", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_expenses_for_kind(string kind)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@kind", SqlDbType.VarChar, 50);
            param[0].Value = kind;

            dt = DAL.selectData("get_all_expenses_for_kind", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_expenses()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_expenses", null);
            DAL.close();
            return dt;

        }

        public void delete_expenses(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("delete_expenses", param);
            DAL.close();
        }

        public void add_expenses(string type, double cach, string details, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[0].Value = type;
            param[1] = new SqlParameter("@cach", SqlDbType.Float);
            param[1].Value = cach;
            param[2] = new SqlParameter("@details", SqlDbType.NVarChar, 800);
            param[2].Value = details;
            param[3] = new SqlParameter("@dte", SqlDbType.Date);
            param[3].Value = dte;

            DAL.executecommand("add_expenses", param);
            DAL.close();
        }

        public void edit_expenses(int id, string type, double cach, string details, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@type", SqlDbType.NVarChar,50);
            param[1].Value = type;
            param[2] = new SqlParameter("@cach", SqlDbType.Float);
            param[2].Value = cach;
            param[3] = new SqlParameter("@details", SqlDbType.NVarChar,800);
            param[3].Value = details;
            param[4] = new SqlParameter("@dte", SqlDbType.Date);
            param[4].Value = dte;

            DAL.executecommand("edit_expenses", param);
            DAL.close();
        }

    }
}
