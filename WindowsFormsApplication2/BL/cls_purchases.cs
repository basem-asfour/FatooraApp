using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.BL
{
    class cls_purchases
    {
        public DataTable get_single_purchase_id(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 500);
            param[0].Value = nme;
            dt = DAL.selectData("get_single_purchase_id", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_fatora_mwrd_purchases(string fatora_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@fatora_id", SqlDbType.VarChar, 50);
            param[0].Value = fatora_id;
            dt = DAL.selectData("get_all_fatora_mwrd_purchases", param);
            DAL.close();
            return dt;
        }
        public DataTable get_prd_purchases_for_card(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 50);
            param[0].Value = nme;
            dt = DAL.selectData("get_prd_purchases_for_card", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_purchases()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_purchases", null);
            DAL.close();
            return dt;
        }
        public void un_delete_purchase(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("un_delete_purchase", param);
            DAL.close();

        }
        public void delete_purchase(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_purchase", param);
            DAL.close();

        }

        public void edit_purchase(string nme, int qte, string pshr, string pg, string pb, string pmsthlk,
    string tmd, byte[] img, string id, string kind, string store)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 50);
            param[0].Value = nme;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            param[2] = new SqlParameter("@pshr", SqlDbType.VarChar, 50);
            param[2].Value = pshr;
            param[3] = new SqlParameter("@pg", SqlDbType.VarChar, 50);
            param[3].Value = pg;
            param[4] = new SqlParameter("@pb", SqlDbType.VarChar, 50);
            param[4].Value = pb;
            param[5] = new SqlParameter("@pmsthlk", SqlDbType.VarChar, 50);
            param[5].Value = pmsthlk;
            param[6] = new SqlParameter("@tmd", SqlDbType.VarChar, 50);
            param[6].Value = tmd;
            param[7] = new SqlParameter("@img", SqlDbType.Image);
            param[7].Value = img;
            param[8] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[8].Value = id;
            param[9] = new SqlParameter("@kind", SqlDbType.NVarChar, 50);
            param[9].Value = kind;
            param[10] = new SqlParameter("@store", SqlDbType.NVarChar, 100);
            param[10].Value = store;

            DAL.executecommand("edit_purchase", param);
            DAL.close();
        }
        public void add_purshase(string nme, int qte, string pshr, string pg, string pb, string pmsthlk
           , string tmd, byte[] img, string kind, string mwrd_name, string id_order, string store)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 50);
            param[0].Value = nme;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            param[2] = new SqlParameter("@pshr", SqlDbType.VarChar, 50);
            param[2].Value = pshr;
            param[3] = new SqlParameter("@pg", SqlDbType.VarChar, 50);
            param[3].Value = pg;
            param[4] = new SqlParameter("@pb", SqlDbType.VarChar, 50);
            param[4].Value = pb;
            param[5] = new SqlParameter("@pmsthlk", SqlDbType.VarChar, 50);
            param[5].Value = pmsthlk;
            param[6] = new SqlParameter("@tmd", SqlDbType.VarChar, 50);
            param[6].Value = tmd;
            param[7] = new SqlParameter("@img", SqlDbType.Image);
            param[7].Value = img;
            param[8] = new SqlParameter("@kind", SqlDbType.NVarChar, 50);
            param[8].Value = kind;
            param[9] = new SqlParameter("@mwrd_name", SqlDbType.NVarChar, 50);
            param[9].Value = mwrd_name;
            param[10] = new SqlParameter("@id_order", SqlDbType.NVarChar, 50);
            param[10].Value = id_order;
            param[11] = new SqlParameter("@store", SqlDbType.NVarChar, 100);
            param[11].Value = store;

            DAL.executecommand("add_purshase", param);
            DAL.close();
        }
    }
}
