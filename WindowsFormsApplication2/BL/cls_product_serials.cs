using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2.BL
{
    class cls_product_serials
    {
        /// <summary>Returns product IDs that have at least one serial in product_serials.</summary>
        public List<int> GetProductIdsThatHaveSerials()
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = DAL.selectData("get_product_ids_with_serials", null);
            DAL.close();
            var list = new List<int>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow r in dt.Rows)
                {
                    if (r["product_id"] != null && r["product_id"] != DBNull.Value)
                        list.Add(Convert.ToInt32(r["product_id"]));
                }
            return list;
        }

        public DataTable GetSerialsByProduct(int productId)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_id", SqlDbType.Int);
            param[0].Value = productId;
            dt = DAL.selectData("get_serials_by_product", param);
            DAL.close();
            return dt;
        }

        /// <summary>Returns serials from product_serials that are not yet sold (not in order_details.serials).</summary>
        public DataTable GetAvailableSerialsForProduct(int productId)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_id", SqlDbType.Int);
            param[0].Value = productId;
            dt = DAL.selectData("get_available_serials_for_product", param);
            DAL.close();
            return dt;
        }

        /// <summary>Returns true if the serial has been sold (exists in order_details.serials).</summary>
        public bool IsSerialSold(string serial)
        {
            if (string.IsNullOrWhiteSpace(serial)) return false;
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@serial", SqlDbType.NVarChar, 500);
            param[0].Value = serial.Trim();
            dt = DAL.selectData("is_serial_sold", param);
            DAL.close();
            if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("is_sold"))
            {
                var v = dt.Rows[0]["is_sold"];
                return v != null && v != DBNull.Value && Convert.ToInt32(v) == 1;
            }
            return false;
        }

        public void AddProductSerial(int productId, string serial, string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@product_id", SqlDbType.Int);
            param[0].Value = productId;
            param[1] = new SqlParameter("@serial", SqlDbType.NVarChar, 500);
            param[1].Value = serial ?? "";
            param[2] = new SqlParameter("@notes", SqlDbType.NVarChar, 500);
            param[2].Value = string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes;
            DAL.executecommand("add_product_serial", param);
            DAL.close();
        }

        public void UpdateProductSerial(int id, string serial, string notes)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@serial", SqlDbType.NVarChar, 500);
            param[1].Value = serial ?? "";
            param[2] = new SqlParameter("@notes", SqlDbType.NVarChar, 500);
            param[2].Value = string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes;
            DAL.executecommand("update_product_serial", param);
            DAL.close();
        }

        public void DeleteProductSerial(int id)
        {
            DAL.DATAaccesslayer DAL = new DAL.DATAaccesslayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.executecommand("delete_product_serial", param);
            DAL.close();
        }
    }
}
