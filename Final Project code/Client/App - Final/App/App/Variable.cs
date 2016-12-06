using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    // This class mainly design for sharing datavalues between forms
    class Variable
    {
        public static string gusername = ""; // it will store username
        public static string gusertype = ""; // it will store user type 
        public static string guserfullname = ""; //fullname
        public static string ipaddress = "10.100.220.33";
        public static int port = 12000;//8080; //12000
        public static string[,] sec_qus = new string[5, 2] { { "Favorite Food?", "0" },
                                                             { "Favorite Teacher?", "1" },
                                                             { "Favorite Hobby?", "2" },
                                                             { "Pet Name?", "3" },
                                                             { "Highschool name?", "4" }};
        public static DataTable Tab_sec = new DataTable();
        public static DataTable Tab_default = new DataTable();
        public static string sm_id = "0";


        public static string add_id = "";
        public static string add_name = "";
        public static string add_detail = "";

        //inet addr:172.17.0.50  Bcast:0.0.0.0  Mask:255.255.0.0 Cloudnine
    }
}