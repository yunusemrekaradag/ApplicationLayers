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
    public class Bina
    {
        public int id { get; set; }
        public string BinaAdi { get; set; }
        public int tipid { get; set; }

        Execute _execute = new Execute();
        List<SqlParameter> _params = new List<SqlParameter>();
        SQL.Bina _sql = new SQL.Bina();
     
        public bool ekle()
        {
            bool _result = false;
            _params.Add(new SqlParameter("@BinaAdi", BinaAdi));
            _params.Add(new SqlParameter("@tipid", tipid));
            string _hataMesaji = "";
            _result = _execute.execute(_sql.sqlEkle(), _params.ToArray(), false, ref _hataMesaji);

            return _result;
        }

        public DataTable listele()
        {
            string _hataMesaji = "";
            return _execute.executeDT(_sql.sqlListele(), null, false, ref _hataMesaji);
        }
        public bool güncelle()
        {
            bool _result = false;
            _params.Add(new SqlParameter("@BinaAdi", BinaAdi));
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@tipid", tipid));
            string _hataMesaji = "";
            _result = _execute.execute(_sql.sqlGüncelle(), _params.ToArray(), false, ref _hataMesaji);

            return _result;
        }

        public bool Sil()
        {
            bool _result = false;
            _params.Add(new SqlParameter("@id", id));
            string _hataMesaji = "";
            _result = _execute.execute(_sql.sqlSil(), _params.ToArray(), false, ref _hataMesaji);
            return _result;
        }
    }


}
