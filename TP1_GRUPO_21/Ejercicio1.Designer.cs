namespace TP1_GRUPO_21
{
    partial class Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombresIz = new System.Windows.Forms.ListBox();
            this.lbMover = new System.Windows.Forms.ListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnMoverTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(267, 47);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(190, 22);
            this.textNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(491, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombresIz
            // 
            this.lbNombresIz.FormattingEnabled = true;
            this.lbNombresIz.ItemHeight = 16;
            this.lbNombresIz.Location = new System.Drawing.Point(39, 100);
            this.lbNombresIz.Name = "lbNombresIz";
            this.lbNombresIz.Size = new System.Drawing.Size(231, 676);
            this.lbNombresIz.TabIndex = 3;
            this.lbNombresIz.SelectedIndexChanged += new System.EventHandler(this.lbNombresIz_SelectedIndexChanged);
            // 
            // lbMover
            // 
            this.lbMover.FormattingEnabled = true;
            this.lbMover.ItemHeight = 16;
            this.lbMover.Location = new System.Drawing.Point(412, 100);
            this.lbMover.Name = "lbMover";
            this.lbMover.Size = new System.Drawing.Size(231, 676);
            this.lbMover.TabIndex = 4;
            this.lbMover.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(300, 360);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = ">";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnMoverTodo
            // 
            this.btnMoverTodo.Location = new System.Drawing.Point(300, 405);
            this.btnMoverTodo.Name = "btnMoverTodo";
            this.btnMoverTodo.Size = new System.Drawing.Size(75, 23);
            this.btnMoverTodo.TabIndex = 9;
            this.btnMoverTodo.Text = ">>";
            this.btnMoverTodo.UseVisualStyleBackColor = true;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 1046);
            this.Controls.Add(this.btnMoverTodo);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lbMover);
            this.Controls.Add(this.lbNombresIz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1 (Nombres)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombresIz;
        private System.Windows.Forms.ListBox lbMover;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnMoverTodo;
    }
}