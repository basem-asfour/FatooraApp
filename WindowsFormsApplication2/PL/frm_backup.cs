using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2.PL
{
    public partial class frm_backup : Form
    {
        
      //  SqlConnection con = new SqlConnection(@"server=N5BA-PC\SQLEXPRESS;Database=mostafa_helth;Integrated security=true");
       // SqlConnection con = new SqlConnection(@"server=PC-PC\SQLEXPRESS; database=mostafa_helth; integrated security=true");
        //SqlConnection con = new SqlConnection(@"server=./; database=mostafa_helth; integrated security=true");
        SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS; database=mostafa_helth; integrated security=true");
        SqlCommand cmd;
        public frm_backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtfilename.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn2nsh2_Click(object sender, EventArgs e)
        {
            string filename = txtfilename.Text + "\\mostafa_helth" + DateTime.Now.ToShortDateString().Replace('/', '-');
            string strquery = "Backup Database mostafa_helth to Disk='" + filename + ".bak'";
            cmd = new SqlCommand(strquery, con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
            con.Close();
            MessageBox.Show("تم انشاء نسخة احتياطيه بنجاح","انشاء نسخة احتياطية",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
