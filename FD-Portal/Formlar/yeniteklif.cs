using Firebase.Auth.Providers;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FD_Portal.Formlar
{
    public partial class yeniteklif : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "5vt09TnzlV6g3Eiwl4zyg3Asq5DCSg86cY21YEpd",
            BasePath = "https://fd-deneme-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
   

        public yeniteklif()
        {
            
            

            InitializeComponent();
            txtlzrtekliffiyati.Text = "0";
            txtcnctekliffiyati.Text = "0";
            txtfdkesimfiyati.Text = "0";
            txthatve.Text = "0";
            txtmiktar.Text = "0";
        }
        
        private void yeniteklif_Load(object sender, EventArgs e)
        {

            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            



             var yeniveri = new Data
              {

                  TeklifNo = txttklifno.Text,
                  TeklifistemeTarihi = txttklfistme.Text,
                  FirmaAdi = txtfirmaadi.Text,
                  isinadi = txtisinadi.Text,
                  Hatve = int.Parse(txthatve.Text),
                  Miktar = int.Parse(txtmiktar.Text),
                  CncTeklifTarihi = txtcnctklftarihi.Text,
                  CncTeklifFiyati = int.Parse(txtcnctekliffiyati.Text),
                  FdkesimFiyati = int.Parse(txtfdkesimfiyati.Text),
                  LzrTeklifTarihi = txtlzrtekliftarihi.Text,
                  LzrTeklifFiyati = int.Parse(txtlzrtekliffiyati.Text),
                  Aciklama = txtaciklama.Text,




              };



            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetAsync("Teklif/" + txttklifno.Text, yeniveri);
            Data.result = response.ResultAs<Data>();
            temizle();
        }
        public void temizle()
        {
            txttklifno.Text = "";
            txttklfistme.Text = "";
            txtfirmaadi.Text = "";
            txtisinadi.Text = "";
            txthatve.Text = "0";
            txtmiktar.Text = "0";
            txtcnctklftarihi.Text = "";
            txtcnctekliffiyati.Text = "0";
            txtfdkesimfiyati.Text = "0";
            txtcnctklftarihi.Text = "";
            txtlzrtekliffiyati.Text = "0";
            txtaciklama.Text = "";
        }

        private async void cncpdfup_Click(object sender, EventArgs e)
        {

            OpenFileDialog cncpdfsec = new OpenFileDialog();
            cncpdfsec.Title = "CNC Fiyat Teklifi pdf Dosyası Seç";
            cncpdfsec.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
            if (cncpdfsec.ShowDialog() == DialogResult.OK)
            {
                txtcncteklifpdf.Text = cncpdfsec.FileName;
                // axAcroPDF1.LoadFile(cncpdfsec.FileName);

            }




        }
    }
}
