using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepasoHerenciaPolimorfismo
{
    public partial class respuestacs : Form
    {
        int n;
        public respuestacs(int nume)
        {
            InitializeComponent();
            this.n = nume;
        }
        
        private void respuestacs_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult l= MessageBox.Show("Continuar","Aplicacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (l == DialogResult.Yes)
           {
               encuesta1 n = new encuesta1();
               n.Show();
           }
           else
           {
               this.Close();
           }

        }
    }
}
