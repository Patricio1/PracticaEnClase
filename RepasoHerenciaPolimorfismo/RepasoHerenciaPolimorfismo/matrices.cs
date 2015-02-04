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
   
    public partial class matrices : Form
    {
        #region indices
        public int fila = 0;
        public int columna = 0;
      public  int[,] matriz1;
      public int[,] matriz2;
      public int totalElementosA = 0;
      public int totalElementosB = 0;
        #endregion
        public matrices()
        {
            InitializeComponent();
        }


        public void llenarMatriz() {
            int[,] matriz1 = new int[Convert.ToInt32(txtFila), Convert.ToInt32(txtColumna)];
            if(txtIngresodat.Text!=""){
            
            }

        }
        private void btnDimension_Click(object sender, EventArgs e)
        {

            if (checkLeft.Checked)
            {
                matrizA.RowCount = Convert.ToInt32(txtFila.Text);
                matrizA.ColumnCount = Convert.ToInt32(txtColumna.Text);
                matriz1 = new int[Convert.ToInt32(txtFila.Text), Convert.ToInt32(txtColumna.Text)];


            }
            else if (checkRight.Checked)
            {
                MatrizB.RowCount = Convert.ToInt32(txtFila.Text);
                MatrizB.ColumnCount = Convert.ToInt32(txtColumna.Text);
                matriz2 = new int[Convert.ToInt32(txtFila.Text), Convert.ToInt32(txtColumna.Text)];
            }
        }

        private void btnIngDatos_Click(object sender, EventArgs e)
        {
            if(columna==Convert.ToInt32(txtColumna.Text)){
                columna = 0;
                fila++;
            }
            if(checkLeft.Checked){
                matrizA[columna, fila].Value = txtIngresodat.Text;
                matriz1[fila, columna] = Convert.ToInt32(txtIngresodat.Text);
                columna++;
                totalElementosA++;
                if (totalElementosA == Convert.ToInt32(txtFila.Text) * Convert.ToInt32(txtColumna.Text))
                {
                    MessageBox.Show("datos completos");
                    fila = 0;
                    columna = 0;
                }
            }
            if(checkRight.Checked){
                MatrizB[columna, fila].Value = txtIngresodat.Text;
                matriz2[fila, columna] = Convert.ToInt32(txtIngresodat.Text);
                columna++;
                totalElementosB++;
                if (totalElementosB == Convert.ToInt32(txtFila.Text) * Convert.ToInt32(txtColumna.Text))
                {
                    MessageBox.Show("datos completos");
            }
            }
            

        }

        private void btnMult_Click(object sender, EventArgs e)
        {

            int fila1= matrizA.RowCount; 
            int columna1= matrizA.ColumnCount;
            int fila2= MatrizB.RowCount; 
            int columna2= MatrizB.ColumnCount;
            int [,]matrizRst= new int[fila1,columna2];
            MatrizR.RowCount = fila1;
            MatrizR.ColumnCount = columna2;
            for(int i=0;i<=fila1-1;i++){
                for(int j=0;j<columna2;j++){
                    for (int k = 0; k < columna1; k++)
                    {
                        matrizRst[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }
            for (int i = 0; i <= fila1 - 1;i++ )
            {
                for (int j = 0; j <= columna2 - 1;j++ )
                {
                    MatrizR[j, i].Value = matrizRst[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(matrizA.RowCount);
        }
    }
}
