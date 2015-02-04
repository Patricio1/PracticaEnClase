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
    public partial class encuesta2 : Form
    {
        public encuesta2(int num)
        {
            InitializeComponent();
            this.numero = num;
            label2.Text= Convert.ToString(numero);
        }
        int numero;
        private void button1_Click(object sender, EventArgs e)
        {
 if (radioButton1.Checked == true)
            {
                numero += 50;
                MessageBox.Show("Acabas de ganar 50 puntos");
            }
            else MessageBox.Show("La respuesta correcta era: Perro");

            respuestacs n = new respuestacs(numero);
        n.Show();
        this.Hide();
        }
        
        }
    }

