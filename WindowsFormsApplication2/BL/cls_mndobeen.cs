using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.BL
{
    class cls_mndobeen
    {
        public DataTable get_all_order_details_for_mndb(string id_order)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.NVarChar,50);
            param[0].Value = id_order;

            dt = DAL.selectData("get_all_order_details_for_mndb", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_expenses_for_kind_by_date(string kind, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@kind", SqlDbType.NVarChar,50);
            param[0].Value = kind;
            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = dte;

            dt = DAL.selectData("get_all_expenses_for_kind_by_date", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_orders_for_mandob_by_date(int id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@dte", SqlDbType.VarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_all_orders_for_mandob_by_date", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_cstmr_pays_for_mndb_by_date(string mndb_name,string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mndb_name", SqlDbType.VarChar, 100);
            param[0].Value = mndb_name;
            param[1] = new SqlParameter("@dte", SqlDbType.VarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_all_cstmr_pays_for_mndb_by_date", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_cstmr_pays_for_mndb(string mndb_name)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@mndb_name", SqlDbType.VarChar, 100);
            param[0].Value = mndb_name;

            dt = DAL.selectData("get_all_cstmr_pays_for_mndb", param);
            DAL.close();
            return dt;
        }


        public DataTable get_all_orders_for_mandob(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_all_orders_for_mandob", param);
            DAL.close();
            return dt;
        }

        public DataTable search_mndobeen(string dscrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrpshn", SqlDbType.VarChar, 100);
            param[0].Value = dscrpshn;

            dt = DAL.selectData("search_mndobeen", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_mndopeen()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_mndopeen", null);
            DAL.close();
            return dt;
        }
        public void add_mndoob(string nme,string phone,double rseed)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 100);
            param[0].Value = nme;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@rseed", SqlDbType.Float);
            param[2].Value = rseed;


            DAL.executecommand("add_mndoob", param);
            DAL.close();
        }
        public void edit_mndoob(int id,string nme, string phone, double rseed)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.VarChar, 100);
            param[1].Value = nme;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@rseed", SqlDbType.Float);
            param[3].Value = rseed;


            DAL.executecommand("edit_mndoob", param);
            DAL.close();
        }

        public void delete_mndoop(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("delete_mndoop", param);
            DAL.close();
        }
    }
}
