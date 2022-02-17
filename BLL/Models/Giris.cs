﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
     

    public class Giris
    {
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifresi { get; set; }

        Execute _execute = new Execute();
        SQL.Giris _girisSql = new SQL.Giris();
        List<SqlParameter> _params = new List<SqlParameter>();

        public void giris(ref string _hataMesaji)
        {
            _params.Clear();
            _params.Add(new SqlParameter("@kullaniciAdi", kullaniciAdi));
            _params.Add(new SqlParameter("@sifresi", kullaniciSifresi));
            _params.Add(new SqlParameter("@id", id));

            _hataMesaji = "";

            DataTable dt =_execute.executeDT(_girisSql.giris(),_params.ToArray(),false,ref _hataMesaji);



        }

        
    }
   
}
