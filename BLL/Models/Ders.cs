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
    public class Ders
    {
     public int id { get; set; }
     public string DersAdi { get; set; }

     private Execute _execute = new Execute();
     private SQL.Ders _sql = new SQL.Ders();
     private List<SqlParameter> _params = new List<SqlParameter>();
        public void ara(ref string _hataMesaji)
        {
            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            DataTable dtSefer = _execute.executeDT(_sql.ara(), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji == "" && dtSefer != null && dtSefer.Rows.Count > 0)
            {
                id = int.Parse(dtSefer.Rows[0]["id"].ToString());
                DersAdi = dtSefer.Rows[0]["DersAdi"].ToString();
            }
            else
            {
                _hataMesaji = "Kullanıcı bilgisi alınamadı!";

                id = 0;
                DersAdi = "";
            }
        }
        public DataTable listele(string aramaDegeri, ref string _hataMesaji)
        {
            DataTable dtResult = new DataTable();
            _params.Clear();
            _params.Add(new SqlParameter("@aramaDegeri", aramaDegeri));

            _hataMesaji = "";
            dtResult = _execute.executeDT(_sql.listele(), _params.ToArray(), false, ref _hataMesaji);

            if (_hataMesaji != "")
            {
                dtResult = null;
            }

            return dtResult;
        }
        public bool ekle(ref string _hataMesaji)
        {
            bool result = true;

            
            _params.Clear();
            _params.Add(new SqlParameter("@DersAdi", DersAdi));
 
            _hataMesaji = "";
            result = _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }
        public bool guncelle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@DersAdi", DersAdi));


            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.guncelle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }
        public bool sil(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@id", id));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.sil(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }
    }
}
