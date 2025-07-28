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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLibreta = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBuscarLibreta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAlumnoMayoryMenorNota = new System.Windows.Forms.Button();
            this.btnCantAlumnos = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnListaOrdenadaPromedio = new System.Windows.Forms.Button();
            this.btnListaOrdenada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libreta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota";
            // 
            // tbLibreta
            // 
            this.tbLibreta.Location = new System.Drawing.Point(128, 78);
            this.tbLibreta.Name = "tbLibreta";
            this.tbLibreta.Size = new System.Drawing.Size(128, 20);
            this.tbLibreta.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(128, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(155, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(128, 137);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(66, 20);
            this.tbNota.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(354, 98);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumno con la mayor y menor nota";
            // 
            // tbBuscarLibreta
            // 
            this.tbBuscarLibreta.Location = new System.Drawing.Point(114, 216);
            this.tbBuscarLibreta.Name = "tbBuscarLibreta";
            this.tbBuscarLibreta.Size = new System.Drawing.Size(128, 20);
            this.tbBuscarLibreta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Libreta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 215);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 316);
            this.listBox1.TabIndex = 13;
            // 
            // btnAlumnoMayoryMenorNota
            // 
            this.btnAlumnoMayoryMenorNota.Location = new System.Drawing.Point(273, 258);
            this.btnAlumnoMayoryMenorNota.Name = "btnAlumnoMayoryMenorNota";
            this.btnAlumnoMayoryMenorNota.Size = new System.Drawing.Size(88, 60);
            this.btnAlumnoMayoryMenorNota.TabIndex = 14;
            this.btnAlumnoMayoryMenorNota.Text = "Alumno mayor y menor nota";
            this.btnAlumnoMayoryMenorNota.UseVisualStyleBackColor = true;
            this.btnAlumnoMayoryMenorNota.Click += new System.EventHandler(this.btnAlumnoMayoryMenorNota_Click);
            // 
            // btnCantAlumnos
            // 
            this.btnCantAlumnos.Location = new System.Drawing.Point(273, 328);
            this.btnCantAlumnos.Name = "btnCantAlumnos";
            this.btnCantAlumnos.Size = new System.Drawing.Size(88, 51);
            this.btnCantAlumnos.TabIndex = 15;
            this.btnCantAlumnos.Text = "Cantidad de Alumnos";
            this.btnCantAlumnos.UseVisualStyleBackColor = true;
            this.btnCantAlumnos.Click += new System.EventHandler(this.btnCantAlumnos_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(273, 392);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(88, 32);
            this.btnPromedio.TabIndex = 16;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnListaOrdenadaPromedio
            // 
            this.btnListaOrdenadaPromedio.Location = new System.Drawing.Point(273, 500);
            this.btnListaOrdenadaPromedio.Name = "btnListaOrdenadaPromedio";
            this.btnListaOrdenadaPromedio.Size = new System.Drawing.Size(88, 64);
            this.btnListaOrdenadaPromedio.TabIndex = 18;
            this.btnListaOrdenadaPromedio.Text = "Mostrar Lista Superior al Promedio";
            this.btnListaOrdenadaPromedio.UseVisualStyleBackColor = true;
            this.btnListaOrdenadaPromedio.Click += new System.EventHandler(this.btnListaOrdenadaPromedio_Click);
            // 
            // btnListaOrdenada
            // 
            this.btnListaOrdenada.Location = new System.Drawing.Point(273, 437);
            this.btnListaOrdenada.Name = "btnListaOrdenada";
            this.btnListaOrdenada.Size = new System.Drawing.Size(88, 51);
            this.btnListaOrdenada.TabIndex = 17;
            this.btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            this.btnListaOrdenada.UseVisualStyleBackColor = true;
            this.btnListaOrdenada.Click += new System.EventHandler(this.btnListaOrdenada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 652);
            this.Controls.Add(this.btnListaOrdenadaPromedio);
            this.Controls.Add(this.btnListaOrdenada);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnCantAlumnos);
            this.Controls.Add(this.btnAlumnoMayoryMenorNota);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscarLibreta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbLibreta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLibreta;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBuscarLibreta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAlumnoMayoryMenorNota;
        private System.Windows.Forms.Button btnCantAlumnos;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnListaOrdenadaPromedio;
        private System.Windows.Forms.Button btnListaOrdenada;
    }
}

