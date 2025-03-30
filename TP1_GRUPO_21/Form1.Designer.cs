namespace TP1_GRUPO_21
{
    partial class FormularioPrincipal
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
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.nombreUno = new System.Windows.Forms.Label();
            this.nombreDos = new System.Windows.Forms.Label();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.btnEjercicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(56, 87);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(164, 63);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(75, 199);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(145, 29);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // nombreUno
            // 
            this.nombreUno.AutoSize = true;
            this.nombreUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUno.Location = new System.Drawing.Point(201, 262);
            this.nombreUno.Name = "nombreUno";
            this.nombreUno.Size = new System.Drawing.Size(180, 29);
            this.nombreUno.TabIndex = 2;
            this.nombreUno.Text = "Olguín, Andrés";
            this.nombreUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreDos
            // 
            this.nombreDos.AutoSize = true;
            this.nombreDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreDos.Location = new System.Drawing.Point(201, 302);
            this.nombreDos.Name = "nombreDos";
            this.nombreDos.Size = new System.Drawing.Size(206, 29);
            this.nombreDos.TabIndex = 3;
            this.nombreDos.Text = "Cardozo, Martina";
            this.nombreDos.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.Location = new System.Drawing.Point(249, 87);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(164, 63);
            this.btnEjercicio2.TabIndex = 4;
            this.btnEjercicio2.Text = "Ejercicio 2";
            this.btnEjercicio2.UseVisualStyleBackColor = true;
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio3.Location = new System.Drawing.Point(442, 87);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(164, 63);
            this.btnEjercicio3.TabIndex = 5;
            this.btnEjercicio3.Text = "Ejercicio 3";
            this.btnEjercicio3.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 1046);
            this.Controls.Add(this.btnEjercicio3);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.nombreDos);
            this.Controls.Add(this.nombreUno);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEjercicio1);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label nombreUno;
        private System.Windows.Forms.Label nombreDos;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button btnEjercicio3;
    }
}

