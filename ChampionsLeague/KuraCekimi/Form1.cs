using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuraCekimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Takimlar> takimlarlistesi = GetTakimList();

            TorbalaraDagit(takimlarlistesi);
        }

        public List<Takimlar> GetTakimList()
        {
            Takimlar takim1 = new Takimlar();
            takim1.adi = "Real Madrid";
            takim1.ulke = "İspanya";
            Takimlar takim2 = new Takimlar();
            takim2.adi = "BayernMünih";
            takim2.ulke = "Almanya";
            Takimlar takim3 = new Takimlar();
            takim3.adi = "Chelsea";
            takim3.ulke = "İngiltere";
            Takimlar takim4 = new Takimlar();
            takim4.adi = "Juventus";
            takim4.ulke = "İtalya";
            Takimlar takim5 = new Takimlar();
            takim5.adi = "Benfica";
            takim5.ulke = "Portekiz";
            Takimlar takim6 = new Takimlar();
            takim6.adi = "As Monaco";
            takim6.ulke = "Fransa";
            Takimlar takim7 = new Takimlar();
            takim7.adi = "Spartak Moscow";
            takim7.ulke = "Rusya";


            Takimlar takim8 = new Takimlar();
            takim8.adi = "Shaktar Donetsk";
            takim8.ulke = "Ukrayna";

            Takimlar takim9 = new Takimlar();
            takim9.adi = "FC Barcelona";
            takim9.ulke = "İspanya";
            Takimlar takim10 = new Takimlar();
            takim10.adi = "Athletico Madrid";
            takim10.ulke = "İspanya";
            Takimlar takim11 = new Takimlar();
            takim11.adi = "Paris Saint-Germain";
            takim11.ulke = "Fransa";
            Takimlar takim12 = new Takimlar();
            takim12.adi = "Borussia Dortmund";
            takim12.ulke = "Almanya";
            Takimlar takim13 = new Takimlar();
            takim13.adi = "Sevilla";
            takim13.ulke = "İspanya";
            Takimlar takim14 = new Takimlar();
            takim14.adi = "Manchester City";
            takim14.ulke = "İngiltere";
            Takimlar takim15 = new Takimlar();
            takim15.adi = "FC Porto";
            takim15.ulke = "Portekiz";
            Takimlar takim16 = new Takimlar();
            takim16.adi = "Manchester United";
            takim16.ulke = "İngiltere";

            Takimlar takim17 = new Takimlar();
            takim17.adi = "Napoli";
            takim17.ulke = "İtalya";
            Takimlar takim18 = new Takimlar();
            takim18.adi = "Tottenham Hotspur";
            takim18.ulke = "İngiltere";
            Takimlar takim19 = new Takimlar();
            takim19.adi = "FC Basel";
            takim19.ulke = "İsviçre";
            Takimlar takim20 = new Takimlar();
            takim20.adi = "Olympiakos Piraeus";
            takim20.ulke = "Yunanistan";
            Takimlar takim21 = new Takimlar();
            takim21.adi = "Anderlecht";
            takim21.ulke = "Belçika";
            Takimlar takim22 = new Takimlar();
            takim22.adi = "Liverpool";
            takim22.ulke = "İngiltere";
            Takimlar takim23 = new Takimlar();
            takim23.adi = "AS Roma";
            takim23.ulke = "İtalya";
            Takimlar takim24 = new Takimlar();
            takim24.adi = "Besiktas";
            takim24.ulke = "Turkiye";

            Takimlar takim25 = new Takimlar();
            takim25.adi = "Celtic";
            takim25.ulke = "İskoçya";
            Takimlar takim26 = new Takimlar();
            takim26.adi = "CSK Moscow";
            takim26.ulke = "Rusya";
            Takimlar takim27 = new Takimlar();
            takim27.adi = "FC Kobenhavn";
            takim27.ulke = "Danimarka";
            Takimlar takim28 = new Takimlar();
            takim28.adi = "Sporting CP Lisbon";
            takim28.ulke = "Portekiz";
            Takimlar takim29 = new Takimlar();
            takim29.adi = "APOEL Nicosia";
            takim29.ulke = "Kıbrıs";
            Takimlar takim30 = new Takimlar();
            takim30.adi = "Feyenoord";
            takim30.ulke = "Hollanda";
            Takimlar takim31 = new Takimlar();
            takim31.adi = "NK Maribor";
            takim31.ulke = "Slovenya";
            Takimlar takim32 = new Takimlar();
            takim32.adi = "RB Leipzig";
            takim32.ulke = "Almanya";

            List<Takimlar> takimlarlistesi = new List<Takimlar>();
            takimlarlistesi.Add(takim1);
            takimlarlistesi.Add(takim2);
            takimlarlistesi.Add(takim3);
            takimlarlistesi.Add(takim4);
            takimlarlistesi.Add(takim5);
            takimlarlistesi.Add(takim6);
            takimlarlistesi.Add(takim7);
            takimlarlistesi.Add(takim8);
            takimlarlistesi.Add(takim9);
            takimlarlistesi.Add(takim10);
            takimlarlistesi.Add(takim11);
            takimlarlistesi.Add(takim12);
            takimlarlistesi.Add(takim13);
            takimlarlistesi.Add(takim14);
            takimlarlistesi.Add(takim15);
            takimlarlistesi.Add(takim16);
            takimlarlistesi.Add(takim17);
            takimlarlistesi.Add(takim18);
            takimlarlistesi.Add(takim19);
            takimlarlistesi.Add(takim20);
            takimlarlistesi.Add(takim21);
            takimlarlistesi.Add(takim22);
            takimlarlistesi.Add(takim23);
            takimlarlistesi.Add(takim24);
            takimlarlistesi.Add(takim25);
            takimlarlistesi.Add(takim26);
            takimlarlistesi.Add(takim27);
            takimlarlistesi.Add(takim28);
            takimlarlistesi.Add(takim29);
            takimlarlistesi.Add(takim30);
            takimlarlistesi.Add(takim31);
            takimlarlistesi.Add(takim32);
            return takimlarlistesi;
        }

        public void TorbalaraDagit(List<Takimlar> takimlarlistesi)
        {
            lvTorba1.Items.Clear();
            lvTorba2.Items.Clear();
            lvTorba3.Items.Clear();
            lvTorba4.Items.Clear();

            Random rndm = new Random();
            for (int i = 0; i < 8; i++)
            {
                int sayi = rndm.Next(takimlarlistesi.Count);
                var secilenTakim = takimlarlistesi[sayi];
                secilenTakim.torbano = 1;

                ListViewItem item = new ListViewItem();
                item.Text = secilenTakim.adi;
                item.Tag = secilenTakim;
                item.SubItems.Add(secilenTakim.ulke);
                lvTorba1.Items.Add(item);
                takimlarlistesi.RemoveAt(sayi);
            }
            for (int i = 0; i < 8; i++)
            {
                int sayi = rndm.Next(takimlarlistesi.Count);
                var secilenTakim = takimlarlistesi[sayi];
                secilenTakim.torbano = 2;

                ListViewItem item = new ListViewItem();
                item.Text = secilenTakim.adi;
                item.Tag = secilenTakim;
                item.SubItems.Add(secilenTakim.ulke);
                lvTorba2.Items.Add(item);
                takimlarlistesi.RemoveAt(sayi);
            }
            for (int i = 0; i < 8; i++)
            {
                int sayi = rndm.Next(takimlarlistesi.Count);
                var secilenTakim = takimlarlistesi[sayi];
                secilenTakim.torbano = 3;

                ListViewItem item = new ListViewItem();
                item.Text = secilenTakim.adi;
                item.Tag = secilenTakim;
                item.SubItems.Add(secilenTakim.ulke);
                lvTorba3.Items.Add(item);
                takimlarlistesi.RemoveAt(sayi);
            }

            for (int i = 0; i < 8; i++)
            {
                int sayi = rndm.Next(takimlarlistesi.Count);
                var secilenTakim = takimlarlistesi[sayi];
                secilenTakim.torbano = 4;

                ListViewItem item = new ListViewItem();
                item.Text = secilenTakim.adi;
                item.Tag = secilenTakim;
                item.SubItems.Add(secilenTakim.ulke);
                lvTorba4.Items.Add(item);
                takimlarlistesi.RemoveAt(sayi);
            }
        }

        private List<Takimlar> GetGruptakiTakimlar(ListView listView)
        {
            List<Takimlar> gruptakiTakimlar = new List<Takimlar>();
            foreach (ListViewItem item in listView.Items)
            {
                var takim = item.Tag as Takimlar;
                if (takim != null)
                {
                    gruptakiTakimlar.Add(takim);
                }
                else
                {
                    int i = 5;
                }
            }

            return gruptakiTakimlar;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //for (int i = 0; i < 32; i++)
            //{
                if (lvTorba1.Items.Count > 0)
                {
                    TorbadanDagit(lvTorba1);
                }

                else if (lvTorba2.Items.Count > 0)
                {
                    TorbadanDagit(lvTorba2);
                }

                else if (lvTorba3.Items.Count > 0)
                {
                    TorbadanDagit(lvTorba3);
                }

                else if (lvTorba4.Items.Count > 0)
                {
                    TorbadanDagit(lvTorba4);
                }
            //}

          
        }

        private void TorbadanDagit(ListView lvTorba)
        {
            Random r = new Random();
            //torbadan rastgele bir takım seçilecek
            int secilen = r.Next(0, lvTorba.Items.Count);
            var takim = lvTorba.Items[secilen].Tag as Takimlar;
            ListView seciligrupLv = null;

            bool grubaEklenebilirMi = false;
            while (!grubaEklenebilirMi)
            {
                int grupsecimi = r.Next(8);
                seciligrupLv = GetGrup(grupsecimi);

                if (seciligrupLv.Items.Count == 4)
                {
                    continue;
                }

                List<Takimlar> gruptakiTakimlar = GetGruptakiTakimlar(seciligrupLv);

                //Seçilen grupta aynı torbadan var mı kontrol edilecek
                var ayniTorba = gruptakiTakimlar.Count(x => x.torbano == takim.torbano);

                //seçilen grupta aynı ülkeden varmı kontrol edilmeli.
                var ayniUlke = gruptakiTakimlar.Count(x => x.ulke == takim.ulke);
                if (ayniUlke == 0 && ayniTorba == 0)
                {
                    grubaEklenebilirMi = true;
                }

            }

            if (seciligrupLv != null)
            {
                lvTorba.Items.RemoveAt(secilen);
                ListViewItem item = new ListViewItem();
                item.Text = takim.adi;
                item.Tag = takim;
                item.SubItems.Add(takim.ulke);
                seciligrupLv.Items.Add(item);
            }

        }

        public ListView GetGrup(int sayi)
        {
            if (sayi == 0)
            {
                return lvGrupA;
            }

            if (sayi == 1)
            {
                return lvGrupB;
            }
            if (sayi == 2)
            {
                return lvGrupC;
            }
            if (sayi == 3)
            {
                return lvGrupD;
            }
            if (sayi == 4)
            {
                return lvGrupE;
            }

            if (sayi == 5)
            {
                return lvGrupF;
            }
            if (sayi == 6)
            {
                return lvGrupG;
            }
            return lvGrupH;
        }
    }
}
