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
    public class Personel
    {
        public string personelAdi { get; set; }
        public string personelSoyadi { get; set; }
        public int tcNo { get; set; }       

    
    //global
    private Execute _execute  = new Execute();
    private SQL.Personel _sql = new SQL.Personel();
    private List<SqlParameter> _params = new List<SqlParameter>(); 

    public bool ekle(ref string _hataMesaji) 
    {
             bool result = true;

            _params.Clear();
            _params.Add(new SqlParameter("@personelAdi", personelAdi));
            _params.Add(new SqlParameter("@personelSoyadi", personelSoyadi));
            _params.Add(new SqlParameter("@tcNo", tcNo));

            _hataMesaji = "";
            result = _execute.execute(_sql.ekle(), _params.ToArray(), false, ref _hataMesaji);
 
         return result;
    }

        public bool guncelle(ref string _hataMesaji)
        {
            bool result = true;

            _params.Clear();
            _params.Add(new SqlParameter("@personelAdi", personelAdi));
            _params.Add(new SqlParameter("@personelSoyadi", personelSoyadi));
            _params.Add(new SqlParameter("@tcNo", tcNo));

            _hataMesaji = "";
            result = _execute.execute(_sql.guncelle(),_params.ToArray(),false, ref _hataMesaji);

            return result;
        }

        public bool sil(ref string _hataMesaji)
        {
            bool result = true;
            _params.Clear();
            _params.Add(new SqlParameter("@tcNo", tcNo));

            _hataMesaji = "";
            result= _execute.execute(_sql.sil(),_params.ToArray(),false, ref _hataMesaji);
            return result;
        }
        public DataTable listele(ref string _hataMesaji)
        {
            DataTable result = new DataTable();           
            _hataMesaji = "";
            result = _execute.executeDT(_sql.listele(),null, false, ref _hataMesaji);
            return result;

        }


    }
}
