using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepasoHerenciaPolimorfismo
{
    class ClaseBase:Object
    {
#region Variables
        private double ladoA;
        private double ladoB;
        private double ladoC;
        private double perimetro;
        private double area;
        private TextBox textBox2;
#endregion

        #region Constructores
        
        public ClaseBase(double lado)
        {
            this.ladoA = lado;           
        }

        public ClaseBase(double lado, double ancho)
        {
            this.ladoA = lado;
            this.ladoB = ancho;
        }

        public ClaseBase(double lado1, double lado2, double lado3)
        {
            this.ladoA = lado1;
            this.ladoB = lado2;
            this.ladoC = lado3;
        }

        #endregion

        #region Metodos_manejo_Datos
        public void SetLado1(double lado) {
            this.ladoA = lado;
        }
        public void SetLado2(double lado)
        {
            this.ladoB = lado;
        }
        public void SetLado3(double lado)
        {
            this.ladoC = lado;
        }

        public double GetLado1()
        {
            return this.ladoA;
        }
        public double GetLado2()
        {
            return this.ladoB;
        }
        public double GetLado3()
        {
            return this.ladoC;
        }

        public void SetPerimetro(double perimetro){
            this.perimetro = perimetro;
        }
        public double GetPerimetro()
        {
           return  this.perimetro;
        }

        public void SetArea(double area)
        {
            this.area = area;
        }
        public double GetArea()
        {
            return this.area;
        }

        #endregion

        #region Validacion
        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(char.IsDigit&& e.KeyChar|){
        //    }
        //}
        
        #endregion
    }
}
