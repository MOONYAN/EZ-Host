using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZ_Host.ComField
{
    class ComItem: IComparable<ComItem>
    {
        public string Id { get; set; }
        public int Count { get; set; }

        public int CompareTo(ComItem other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
