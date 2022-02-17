using DAL;
using System;
using System.Collections.Generic;
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
        //Actions
        public bool ekle()
        {
            bool _result = false;
            _params.Add(new SqlParameter("@BinaAdi", BinaAdi));
            string _hataMesaji = "";
            _result = _execute.execute(_sql.sqlEkle(), _params.ToArray(), false, ref _hataMesaji);

            return _result;
        }
    }


}
