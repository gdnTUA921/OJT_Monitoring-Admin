using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OJT_Monitoring
{
    public static class OJTSession
    {
        public static string userEmail { get; set; }
        public static int userID { get; set; }
        public static string accType { get; set; }

        public static void Clear()
        {
            userEmail = null;
            userID = 0;
            accType = null;
            
        }

    }
}
