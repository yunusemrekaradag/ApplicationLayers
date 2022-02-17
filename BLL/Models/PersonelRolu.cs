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
    public class PersonelRolu
    {
        //Properties:
        public int id{ get; set; }
        public string personelRolu{ get; set; }

        //Global values
        private Execute _execute = new Execute();
        private SQL.PersonelRol _sql = new SQL.PersonelRol();
        private List<SqlParameter> _params = new List<SqlParameter>();

        //Actions:
        public DataTable listele()
        {
            DataTable dtResult = new DataTable();
            string _hataMesaji = "";
            dtResult = _execute.executeDT(_sql.Listele(), null, false, ref _hataMesaji);

            return dtResult;
        }
        public bool ekle()
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Clear();
            _params.Add(new SqlParameter("@personelrolu", personelRolu));

            _hataMesaji = "";
            result = _execute.execute(_sql.Ekle(), _params.ToArray(), false, ref _hataMesaji);

            return result;
        }
        public bool guncelle()
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Clear();
            _params.Add(new SqlParameter("@personelrolu", personelRolu));
            _params.Add(new SqlParameter("@id", id));

            _hataMesaji = "";
            result = _execute.execute(_sql.Guncelle(), _params.ToArray(), false, ref _hataMesaji);

            return result;
        }
        public bool sil()
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));

            _hataMesaji = "";
            result = _execute.execute(_sql.Sil(), _params.ToArray(), false, ref _hataMesaji);

            return result;
        }

    }
}
