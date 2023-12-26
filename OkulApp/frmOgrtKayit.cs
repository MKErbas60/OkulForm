using OkulApp.BLL;
using OkullApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class frmOgrtKayit : Form
    {
        public frmOgrtKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("11 haneli TC giriniz");
                
            }
            else
            {
                try
                {
                    var obl = new OgretmenBL();
                    bool sonuc = obl.OgretmenEkle(new Ogretmen { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), TC = txtTC.Text.Trim(), });
                    MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme başarısız!!");
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 2627:
                            MessageBox.Show("Bu numaralı öğretmen zaten var.");
                            break;
                        default:
                            MessageBox.Show("Veritabanı hatası");
                            break;
                    }
                }
                catch (Exception)
                {
                    throw;
                    MessageBox.Show("Allahallah ne oldu acep");
                }

            }
        }

        private void ogrBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void TC_Click(object sender, EventArgs e)
        {

        }
    }
}
