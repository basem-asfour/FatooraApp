using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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


        public static string company_name = "القرش - لخدمات المحمول";
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
        public static System.Drawing.Bitmap SharkStoreLogoThermal = global::WindowsFormsApplication2.Properties.Resources.Gemini_Generated_Image_4t110l4t110l4t11;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ensure database exists on first launch (runs as current user)
            if (!IsDatabaseReady())
            {
                EnsureDatabase();
            }

            Application.Run(new PL.frm_main());
        }

        static string MasterConnectionString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder(
                    ConfigurationManager.ConnectionStrings["FatooraDB"].ConnectionString);
                builder.InitialCatalog = "master";
                return builder.ConnectionString;
            }
        }

        static bool IsDatabaseReady()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["FatooraDB"].ConnectionString;
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Check that key tables AND procedures exist
                        cmd.CommandText = @"
                            SELECT CASE WHEN
                                EXISTS(SELECT 1 FROM sys.tables WHERE name='catogry') AND
                                EXISTS(SELECT 1 FROM sys.tables WHERE name='new_orders') AND
                                EXISTS(SELECT 1 FROM sys.tables WHERE name='cstmrs') AND
                                EXISTS(SELECT 1 FROM sys.procedures WHERE name='search_new_orders_bydate')
                            THEN 1 ELSE 0 END";
                        return (int)cmd.ExecuteScalar() == 1;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        static void StartLocalDB()
        {
            // Find sqllocaldb.exe - check common paths since PATH may not be updated
            string[] searchPaths = new[]
            {
                "sqllocaldb.exe", // PATH
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                    "Microsoft SQL Server", "150", "Tools", "Binn", "SqlLocalDB.exe"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                    "Microsoft SQL Server", "140", "Tools", "Binn", "SqlLocalDB.exe"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                    "Microsoft SQL Server", "130", "Tools", "Binn", "SqlLocalDB.exe"),
            };

            foreach (var path in searchPaths)
            {
                try
                {
                    var psi = new ProcessStartInfo(path, "start MSSQLLocalDB")
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };
                    var p = Process.Start(psi);
                    if (p != null && p.WaitForExit(15000))
                        return;
                }
                catch { }
            }

            // Also try creating the instance if start fails
            foreach (var path in searchPaths)
            {
                try
                {
                    var psi = new ProcessStartInfo(path, "create MSSQLLocalDB")
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };
                    var p = Process.Start(psi);
                    if (p != null) p.WaitForExit(15000);

                    psi.Arguments = "start MSSQLLocalDB";
                    p = Process.Start(psi);
                    if (p != null && p.WaitForExit(15000))
                        return;
                }
                catch { }
            }
        }

        static void ExecuteSqlBatches(string connectionString, string sql)
        {
            // Split on GO statements (same as sqlcmd)
            var batches = Regex.Split(sql, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var batch in batches)
                {
                    string trimmed = batch.Trim();
                    if (string.IsNullOrEmpty(trimmed)) continue;

                    // Skip pure comment-only batches (no SQL statements)
                    string withoutComments = Regex.Replace(trimmed, @"--[^\r\n]*", "").Trim();
                    if (string.IsNullOrEmpty(withoutComments)) continue;

                    // Skip database-level commands (handled separately)
                    if (Regex.IsMatch(trimmed, @"(?i)CREATE\s+DATABASE")) continue;
                    if (Regex.IsMatch(trimmed, @"(?i)ALTER\s+DATABASE")) continue;
                    if (Regex.IsMatch(trimmed, @"(?i)^\s*USE\s+\[")) continue;
                    if (Regex.IsMatch(trimmed, @"(?i)SELECT\s+name\s+FROM\s+sys\.databases")) continue;
                    if (Regex.IsMatch(trimmed, @"(?i)SELECT\s+collation_name\s+FROM\s+sys\.databases")) continue;

                    try
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = trimmed;
                            cmd.CommandTimeout = 120;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error to temp file for debugging
                        try
                        {
                            string logPath = Path.Combine(Path.GetTempPath(), "FatooraApp_setup.log");
                            string preview = trimmed.Length > 200 ? trimmed.Substring(0, 200) : trimmed;
                            File.AppendAllText(logPath,
                                DateTime.Now.ToString("HH:mm:ss") + " ERROR: " + ex.Message + " | SQL: " + preview + Environment.NewLine);
                        }
                        catch { }
                    }
                }
            }
        }

        static void EnsureDatabase()
        {
            try
            {
                // Step 1: Start LocalDB instance
                StartLocalDB();
                System.Threading.Thread.Sleep(2000);

                // Step 2: Create database if not exists (preserves existing data)
                using (var conn = new SqlConnection(MasterConnectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandTimeout = 120;
                        cmd.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'mostafa_helth') CREATE DATABASE [mostafa_helth] COLLATE Arabic_CI_AS";
                        cmd.ExecuteNonQuery();
                    }
                }

                System.Threading.Thread.Sleep(2000);

                // Step 3: Run setup_database.sql (tables + stored procedures)
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                string dbSetupDir = Path.Combine(appDir, "dbsetup");
                string dbConnStr = ConfigurationManager.ConnectionStrings["FatooraDB"].ConnectionString;

                string setupFile = Path.Combine(dbSetupDir, "setup_database.sql");
                if (File.Exists(setupFile))
                {
                    string sql = File.ReadAllText(setupFile, System.Text.Encoding.UTF8);
                    ExecuteSqlBatches(dbConnStr, sql);
                }

                // Step 4: Run seed_data.sql
                string seedFile = Path.Combine(dbSetupDir, "seed_data.sql");
                if (File.Exists(seedFile))
                {
                    string sql = File.ReadAllText(seedFile, System.Text.Encoding.UTF8);
                    ExecuteSqlBatches(dbConnStr, sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في إعداد قاعدة البيانات:\n" + ex.Message,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
