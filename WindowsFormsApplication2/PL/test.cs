using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication2.PL
{
    class test
    {
       
        
        String id, pwd;
        test()
        {
            cls_login s = new cls_login();

            DataTable dt = new DataTable();
            dt = s.login("adham" , "asfour");
            Console.WriteLine(dt);
        }
            
        
    }
}
