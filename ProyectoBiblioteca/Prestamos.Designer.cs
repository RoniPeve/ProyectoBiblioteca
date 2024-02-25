namespace ProyectoBiblioteca
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.textLibro = new System.Windows.Forms.TextBox();
            this.textCodLibro = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.codigo_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultarPrestamo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.textPersona);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateFecha);
            this.groupBox1.Controls.Add(this.textLibro);
            this.groupBox1.Controls.Add(this.textCodLibro);
            this.groupBox1.Controls.Add(this.textDNI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textPersona
            // 
            this.textPersona.BackColor = System.Drawing.Color.White;
            this.textPersona.Location = new System.Drawing.Point(206, 88);
            this.textPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textPersona.MaxLength = 30;
            this.textPersona.Name = "textPersona";
            this.textPersona.Size = new System.Drawing.Size(146, 20);
            this.textPersona.TabIndex = 7;
            this.textPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPersona_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre de la Persona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del libro:";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(206, 146);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(146, 20);
            this.dateFecha.TabIndex = 11;
            // 
            // textLibro
            // 
            this.textLibro.BackColor = System.Drawing.Color.White;
            this.textLibro.Location = new System.Drawing.Point(206, 61);
            this.textLibro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textLibro.MaxLength = 30;
            this.textLibro.Name = "textLibro";
            this.textLibro.Size = new System.Drawing.Size(146, 20);
            this.textLibro.TabIndex = 5;
            this.textLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLibro_KeyPress);
            // 
            // textCodLibro
            // 
            this.textCodLibro.BackColor = System.Drawing.Color.White;
            this.textCodLibro.Location = new System.Drawing.Point(206, 35);
            this.textCodLibro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textCodLibro.MaxLength = 30;
            this.textCodLibro.Name = "textCodLibro";
            this.textCodLibro.Size = new System.Drawing.Size(146, 20);
            this.textCodLibro.TabIndex = 3;
            this.textCodLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodLibro_KeyPress);
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.White;
            this.textDNI.Location = new System.Drawing.Point(206, 114);
            this.textDNI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textDNI.MaxLength = 8;
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(146, 20);
            this.textDNI.TabIndex = 9;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // textEstado
            // 
            this.textEstado.BackColor = System.Drawing.Color.White;
            this.textEstado.Location = new System.Drawing.Point(188, 183);
            this.textEstado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textEstado.MaxLength = 200;
            this.textEstado.Multiline = true;
            this.textEstado.Name = "textEstado";
            this.textEstado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEstado.Size = new System.Drawing.Size(164, 100);
            this.textEstado.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo de libro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 54);
            this.label8.TabIndex = 260;
            this.label8.Text = "Registro de Préstamo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnConsultarPrestamo);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnAgregarPrestamo);
            this.groupBox3.Controls.Add(this.dataPrestamos);
            this.groupBox3.Location = new System.Drawing.Point(420, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 351);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 260;
            this.label9.Text = "Libros Prestados";
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowDrop = true;
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.AllowUserToResizeColumns = false;
            this.dataPrestamos.AllowUserToResizeRows = false;
            this.dataPrestamos.BackgroundColor = System.Drawing.Color.Silver;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_libro,
            this.nombre_libro,
            this.nombre_persona,
            this.DNI,
            this.fecha_salida,
            this.estado});
            this.dataPrestamos.Location = new System.Drawing.Point(18, 101);
            this.dataPrestamos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.RowHeadersVisible = false;
            this.dataPrestamos.Size = new System.Drawing.Size(427, 236);
            this.dataPrestamos.TabIndex = 19;
            this.dataPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrestamos_CellContentClick);
            // 
            // codigo_libro
            // 
            this.codigo_libro.DataPropertyName = "codigo_libro";
            this.codigo_libro.HeaderText = "Codigo del Libro";
            this.codigo_libro.Name = "codigo_libro";
            // 
            // nombre_libro
            // 
            this.nombre_libro.DataPropertyName = "nombre_libro";
            this.nombre_libro.HeaderText = "Nombre del Libro";
            this.nombre_libro.Name = "nombre_libro";
            // 
            // nombre_persona
            // 
            this.nombre_persona.DataPropertyName = "nombre_persona";
            this.nombre_persona.HeaderText = "Nombre ";
            this.nombre_persona.Name = "nombre_persona";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // fecha_salida
            // 
            this.fecha_salida.DataPropertyName = "fecha_salida";
            this.fecha_salida.HeaderText = "Fecha";
            this.fecha_salida.Name = "fecha_salida";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ProyectoBiblioteca.Properties.Resources.cancel;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(121, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 48);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "     Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultarPrestamo
            // 
            this.btnConsultarPrestamo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPrestamo.Image = global::ProyectoBiblioteca.Properties.Resources.check;
            this.btnConsultarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPrestamo.Location = new System.Drawing.Point(236, 19);
            this.btnConsultarPrestamo.Name = "btnConsultarPrestamo";
            this.btnConsultarPrestamo.Size = new System.Drawing.Size(109, 48);
            this.btnConsultarPrestamo.TabIndex = 17;
            this.btnConsultarPrestamo.Text = "       Consultar";
            this.btnConsultarPrestamo.UseVisualStyleBackColor = true;
            this.btnConsultarPrestamo.Click += new System.EventHandler(this.btnConsultarPrestamo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoBiblioteca.Properties.Resources.exit_closethesession_close_6317;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(351, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 48);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "      Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.Image = global::ProyectoBiblioteca.Properties.Resources.folder_add;
            this.btnAgregarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(109, 48);
            this.btnAgregarPrestamo.TabIndex = 15;
            this.btnAgregarPrestamo.Text = "     Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::ProyectoBiblioteca.Properties.Resources.solicit_accept_check_ok_theaction_6340;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(150, 303);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(149, 40);
            this.btnSeleccionar.TabIndex = 17;
            this.btnSeleccionar.Text = "    Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCodLibro;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLibro;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultarPrestamo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.DataGridView dataPrestamos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}