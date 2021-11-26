namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pausa = new System.Windows.Forms.Button();
            this.continua = new System.Windows.Forms.Button();
            this.Reglas = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pausa
            // 
            this.Pausa.Location = new System.Drawing.Point(475, 43);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(145, 51);
            this.Pausa.TabIndex = 0;
            this.Pausa.Text = "Pausa";
            this.Pausa.UseVisualStyleBackColor = true;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // continua
            // 
            this.continua.Location = new System.Drawing.Point(475, 113);
            this.continua.Name = "continua";
            this.continua.Size = new System.Drawing.Size(144, 54);
            this.continua.TabIndex = 1;
            this.continua.Text = "continua";
            this.continua.UseVisualStyleBackColor = true;
            // 
            // Reglas
            // 
            this.Reglas.Location = new System.Drawing.Point(475, 182);
            this.Reglas.Name = "Reglas";
            this.Reglas.Size = new System.Drawing.Size(144, 50);
            this.Reglas.TabIndex = 2;
            this.Reglas.Text = "Reglas";
            this.Reglas.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(475, 246);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(145, 52);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reglas);
            this.Controls.Add(this.continua);
            this.Controls.Add(this.Pausa);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pausa;
        private System.Windows.Forms.Button continua;
        private System.Windows.Forms.Button Reglas;
        private System.Windows.Forms.Button Salir;
    }
}

