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
    public class BinaTipi
    {
        //global 
        Execute _execute = new Execute();
        List<SqlParameter> _params = new List<SqlParameter>();  
        SQL.BinaTipi _binaTipi = new SQL.BinaTipi();

        //properties
        public int id { get; set; }
        public string bina_tipi { get; set; }

        //actions
        public DataTable Listele()
        {
            DataTable dt = new DataTable();
            string _hataMesaji="";
            dt=_execute.executeDT(_binaTipi.Listele(), null, false, ref _hataMesaji);
            return dt;
        }
        public bool Ekle()
        {
            bool result = true; 
            string _hataMesaji = "";
            _params.Add(new SqlParameter("@binatipi",bina_tipi));
            result=_execute.execute(_binaTipi.Ekle(),_params.ToArray(),false, ref _hataMesaji);
            return result;
        }
        public bool Guncelle()
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@binatipi", bina_tipi));
            result=_execute.execute(_binaTipi.Guncelle(),_params.ToArray(),false, ref _hataMesaji);
            return result;
        }
        public bool Sil()
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));
            result=_execute.execute(_binaTipi.Sil(),_params.ToArray(),false, ref _hataMesaji);
            return result;
        }
    }
}
