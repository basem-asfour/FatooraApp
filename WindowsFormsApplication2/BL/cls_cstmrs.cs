using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2.BL
{
    class cls_cstmrs
    {
        public DataTable get_last_date_for_cstmr(int cstmr_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            dt = DAL.selectData("get_last_date_for_cstmr", param);
            DAL.close();
            return dt;
        }
        public DataTable Get_single_cstmr_pay_by_id(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.selectData("Get_single_cstmr_pay_by_id", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_late_cstmr_pays(string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[0].Value = dte;

            dt = DAL.selectData("get_all_late_cstmr_pays", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_cstnrs_report(int cstmr_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            dt = DAL.selectData("get_all_cstnrs_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_pays_first_rseed_for_cstmr_report(int cstmr_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_cstmr_pays_first_rseed_for_cstmr_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_mrtg3_for_cstmr_report(int cstmr_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_cstmr_mrtg3_for_cstmr_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_orders_msdd_for_cstmr_report(int cstmr_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_cstmr_orders_msdd_for_cstmr_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_orders_for_cstmr_report(int cstmr_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;

            dt = DAL.selectData("get_cstmr_orders_for_cstmr_report", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_pays_for_cstmr_report(int cstmr_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar,50);
            param[1].Value = dte;

            dt = DAL.selectData("get_cstmr_pays_for_cstmr_report", param);
            DAL.close();
            return dt;
        }

        public void after_delete_mrtg3_mbe3at(int prd_id,int fatora_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@fatora_id", SqlDbType.Int);
            param[1].Value = fatora_id;
            DAL.executecommand("after_delete_mrtg3_mbe3at", param);
            DAL.close();
        }

        public DataTable search_cstmrs_mrtg3_bydate(DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.Date);
            param[0].Value = dte;

            dt = DAL.selectData("search_cstmrs_mrtg3_bydate", param);
            DAL.close();
            return dt;
        }

        public void delete_cstmr_fatora(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_cstmr_fatora", param);
            DAL.close();
        }


        public void delete_cstmr_fatora_with_products(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_cstmr_fatora_with_products", param);
            DAL.close();
        }

        public void update_cstmr_fatora(int id, double total, double khsm, string type, double final_total)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@total", SqlDbType.Float);
            param[1].Value = total;
            param[2] = new SqlParameter("@khsm", SqlDbType.Float);
            param[2].Value = khsm;
            param[3] = new SqlParameter("@type", SqlDbType.NVarChar,50);
            param[3].Value = type;
            param[4] = new SqlParameter("@final_total", SqlDbType.Float);
            param[4].Value = final_total;


            DAL.executecommand("update_cstmr_fatora", param);
            DAL.close();
        }

        public DataTable get_all_fwareer_mrtg3()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_fwareer_mrtg3", null);
            DAL.close();
            return dt;

        }
        public DataTable get_all_cstmrs_pays_bydate(string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[0].Value = dte;

            dt = DAL.selectData("get_all_cstmrs_pays_bydate", param);
            DAL.close();
            return dt;
        }

        public void after_add_notExist_prd_to_cstmr_fatora(double price, int quantity, int cstmr_id, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@price", SqlDbType.Float);
            param[0].Value = price;
            param[1] = new SqlParameter("@quantity", SqlDbType.Int);
            param[1].Value = quantity;
            param[2] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[2].Value = cstmr_id;
            param[3] = new SqlParameter("@dte", SqlDbType.Date);
            param[3].Value = dte;


            DAL.executecommand("after_add_notExist_prd_to_cstmr_fatora", param);
            DAL.close();
        }


        public void delete_cstmr_pay(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("delete_cstmr_pay", param);
            DAL.close();
        }
        public DataTable get_all_cstmr_pays(int cstmr_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;

            dt = DAL.selectData("get_all_cstmr_pays", param);
            DAL.close();
            return dt;
        }

        public void edit_cstmr_pay(int id, int cstmr_id, double first_rseed, double mdfo3, double last_rseed, string dte,string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[1].Value = cstmr_id;
            param[2] = new SqlParameter("@first_rseed", SqlDbType.Float);
            param[2].Value = first_rseed;
            param[3] = new SqlParameter("@mdfo3", SqlDbType.Float);
            param[3].Value = mdfo3;
            param[4] = new SqlParameter("@last_rseed", SqlDbType.Float);
            param[4].Value = last_rseed;
            param[5] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[5].Value = dte;
            param[6] = new SqlParameter("@notes", SqlDbType.NVarChar, 1000);
            param[6].Value = notes;

            DAL.executecommand("edit_cstmr_pay", param);
            DAL.close();
        }
        public void add_cstmr_pay(int cstmr_id, double first_rseed, double mdfo3, double last_rseed, string dte, string mndb_nme,string type,string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@first_rseed", SqlDbType.Float);
            param[1].Value = first_rseed;
            param[2] = new SqlParameter("@mdfo3", SqlDbType.Float);
            param[2].Value = mdfo3;
            param[3] = new SqlParameter("@last_rseed", SqlDbType.Float);
            param[3].Value = last_rseed;
            param[4] = new SqlParameter("@dte", SqlDbType.NVarChar,50);
            param[4].Value = dte;
            param[5] = new SqlParameter("@mndb_nme", SqlDbType.NVarChar, 100);
            param[5].Value = mndb_nme;
            param[6] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[6].Value = type;
            param[7] = new SqlParameter("@notes", SqlDbType.NVarChar,1000);
            param[7].Value = notes;

            DAL.executecommand("add_cstmr_pay", param);
            DAL.close();
        }
        public DataTable get_all_fatora_mrtg3_products(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_all_fatora_mrtg3_products", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_fwareer_mrtg3_for_cstmr(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_all_fwareer_mrtg3_for_cstmr", param);
            DAL.close();
            return dt;
        }
        public DataTable get_max_for_cstmr(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_max_for_cstmr", param);
            DAL.close();
            return dt;
        }

        public DataTable get_all_7sab_sabk(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_all_7sab_sabk", param);
            DAL.close();
            return dt;
        }

        public void avoid_prduct_from_specific_order(int custmer_id, int order_id, int product_id, int quantity)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@custmer_id", SqlDbType.Int);
            param[0].Value = custmer_id;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;
            param[2] = new SqlParameter("@product_id", SqlDbType.Int);
            param[2].Value = product_id;
            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quantity;


            DAL.executecommand("avoid_prduct_from_specific_order", param);
            DAL.close();
        }
        public void avoid_prduct_from_specific_order_notall_qnt(int custmer_id, int order_id, int product_id, int quantity)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@custmer_id", SqlDbType.Int);
            param[0].Value = custmer_id;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;
            param[2] = new SqlParameter("@product_id", SqlDbType.Int);
            param[2].Value = product_id;
            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quantity;


            DAL.executecommand("avoid_prduct_from_specific_order_notall_qnt", param);
            DAL.close();
        }

        public void add_cstmr_fatora(int cstmr_id, DateTime timastamp)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[0].Value = cstmr_id;
            param[1] = new SqlParameter("@timastamp", SqlDbType.DateTime);
            param[1].Value = timastamp;


            DAL.executecommand("add_cstmr_fatora", param);
            DAL.close();
        }
        public void add_preExist_prd_to_cstmr_fatora(int prd_id, double price, int quantity, int cstmr_id, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@price", SqlDbType.Float);
            param[1].Value = price;
            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;
            param[3] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[3].Value = cstmr_id;
            param[4] = new SqlParameter("@dte", SqlDbType.Date);
            param[4].Value = dte;


            DAL.executecommand("add_preExist_prd_to_cstmr_fatora", param);
            DAL.close();
        }
        public DataTable get_all_cstmrs()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_cstmrs", null);
            DAL.close();
            return dt;

        }
        public void ad_cstmr(string nme, string phone, string adress, double max, string mndb)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 50);
            param[0].Value = nme;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar,50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@adress", SqlDbType.VarChar, 50);
            param[2].Value = adress;
            param[3] = new SqlParameter("@max", SqlDbType.Float);
            param[3].Value = max;
            param[4] = new SqlParameter("@mndb", SqlDbType.VarChar, 100);
            param[4].Value = mndb;
            DAL.executecommand("add_cstmr", param);
            DAL.close();
        }
        public DataTable search_cstmrs(string dscrbshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrbshn", SqlDbType.VarChar, 50);
            param[0].Value = dscrbshn;

            dt = DAL.selectData("search_cstmrs", param);
            DAL.close();
            return dt;
        }
        public void edit_cstmrs(string id,string nme, string pho, string adrs,double max,string mndb)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.VarChar,50);
            param[1].Value = nme;
            param[2] = new SqlParameter("@pho", SqlDbType.VarChar, 50);
            param[2].Value = pho;
            param[3] = new SqlParameter("@adrs", SqlDbType.VarChar, 50);
            param[3].Value = adrs;
            param[4] = new SqlParameter("@max", SqlDbType.Float);
            param[4].Value = max;
            param[5] = new SqlParameter("@mndb", SqlDbType.VarChar,100);
            param[5].Value = mndb;
            DAL.executecommand("edit_cstmrs", param);
            DAL.close();
        }
        public void delete_cstmr(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.executecommand("delete_cstmr", param);
            DAL.close();
        }
        public DataTable get_cstmr_adress(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar, 50);
            param[0].Value = nme;

            dt = DAL.selectData("get_cstmr_adress", param);
            DAL.close();
            return dt;
        }
        
    }
}
