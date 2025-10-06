using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2.BL
{
    class cls_mwrdeen
    {

        public DataTable get_all_mwrdeen_report(int mwrd_id, string mwrd_name)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_id", SqlDbType.Int);
            param[0].Value = mwrd_id;
            param[1] = new SqlParameter("@mwrd_name", SqlDbType.NVarChar, 100);
            param[1].Value = mwrd_name;

            dt = DAL.selectData("get_all_mwrdeen_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_mwrd_pays_first_rseed_for_mwrd_report(int mwrd_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_id", SqlDbType.Int);
            param[0].Value = mwrd_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_mwrd_pays_first_rseed_for_mwrd_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_mwrd_mrtg3_for_mwrd_report(string mwrd_nme, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_nme", SqlDbType.NVarChar, 100);
            param[0].Value = mwrd_nme;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_mwrd_mrtg3_for_mwrd_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_mwrd_fwateer_msdd_for_mwrd_report(string mwrd_nme, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_nme", SqlDbType.NVarChar, 100);
            param[0].Value = mwrd_nme;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_mwrd_fwateer_msdd_for_mwrd_report", param);
            DAL.close();
            return dt;
        }

        public DataTable get_mwrd_fwateer_for_mwrd_report(string mwrd_nme, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_nme", SqlDbType.NVarChar, 100);
            param[0].Value = mwrd_nme;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_mwrd_fwateer_for_mwrd_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_mwrd_pays_for_mwrd_report(int mwrd_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mwrd_id", SqlDbType.Int);
            param[0].Value = mwrd_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_mwrd_pays_for_mwrd_report", param);
            DAL.close();
            return dt;
        }
        public DataTable search_mrtg3_mshtriat_bydate(DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.Date);
            param[0].Value = dte;

            dt = DAL.selectData("search_mrtg3_mshtriat_bydate", param);
            DAL.close();
            return dt;
        }

        public DataTable search_fwateer_mwrd_bydate(string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[0].Value = dte;

            dt = DAL.selectData("search_fwateer_mwrd_bydate", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_mwrdeen_pays_bydate(string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[0].Value = dte;

            dt = DAL.selectData("get_all_mwrdeen_pays_bydate", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_mwrd_pays(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_all_mwrd_pays", param);
            DAL.close();
            return dt;
        }

        public void edit_mwrd_pays(int id,int mwrd_id, double first_rseed, double payed, double last_rseed, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@mwrd_id", SqlDbType.Int);
            param[1].Value = mwrd_id;
            param[2] = new SqlParameter("@first_rseed", SqlDbType.Float);
            param[2].Value = first_rseed;
            param[3] = new SqlParameter("@payed", SqlDbType.Float);
            param[3].Value = payed;
            param[4] = new SqlParameter("@last_rseed", SqlDbType.Float);
            param[4].Value = last_rseed;
            param[5] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[5].Value = dte;

            DAL.executecommand("edit_mwrd_pays", param);
            DAL.close();
        }

        public void add_mwrd_pays(int mwrd_id, double first_rseed, double payed, double last_rseed, string dte,string kind,string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@mwrd_id", SqlDbType.Int);
            param[0].Value = mwrd_id;
            param[1] = new SqlParameter("@first_rseed", SqlDbType.Float);
            param[1].Value = first_rseed;
            param[2] = new SqlParameter("@payed", SqlDbType.Float);
            param[2].Value = payed;
            param[3] = new SqlParameter("@last_rseed", SqlDbType.Float);
            param[3].Value = last_rseed;
            param[4] = new SqlParameter("@dte", SqlDbType.NVarChar,50);
            param[4].Value = dte;
            param[5] = new SqlParameter("@kind", SqlDbType.NVarChar, 50);
            param[5].Value = kind;
            param[6] = new SqlParameter("@notes", SqlDbType.NVarChar, 2000);
            param[6].Value = notes;
            DAL.executecommand("add_mwrd_pays", param);
            DAL.close();
        }

        public void delete_mwrd_pays(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_mwrd_pays", param);
            DAL.close();
        }

        public DataTable search_mwrdeen(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[0].Value = nme;

            dt = DAL.selectData("search_mwrdeen", param);
            DAL.close();
            return dt;
        }

        public void add_mrtg3_mshtriat(int prd_id, string nme, int qte, double price, int fatora_id, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@nme", SqlDbType.NVarChar,100);
            param[1].Value = nme;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;
            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;
            param[4] = new SqlParameter("@fatora_id", SqlDbType.Int);
            param[4].Value = fatora_id;
            param[5] = new SqlParameter("@dte", SqlDbType.Date);
            param[5].Value = dte;




            DAL.executecommand("add_mrtg3_mshtriat", param);
            DAL.close();
        }
        public void update_total_w_msdd_fwateer_mwrd_case_add(int id, double value)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@value", SqlDbType.Float);
            param[1].Value = value;



            DAL.executecommand("update_total_w_msdd_fwateer_mwrd_case_add", param);
            DAL.close();
        }

        public void add_mwrd(string nme, string phone, string adress)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[0].Value = nme;
            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            param[2].Value = adress;


            DAL.executecommand("add_mwrd", param);
            DAL.close();
        }
        public void edit_mwrd(int id, string nme, string phone, string adress)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[1].Value = nme;
            param[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            param[3].Value = adress;


            DAL.executecommand("edit_mwrd", param);
            DAL.close();
        }
        public void delete_mwrd(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_mwrd", param);
            DAL.close();
        }
        public void delete_fwateer_mwrd(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_fwateer_mwrd", param);
            DAL.close();
        }
        public DataTable get_all_mwrdeen()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_mwrdeen", null);
            DAL.close();
            return dt;

        }
        public DataTable get_last_order_id_mwrd()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_last_order_id_mwrd", null);
            DAL.close();
            return dt;

        }
        public DataTable get_all_fatora_mwrd_product(string id_order)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.NVarChar,50);
            param[0].Value = id_order;

            dt = DAL.selectData("get_all_fatora_mwrd_product", param);
            DAL.close();
            return dt;
        }
        public void edit_fwateer_mwrd(int id, string nme, string date, string value, string msdd, string mtbaki)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[1].Value = nme;
            param[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
            param[2].Value = date;
            param[3] = new SqlParameter("@value", SqlDbType.NVarChar, 50);
            param[3].Value = value;
            param[4] = new SqlParameter("@msdd", SqlDbType.NVarChar, 50);
            param[4].Value = msdd;
            param[5] = new SqlParameter("@mtbaki", SqlDbType.NVarChar, 50);
            param[5].Value = mtbaki;


            DAL.executecommand("edit_fwateer_mwrd", param);
            DAL.close();
        }
        public void add_fwateer_mwrd(int id,string nme, string date, string value, string msdd, string mtbaki)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[1].Value = nme;
            param[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
            param[2].Value = date;
            param[3] = new SqlParameter("@value", SqlDbType.NVarChar, 50);
            param[3].Value = value;
            param[4] = new SqlParameter("@msdd", SqlDbType.NVarChar, 50);
            param[4].Value = msdd;
            param[5] = new SqlParameter("@mtbaki", SqlDbType.NVarChar, 50);
            param[5].Value = mtbaki;

            DAL.executecommand("add_fwateer_mwrd", param);
            DAL.close();
        }
        public DataTable get_all_fwateer_mwrd(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 50);
            param[0].Value = nme;

            dt = DAL.selectData("get_all_fwateer_mwrd", param);
            DAL.close();
            return dt;
        }
    }
}
