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


        public static string company_name = "القرش - لخدمات الحمول";
        public static string details_1 = "ميت غمر - شارع الجيش - برج الأطباء";
        public static string details_2 = "   ";
        public static string telephon_1 = "01288870447 / 01002826560";


        public static string PrintFontType = "Arial";
        //public static string FooterInvoiceText = "البضاعة المباعة لا ترد ولا تستبدل الا في خلال 14 يوم من تاريخ الفاتورة وبحالتها";

        //public static string FooterInvoiceText = "اعداد برنامج ادارة المخازن والمبيعات : م/باسم عصفور         " + "ت/01153306987";
        //public static string FooterAllReportsText = "اعداد برنامج ادارة المخازن والمبيعات : م/باسم عصفور         " + "ت/01153306987";
        public static string FooterInvoiceText = " ";
        public static string FooterAllReportsText = " ";

        public static System.Drawing.Bitmap PrintUpperImageSource = global::WindowsFormsApplication2.Properties.Resources.sharkLogo_Photoroom;
        public static System.Drawing.Bitmap PrintWaterMarkImageSource = global::WindowsFormsApplication2.Properties.Resources.sharkLogo_Photoroom;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.frm_main());
        }
    }
}
