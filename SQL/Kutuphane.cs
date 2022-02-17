using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Kutuphane
    {
        public string Listele()
        {
            return "select * from TBL_KUTUPHANE";
        }

        public string Ekle()
        {
            return "insert into TBL_KUTUPHANE (bina_id,kitap_id, aciklama) values (@bina_id,@kitap_id,@aciklama)";
        }

        public string Guncelle()
        {
            return "update TBL_KUTUPHANE set bina_id=@bina_id, kitap_id=@kitap_id, aciklama=@aciklama where id=@id";
        }

        public string Sil()
        {
            return "delete from TBL_KUTUPHANE  where id=@id";
        }
    }
}
