using OkullApp.MODEL;
using System;
using System.Data.SqlClient;
using DAL;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogret)
        {


            SqlParameter[] p = {
                    new SqlParameter("@Ad",ogret.Ad),
                    new SqlParameter("@Soyad",ogret.Soyad),
                    new SqlParameter("@TC",ogret.TC)
                    };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values(@Ad,@Soyad,@TC)", p) > 0;


        }

    }


}
