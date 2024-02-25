namespace ProyectoBiblioteca
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataLibros = new System.Windows.Forms.DataGridView();
            this.codigo_de_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_de_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idioma_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textAutorLibro = new System.Windows.Forms.TextBox();
            this.textCodigoLibro = new System.Windows.Forms.TextBox();
            this.comboCategoriaLibro = new System.Windows.Forms.ComboBox();
            this.textNombreLibro = new System.Windows.Forms.TextBox();
            this.textIdiomaLibro = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.dataLibros);
            this.groupBox1.Location = new System.Drawing.Point(427, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 316);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ProyectoBiblioteca.Properties.Resources.cancel;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(176, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 38);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "       Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ProyectoBiblioteca.Properties.Resources.edit_validated_40458;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(296, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 38);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "      Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ProyectoBiblioteca.Properties.Resources.folder_add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(52, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 38);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "      Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoBiblioteca.Properties.Resources.exit_closethesession_close_6317;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(416, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 38);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "    Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataLibros
            // 
            this.dataLibros.AllowDrop = true;
            this.dataLibros.AllowUserToAddRows = false;
            this.dataLibros.AllowUserToDeleteRows = false;
            this.dataLibros.AllowUserToResizeColumns = false;
            this.dataLibros.AllowUserToResizeRows = false;
            this.dataLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_de_libro,
            this.nombre_de_libro,
            this.autor_libro,
            this.categoria_libro,
            this.idioma_libro,
            this.tipo_libro,
            this.precio_libro});
            this.dataLibros.Location = new System.Drawing.Point(17, 70);
            this.dataLibros.Name = "dataLibros";
            this.dataLibros.RowHeadersVisible = false;
            this.dataLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLibros.Size = new System.Drawing.Size(500, 222);
            this.dataLibros.TabIndex = 21;
            // 
            // codigo_de_libro
            // 
            this.codigo_de_libro.DataPropertyName = "codigo_de_libro";
            this.codigo_de_libro.FillWeight = 113.7534F;
            this.codigo_de_libro.HeaderText = "Codigo del Libro";
            this.codigo_de_libro.Name = "codigo_de_libro";
            this.codigo_de_libro.Width = 78;
            // 
            // nombre_de_libro
            // 
            this.nombre_de_libro.DataPropertyName = "nombre_de_libro";
            this.nombre_de_libro.FillWeight = 125.9657F;
            this.nombre_de_libro.HeaderText = "Nombre del Libro";
            this.nombre_de_libro.Name = "nombre_de_libro";
            this.nombre_de_libro.Width = 82;
            // 
            // autor_libro
            // 
            this.autor_libro.DataPropertyName = "autor_libro";
            this.autor_libro.FillWeight = 87.37782F;
            this.autor_libro.HeaderText = "Autor";
            this.autor_libro.Name = "autor_libro";
            this.autor_libro.Width = 57;
            // 
            // categoria_libro
            // 
            this.categoria_libro.DataPropertyName = "categoria_libro";
            this.categoria_libro.FillWeight = 120.1587F;
            this.categoria_libro.HeaderText = "Categoria";
            this.categoria_libro.Name = "categoria_libro";
            this.categoria_libro.Width = 77;
            // 
            // idioma_libro
            // 
            this.idioma_libro.DataPropertyName = "idioma_libro";
            this.idioma_libro.FillWeight = 93.84738F;
            this.idioma_libro.HeaderText = "Idioma";
            this.idioma_libro.Name = "idioma_libro";
            this.idioma_libro.Width = 63;
            // 
            // tipo_libro
            // 
            this.tipo_libro.DataPropertyName = "tipo_libro";
            this.tipo_libro.FillWeight = 125.5632F;
            this.tipo_libro.HeaderText = "Tipo de Libro";
            this.tipo_libro.Name = "tipo_libro";
            this.tipo_libro.Width = 87;
            // 
            // precio_libro
            // 
            this.precio_libro.DataPropertyName = "precio_libro";
            this.precio_libro.FillWeight = 81.48138F;
            this.precio_libro.HeaderText = "Precio";
            this.precio_libro.Name = "precio_libro";
            this.precio_libro.Width = 62;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Controls.Add(this.textPrecio);
            this.groupBox2.Controls.Add(this.comboTipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textAutorLibro);
            this.groupBox2.Controls.Add(this.textCodigoLibro);
            this.groupBox2.Controls.Add(this.comboCategoriaLibro);
            this.groupBox2.Controls.Add(this.textNombreLibro);
            this.groupBox2.Controls.Add(this.textIdiomaLibro);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(41, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 266);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::ProyectoBiblioteca.Properties.Resources.solicit_accept_check_ok_theaction_6340;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(189, 218);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(149, 40);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "    Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.White;
            this.textPrecio.Location = new System.Drawing.Point(178, 182);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(160, 20);
            this.textPrecio.TabIndex = 14;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Gratuito",
            "Venta"});
            this.comboTipo.Location = new System.Drawing.Point(178, 155);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(157, 21);
            this.comboTipo.TabIndex = 12;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoBiblioteca.Properties.Resources.search_book;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(43, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 46);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "     Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 18);
            this.label17.TabIndex = 1;
            this.label17.Text = "Codigo de libro:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(40, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 18);
            this.label18.TabIndex = 3;
            this.label18.Text = "Nombre de libro:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(115, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 18);
            this.label19.TabIndex = 5;
            this.label19.Text = "Autor:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(90, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 18);
            this.label21.TabIndex = 7;
            this.label21.Text = "Categoria:";
            // 
            // textAutorLibro
            // 
            this.textAutorLibro.BackColor = System.Drawing.Color.White;
            this.textAutorLibro.Location = new System.Drawing.Point(175, 68);
            this.textAutorLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAutorLibro.Name = "textAutorLibro";
            this.textAutorLibro.Size = new System.Drawing.Size(160, 20);
            this.textAutorLibro.TabIndex = 6;
            this.textAutorLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAutorLibro_KeyPress);
            // 
            // textCodigoLibro
            // 
            this.textCodigoLibro.BackColor = System.Drawing.Color.White;
            this.textCodigoLibro.Location = new System.Drawing.Point(175, 14);
            this.textCodigoLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCodigoLibro.Name = "textCodigoLibro";
            this.textCodigoLibro.Size = new System.Drawing.Size(160, 20);
            this.textCodigoLibro.TabIndex = 2;
            this.textCodigoLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoLibro_KeyPress);
            // 
            // comboCategoriaLibro
            // 
            this.comboCategoriaLibro.FormattingEnabled = true;
            this.comboCategoriaLibro.Items.AddRange(new object[] {
            "ARTE",
            "AVENTURAS",
            "AUTOAYUDA",
            "ARQUITECTURA",
            "ADMINISTRACIÓN",
            "BIOGRAFÍA",
            "BÉLICO",
            "BIOLOGÍA",
            "CLÁSICA",
            "CLÁSICO",
            "CRÍTICA Y TEORÍA LITERARIA",
            "CUENTOS",
            "CIENCIA FICCIÓN",
            "CIENCIA",
            "CIENCIAS EXACTAS",
            "CIENCIAS NATURALES",
            "CIENCIAS SOCIALES",
            "CONTABILIDAD",
            "COMUNICACIÓN",
            "COMICS",
            "CIENCIAS OCULTAS",
            "DEPORTES Y JUEGOS",
            "DEPORTES",
            "DICCIONARIOS Y ENCICLOPEDIAS",
            "DIVULGACIÓN",
            "DIVULGACIÓN CIENTÍFICA",
            "DIDÁCTICO",
            "DRAMA",
            "ENSAYO",
            "ERÓTICO",
            "ESOTERISMO",
            "ESPIRITUALIDAD",
            "ECONOMÍA",
            "EMPLEO Y EMPRESAS",
            "FINANZAS",
            "FANTÁSTICO",
            "FILOSOFÍA",
            "FILOSÓFICO",
            "FÍSICA",
            "HISTORIA",
            "HISTÓRICO",
            "HOGAR",
            "HUMOR",
            "INFANTIL",
            " JUVENIL",
            "INTRIGA",
            "IDIOMAS",
            "INTERACTIVO",
            "INGENIERÍA",
            "JUVENIL",
            "MANUALIDADES",
            "MISTERIO",
            "MEMORIAS",
            "MEDICINA",
            "MATEMÁTICA",
            "MANUALES DE SOFTWARE",
            "MANUALES Y CURSOS",
            "MECÁNICA",
            "NARRATIVA",
            "NARRATIVA DE HUMOR",
            "NOVELA",
            "NOVELA NEGRA",
            "NARRATIVA ERÓTICA",
            "NARRATIVA HISTÓRICA",
            "PADRES E HIJOS",
            "POLICIAL",
            "POLICIACO",
            "POESÍA",
            "PSICOLOGÍA",
            "PSICOLÓGICO",
            "PEDAGOGÍA",
            "POLÍTICA Y SOCIEDAD",
            "POLÍTICA",
            "PROGRAMACIÓN",
            "QUÍMICA",
            "REALISTA",
            "RELATO",
            "ROMANCE",
            "ROMANTICO",
            "ARROWLIBROS R-V",
            "REFERENCIA",
            "RELIGIÓN",
            "SÁTIRA",
            "SUSPENSO",
            "SEXUALIDAD",
            "SALUD Y BIENESTAR",
            "SOLUCIONARIOS",
            "TEATRO",
            "TERROR",
            "TECNOLOGÍA",
            "VIAJES",
            "VETERINARIA",
            "VARIOS GÉNEROS",
            "VARIADA"});
            this.comboCategoriaLibro.Location = new System.Drawing.Point(177, 95);
            this.comboCategoriaLibro.Name = "comboCategoriaLibro";
            this.comboCategoriaLibro.Size = new System.Drawing.Size(159, 21);
            this.comboCategoriaLibro.TabIndex = 8;
            // 
            // textNombreLibro
            // 
            this.textNombreLibro.BackColor = System.Drawing.Color.White;
            this.textNombreLibro.Location = new System.Drawing.Point(175, 40);
            this.textNombreLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textNombreLibro.Name = "textNombreLibro";
            this.textNombreLibro.Size = new System.Drawing.Size(160, 20);
            this.textNombreLibro.TabIndex = 4;
            this.textNombreLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreLibro_KeyPress);
            // 
            // textIdiomaLibro
            // 
            this.textIdiomaLibro.BackColor = System.Drawing.Color.White;
            this.textIdiomaLibro.Location = new System.Drawing.Point(178, 129);
            this.textIdiomaLibro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textIdiomaLibro.Name = "textIdiomaLibro";
            this.textIdiomaLibro.Size = new System.Drawing.Size(160, 20);
            this.textIdiomaLibro.TabIndex = 10;
            this.textIdiomaLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdiomaLibro_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(111, 128);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 18);
            this.label25.TabIndex = 9;
            this.label25.Text = "Idioma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 54);
            this.label4.TabIndex = 263;
            this.label4.Text = "Libros";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 51.85236F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ProyectoBiblioteca.Properties.Resources.modificar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLibros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataLibros;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textAutorLibro;
        private System.Windows.Forms.TextBox textCodigoLibro;
        private System.Windows.Forms.ComboBox comboCategoriaLibro;
        private System.Windows.Forms.TextBox textNombreLibro;
        private System.Windows.Forms.TextBox textIdiomaLibro;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_de_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_de_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idioma_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_libro;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}