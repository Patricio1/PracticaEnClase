namespace RepasoHerenciaPolimorfismo
{
    partial class matrices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatrizB = new System.Windows.Forms.DataGridView();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.txtIngresodat = new System.Windows.Forms.TextBox();
            this.btnDimension = new System.Windows.Forms.Button();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.MatrizR = new System.Windows.Forms.DataGridView();
            this.btnMult = new System.Windows.Forms.Button();
            this.checkLeft = new System.Windows.Forms.CheckBox();
            this.checkRight = new System.Windows.Forms.CheckBox();
            this.btnIngDatos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizR)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrizB
            // 
            this.MatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizB.Location = new System.Drawing.Point(335, 90);
            this.MatrizB.Name = "MatrizB";
            this.MatrizB.Size = new System.Drawing.Size(240, 150);
            this.MatrizB.TabIndex = 17;
            // 
            // matrizA
            // 
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.Location = new System.Drawing.Point(69, 90);
            this.matrizA.Name = "matrizA";
            this.matrizA.Size = new System.Drawing.Size(240, 150);
            this.matrizA.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(200, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 15;
            this.label32.Text = "Datos";
            // 
            // txtIngresodat
            // 
            this.txtIngresodat.Location = new System.Drawing.Point(265, 65);
            this.txtIngresodat.Name = "txtIngresodat";
            this.txtIngresodat.Size = new System.Drawing.Size(100, 20);
            this.txtIngresodat.TabIndex = 14;
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(388, 12);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(75, 23);
            this.btnDimension.TabIndex = 13;
            this.btnDimension.Text = "Dimensionar";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(265, 38);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(100, 20);
            this.txtColumna.TabIndex = 12;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(265, 12);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(100, 20);
            this.txtFila.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(197, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Columna";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(198, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 13);
            this.label30.TabIndex = 9;
            this.label30.Text = "Fila";
            // 
            // MatrizR
            // 
            this.MatrizR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizR.Location = new System.Drawing.Point(191, 250);
            this.MatrizR.Name = "MatrizR";
            this.MatrizR.Size = new System.Drawing.Size(240, 150);
            this.MatrizR.TabIndex = 18;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(477, 272);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 19;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // checkLeft
            // 
            this.checkLeft.AutoSize = true;
            this.checkLeft.Location = new System.Drawing.Point(89, 64);
            this.checkLeft.Name = "checkLeft";
            this.checkLeft.Size = new System.Drawing.Size(64, 17);
            this.checkLeft.TabIndex = 20;
            this.checkLeft.Text = "Matriz A";
            this.checkLeft.UseVisualStyleBackColor = true;
            // 
            // checkRight
            // 
            this.checkRight.AutoSize = true;
            this.checkRight.Location = new System.Drawing.Point(517, 65);
            this.checkRight.Name = "checkRight";
            this.checkRight.Size = new System.Drawing.Size(64, 17);
            this.checkRight.TabIndex = 21;
            this.checkRight.Text = "Matriz B";
            this.checkRight.UseVisualStyleBackColor = true;
            // 
            // btnIngDatos
            // 
            this.btnIngDatos.Location = new System.Drawing.Point(388, 61);
            this.btnIngDatos.Name = "btnIngDatos";
            this.btnIngDatos.Size = new System.Drawing.Size(75, 23);
            this.btnIngDatos.TabIndex = 22;
            this.btnIngDatos.Text = "Ingresar";
            this.btnIngDatos.UseVisualStyleBackColor = true;
            this.btnIngDatos.Click += new System.EventHandler(this.btnIngDatos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIngDatos);
            this.Controls.Add(this.checkRight);
            this.Controls.Add(this.checkLeft);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.MatrizR);
            this.Controls.Add(this.MatrizB);
            this.Controls.Add(this.matrizA);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtIngresodat);
            this.Controls.Add(this.btnDimension);
            this.Controls.Add(this.txtColumna);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Name = "matrices";
            this.Text = "matrices";
            ((System.ComponentModel.ISupportInitialize)(this.MatrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrizB;
        private System.Windows.Forms.DataGridView matrizA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtIngresodat;
        private System.Windows.Forms.Button btnDimension;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView MatrizR;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.CheckBox checkLeft;
        private System.Windows.Forms.CheckBox checkRight;
        private System.Windows.Forms.Button btnIngDatos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}