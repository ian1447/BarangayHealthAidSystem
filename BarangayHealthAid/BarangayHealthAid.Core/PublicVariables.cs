using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarangayHealthAid.Core
{
    public class PublicVariables
    {
        public static string ProjectName = "Barangay Aid System";
        public static string ProjectVersion = "v1.0.0";

        public static string ConnectionString = "";

        #region Directory Settings
        public static string DefaultDirectory = Environment.CurrentDirectory;

        #endregion

        #region SecurityKey

        //public static string SecurityKey { get; set; }

        public static string SecurityKey = "BarangayAidSystem";

        #endregion

        #region User's Credentials/Privilege

        public static string UserFullName { get; set; }

        #endregion

    }
}
