using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class PersonelRol
    {
        public string Listele()
        {
            return "select * from Personel_Rolu";
        }
        public string Ekle()
        {
            return "insert into Personel_Rolu(Personel_Rolu) values(@personelrolu)";
        }
        public string Guncelle()
        {
            return "update Personel_Rolu set Personel_Rolu = @personelrolu where ID=@id";
        }
        public string Sil()
        {
            return "delete from Personel_Rolu where ID=@id";
        }
    }
}
