using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFila.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(txtFila.Text);
            dataGridView1.ColumnCount = Convert.ToInt16(txtColumna.Text);
            

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int fila= Convert.ToInt32(txtFila.Text);
            int columna=Convert.ToInt16(txtColumna.Text);
            int [,]matriz= new int[fila,columna];
            Boolean h= true;
            int f=0;int c=0;
            Random r = new Random();
            for (int i = 0; i <= fila - 1; i++ )
            {
                for (int j = 0; j <= columna - 1; j++ )
                {
                    
                }
            }
            }


                
        
    }
}
