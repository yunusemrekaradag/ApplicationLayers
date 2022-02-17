using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Kutuphane
    {
        //Properties

        public int id { get; set; }
        public int bina_id { get; set; }
        public int kitap_id { get; set; }
        public string aciklama { get; set; }

        string hataMesaji = "";

        //instance
        Execute exec = new Execute();
        SQL.Kutuphane kutuphane = new SQL.Kutuphane();

        //Actions

        public DataTable listele()
        {
            return exec.executeDT(kutuphane.Listele(), null, false, ref hataMesaji);
        }

        public bool ekle()
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@bina_id", bina_id));
            _params.Add(new SqlParameter("@kitap_id", kitap_id));
            _params.Add(new SqlParameter("@aciklama", aciklama));

            return exec.execute(kutuphane.Ekle(), _params.ToArray(),false, ref hataMesaji);

        }

        public bool guncelle()
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@bina_id", bina_id));
            _params.Add(new SqlParameter("@kitap_id", kitap_id));
            _params.Add(new SqlParameter("@aciklama", aciklama));

            return exec.execute(kutuphane.Guncelle(), _params.ToArray(), false, ref hataMesaji);

        }

        public bool sil()
        {
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));
            
            return exec.execute(kutuphane.Sil(), _params.ToArray(), false, ref hataMesaji);

        }


    }
}
