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
    public partial class AntrenorForm : Form
    {
        SuperLig2Entities context3 = new SuperLig2Entities(); 
        public AntrenorForm()
        {
            InitializeComponent();
        }

        private void btnAntrenorKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox9.Text;
            int yas = int.Parse(textBox10.Text);
            string Ulke = textBox11.Text;
            string calistirdigiT = textBox12.Text;


            Antrenor teknikDirektor = new Antrenor();
            teknikDirektor.AntrenorAdi = adSoyad;
            teknikDirektor.Yas = yas;
            teknikDirektor.Ulke = Ulke;
            teknikDirektor.TakimI = calistirdigiT;

            Context c3 = new Context();
            c3.Trainers.Add(teknikDirektor);

            c3.SaveChanges();

            MessageBox.Show(teknikDirektor.AntrenorAdi + " teknik direktor tablosuna eklendi  ");

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }

        private void AntrenorForm_Load(object sender, EventArgs e)
        {
            dataGridViewAntrenor.DataSource = (from ant in context3.Antrenors
                                               orderby ant.AntrenorId descending
                                               select new
                                               {
                                                   ant.AntrenorId,
                                                   ant.AntrenorAdi,
                                                   ant.Yas,
                                                   ant.TakimI,
                                                   ant.Ulke
                                               }).ToList(); 

        }
    }
}
