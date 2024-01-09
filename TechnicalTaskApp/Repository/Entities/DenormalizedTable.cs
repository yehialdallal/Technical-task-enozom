using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class DenormalizedTable
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Categories { get; set; }
    }
}
