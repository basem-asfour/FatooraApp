using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2.BL
{
    class cls_products
    {

        public DataTable get_prd_by_serial(string serial)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@serial", SqlDbType.NVarChar, 1000);
            param[0].Value = serial;
            dt = DAL.selectData("get_prd_by_serial", param);
            DAL.close();
            return dt;
        }
        public void Delete_prd_first_rseed(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("Delete_prd_first_rseed", param);
            DAL.close();

        }

        public void update_prd_name(string nme, int prd_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 500);
            param[0].Value = nme;
            param[1] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[1].Value = prd_id;
            DAL.executecommand("update_prd_name", param);
            DAL.close();

        }

        public DataTable get_order_details_for_catogry_report_date_filter(string cat, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = dte;
            dt = DAL.selectData("get_order_details_for_catogry_report_date_filter", param);
            DAL.close();
            return dt;
        }
        public DataTable get_mrtg3_mbe3at_for_catogry_report_date_filter(string cat, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = dte;
            dt = DAL.selectData("get_mrtg3_mbe3at_for_catogry_report_date_filter", param);
            DAL.close();
            return dt;
        }

        public DataTable get_mrtg3_mshtriat_for_catogry_report_date_filter(string cat, DateTime dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            param[1] = new SqlParameter("@dte", SqlDbType.Date);
            param[1].Value = dte;
            dt = DAL.selectData("get_mrtg3_mshtriat_for_catogry_report_date_filter", param);
            DAL.close();
            return dt;
        }
        public DataTable get_purchases_for_catogry_report_date_filter(string cat, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;
            dt = DAL.selectData("get_purchases_for_catogry_report_date_filter", param);
            DAL.close();
            return dt;
        }
        public DataTable get_order_details_for_catogry_report(string cat)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            dt = DAL.selectData("get_order_details_for_catogry_report", param);
            DAL.close();
            return dt;
        }

        public DataTable get_purchases_for_catogry_report(string cat)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            dt = DAL.selectData("get_purchases_for_catogry_report", param);
            DAL.close();
            return dt;
        }

        public DataTable get_mrtg3_mshtriat_for_catogry_report(string cat)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            dt = DAL.selectData("get_mrtg3_mshtriat_for_catogry_report", param);
            DAL.close();
            return dt;
        }

        public DataTable get_mrtg3_mbe3at_for_catogry_report(string cat)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat", SqlDbType.NVarChar, 100);
            param[0].Value = cat;
            dt = DAL.selectData("get_mrtg3_mbe3at_for_catogry_report", param);
            DAL.close();
            return dt;
        }

        public void update_products_first_rseed(int prd_id, int qte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            DAL.executecommand("update_products_first_rseed", param);
            DAL.close();

        }

        public DataTable get_all_products_first_rseed()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_products_first_rseed", null);
            DAL.close();
            return dt;

        }

        public DataTable get_all_products_for_gard(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.selectData("get_all_products_for_gard", param);
            DAL.close();
            return dt;
        }

        public void edit_prd_qte_for_gard(int id, int qte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            DAL.executecommand("edit_prd_qte_for_gard", param);
            DAL.close();

        }

        public void prd_permenant_delete(int id, string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[1].Value = nme;
            DAL.executecommand("prd_permenant_delete", param);
            DAL.close();

        }

        public void update_prd_first_rseed(int prd_id, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[1].Value = dte;
            DAL.executecommand("update_prd_first_rseed", param);
            DAL.close();

        }
        public DataTable get_all_mrtg3_mshtriat_for_mwrd(string mwrd_nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@mwrd_nme", SqlDbType.NVarChar, 50);
            param[0].Value = mwrd_nme;
            dt = DAL.selectData("get_all_mrtg3_mshtriat_for_mwrd", param);
            DAL.close();
            return dt;
        }

        public DataTable get_mrtg3_mshtriat_for_single_fatora(int fatora_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@fatora_id", SqlDbType.Int);
            param[0].Value = fatora_id;
            dt = DAL.selectData("get_mrtg3_mshtriat_for_single_fatora", param);
            DAL.close();
            return dt;
        }


        public void update_total_mdfo3()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[0];

            DAL.executecommand("update_total_mdfo3", param);
            DAL.close();
        }
        public DataTable search_prd_first_rseed(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[0].Value = nme;
            dt = DAL.selectData("search_prd_first_rseed", param);
            DAL.close();
            return dt;
        }

        public void add_prd_first_rseed(int prd_id, string prd_nme, int qte, double price, double toal_mdfo3, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@prd_nme", SqlDbType.NVarChar, 100);
            param[1].Value = prd_nme;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;
            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;
            param[4] = new SqlParameter("@toal_mdfo3", SqlDbType.Float);
            param[4].Value = toal_mdfo3;
            param[5] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[5].Value = dte;
            DAL.executecommand("add_prd_first_rseed", param);
            DAL.close();

        }
        public DataTable search_corrupted_prd(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[0].Value = nme;
            dt = DAL.selectData("search_corrupted_prd", param);
            DAL.close();
            return dt;
        }
        public void delete_corrupted_prd(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_corrupted_prd", param);
            DAL.close();

        }
        public void edit_corrupted_prd(int id, int prd_id, int qte, string reason, string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[1].Value = prd_id;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;
            param[3] = new SqlParameter("@reason", SqlDbType.NVarChar, 500);
            param[3].Value = reason;
            param[4] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[4].Value = dte;
            DAL.executecommand("edit_corrupted_prd", param);
            DAL.close();

        }

        public void add_corrupted_product(int prd_id, int qte,string reason,string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[0].Value = prd_id;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            param[2] = new SqlParameter("@reason", SqlDbType.NVarChar,500);
            param[2].Value = reason;
            param[3] = new SqlParameter("@dte", SqlDbType.NVarChar,50);
            param[3].Value = dte;
            DAL.executecommand("add_corrupted_product", param);
            DAL.close();

        }

        public void update_product_after_mrtg3_mshtriat(int id, int qte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            DAL.executecommand("update_product_after_mrtg3_mshtriat", param);
            DAL.close();

        }

        public DataTable get_all_mrtg3_mshtriat_for_card(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[0].Value = nme;
            dt = DAL.selectData("get_all_mrtg3_mshtriat_for_card", param);
            DAL.close();
            return dt;
        }
        public DataTable mrtg3_mbe3at_for_card(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[0].Value = nme;
            dt = DAL.selectData("mrtg3_mbe3at_for_card", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_order_details_for_card(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar, 100);
            param[0].Value = nme;
            dt = DAL.selectData("get_all_order_details_for_card", param);
            DAL.close();
            return dt;
        }
        public DataTable get_product_mwrd_for_card(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@nme", SqlDbType.NVarChar,100);
            param[0].Value = nme;
            dt = DAL.selectData("get_product_mwrd_for_card", param);
            DAL.close();
            return dt;
        }
        public DataTable filter_by_store(string store)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@store", SqlDbType.VarChar, 100);
            param[0].Value = store;
            dt = DAL.selectData("filter_by_store", param);
            DAL.close();
            return dt;
        }
        public void add_catogry(string name)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar,200);
            param[0].Value = name;
            DAL.executecommand("add_catogry", param);
            DAL.close();

        }
        public void delete_catogry(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_catogry", param);
            DAL.close();

        }
        public void edit_catogry(int id,string name)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar,200);
            param[1].Value = name;
            DAL.executecommand("edit_catogry", param);
            DAL.close();

        }
        public DataTable get_all_catogries()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_catogries", null);
            DAL.close();
            return dt;

        }
        
       ////////////////////////////////////////////////////
        
        public DataTable get_last_prd_id()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_last_prd_id", null);
            DAL.close();
            return dt;

        }
        public DataTable get_all_catagories()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_catagories", null);
            DAL.close();
            return dt;

        }
        public DataTable get_all_deleted_products()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_deleted_products", null);
            DAL.close();
            return dt;

        }
        public void ad_product(string nme, int qte, string pshr, string pg, string pb,string pmsthlk, string tmd, byte[] img,string kind,string store, string serial, int serialNumberMode = 0)
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
            param[9] = new SqlParameter("@store", SqlDbType.NVarChar, 100);
            param[9].Value = store;
            param[10] = new SqlParameter("@serial", SqlDbType.NVarChar, 2000);
            param[10].Value = serial;
            param[11] = new SqlParameter("@serial_number_mode", SqlDbType.TinyInt);
            param[11].Value = serialNumberMode;
            DAL.executecommand("add_product", param);
            DAL.close();
        }

        public DataTable get_all_products()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_products", null);
            DAL.close();
            return dt;
        }
        public DataTable searchproduct(string ID)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            dt = DAL.selectData("searchproduct", param);
            DAL.close();
            return dt;
        }
        public void deleteproduct(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("deleteproduct", param);
            DAL.close();

        }
        public void undelete_product(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("undelete_product", param);
            DAL.close();

        }
        public DataTable get_image_product(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.selectData("get_image_product", param);
            DAL.close();
            return dt;
        }
        public void update_product(string nme, int qte, string pshr, string pg, string pb, string pmsthlk,
              string tmd, byte[] img, string id, string kind, string store, string serial, int serialNumberMode = 0)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[13];

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
            param[11] = new SqlParameter("@serial", SqlDbType.NVarChar, 500);
            param[11].Value = serial;
            param[12] = new SqlParameter("@serial_number_mode", SqlDbType.TinyInt);
            param[12].Value = serialNumberMode;
            DAL.executecommand("update_product", param);
            DAL.close();
        }
        public DataTable get_nme_product(string dscrbshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dscrbshn", SqlDbType.VarChar, 50);
            param[0].Value = dscrbshn;
            dt = DAL.selectData("get_nme_product", param);
            DAL.close();
            return dt;
        }
        public void add_product_with_mwrd(string nme, int qte, string pshr, string pg, string pb, string pmsthlk
            , string tmd, byte[] img, string kind, string mwrd_name, string id_order,string store)
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

            DAL.executecommand("add_product_with_mwrd", param);
            DAL.close();
        }


        public DataTable select_prd_nme_for_compo()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("select_prd_nme_for_compo", null);
            DAL.close();
            return dt;

        }

        public DataTable get_single_product(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.selectData("get_single_product", param);
            DAL.close();
            return dt;
        }
        /// <summary>Returns serial_number_mode (0=OnePerProduct, 1=OnePerPiece) for a product. Returns 0 if column not found.</summary>
        public int GetProductSerialNumberMode(string productId)
        {
            int id;
            if (!int.TryParse(productId, out id)) return 0;
            var dt = get_single_product(id);
            if (dt.Rows.Count == 0) return 0;
            if (dt.Columns.Contains("serial_number_mode"))
            {
                var v = dt.Rows[0]["serial_number_mode"];
                if (v != null && v != DBNull.Value) return Convert.ToInt32(v);
            }
            return 0;
        }
        public void update_total_mdfo3_to_zero(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DAL.executecommand("update_total_mdfo3_to_zero", param);
            DAL.close();
        }
    /*   public DataTable total_asnaf()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("total_asnaf", null);
            DAL.close();
            return dt;
        }*/
     /*   public DataTable get_all_prodocts_by_me()
        {
        

        }*/
    }

}
