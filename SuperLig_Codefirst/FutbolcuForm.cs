using SuperLig_Codefirst.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLig_Codefirst
{
    public partial class FutbolcuForm : Form
    {
        SuperLig2Entities context1 = new SuperLig2Entities(); 
        public FutbolcuForm()
        {
            InitializeComponent();
        }

        private void btnFutbolcuKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox4.Text;
            int FYas = int.Parse(textBox5.Text);
            string Ulke = textBox6.Text;
            string Takimi = textBox7.Text;
            int formaNo = int.Parse(textBox8.Text);


            Player futbolcu = new Player();
            futbolcu.Name = adSoyad;
            futbolcu.Yas = FYas;
            futbolcu.Country = Ulke;
            futbolcu.FormaNumarasi = formaNo;
            futbolcu.OynadigiTakim = Takimi;

            Context c2 = new Context();
            c2.Players.Add(futbolcu);

            c2.SaveChanges();

            MessageBox.Show(futbolcu.Name + " futbolcu tablosuna eklendi");
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void gbFutbolcu_Enter(object sender, EventArgs e)
        {

        }

        private void FutbolcuForm_Load(object sender, EventArgs e)
        {
            dataGridViewFutbolcu.DataSource = (from fut in context1.Players
                                               orderby fut.PlayerId descending
                                               select new
                                               {
                                                   fut.PlayerId,
                                                   fut.Name,
                                                   fut.OynadigiTakim,
                                                   fut.Yas,
                                                   fut.FormaNumarasi
                                               }).ToList(); 
        }
    }
}
