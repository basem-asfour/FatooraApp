using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static bool isDemo = false;
        public static int months = 1;
        public static string statusCode="basem01285351038asfour";
        public static string saleman;
        //public static string company_name = "EASY MANAGE";
        //public static string company_name = "المهندس";
        //public static string details_1 = "للوازم الأثاث والديكور";
        //public static string details_2 = "واكسسوارات المطبخ الحديث";
        //public static string telephon_1 = "م/أحمد 01009603596";
        ////public static string telephon_2 = " ميت غمر - كفر بهيدة";
        public static string telephon_2 = "";


        public static string company_name = "الشاكر الأعلاف";
        public static string details_1 = "دمياط الجديدة - المنطقة الصناعية";
        public static string details_2 = "    قطعة 37 - بلوك 10";
        public static string telephon_1 = "01200300841 / 01050038421";


        public static string PrintFontType = "Arial";
        //public static string FooterInvoiceText = "البضاعة المباعة لا ترد ولا تستبدل الا في خلال 14 يوم من تاريخ الفاتورة وبحالتها";
        public static string FooterInvoiceText = "اعداد برنامج ادارة المخازن والمبيعات : م/باسم عصفور         " + "ت/01153306987";
        public static string FooterAllReportsText = "اعداد برنامج ادارة المخازن والمبيعات : م/باسم عصفور         " + "ت/01153306987";
        //public static string FooterAllReportsText = "اعداد برنامج ادارة المخازن والمبيعات : م/عبدالعزيز رمضان         " + "ت/01554052883";

        public static System.Drawing.Bitmap PrintUpperImageSource = global::WindowsFormsApplication2.Properties.Resources.logo_trans_ElShaker;
        public static System.Drawing.Bitmap PrintWaterMarkImageSource = global::WindowsFormsApplication2.Properties.Resources.logo_trans_ElShaker;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.frm_main());
        }
    }
}
