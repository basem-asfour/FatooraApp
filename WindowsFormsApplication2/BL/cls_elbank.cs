using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2.BL
{
    class cls_elbank
    {

        public DataTable filter_elbank_by_date(string dte)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dte", SqlDbType.NVarChar, 50);
            param[0].Value = dte;


            dt = DAL.selectData("filter_elbank_by_date", param);
            DAL.close();
            return dt;


        }
        public DataTable Get_month_details(string date)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.NVarChar,50);
            param[0].Value = date;


            dt = DAL.selectData("Get_month_details", param);
            DAL.close();
            return dt;


        }
        public DataTable get_all_elbank()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_all_elbank", null);
            DAL.close();
            return dt;

        }
        public void add_elbank(string type, double first,string value,double last,string dscrpshn, string date)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@type", SqlDbType.NVarChar,50);
            param[0].Value = type;
            param[1] = new SqlParameter("@first", SqlDbType.Float);
            param[1].Value = first;
            param[2] = new SqlParameter("@value", SqlDbType.VarChar,50);
            param[2].Value = value;
            param[3] = new SqlParameter("@last", SqlDbType.Float);
            param[3].Value = last;
            param[4] = new SqlParameter("@dscrpshn", SqlDbType.NVarChar,50);
            param[4].Value = dscrpshn;
            param[5] = new SqlParameter("@date", SqlDbType.VarChar, 50);
            param[5].Value = date;


            DAL.executecommand("add_elbank", param);
            DAL.close();
        }
        public void edit_elbank(string type,double first, string value,double last, string dscrpshn, string date)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@type", SqlDbType.NVarChar);
            param[0].Value = type;
            param[1] = new SqlParameter("@first", SqlDbType.Float);
            param[1].Value = first;
            param[2] = new SqlParameter("@value", SqlDbType.VarChar, 50);
            param[2].Value = value;
            param[3] = new SqlParameter("@last", SqlDbType.Float);
            param[3].Value = last;
            param[4] = new SqlParameter("@dscrpshn", SqlDbType.NVarChar, 50);
            param[4].Value = dscrpshn;
            param[5] = new SqlParameter("@date", SqlDbType.VarChar, 50);
            param[5].Value = date;


            DAL.executecommand("edit_elbank", param);
            DAL.close();
        }
        public void delete_bank(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_bank", param);
            DAL.close();
        }
    }
}
