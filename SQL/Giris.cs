using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Giris
    {
        public string giris()
        {
            return "select * from KULLANICI where (kullaniciAdi = @kullaniciAdi and kullaniciSifre = @kullaniciSifre) ; ";
        }
    }
}
