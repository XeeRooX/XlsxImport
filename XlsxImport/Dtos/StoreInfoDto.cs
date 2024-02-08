using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxImport.Dtos
{
    internal class StoreInfoDto
    {
        public int Store { get; set; }
        public string DocNumber { get; set; } = null!;
        public DateTime DocDate { get; set; }
    }
}
