using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLibrary
{

    /// <summary>
    /// контракт сканера
    /// </summary>
    public class FaceData
    {

        public int CPU_Usage { get; set; }
        public int RAMLoading { get; set; }
        public DateTime Time { get; set; }

    }


}
