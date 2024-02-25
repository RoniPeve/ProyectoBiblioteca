namespace ProyectoBiblioteca
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateVenta = new System.Windows.Forms.DateTimePicker();
            this.textPersona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textLibro = new System.Windows.Forms.TextBox();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.codigo_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConsultarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.btnAgregarCompras = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 54);
            this.label11.TabIndex = 260;
            this.label11.Text = "Ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.dateVenta);
            this.groupBox1.Controls.Add(this.textPersona);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textLibro);
            this.groupBox1.Controls.Add(this.textcodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textDNI);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateVenta
            // 
            this.dateVenta.CustomFormat = "dd/MM/yyyy";
            this.dateVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVenta.Location = new System.Drawing.Point(250, 206);
            this.dateVenta.Name = "dateVenta";
            this.dateVenta.Size = new System.Drawing.Size(146, 20);
            this.dateVenta.TabIndex = 13;
            // 
            // textPersona
            // 
            this.textPersona.BackColor = System.Drawing.Color.White;
            this.textPersona.Location = new System.Drawing.Point(250, 96);
            this.textPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textPersona.MaxLength = 30;
            this.textPersona.Name = "textPersona";
            this.textPersona.Size = new System.Drawing.Size(146, 20);
            this.textPersona.TabIndex = 7;
            this.textPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPersona_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre de la Persona:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del libro:";
            // 
            // textLibro
            // 
            this.textLibro.BackColor = System.Drawing.Color.White;
            this.textLibro.Location = new System.Drawing.Point(250, 64);
            this.textLibro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textLibro.MaxLength = 30;
            this.textLibro.Name = "textLibro";
            this.textLibro.Size = new System.Drawing.Size(146, 20);
            this.textLibro.TabIndex = 5;
            this.textLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLibro_KeyPress);
            // 
            // textcodigo
            // 
            this.textcodigo.BackColor = System.Drawing.Color.White;
            this.textcodigo.Location = new System.Drawing.Point(250, 32);
            this.textcodigo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(146, 20);
            this.textcodigo.TabIndex = 3;
            this.textcodigo.TextChanged += new System.EventHandler(this.textcodigo_TextChanged);
            this.textcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de Venta:";
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.White;
            this.textDNI.Location = new System.Drawing.Point(250, 129);
            this.textDNI.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textDNI.MaxLength = 8;
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(146, 20);
            this.textDNI.TabIndex = 9;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.White;
            this.textPrecio.Location = new System.Drawing.Point(250, 161);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textPrecio.MaxLength = 30;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(146, 20);
            this.textPrecio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 128);
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
            this.label3.Location = new System.Drawing.Point(148, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo de libro:";
            // 
            // dataVentas
            // 
            this.dataVentas.AllowDrop = true;
            this.dataVentas.AllowUserToAddRows = false;
            this.dataVentas.AllowUserToDeleteRows = false;
            this.dataVentas.AllowUserToResizeColumns = false;
            this.dataVentas.AllowUserToResizeRows = false;
            this.dataVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVentas.BackgroundColor = System.Drawing.Color.Silver;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_libro,
            this.nombre_libro,
            this.nombre_persona,
            this.DNI,
            this.precio,
            this.fecha_venta});
            this.dataVentas.Location = new System.Drawing.Point(18, 101);
            this.dataVentas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.RowHeadersVisible = false;
            this.dataVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVentas.Size = new System.Drawing.Size(453, 196);
            this.dataVentas.TabIndex = 18;
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
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // fecha_venta
            // 
            this.fecha_venta.DataPropertyName = "fecha_venta";
            this.fecha_venta.HeaderText = "Fecha de Venta";
            this.fecha_venta.Name = "fecha_venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 211;
            this.label2.Text = "Libros Vendidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnConsultarVenta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnEliminarCompras);
            this.groupBox2.Controls.Add(this.btnAgregarCompras);
            this.groupBox2.Controls.Add(this.dataVentas);
            this.groupBox2.Location = new System.Drawing.Point(450, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 317);
            this.groupBox2.TabIndex = 262;
            this.groupBox2.TabStop = false;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnConsultarVenta
            // 
            this.btnConsultarVenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVenta.Image = global::ProyectoBiblioteca.Properties.Resources.check;
            this.btnConsultarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVenta.Location = new System.Drawing.Point(245, 19);
            this.btnConsultarVenta.Name = "btnConsultarVenta";
            this.btnConsultarVenta.Size = new System.Drawing.Size(116, 48);
            this.btnConsultarVenta.TabIndex = 16;
            this.btnConsultarVenta.Text = "      Consultar";
            this.btnConsultarVenta.UseVisualStyleBackColor = true;
            this.btnConsultarVenta.Click += new System.EventHandler(this.btnConsultarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoBiblioteca.Properties.Resources.exit_closethesession_close_6317;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(367, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 48);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "      Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompras.Image = global::ProyectoBiblioteca.Properties.Resources.cancel;
            this.btnEliminarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCompras.Location = new System.Drawing.Point(126, 19);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(113, 48);
            this.btnEliminarCompras.TabIndex = 15;
            this.btnEliminarCompras.Text = "       Eliminar";
            this.btnEliminarCompras.UseVisualStyleBackColor = true;
            this.btnEliminarCompras.Click += new System.EventHandler(this.btnEliminarCompras_Click);
            // 
            // btnAgregarCompras
            // 
            this.btnAgregarCompras.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompras.Image = global::ProyectoBiblioteca.Properties.Resources.folder_add;
            this.btnAgregarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCompras.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarCompras.Name = "btnAgregarCompras";
            this.btnAgregarCompras.Size = new System.Drawing.Size(111, 48);
            this.btnAgregarCompras.TabIndex = 14;
            this.btnAgregarCompras.Text = "    Agregar";
            this.btnAgregarCompras.UseVisualStyleBackColor = true;
            this.btnAgregarCompras.Click += new System.EventHandler(this.btnAgregarCompras_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::ProyectoBiblioteca.Properties.Resources.solicit_accept_check_ok_theaction_6340;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(151, 257);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(149, 40);
            this.btnSeleccionar.TabIndex = 17;
            this.btnSeleccionar.Text = "    Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLibro;
        private System.Windows.Forms.TextBox textPersona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.Button btnAgregarCompras;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DateTimePicker dateVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}