using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZ_Host.FireField
{
    class FireRecord
    {
        public String Uid { get; set; }
        public String TransactionTime { get; set; }
        public FireCart Cart { get; set; }
    }
}
