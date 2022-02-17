using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Kredi
    {
        public string listele()
        {
            return "select * from Kredi ;";
        }
        public string ekle()
        {
            return "insert into Kredi (KrediDegeri, DersId, SinifDuzeyId) values (@KrediDegeri, @DersId,@SinifDuzeyId);";
        }
        public string guncelle()
        {
            return "update Kredi set KrediDegeri = @KrediDegeri, DersId = @DersId, SinifDuzeyId = @SinifDuzeyId where Id = @Id;";
        }
        public string sil()
        {           
            return "delete from Kredi where Id = @Id;";           
        }
    }
}
