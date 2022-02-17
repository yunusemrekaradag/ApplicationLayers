using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Ogrenci
    {
        //Properties

         public int id { get; set; }
        public string OgrenciAdi { get; set; }
         public string OgrenciSoyadi { get; set; }
         public string OgrenciSinif { get; set; }

        public int DersId { get; set; }

        // Actions 

        

    }
}
