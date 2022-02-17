using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
     public class KitapKayitlari
    {
        //Properties:
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public int KutuphaneID { get; set; }

        DAL.Execute _execute = new DAL.Execute();
        SQL.KitapKayitlari _sql = new SQL.KitapKayitlari();

        string _hataMesaji = "";

        //Actions:
        public DataTable listele()
        {
            
            return _execute.executeDT(_sql.listele(), null, false, ref _hataMesaji);
        }

        public bool ekle()
        {
           // bool _result = false;
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@KitapAdi", KitapAdi));
            _params.Add(new SqlParameter("@KutuphaneID", KutuphaneID));

            return _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);
        }

        public bool guncelle()
        {
            // bool _result = false;
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@KitapID", KitapID));
            _params.Add(new SqlParameter("@KitapAdi", KitapAdi));
            _params.Add(new SqlParameter("@KutuphaneID", KutuphaneID));

            return _execute.execute(_sql.guncelle(), _params.ToArray(), false, ref _hataMesaji);
        }
        public bool sil()
        {
            // bool _result = false;
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@KitapID", KitapID));

            return _execute.execute(_sql.sil(), _params.ToArray(), false, ref _hataMesaji);
        }
    }
}
