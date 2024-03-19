using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilePlano_Form.src.Model
{
    public class DataModel
    {
        public string Prefijo {  get; set; }
        public double Total { get; set; }
        public double Impuesto { get; set; }
        public double TotalConImpuesto { get; set; }
        public string Mes {  get; set; }
        public string Pagado { get; set; }
    }
}
