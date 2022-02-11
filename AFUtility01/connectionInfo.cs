using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFUtility01
{
    //use this class to set your conneciton information
    internal class connectionInfo
    {
        //for Analysis, we don't even need to specify the database, only AFServerName
        //also listed user and password, if we like to do basic/NTLM/Kerberos authentication, but without specifying it I can connect using NTLM too
        //https://docs.microsoft.com/en-us/dotnet/api/system.net.networkcredential?view=net-6.0
        static public string AFServerName = "Gary-VM2.dev.osisoft.int";
        static public string AFDatabaseName = "SecondDatabase";
        static public string user = @"DEV\svc-twijono-pi-cor";
        static public string password = @"L3QYMs@)GJFpnPZv&E";
    }
}
