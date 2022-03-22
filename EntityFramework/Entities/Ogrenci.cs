using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Ogrenci : BaseEntity
    {
        public string OgrenciAdi{ get; set; }
        public int No{ get; set; }
        public string Sinif{ get; set; }
        public Ogretmen Ogretmen{ get; set; }        

    }
}
