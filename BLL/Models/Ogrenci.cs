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
    public class Ogrenci
    {
        //Properties

        public int id { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciSinif { get; set; }

        public int DersId { get; set; }

        // Actions 

        Execute ex = new Execute();
        SQL.OgrenciSql sql = new SQL.OgrenciSql();
        List<SqlParameter> _params = new List<SqlParameter>();
        string _hataMesaji = "";



        public DataTable listele()
        {


            DataTable dtResult = new DataTable();
            dtResult.TableName = "dtTable";

            dtResult = ex.executeDT(sql.listele(), null, false, ref _hataMesaji);

            return dtResult;

        }

        public bool ekle()
        {
            bool _result = true;

            _params.Add(new SqlParameter("@OgrenciAdi", OgrenciAdi));
            _params.Add(new SqlParameter("@OgrenciSoyadi", OgrenciSoyadi));
            _params.Add(new SqlParameter("@OgrenciSinif", OgrenciSinif));


            bool sonuc = ex.execute(sql.ekle(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;

           

        }
        public bool sil()
        {
            bool result = true;

           
            _params.Add(new SqlParameter("@id", id));

            bool sonuc = ex.execute(sql.sil(), _params.ToArray(),false, ref _hataMesaji);

            return sonuc;
        }

        public bool guncelle()
        {
            bool _result = true;
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@OgrenciAdi", OgrenciAdi));
            _params.Add(new SqlParameter("@OgrenciSoyadi", OgrenciSoyadi));
            _params.Add(new SqlParameter("@OgrenciSinif", OgrenciSinif));


            bool sonuc = ex.execute(sql.guncelle(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;
        }

    }
}


