namespace Repeticion_prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cajaTexto = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cajaTexto
            // 
            this.cajaTexto.Location = new System.Drawing.Point(39, 28);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(135, 143);
            this.cajaTexto.TabIndex = 0;
            this.cajaTexto.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(224, 28);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(128, 147);
            this.lstResultados.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cajaTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cajaTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstResultados;
    }
}

