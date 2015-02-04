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
    public partial class encuesta1 : Form
    {
         int num = 0;
        public encuesta1()
        {
            InitializeComponent();
            label2.Text=Convert.ToString(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                num = 50;
                MessageBox.Show("Acabas de ganar 50 puntos");
            }
            else MessageBox.Show("La respuesta correcta era: Alemania");

            encuesta2 n = new encuesta2(num);
            n.Show();
            this.Hide();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
            label13.Text = Convert.ToString(DateTime.Now.Day);
            label14.Text = Convert.ToString(DateTime.Now.Month);
            label15.Text = Convert.ToString(DateTime.Now.Year);

            label16.Text = Convert.ToString(DateTime.Now.Hour );
            label17.Text = Convert.ToString(DateTime.Now.Minute);
            label18.Text = Convert.ToString(DateTime.Now.Second);
            label20.Text = Convert.ToString(DateTime.Now.Millisecond);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String g = txtCadena.Text;
           Boolean rs= g.Contains("mundo");
           Boolean rs1 = g.Contains("MUNDO");
            g.
            
            
            if(rs||rs1){
                label21.Text = "encontrada";
            }
            
            else{
                label21.Text = "NO encontrada";
            }
        }
        
    }
}
