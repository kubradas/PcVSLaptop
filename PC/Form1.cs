using System;
using System.Windows.Forms;

namespace PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bilgisayar pc = new Bilgisayar();
            pc.Marka = "Asus";
            pc.Model = "G21CN-TR001T";
            pc.CPU = "Intel i7";
            pc.RAM = "16 GB";
            pc.EkranBoyut = "20 inç";
            pc.IslemciHizi = "2.8 GHz";
            pc.KasaBoyut = "Middle Tower";  //
            pc.SSD ="512 GB";

            Laptop lptp = new Laptop();
            lptp.Marka = "Lenovo";   //
            lptp.Model = "Yoga 730";
            lptp.CPU = "Intel i9";  //
            lptp.IslemciHizi = "1.80 GHz"; //
            lptp.RAM = "32 GB";    //
            lptp.Bluetooth = "Var";
            lptp.KatlananEkran = "Var";
            lptp.SSD = "256 GB";  //
            lptp.Agirlik = "1.5 kg";
            lptp.EkranBoyut = "13.3 inç";  //
            lptp.Kamera = "Var";


            lblPCMarka.Text =pc.Marka;
            //lblPCModel.Text =;
            //lblPCEkranBoyut.Text=;
            //lblPCIslemci.Text=;
            //lblPCHiz.Text=;
            //lblPCRAM.Text =;
            //lblPCSSD.Text =;
            //lblKasaBoyut.Text =;

            //lblLMarka.Text =;
            //lblLModel.Text =;
            //lblLEkranB.Text =;
            //lblLIslemci.Text =;
            //lblLHiz.Text =;
            //lblLRAM,.Text =;
            //lblLSSD.Text =;
            //lblBluetooth.Text=;
            //lblAgirlik.Text =;
            //lblKamera.Text =;
            //lblKatEkran.Text =;
        }

    }
}
