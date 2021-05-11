using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLig_Codefirst;
using SuperLig_Codefirst.Entity;

namespace SuperLig_Codefirst
{
    public partial class TakimForm : Form
    {
        SuperLig2Entities context = new SuperLig2Entities(); 
        public TakimForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Context c = new Context();
            // c.Database.Create();
            dataGridViewTakim.DataSource = (from takim in context.Takims
                                            orderby takim.TakimId descending
                                            select new
                                            {
                                                takim.TakimId,
                                                takim.TakimAd,
                                                takim.KurulusTarihi,
                                                takim.Players
                                            }).ToList();

        }

        private void btnTakimKaydet_Click(object sender, EventArgs e)
        {
            string takimAdi = textBox1.Text;
            string kurulus = textBox2.Text;
            string Antrenor = textBox3.Text;

            Takim t = new Takim();
            t.TakimAd = takimAdi;
            t.KurulusTarihi = kurulus;


            t.AntrenorAdi = Antrenor;

            Context c1 = new Context();
            c1.Teams.Add(t);
            // c1.Teams.Add(trh);
            // c1.Teams.Add(Ant);
            c1.SaveChanges();


            MessageBox.Show("Eklenen Takim : " + takimAdi);
           

                    //var eklenenler = from i in c1.Teams
                    //                 select i;

                    //foreach (var item in eklenenler)
                    //{
                    //    MessageBox.Show("Eklenen takim :" + item.TakimAd); 
                    //}

                    /* string kurulus = textBox2.Text;

                     Takim trh = new Takim();
                     trh.KurulusTarihi = kurulus;

                     Context c2 = new Context();
                     c2.Teams.Add(trh);
                     c2.SaveChanges();

                     string Antrenor = textBox3.Text;

                     Takim Ant = new Takim();
                     Ant.AntrenorAdi = Antrenor;

                     Context c3 = new Context();
                     c3.Teams.Add(Ant);
                     c3.SaveChanges(); 
                      */
                }

        private void btnFutbolcuKaydet_Click(object sender, EventArgs e)
        {
            //string adSoyad = textBox4.Text;
            //int FYas = int.Parse(textBox5.Text);
            //string Ulke = textBox6.Text;
            //string Takimi = textBox7.Text;
            //int formaNo = int.Parse(textBox8.Text);


            //Player futbolcu = new Player();
            //futbolcu.Name = adSoyad;
            //futbolcu.Yas = FYas;
            //futbolcu.Country = Ulke;
            //futbolcu.FormaNumarasi = formaNo;
            //futbolcu.OynadigiTakim = Takimi;

            //Context c2 = new Context();
            //c2.Players.Add(futbolcu);

            //c2.SaveChanges();

            //MessageBox.Show(futbolcu.Name + " futbolcu tablosuna eklendi");




        }

        private void btnAntrenorKaydet_Click(object sender, EventArgs e)
        {
            //string adSoyad = textBox9.Text;
            //int yas = int.Parse(textBox10.Text);
            //string Ulke = textBox11.Text;
            //string calistirdigiT = textBox12.Text;


            //Antrenor teknikDirektor = new Antrenor();
            //teknikDirektor.AntrenorAdi = adSoyad;
            //teknikDirektor.Yas = yas;
            //teknikDirektor.Ulke = Ulke;
            //teknikDirektor.TakimI = calistirdigiT;

            //Context c3 = new Context();
            //c3.Trainers.Add(teknikDirektor);

            //c3.SaveChanges();

            //MessageBox.Show(teknikDirektor.AntrenorAdi + " teknik direktor tablosuna eklendi  ");


        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Refresh(); 
            
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //textBox7.Clear();
            //textBox8.Clear();
            //textBox9.Clear();
            //textBox10.Clear();
            //textBox11.Clear();
            //textBox12.Clear();

            // void textclear(Control ctl)
            //{ 
            //    foreach (Control item in ctl.Controls)
            //    {
            //        if (item is TextBox)
            //        {
            //            ((TextBox)item).Clear();
            //        }
            //        if (item.Controls.Count > 0)
            //        {
            //            textclear(item);
            //        }
            //    }
            //}
        }
        

        }
}

