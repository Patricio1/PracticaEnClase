using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repeticion_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso(cajaTexto.Text);
        }
        //
        public void ingreso(String dato)
        {

            #region N_palabras
            int i=0;
            int c = 1;
            char ca;
            while(i<=dato.Length-1){
                ca = dato[i];
                if(ca==' '|| ca=='\n'||ca=='\t'){
                    c++;
                    
                }
            i++;
            }
         MessageBox.Show("numero de palabras "+c);
            #endregion


            #region Borrar_Especiales
            String []vector=new String[c];
            int j = 0;
            char car;
            String nuevaCadena="";
            while(j<=dato.Length-1){
                car = dato[j];
                if (!(car == '.' || car == ',' || car == ':' || car == ';'))
                {
                    nuevaCadena += car;
                
                }

                j++;
            }
           MessageBox.Show(nuevaCadena);
            #endregion

            int k = 0;
            int l = 0;
            char ct;
            String palabra="";
            while(k<=nuevaCadena.Length-1){
                ct=nuevaCadena[k];
                if(ct==' '|| ct=='\n'){   
                    vector[l] = palabra;
                    l++;
                    palabra = "";
                   
                    

                    //ct++;
                }
                int s = vector.Length - 1;
                //if (vector.i)
                //{
                //    vector[l] = palabra;
                //}
                palabra += ct;

            k++;
            }

            int o = 0;
            int h = vector.Length;
            while(o<=vector.Length-1){
                MessageBox.Show(vector[o]);
              //  lstResultados.Items.Add(vector[o]);
            o++;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
