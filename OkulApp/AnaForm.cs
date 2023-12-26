using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void CmdOgrenciKayit_Click(object sender, EventArgs e)
        {

            frmOgrKayit ogrenciKayitForm = new frmOgrKayit();
            ogrenciKayitForm.Show();
        }

        private void CmdOgretmenKayit_Click(object sender, EventArgs e)
        {
            frmOgrtKayit ogrenciKayitForm = new frmOgrtKayit();
            ogrenciKayitForm.Show();
        }
    }
}
