namespace Parcial1_LUG
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnPintura = new System.Windows.Forms.Button();
            this.btnElectro = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.cmbTipoMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvFaltantes = new System.Windows.Forms.DataGridView();
            this.btnFaltantes = new System.Windows.Forms.Button();
            this.txtFalantes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(384, 30);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.Size = new System.Drawing.Size(710, 191);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // btnPintura
            // 
            this.btnPintura.Location = new System.Drawing.Point(384, 227);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(105, 44);
            this.btnPintura.TabIndex = 1;
            this.btnPintura.Text = "Productos  Pintura";
            this.btnPintura.UseVisualStyleBackColor = true;
            this.btnPintura.Click += new System.EventHandler(this.btnPintura_Click);
            // 
            // btnElectro
            // 
            this.btnElectro.Location = new System.Drawing.Point(525, 227);
            this.btnElectro.Name = "btnElectro";
            this.btnElectro.Size = new System.Drawing.Size(105, 44);
            this.btnElectro.TabIndex = 2;
            this.btnElectro.Text = "Productos  Electro";
            this.btnElectro.UseVisualStyleBackColor = true;
            this.btnElectro.Click += new System.EventHandler(this.btnElectro_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(666, 227);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(105, 44);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.Text = "Productos Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(202, 33);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(161, 21);
            this.cmbCategorias.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(201, 85);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(201, 133);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(161, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(201, 178);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(161, 20);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(201, 229);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(161, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(201, 276);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(161, 21);
            this.cmbProveedor.TabIndex = 10;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(201, 325);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(161, 20);
            this.txtColor.TabIndex = 11;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(199, 17);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(51, 13);
            this.Categoria.TabIndex = 12;
            this.Categoria.Text = "categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Proveedor";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(205, 309);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 18;
            this.Color.Text = "Color";
            // 
            // cmbTipoMedida
            // 
            this.cmbTipoMedida.FormattingEnabled = true;
            this.cmbTipoMedida.Location = new System.Drawing.Point(201, 376);
            this.cmbTipoMedida.Name = "cmbTipoMedida";
            this.cmbTipoMedida.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoMedida.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo de Medida";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(201, 437);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(161, 20);
            this.txtMedida.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Medida";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(12, 17);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 23;
            this.Codigo.Text = "Código";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(71, 177);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(105, 44);
            this.btnAltaProducto.TabIndex = 25;
            this.btnAltaProducto.Text = "Alta Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(15, 84);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoProducto.TabIndex = 26;
            this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipo Producto";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(71, 133);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 38);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(71, 289);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(105, 44);
            this.btnBaja.TabIndex = 29;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(71, 236);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 44);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvFaltantes
            // 
            this.dgvFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltantes.Location = new System.Drawing.Point(384, 307);
            this.dgvFaltantes.Name = "dgvFaltantes";
            this.dgvFaltantes.Size = new System.Drawing.Size(710, 150);
            this.dgvFaltantes.TabIndex = 31;
            this.dgvFaltantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaltantes_CellContentClick);
            // 
            // btnFaltantes
            // 
            this.btnFaltantes.Location = new System.Drawing.Point(384, 472);
            this.btnFaltantes.Name = "btnFaltantes";
            this.btnFaltantes.Size = new System.Drawing.Size(105, 44);
            this.btnFaltantes.TabIndex = 32;
            this.btnFaltantes.Text = "Buscar Faltantes";
            this.btnFaltantes.UseVisualStyleBackColor = true;
            this.btnFaltantes.Click += new System.EventHandler(this.btnFaltantes_Click);
            // 
            // txtFalantes
            // 
            this.txtFalantes.Location = new System.Drawing.Point(509, 496);
            this.txtFalantes.Name = "txtFalantes";
            this.txtFalantes.Size = new System.Drawing.Size(141, 20);
            this.txtFalantes.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cantidad Falta Buqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 549);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFalantes);
            this.Controls.Add(this.btnFaltantes);
            this.Controls.Add(this.dgvFaltantes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoMedida);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnElectro);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnPintura;
        private System.Windows.Forms.Button btnElectro;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox cmbTipoMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvFaltantes;
        private System.Windows.Forms.Button btnFaltantes;
        private System.Windows.Forms.TextBox txtFalantes;
        private System.Windows.Forms.Label label9;
    }
}

