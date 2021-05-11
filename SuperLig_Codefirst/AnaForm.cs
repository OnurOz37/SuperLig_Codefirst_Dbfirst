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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void takimKaydiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form TF in Application.OpenForms)
            {
                if (TF.Text == "TakimForm")
                {
                    IsOpen = true;
                    TF.Focus();
                    break; 
                }

            }
            if (IsOpen ==false)
            {
                TakimForm TK2 = new TakimForm();
                TK2.MdiParent = this;
                TK2.Show(); 
                    
            }
        }

       

        private void futbolcuKaydiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FutbolcuForm child2 = new FutbolcuForm();
            child2.MdiParent = this;
            child2.Show();
            
            
            

        }

        private void antrenorKaydiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AntrenorForm child3 = new AntrenorForm();
            child3.MdiParent = this;
            child3.Show(); 
        }
    }
}

