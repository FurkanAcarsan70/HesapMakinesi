using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        char _İşlem;
        bool _EkranTemizlenecekMi;
        int _İlkSayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "4";
        }

        private void Sayı1Button_Click(object sender, EventArgs e)
        {
            if(_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if(EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "1";
        }

        private void Sayı2Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "2";
        }

        private void Sayı3Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) { 
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "3";
        }

        private void Sayı5Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) { 
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "5";
        }

        private void Sayı6Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "6";
        }

        private void Sayı8Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) {
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") { EkranLabel.Text = ""; }
            EkranLabel.Text += "8";
        }

        private void Sayı0Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) { 
                EkranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            EkranLabel.Text += "0";
        }

        private void ArtıButton_Click(object sender, EventArgs e)
        {
            _İşlem = '+';
            _EkranTemizlenecekMi = true;
            _İlkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void EksiButton_Click(object sender, EventArgs e)
        {
            _İşlem = '-';
            _EkranTemizlenecekMi = true;
            _İlkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void ÇarpıButton_Click(object sender, EventArgs e)
        {
            _İşlem = '*';
            _EkranTemizlenecekMi = true;
            _İlkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void BölmeButton_Click(object sender, EventArgs e)
        {
            _İşlem = '/';
            _EkranTemizlenecekMi = true;
            _İlkSayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void EşittirButton_Click(object sender, EventArgs e)
        {
            int İkinciSayı = Convert.ToInt32(EkranLabel.Text);
            int Sonuç;
            switch (_İşlem)
            {
                case '+':
                    Sonuç = _İlkSayı + İkinciSayı;
                    break;
                case '-':
                    Sonuç = _İlkSayı - İkinciSayı;
                    break;
                case '*':
                    Sonuç = _İlkSayı * İkinciSayı;
                    break;
                case '/':
                    Sonuç = _İlkSayı / İkinciSayı;
                    break;
                default:
                    Sonuç = 0;
                    break;
            }
            EkranLabel.Text = Convert.ToString(Sonuç);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }
    }
}
