using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Bina
    {
        public string sqlEkle()
        {
            string _sql = "insert into Bina (BinaAdi,tipid) values (@BinaAdi,@tipid);";

            return _sql;
        }
        public string sqlListele()
        {
            string _sql = "select * from Bina";

            return _sql;
        }
        public string sqlGüncelle()
        {
            string _sql = "update Bina set BinaAdi=@BinaAdi,tipid=@tipid where id=@id;";

            return _sql;
        }
        public string sqlSil()
        {
            string _sql = "delete from Bina where id=@id";

            return _sql;
        }
    }
}
