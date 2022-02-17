using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class KitapKayitlari
    {
        public string listele()
        {
            return "Select * from TBL_KITAPKAYITLARI";

        }
        public string sil()
        {
            return "Delete from TBL_KITAPKAYITLARI where KitapID=@KitapID";

        }
        public string ekle()
        {
            return "Insert into TBL_KITAPKAYITLARI (KitapAdi) values (@KitapAdi)";

        }
        public string guncelle()
        {
            return "Update TBL_KITAPKAYITLARI set KitapAdi=@KitapAdi where KitapID=@KitapID";

        }
    }
}
