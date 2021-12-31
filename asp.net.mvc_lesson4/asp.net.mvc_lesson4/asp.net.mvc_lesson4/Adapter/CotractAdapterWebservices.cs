using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.mvc_lesson4
{
    /// <summary>
    /// контракт вебсеривисов 
    /// </summary>
    internal class ContractAdapterWebservices
    {
        internal string ServiceName { get; set; }
        internal string Name { get; set; }
        internal  string Dimension { get; set; }
        internal decimal Price { get; set; }
        internal int Discount { get; set; }


    }
}
