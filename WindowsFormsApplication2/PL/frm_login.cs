using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.UI;

namespace WindowsFormsApplication2.PL
{
    public partial class frm_login : Form
    {
        PL.cls_login log = new PL.cls_login();
        int i;
        public frm_login()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            // Apply modern theme to form
            ModernTheme.StyleForm(this);
            
            // Style textboxes
            ModernTheme.StyleTextBox(txtid);
            ModernTheme.StyleTextBox(txtpwd);
            
            // Style buttons with modern theme
            ModernTheme.StyleButton(btnlogin, ButtonStyle.Success);
            ModernTheme.StyleButton(btncancel, ButtonStyle.Danger);
            
            // Style labels
            ModernTheme.StyleLabel(label1, LabelStyle.Normal);
            ModernTheme.StyleLabel(label2, LabelStyle.Normal);
            ModernTheme.StyleLabel(label3, LabelStyle.Secondary);
            ModernTheme.StyleLabel(label4, LabelStyle.Header);
            
            // Customize header label
            label4.BackColor = ModernTheme.PrimaryColor;
            label4.ForeColor = ModernTheme.TextLight;
            
            // Form styling
            this.BackColor = ModernTheme.BackgroundMain;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (log.get_system_type().Rows.Count == 0)
            {
                log.add_system_type(DateTime.UtcNow.Date, Program.isDemo ? Program.months : 0, Program.isDemo ? "demo" : Program.statusCode);
            }
            if ((Convert.ToDateTime(log.get_system_type().Rows[0][1].ToString()).AddMonths(Convert.ToInt32(log.get_system_type().Rows[0][2].ToString()))) <= DateTime.UtcNow && Program.isDemo)
            {
                log.edit_system_type(1, Program.months, "demo", false);
            }
            if (!Convert.ToBoolean(log.get_system_type().Rows[0][4]) && Program.isDemo)
            {
                MessageBox.Show("برجاء شراء البرنامج للتمتع بكافة الصلاحيات \n انتهت صلاحية النسخة التجريبية", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DataTable dt = log.login(txtid.Text, txtpwd.Text);

            if (dt.Rows.Count > 0)
            {
                frm_main.getmainform.الاصنافToolStripMenuItem.Enabled = true;
                frm_main.getmainform.العملاءToolStripMenuItem.Enabled = true;
                frm_main.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                frm_main.getmainform.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                //frm_main.getmainform.استعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                frm_main.getmainform.الموردينToolStripMenuItem.Enabled = true;
                //frm_main.getmainform.الربحالشهريToolStripMenuItem.Enabled = true;
                frm_main.getmainform.اخريToolStripMenuItem.Enabled = true;
                frm_main.getmainform.النقديةToolStripMenuItem.Enabled = true;
                Program.saleman = dt.Rows[0]["full name"].ToString();
                this.Close();
                MessageBox.Show("login succssesfull");
                i = 0;
                frm_main.getmainform.button1.Visible = false;
                frm_main.getmainform.dataGridView1.Visible = true;

                frm_main.getmainform.groupBox1.Dock = DockStyle.Right;
                //frm_main.getmainform.groupBox2.Dock = DockStyle.Right;
                //frm_main.getmainform.groupBox2.Visible = true;
                frm_main.getmainform.groupBox1.Visible = true;
                frm_main.getmainform.dataGridView1.Dock = DockStyle.Right;

            }
            else
                i++;
            if (i == 1)
            {
                label3.Text = "فشل الدخول ولسالك محاولتين";
                MessageBox.Show("login failed !");

            }

            else if (i == 2)
            {
                label3.Text = "فشل الدخول وركز بقا عشان فاضلك محاوله واحده";
                MessageBox.Show("login failed !");


            }
            else if (i == 3)
            {
                label3.Text = "خلاص يا لص المحاولات خلصت ومش هدخلك";
                MessageBox.Show("login failed !");
                btnlogin.Enabled = false;

            }
        }
        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void txtpwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Login();
                }
                catch (Exception)
                {

                }
               
            }
        }
    }
}
