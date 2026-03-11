using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication2.PL
{
    public partial class restore : Form
    {
        SqlConnection con = new SqlConnection(
            new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["FatooraDB"].ConnectionString)
            { InitialCatalog = "master" }.ConnectionString);
        SqlCommand cmd;
        SqlCommand New_cmd;
        SqlCommand New_cmd2;
        public restore()
        {
            InitializeComponent();
        }

        private void btnt7dd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtfilename.Text = openFileDialog1.FileName;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2nsh2_Click(object sender, EventArgs e)
        {
            //Alter Database adham_test Set Offline With RollBack Immediate;
            string strquery = "Restore Database mostafa_helth From Disk='" + txtfilename.Text + "'";
            string new_Query = " alter database [mostafa_helth] SET SINGLE_USER";
            string new_Query2 = "alter database [mostafa_helth] set online";
            New_cmd = new SqlCommand(new_Query, con);
            New_cmd2 = new SqlCommand(new_Query2, con);
            cmd = new SqlCommand(strquery, con);
            con.Open();
            New_cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            New_cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة نسخة احتياطيه بنجاح", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
