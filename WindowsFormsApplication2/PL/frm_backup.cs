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
using WindowsFormsApplication2.UI;

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
            
            ApplyModernTheme();
        }
        
        private void ApplyModernTheme()
        {
            // Apply modern form styling
            this.BackColor = ModernTheme.BackgroundMain;
            this.Font = ModernTheme.NormalFont;
            
            // Style TextBox
            if (txtfilename != null)
            {
                ModernTheme.StyleTextBox(txtfilename);
                txtfilename.ReadOnly = true;
                txtfilename.BackColor = Color.FromArgb(248, 249, 250); // Very light gray for readonly
                txtfilename.ForeColor = ModernTheme.TextSecondary;
            }
            
            // Style Labels
            StyleLabels();
            
            // Style Buttons
            StyleButtons();
        }
        
        private void StyleLabels()
        {
            if (label1 != null)
            {
                ModernTheme.StyleLabel(label1, LabelStyle.Title);
                label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                label1.ForeColor = ModernTheme.TextPrimary;
            }
            
            if (label2 != null)
            {
                ModernTheme.StyleLabel(label2, LabelStyle.Secondary);
                label2.BackColor = ModernTheme.BackgroundCard;
                label2.ForeColor = ModernTheme.TextSecondary;
                label2.BorderStyle = BorderStyle.FixedSingle;
                label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }
        }
        
        private void StyleButtons()
        {
            // Browse Folder Button
            if (btnt7dd != null)
            {
                ModernTheme.StyleButton(btnt7dd, ButtonStyle.Secondary);
                btnt7dd.Text = "📁 تحديد مجلد";
                btnt7dd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Create Backup Button
            if (btn2nsh2 != null)
            {
                ModernTheme.StyleButton(btn2nsh2, ButtonStyle.Success);
                btn2nsh2.Text = "💾 إنشاء نسخة احتياطية";
                btn2nsh2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            
            // Exit Button
            if (btnexit != null)
            {
                ModernTheme.StyleButton(btnexit, ButtonStyle.Danger);
                btnexit.Text = "❌ خروج";
                btnexit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
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
