using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2.BL
{
    class cls_orders
    {
        public DataTable edit_order_mndob(int id_order, int id_mndob)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;
            param[1] = new SqlParameter("@id_mndob", SqlDbType.Int);
            param[1].Value = id_mndob;

            dt = DAL.selectData("edit_order_mndob", param);
            DAL.close();
            return dt;
        }
        public void Edit_order_Date(int id, string date, DateTime datetme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@date", SqlDbType.NVarChar,50);
            param[1].Value = date;
            param[2] = new SqlParameter("@datetme", SqlDbType.DateTime);
            param[2].Value = datetme;
            DAL.executecommand("Edit_order_Date", param);
            DAL.close();
        }
        public DataTable get_single_new_orders(int order_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_id;

            dt = DAL.selectData("get_single_new_orders", param);
            DAL.close();
            return dt;
        }
        public DataTable get_single_new_order_mndb(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = DAL.selectData("get_single_new_order_mndb", param);
            DAL.close();
            return dt;


        }

        public void re_calc_total_price_for_order(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("re_calc_total_price_for_order", param);
            DAL.close();
        }

        public void Edit_mksb(int id_order, string mksab)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@mksab", SqlDbType.VarChar,50);
            param[1].Value = mksab;

            DAL.executecommand("Edit_mksb", param);
            DAL.close();
        }
        public void change_cstmr(int order_id, int cstmr_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[1].Value = cstmr_id;

            DAL.executecommand("change_cstmr", param);
            DAL.close();
        }
        public DataTable get_last_order_id()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_last_order_id", null);
            DAL.close();
            return dt;

        }
        public void ad_order(int id_order, DateTime order_date, int cstmr_id, string saleman)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;
            param[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[1].Value = order_date;
            param[2] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[2].Value = cstmr_id;
            param[3] = new SqlParameter("@saleman", SqlDbType.VarChar, 50);
            param[3].Value = saleman;


            DAL.executecommand("ad_order", param);
            DAL.close();
        }
        public void add_order_details(int id_order, int id_product, int qte, string price, double disc, string pmsthlk, string totalp, string msdd, string mtbki, string serials = null)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;
            param[1] = new SqlParameter("@id_product", SqlDbType.Int);
            param[1].Value = id_product;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;
            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;
            param[4] = new SqlParameter("@disc", SqlDbType.Float);
            param[4].Value = disc;
            param[5] = new SqlParameter("@totalp", SqlDbType.VarChar, 50);
            param[5].Value = totalp;
            param[6] = new SqlParameter("@pmsthlk", SqlDbType.VarChar, 50);
            param[6].Value = pmsthlk;
            param[7] = new SqlParameter("@msdd", SqlDbType.VarChar, 50);
            param[7].Value = msdd;
            param[8] = new SqlParameter("@mtbki", SqlDbType.VarChar, 50);
            param[8].Value = mtbki;
            param[9] = new SqlParameter("@serials", SqlDbType.NVarChar, -1);
            param[9].Value = (object)serials ?? DBNull.Value;

            DAL.executecommand("add_order_details", param);
            DAL.close();
        }
        public DataTable verifyqte(int id_product, int qte_entered)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_product", SqlDbType.Int);
            param[0].Value = id_product;
            param[1] = new SqlParameter("@qte_entered", SqlDbType.Int);
            param[1].Value = qte_entered;
            dt = DAL.selectData("verifyqte", param);
            DAL.close();
            return dt;


        }
        public DataTable get_last_order_forprint()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_last_order_forprint", null);
            DAL.close();
            return dt;

        }
        public DataTable getorderdetails(int id_order)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            dt = DAL.selectData("getorderdetails", param);
            DAL.close();
            return dt;
        }
        public DataTable search_order(string dscrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrpshn", SqlDbType.VarChar, 50);
            param[0].Value = dscrpshn;

            dt = DAL.selectData("search_order", param);
            DAL.close();
            return dt;
        }
        public void avoid_order(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.executecommand("avoid_order", param);
            DAL.close();
        }
        /*     //هنا بجيب بيانات العميل ـ تبع تعديل الفاتوره ـ
             public DataTable bianat_ameel_mnelesm(string name)
             {
                 DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
                 DataTable dt = new DataTable();
                 SqlParameter[] param = new SqlParameter[1];

                 param[0] = new SqlParameter("@name", SqlDbType.VarChar,50);
                 param[0].Value = name;

                 dt = DAL.selectData("bianat_ameel_mnelesm", param);
                 DAL.close();
                 return dt;
             }*/
        public DataTable get_order_details_for_edit(string id_order)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.VarChar, 50);
            param[0].Value = id_order;

            dt = DAL.selectData("get_order_details_for_edit", param);
            DAL.close();
            return dt;
        }
        public DataTable get_price_msdd(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = DAL.selectData("get_price_msdd", param);
            DAL.close();
            return dt;
        }
        public DataTable get_price_mtbkii(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = DAL.selectData("get_price_mtbkii", param);
            DAL.close();
            return dt;
        }
        //في التعديل ع الفاتورة لما بعمله من ليسته الاوردرات
        public void add_product_to_order(string id_order, int prd_id, int qte, string price, double disc, string price_msthlk, string totl_price, string price_msdd, string price_mtpkii)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@id_order", SqlDbType.VarChar, 50);
            param[0].Value = id_order;
            param[1] = new SqlParameter("@prd_id", SqlDbType.Int);
            param[1].Value = prd_id;
            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;
            param[4] = new SqlParameter("@disc", SqlDbType.Float);
            param[4].Value = disc;

            param[5] = new SqlParameter("@price_msthlk", SqlDbType.VarChar, 50);
            param[5].Value = price_msthlk;
            param[6] = new SqlParameter("@totl_price", SqlDbType.VarChar, 50);
            param[6].Value = totl_price;

            param[7] = new SqlParameter("@price_msdd", SqlDbType.VarChar, 50);
            param[7].Value = price_msdd;
            param[8] = new SqlParameter("@price_mtpkii", SqlDbType.VarChar, 50);
            param[8].Value = price_mtpkii;
            DAL.executecommand("add_product_to_order", param);
            DAL.close();
        }
        public DataTable get_price_shraa_for_mksb(string id_order)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.VarChar, 50);
            param[0].Value = id_order;

            dt = DAL.selectData("get_price_shraa_for_mksb", param);
            DAL.close();
            return dt;
        }
        public void tzbeet_qte(string id, int qte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
   
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
   

            DAL.executecommand("tzbeet_qte", param);
            DAL.close();

        }
        public void update_msdd_mtpakii(string id, string pmsdd, string pmtpakii)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@pmsdd", SqlDbType.VarChar, 50);
            param[1].Value = pmsdd;

              param[2] = new SqlParameter("@pmtpakii", SqlDbType.VarChar, 50);
            param[2].Value = pmtpakii;


            DAL.executecommand("update_msdd_mtpakii", param);
            DAL.close();
        }
        public DataTable get_cstmr_orders(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = DAL.selectData("get_cstmr_orders", param);
            DAL.close();
            return dt;
        }
        public DataTable get_all_md5lat()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_md5lat", null);
            DAL.close();
            return dt;

        }
        public void edit_md5al(int id, string value,string date, string dskrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@value", SqlDbType.VarChar, 50);
            param[1].Value = value;

            param[2] = new SqlParameter("@date", SqlDbType.VarChar,50);
            param[2].Value = date;

            param[3] = new SqlParameter("@dskrpshn", SqlDbType.VarChar,200);
            param[3].Value = dskrpshn;


            DAL.executecommand("edit_md5al", param);
            DAL.close();
        }
        public void delete_md5al(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_md5al", param);
            DAL.close();
        }
        public void add_md5al( string value, string date, string dskrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            

            param[0] = new SqlParameter("@value", SqlDbType.VarChar, 50);
            param[0].Value = value;

            param[1] = new SqlParameter("@date", SqlDbType.VarChar,50);
            param[1].Value = date;

            param[2] = new SqlParameter("@dskrpshn", SqlDbType.VarChar, 200);
            param[2].Value = dskrpshn;


            DAL.executecommand("add_md5al", param);
            DAL.close();
        }
        public DataTable search_md5lat_bydate(string date)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 50);
            param[0].Value = date;

            dt = DAL.selectData("search_md5lat_bydate", param);
            DAL.close();
            return dt;
        }
        public void add_to_new_orders(int id_order, string order_date, int cstmr_id, string msdd,
            string mtpakii, string total, string mksab,int mndb_id ,double transport,string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;
            param[1] = new SqlParameter("@order_date", SqlDbType.VarChar,50);
            param[1].Value = order_date;
            param[2] = new SqlParameter("@cstmr_id", SqlDbType.Int);
            param[2].Value = cstmr_id;
            param[3] = new SqlParameter("@msdd", SqlDbType.VarChar, 50);
            param[3].Value = msdd;
            param[4] = new SqlParameter("@mtpakii", SqlDbType.VarChar,50);
            param[4].Value = mtpakii;
            param[5] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[5].Value = total;
            param[6] = new SqlParameter("@mksab", SqlDbType.VarChar, 50);
            param[6].Value = mksab;
            param[7] = new SqlParameter("@mndb_id", SqlDbType.Int);
            param[7].Value = mndb_id;
            param[8] = new SqlParameter("@transport", SqlDbType.Float);
            param[8].Value = transport;
            param[9] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
            param[9].Value = notes;

            DAL.executecommand("add_to_new_orders", param);
            DAL.close();
        }
        public DataTable get_all_new_orders()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_new_orders", null);
            DAL.close();
            return dt;

        }
        public DataTable search_new_orders_bydate(string dscrpshn)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dscrpshn", SqlDbType.VarChar, 50);
            param[0].Value = dscrpshn;

            dt = DAL.selectData("search_new_orders_bydate", param);
            DAL.close();
            return dt;
        }
        public DataTable get_price_shraa_formksab_in_order(int id_product)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_product", SqlDbType.Int);
            param[0].Value =id_product;

            dt = DAL.selectData("get_price_shraa_formksab_in_order", param);
            DAL.close();
            return dt;
        }
        public DataTable get_cstmr_id(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar,50);
            param[0].Value = nme;

            dt = DAL.selectData("get_cstmr_id", param);
            DAL.close();
            return dt;
        }
        public void update_msdd_mtpakii_in_new_orders(string id, string pmsdd, string pmtpakii)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@pmsdd", SqlDbType.VarChar, 50);
            param[1].Value = pmsdd;

            param[2] = new SqlParameter("@pmtpakii", SqlDbType.VarChar, 50);
            param[2].Value = pmtpakii;


            DAL.executecommand("update_msdd_mtpakii_in_new_orders", param);
            DAL.close();
        }
        public DataTable delete_m5rgat(string id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = DAL.selectData("delete_m5rgat", param);
            DAL.close();
            return dt;
        }
        public DataTable delete_product_from_order(int id_product,int order_id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_product", SqlDbType.Int);
            param[0].Value = id_product;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;

            dt = DAL.selectData("delete_product_from_order", param);
            DAL.close();
            return dt;
        }
        public DataTable get_7sab_sabk(string nme)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nme", SqlDbType.VarChar,50);
            param[0].Value = nme;

            dt = DAL.selectData("get_7sab_sabk", param);
            DAL.close();
            return dt;
        }
        public void update_total_w_reb7(int id, string total, string reb7, string mtbaki)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[1].Value = total;

            param[2] = new SqlParameter("@reb7", SqlDbType.VarChar, 50);
            param[2].Value = reb7;

            param[3] = new SqlParameter("@mtbaki", SqlDbType.VarChar, 50);
            param[3].Value = mtbaki;

            DAL.executecommand("update_total_w_reb7", param);
            DAL.close();
        }
        //عاوز كل يوم يبقي ليه فاتوره بيع نقدي واحده بس
        public DataTable one_order_for_each_day(string date)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar,50);
            param[0].Value = date;

            dt = DAL.selectData("one_order_for_each_day", param);
            DAL.close();
            return dt;


        }
        public void edit_new_order(int id, string msdd, string mtbaki, string total, string reb7, int mndb_id, double transport)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@msdd", SqlDbType.VarChar, 50);
            param[1].Value =msdd;

            param[2] = new SqlParameter("@mtbaki", SqlDbType.VarChar, 50);
            param[2].Value = mtbaki;

            param[3] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[3].Value = total;

            param[4] = new SqlParameter("@reb7", SqlDbType.VarChar, 50);
            param[4].Value = reb7;

            param[5] = new SqlParameter("@mndb_id", SqlDbType.Int);
            param[5].Value = mndb_id;

            param[6] = new SqlParameter("@transport", SqlDbType.Float);
            param[6].Value = transport;


            DAL.executecommand("edit_new_order", param);
            DAL.close();
        }
    }
}