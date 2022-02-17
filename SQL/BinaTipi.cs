using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class BinaTipi
    {
        public string Listele()
        {
            return "select * from Binatipi";
        }
        public string Ekle()
        {
            return "insert into Binatipi (bina_tipi) values (@binatipi)";
        }
        public string Guncelle()
        {
            return "update Binatipi set bina_tipi=@binatipi where id=@id";
        }
        public string Sil()
        {
            return "delete from Binatipi where id=@id";
        }
    }
}
