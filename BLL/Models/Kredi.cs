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
    public class Kredi
    {
        #region Properties
        public int Id { get; set; } 
        public int KrediDegeri { get; set; }
        public int DersId { get; set; }
        public int SinifDuzeyId { get; set; }
        #endregion
        private Execute _execute = new Execute();
        
        SQL.Kredi _sql = new SQL.Kredi();

        List<SqlParameter> _params = new List<SqlParameter>();
        
        #region Actions
        public bool guncelle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@Id", Id));
            _params.Add(new SqlParameter("@Kredidegeri", KrediDegeri));
            _params.Add(new SqlParameter("@DersId", DersId));
            _params.Add(new SqlParameter("@SinifDuzeyId", SinifDuzeyId));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.guncelle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }

        public bool ekle(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@Kredidegeri", KrediDegeri));
            _params.Add(new SqlParameter("@DersId", DersId));
            _params.Add(new SqlParameter("@SinifDuzeyId", SinifDuzeyId));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }
        public bool sil(ref string _hataMesaji)
        {
            bool result = true;

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@Id", Id));

            //database
            _hataMesaji = "";
            result = _execute.execute(_sql.sil(), _params.ToArray(), false, ref _hataMesaji);

            //return
            return result;
        }

        
        /// <summary>
        /// Tüm kullanıcıları getirir.
        /// </summary>
        /// <param name="_hataMesaji"></param>
        public DataTable listele(string _aramaDegeri, int _sefer_id, ref string _hataMesaji)
        {
            DataTable dtResult = new DataTable();

            //Parameters:
            _params.Clear();
            _params.Add(new SqlParameter("@aramaDegeri", _aramaDegeri));
            _params.Add(new SqlParameter("@sefer_id", _sefer_id));

            //database
            _hataMesaji = "";
            dtResult = _execute.executeDT(_sql.listele(), _params.ToArray(), false, ref _hataMesaji);

            //class map
            if (_hataMesaji != "")
            {
                dtResult = null;
            }

            //return
            return dtResult;
        }
        #endregion
    }
}
