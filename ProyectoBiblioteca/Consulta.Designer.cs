namespace ProyectoBiblioteca
{
    partial class Consulta
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
            this.textNombreBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLibrosConsulta = new System.Windows.Forms.DataGridView();
            this.codigo_de_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_de_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idioma_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibrosConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombreBuscar
            // 
            this.textNombreBuscar.Location = new System.Drawing.Point(112, 34);
            this.textNombreBuscar.Name = "textNombreBuscar";
            this.textNombreBuscar.Size = new System.Drawing.Size(246, 20);
            this.textNombreBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // dataLibrosConsulta
            // 
            this.dataLibrosConsulta.AllowUserToAddRows = false;
            this.dataLibrosConsulta.AllowUserToDeleteRows = false;
            this.dataLibrosConsulta.AllowUserToResizeColumns = false;
            this.dataLibrosConsulta.AllowUserToResizeRows = false;
            this.dataLibrosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLibrosConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_de_libro,
            this.nombre_de_libro,
            this.autor_libro,
            this.categoria_libro,
            this.idioma_libro,
            this.tipo_libro,
            this.precio_libro});
            this.dataLibrosConsulta.Location = new System.Drawing.Point(28, 76);
            this.dataLibrosConsulta.Name = "dataLibrosConsulta";
            this.dataLibrosConsulta.RowHeadersVisible = false;
            this.dataLibrosConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLibrosConsulta.Size = new System.Drawing.Size(505, 205);
            this.dataLibrosConsulta.TabIndex = 3;
            // 
            // codigo_de_libro
            // 
            this.codigo_de_libro.DataPropertyName = "codigo_de_libro";
            this.codigo_de_libro.HeaderText = "Codigo del Libro";
            this.codigo_de_libro.Name = "codigo_de_libro";
            // 
            // nombre_de_libro
            // 
            this.nombre_de_libro.DataPropertyName = "nombre_de_libro";
            this.nombre_de_libro.HeaderText = "Nombre del Libro";
            this.nombre_de_libro.Name = "nombre_de_libro";
            // 
            // autor_libro
            // 
            this.autor_libro.DataPropertyName = "autor_libro";
            this.autor_libro.HeaderText = "Autor del Libro";
            this.autor_libro.Name = "autor_libro";
            // 
            // categoria_libro
            // 
            this.categoria_libro.DataPropertyName = "categoria_libro";
            this.categoria_libro.HeaderText = "Categoria";
            this.categoria_libro.Name = "categoria_libro";
            // 
            // idioma_libro
            // 
            this.idioma_libro.DataPropertyName = "idioma_libro";
            this.idioma_libro.HeaderText = "Idioma";
            this.idioma_libro.Name = "idioma_libro";
            // 
            // tipo_libro
            // 
            this.tipo_libro.DataPropertyName = "tipo_libro";
            this.tipo_libro.HeaderText = "Tipo";
            this.tipo_libro.Name = "tipo_libro";
            // 
            // precio_libro
            // 
            this.precio_libro.DataPropertyName = "precio_libro";
            this.precio_libro.HeaderText = "Precio";
            this.precio_libro.Name = "precio_libro";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::ProyectoBiblioteca.Properties.Resources.solicit_accept_check_ok_theaction_6340;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(28, 303);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(149, 40);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "    Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ProyectoBiblioteca.Properties.Resources.exit_closethesession_close_6317;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(417, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "   Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoBiblioteca.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(418, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "      Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 356);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataLibrosConsulta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombreBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLibrosConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.DataGridView dataLibrosConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_de_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_de_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idioma_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_libro;
    }
}