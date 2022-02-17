using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    internal class Sinif
    {
        public string ekle()
        {
            return "insert into TBL_SINIF(Duzey_id, Sube, aciklama) values(@Duzey_id, @Sube, @aciklama)";
        }

        public string guncelle()
        {
            return "update TBL_SINIF set Duzey_id = @Duzey_ifd ,Sube = @Sube ,aciklama = @aciklama where Sinif_id = @Sinif_id";
          
        }
        public string sil()
        {
            return "delete from TBL_SINIF where Sinif_id = @Sinif_id";
        }

        public string listele()
        {
            return "select Duzey_id,Sube,aciklama from TBL_SINIF order by Duzey_id asc , Sube asc";
        }
    }
}
