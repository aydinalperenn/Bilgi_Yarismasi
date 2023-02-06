using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması___Mini_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;

            if(label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            LblDogrucevap.Text = "Doğru Cevap: \n" + label4.Text;
            LblDogrucevap.Visible = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            LblDogrucevap.Text = "Doğru Cevap: \n" + label4.Text;
            LblDogrucevap.Visible = true;

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            LblDogrucevap.Text = "Doğru Cevap: \n" + label4.Text;
            LblDogrucevap.Visible = true;
        }

        int  dakika = 1, saniye = 0 ;
        int cıktıDakika = 0, cıktıSaniye = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (cıktıSaniye == 60)
            {
                cıktıSaniye = 0;
                cıktıDakika += 1;
            }
            cıktıSaniye++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 0)
            {
                label8.Text = "60";
                saniye = 60;
                dakika -= 1;
                if (dakika < 10)
                {
                    label6.Text = "0" + dakika.ToString();
                }
                else
                {
                    label6.Text = dakika.ToString();
                }
            }
            saniye--;
            if (saniye < 10)
            {
                label8.Text = "0" + saniye.ToString();
            }
            else
            {
                label8.Text = saniye.ToString();
            }

            if(saniye == 0 && dakika == 0)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                BtnSonraki.Text = "Oyun Bitti";
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Süre Bitti!" + "\n" + "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis + "\n" + "Süre: 01:00" , "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            LblDogrucevap.Text = "Doğru Cevap: \n" + label4.Text;
            LblDogrucevap.Visible = true;
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnSonraki.Text = "Sonraki";
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            LblDogrucevap.Visible = false;

            timer1.Start();
            timer2.Start();

            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 3)
            {
                richTextBox1.Text = "İlk Türkçe sözlük hangisidir ?";
                BtnA.Text = "Divan-ı Hikmet";
                BtnB.Text = "Atabetü'l-Hakayık";
                BtnC.Text = "Kutadgu Bilig";
                BtnD.Text = "Dîvânu Lugâti't-Türk";

                label4.Text = "Dîvânu Lugâti't-Türk";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgemizde bulunmaz ?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Uşak";
                BtnD.Text = "Manisa";

                label4.Text = "Balıkesir"; 
            }

            if (soruno == 1)
            {
                richTextBox1.Text = "İstiklal Marşımız kaç mısradan oluşmaktadır ?";
                BtnA.Text = "2";
                BtnB.Text = "10";
                BtnC.Text = "41";
                BtnD.Text = "40";

                label4.Text = "41";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Eurovision ‘da Türkiyeye birincilik getiren sanatçımız/grubumuz kimdir ?";
                BtnA.Text = "Can Bonomo";
                BtnB.Text = "Sertap Erener";
                BtnC.Text = "Manga";
                BtnD.Text = "Athena";

                label4.Text = "Sertap Erener";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Son Kuşlar kitabı hangi yazarımıza aittir ?";
                BtnA.Text = "Sait Faik Abasıyanık";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri Güntekin";

                label4.Text = "Sait Faik Abasıyanık";
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Osmanlı İmparatorluğundaki ilk halife kimdir ?";
                BtnA.Text = "Osman Bey";
                BtnB.Text = "Fatih Sultan Mehmet";
                BtnC.Text = "Kanuni Sultan Süleyman";
                BtnD.Text = "Yavuz Sultan Selim";

                label4.Text = "Yavuz Sultan Selim";
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Birleşik Arap Emirliklerinin başkenti neresidir ?";
                BtnA.Text = "Mekke";
                BtnB.Text = "Abu Dabi";
                BtnC.Text = "Kudüs";
                BtnD.Text = "Medine";

                label4.Text = "Abu Dabi";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "En genç bilim adamı unvanını elinde tutan Türk bilim adamı kimdir ?";
                BtnA.Text = "Aziz Sancar";
                BtnB.Text = "Cahit Arf";
                BtnC.Text = "Oktay Sinanoğlu";
                BtnD.Text = "Hulusi Behçet";

                label4.Text = "Oktay Sinanoğlu";
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "Çok partili rejim hangi tarihten itibaren gerçekleşmiştir ?";
                BtnA.Text = "1923";
                BtnB.Text = "1938";
                BtnC.Text = "1945";
                BtnD.Text = "1947";

                label4.Text = "1945";
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "2007 yılında 4 dalda birden “Oscar ödülü” kazanan filmin adı nedir ?";
                BtnA.Text = "Köstebek (The Departed)";
                BtnB.Text = "Başlangıç (Inception)";
                BtnC.Text = "Sil Baştan (Eternal Sunshine of the Spotless Mind)";
                BtnD.Text = "Zindan Adası (Shutter Island)";

                label4.Text = "Köstebek (The Departed)";
                BtnSonraki.Text = "Sonuçlar";
            }

            if(soruno == 11)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                LblSoruNo.Text = "10";
                BtnSonraki.Text = "Oyun Bitti";
                timer1.Stop();
                timer2.Stop();

                if (cıktıSaniye < 10)
                {
                    MessageBox.Show( "Tebrikler!" + "\n" + "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis + "\n" + "Süre: " + "0" + cıktıDakika + ":" + "0" + cıktıSaniye, "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    MessageBox.Show("Tebrikler!" + "\n" + "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis + "\n" + "Süre: " + "0" + cıktıDakika + ":" + cıktıSaniye, "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                Application.Exit();
            }
        }
    }
}
