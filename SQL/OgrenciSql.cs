using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class OgrenciSql
    {

        public string ekle()
        {
            return "insert into Ogrenci (OgrenciAdi , OgrenciSoyadi,OgrenciSinif) values (@ogrenciAdi,@OgrenciSoyadi,@OgrenciSinif)";

        }

        public string sil()
        {
            return "delete from Ogrenci where id=@id";

        }

        public string listele()
        {
            return "select * from Ogrenci";

        }

        public string guncelle()
        {
            return "update Ogrenci set  OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi, OgrenciSinif=@OgrenciSinif where id=@id";

        }
    }
}
