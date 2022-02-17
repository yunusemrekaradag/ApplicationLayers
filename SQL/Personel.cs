using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Personel
    {

        public string ekle()
        {
            return "insert into Personel (personelAdi, personelSoyadi, tcNo) values (@personelAdi, @personelSoyadi, @tcNo);";
        }

        public string guncelle()
        {
            return "update Personel set personelAdi = @personelAdi, personelSoyadi = @personelSoyadi where tcNo=@tcNo;";
        }

        public string sil()
        {
            return "delete from Personel where tcNo = @tcNo";
        }

        public string listele()
        {
            return "select personelAdi, personelSoyadi, tcNo from Personel";
        }


    }
}
