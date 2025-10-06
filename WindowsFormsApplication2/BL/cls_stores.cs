using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.BL
{
    class cls_stores
    {
        public void change_store(int prd_id,int store_id,int qte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@store_id", SqlDbType.Int);
            param[1].Value = store_id;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;


            DAL.executecommand("change_store", param);
            DAL.close();
        }
        public DataTable search_m5zn(string dscrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrbshn", SqlDbType.VarChar, 100);
            param[0].Value = dscrpshn;

            dt = DAL.selectData("search_m5zn", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_m5azen()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_m5azen", null);
            DAL.close();
            return dt;
        }

        public void add_m5zn(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 100);
            param[0].Value = nme;


            DAL.executecommand("add_m5zn", param);
            DAL.close();
        }
        public void edit_m5zn(int id, string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.VarChar, 100);
            param[1].Value = nme;


            DAL.executecommand("edit_m5zn", param);
            DAL.close();
        }
        public void delete_m5zn(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DAL.executecommand("delete_m5zn", param);
            DAL.close();
        }
    }
}
