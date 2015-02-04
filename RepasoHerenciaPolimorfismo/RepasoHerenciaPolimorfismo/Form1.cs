using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InputKey;

namespace RepasoHerenciaPolimorfismo
{
    public partial class Form1 : Form
    {
        public int[] vec;
        public int s = 10;
        public Form1()
        {
            InitializeComponent();
            txtLadoA.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!(txtLadoA.Text == "" || txtLadoB.Text == "" || txtLadoC.Text == ""))
            {
                double a = Convert.ToDouble(txtLadoA.Text);
                double b = Convert.ToDouble(txtLadoB.Text);
                double c = Convert.ToDouble(txtLadoC.Text);
                ClaseBase cl = new ClaseBase(a, b, c);
                cl.SetPerimetro(cl.GetLado1() + cl.GetLado2() + cl.GetLado3());
                String re = Convert.ToString(cl.GetPerimetro());
                txtPerimetro.Text = re;
                double semiperimetro = 0;
                semiperimetro = cl.GetPerimetro() / 2;
                //CALCULO AREA CON LA FROMULA DE HERON
                cl.SetArea(Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c)));
                txtArea.Text = Convert.ToString(cl.GetArea());
            }
            else MessageBox.Show("No hay datos","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = null;
            txtLadoB.Text = null;
            txtLadoC.Text = null;
            txtPerimetro.Text = null;
            txtArea.Text = null;
            
        }

        private void txtLadoA_Leave(object sender, EventArgs e)
        {
            txtLadoB.Focus();
        }

        private void txtLadoB_Leave(object sender, EventArgs e)
        {
            txtLadoC.Focus();
        }

        private void txtLadoC_Leave(object sender, EventArgs e)
        {
            btnCalcular.Focus();
        }

        private void tabTriangulo_Leave(object sender, EventArgs e)
        {
            txtLadoA.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularAyP_Click(object sender, EventArgs e)
        {
            ClaseBase cd = new ClaseBase(Convert.ToDouble(txtLado.Text));
            cd.SetPerimetro(cd.GetLado1()*4);
            txtPerimetroCuadr.Text=Convert.ToString(cd.GetPerimetro());
            cd.SetArea(cd.GetLado1()*cd.GetLado1());

            txtAreaCuadr.Text = Convert.ToString(cd.GetArea());

        }

        private void btnBorrarCuadr_Click(object sender, EventArgs e)
        {
            txtLado.Text = null;
            txtAreaCuadr.Text = null;
            txtPerimetro.Text = null;

        }

        private void btnCalcularRect_Click(object sender, EventArgs e)
        {
            ClaseBase cl = new ClaseBase(Convert.ToDouble(txtLadoRct.Text),
                                         Convert.ToDouble(txtAnchoRect.Text));

            cl.SetPerimetro(cl.GetLado1()*2+cl.GetLado2()*2);
            txtPerimetroRect.Text = Convert.ToString(cl.GetPerimetro());

            cl.SetArea(cl.GetLado1()*cl.GetLado2());
            txtAreaRect.Text = Convert.ToString(cl.GetArea());

        }

        private void btnBorrarRect_Click(object sender, EventArgs e)
        {
            txtLadoRct.Text = null;
            txtAnchoRect.Text = null;
            txtAreaRect.Text = null;
            txtPerimetroRect.Text = null;
        }

        private void btnCalcularTrap_Click(object sender, EventArgs e)
        {
            ClaseBase cp = new ClaseBase(Convert.ToDouble(txtBaseMenor.Text),
                                           Convert.ToDouble(txtBaseMayor.Text),
                                           Convert.ToDouble(txtLadoTrap.Text));
            cp.SetPerimetro(cp.GetLado2()+cp.GetLado1()+cp.GetLado3()*2);
            txtPerimetroTrap.Text = Convert.ToString(cp.GetPerimetro());
            double dif = (cp.GetLado2() - cp.GetLado1())/2;
            double h = Math.Sqrt(Math.Pow(cp.GetLado3(),2)+Math.Pow(dif,2));
            cp.SetArea(((cp.GetLado2()+cp.GetLado1())*h)/2);
            txtAreaTrap.Text = Convert.ToString(cp.GetArea());
        }

        private void btnBorrarTrap_Click(object sender, EventArgs e)
        {
            txtBaseMenor.Text = null;
            txtBaseMayor.Text = null;
            txtLadoTrap.Text = null;
            txtPerimetroTrap.Text = null;
            txtAreaTrap.Text = null;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtIngreso.Text !=""){
                lstLeft.Items.Add(txtIngreso.Text);
                txtIngreso.Clear();
                txtIngreso.Focus();
            }
            String nombre = InputDialog.mostrar("Ingrese su nombre","Informacion Requerida");
            MessageBox.Show("Su nombre: "+nombre);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstLeft.SelectedIndex >= 0)
            {
                lstRight.Items.Add(lstLeft.SelectedItem);
            }
            else MessageBox.Show("Seleccionar elemento","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            //{
            //    e.Handled = false;
            //}
            //else e.Handled = true;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else {
                txtIngresodat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                MessageBox.Show("digite solo letras"); e.Handled = true; }
        }

        public int[] ordenarAscendente() {
            int num = lstLeft.Items.Count;
            vec = new int[num];
            //pasar los datos de la lista al vector
            for (int i = 0; i <= vec.Length - 1; i++)
            {
                vec[i] = Convert.ToInt32(lstLeft.Items[i]);
            }


            for (int i = 0; i <= vec.Length - 2; i++)
            {

                for (int j = i + 1; j <= vec.Length - 1; j++)
                {
                    if (vec[i] > vec[j])
                    {
                        int aux = vec[i];
                        vec[i] = vec[j];
                        vec[j] = aux;
                    }
                }

            }
            return vec;
        }
        private void btnOrdenAsc_Click(object sender, EventArgs e)
        {
            int dimension=ordenarAscendente().Length;
            int[] vec1 = new int[dimension];
            vec1 = ordenarAscendente();

             lstLeft.Items.Clear();
            for(int i=0;i<=vec1.Length-1;i++){
                lstLeft.Items.Add(vec1[i]);
            }


        }

        private void btnOrdenDesc_Click(object sender, EventArgs e)
        {
            int num = lstLeft.Items.Count;
            vec = new int[num];
            //pasar los datos de la lista al vector
            for (int i = 0; i <= vec.Length - 1; i++)
            {
                vec[i] = Convert.ToInt32(lstLeft.Items[i]);
            }
           for(int i=0; i<=vec.Length-2;i++){
               for (int j = i + 1; j <= vec.Length - 1;j++ )

               {
                   if(vec[i]<vec[j]){
                       int aux = vec[i];
                       vec[i] = vec[j];
                       vec[j] = aux;
                   }
               }

           }
           lstLeft.Items.Clear();
           for (int i = 0; i <= vec.Length - 1;i++ )
           {
               lstLeft.Items.Add(vec[i]);
           }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lstLeft.SelectedIndex>=0){
                lstLeft.Items.Remove(lstLeft.SelectedItem);
            }
            else if (lstRight.SelectedIndex >= 0) {
                lstRight.Items.Remove(lstRight.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                lstLeft.Items.Clear();
              lstRight.Items.Clear();
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtLadoA.Focus();
        }

        private void tabTriangulo_Click(object sender, EventArgs e)
        {
            txtLado.Focus();
            txtLadoRct.Focus();
            txtLado.Focus();
            txtBaseMenor.Focus();
            txtIngreso.Focus();
        }

        private void txtLado_Click(object sender, EventArgs e)
        {

        }

        private void txtLadoRct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoRct_Leave(object sender, EventArgs e)
        {
            txtAnchoRect.Focus();

        }

        private void txtAnchoRect_Leave(object sender, EventArgs e)
        {
            btnCalcularRect.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int []vec= new int[ordenarAscendente().Length];
            vec = ordenarAscendente();
            int min= vec[0];
            int max= vec[vec.Length-1];
            txtMaximo.Text = Convert.ToString(max);
            txtMinimo.Text = Convert.ToString(min);
        }

        private void btnFilas_Click(object sender, EventArgs e)
        {
            //llenar matriz de orden 3x3
            int[,] matriz = new int[3, 3];
            Random r= new Random();
            for(int i=0;i<=2;i++){
                for (int j = 0; j <= 2;j++ )
                {
                    matriz[i,j] = r.Next(100);
                }
            }

            porFilas.RowCount = 3;
            porFilas.ColumnCount = 3;

            for(int i=0;i<=2;i++){
                for (int j = 0; j <= 2; j++)
                {
                    porFilas[j, i].Value = matriz[i, j];
                    MessageBox.Show("valor randomico: "+porFilas[j,i].Value);
            }
        }


        }

        private void btnColumnas_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matriz[i, j] = r.Next(100);
                }
            }

            porColumnas.RowCount = 3;
            porColumnas.ColumnCount = 3;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    porColumnas[i, j].Value = matriz[i, j];
                    MessageBox.Show("valor randomico: " + porColumnas[i, j].Value);
                }
            }

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void btnDimension_Click(object sender, EventArgs e)
        {
            matrices m = new matrices();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //  textBox1.Text= Convert.ToString(comboBox1.SelectedItem);
           Random r = new Random();
           timer1.Enabled = true;
           timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("bienvenido");
            
            s--;
            segundos.Text = s + " segundos";
            if(s==0){
                MessageBox.Show("La aplicacion se cerrara");
                this.Close();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

       

        

       

       
    }
}
