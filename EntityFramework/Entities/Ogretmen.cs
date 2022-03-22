using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Ogretmen : BaseEntity
    {
        public string OgretmenAdi{ get; set; }
        public string Brans{ get; set; }
        public double Maas{ get; set; }
    }
}
