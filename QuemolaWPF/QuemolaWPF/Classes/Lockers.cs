using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuemolaWPF.Classes
{
    public static class Lockers
    {
        public static object DBConnectionLock = new object();
    }
}
