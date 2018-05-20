namespace RegistroDeLibros
{
    partial class Form1
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
            this.Guardar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Siglas = new System.Windows.Forms.Label();
            this.TipoId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Image = global::RegistroDeLibros.Properties.Resources.Sin_título_2;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar.Location = new System.Drawing.Point(32, 208);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(76, 69);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.Editar.Image = global::RegistroDeLibros.Properties.Resources.Sin_título_5;
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Editar.Location = new System.Drawing.Point(151, 208);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(78, 69);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::RegistroDeLibros.Properties.Resources.Sin_título_1;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar.Location = new System.Drawing.Point(269, 208);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 69);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libros Id";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(13, 73);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 4;
            this.Descripcion.Text = "Descripcion";
            // 
            // Siglas
            // 
            this.Siglas.AutoSize = true;
            this.Siglas.Location = new System.Drawing.Point(21, 138);
            this.Siglas.Name = "Siglas";
            this.Siglas.Size = new System.Drawing.Size(35, 13);
            this.Siglas.TabIndex = 5;
            this.Siglas.Text = "Siglas";
            // 
            // TipoId
            // 
            this.TipoId.AutoSize = true;
            this.TipoId.Location = new System.Drawing.Point(19, 171);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(40, 13);
            this.TipoId.TabIndex = 6;
            this.TipoId.Text = "Tipo Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 54);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 171);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 289);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TipoId);
            this.Controls.Add(this.Siglas);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Guardar);
            this.Name = "Form1";
            this.Text = "Registro de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Siglas;
        private System.Windows.Forms.Label TipoId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

