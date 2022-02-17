using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{   
        
        public class Ders
        {
        public string ara()
        {
            return "select * from Ders where id = @id;";
        }
        public string listele()
        {
            return "select * from Ders order by DersAdi desc;";
        }
        public string ekle()
        {
            return "insert into Ders (id, DersAdi) values (@id, @DersAdi);";
        }
        public string guncelle()
        {
            return "update Ders set DersAdi = @DersAdi;";
        }
        public string sil()
        {
            return "delete from Ders where id = @id;";
        }

        }

    }

