using Energy_Chat.ADOApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Chat
{
    internal class DBConnection
    {
        public static Energy_ChatEntities connection = new Energy_ChatEntities();
    }
}
