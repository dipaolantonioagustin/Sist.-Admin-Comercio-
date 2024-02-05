namespace Parcial1_LUG
{
    partial class FRCompras
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
            this.lsbCarrito = new System.Windows.Forms.ListBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarCarrito = new System.Windows.Forms.Button();
            this.btnPintura = new System.Windows.Forms.Button();
            this.btnElectro = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.txtCantidadPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCarrito = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRegistroComprasCliente = new System.Windows.Forms.DataGridView();
            this.lblDescuentosAcumulados = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalConDescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroComprasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(497, 184);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // lsbCarrito
            // 
            this.lsbCarrito.FormattingEnabled = true;
            this.lsbCarrito.Location = new System.Drawing.Point(515, 12);
            this.lsbCarrito.Name = "lsbCarrito";
            this.lsbCarrito.Size = new System.Drawing.Size(209, 290);
            this.lsbCarrito.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(12, 270);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(224, 20);
            this.txtProducto.TabIndex = 2;
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Location = new System.Drawing.Point(250, 270);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(108, 20);
            this.txtCantidadDisponible.TabIndex = 3;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(263, 357);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(95, 32);
            this.btnAgregarCarrito.TabIndex = 5;
            this.btnAgregarCarrito.Text = "Agregar";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(12, 318);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(104, 20);
            this.txtValorUnitario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad Disponible";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Unitario";
            // 
            // btnConfirmarCarrito
            // 
            this.btnConfirmarCarrito.Location = new System.Drawing.Point(629, 409);
            this.btnConfirmarCarrito.Name = "btnConfirmarCarrito";
            this.btnConfirmarCarrito.Size = new System.Drawing.Size(95, 32);
            this.btnConfirmarCarrito.TabIndex = 12;
            this.btnConfirmarCarrito.Text = "Confirmar Carrito";
            this.btnConfirmarCarrito.UseVisualStyleBackColor = true;
            this.btnConfirmarCarrito.Click += new System.EventHandler(this.btnConfirmarCarrito_Click);
            // 
            // btnPintura
            // 
            this.btnPintura.Location = new System.Drawing.Point(12, 202);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(105, 32);
            this.btnPintura.TabIndex = 13;
            this.btnPintura.Text = "Productos Pintura";
            this.btnPintura.UseVisualStyleBackColor = true;
            this.btnPintura.Click += new System.EventHandler(this.btnPintura_Click);
            // 
            // btnElectro
            // 
            this.btnElectro.Location = new System.Drawing.Point(129, 202);
            this.btnElectro.Name = "btnElectro";
            this.btnElectro.Size = new System.Drawing.Size(107, 32);
            this.btnElectro.TabIndex = 14;
            this.btnElectro.Text = "Productos Electro";
            this.btnElectro.UseVisualStyleBackColor = true;
            this.btnElectro.Click += new System.EventHandler(this.btnElectro_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(250, 202);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(110, 32);
            this.btnTodo.TabIndex = 15;
            this.btnTodo.Text = "Productos Todos";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // txtCantidadPedido
            // 
            this.txtCantidadPedido.Location = new System.Drawing.Point(129, 318);
            this.txtCantidadPedido.Name = "txtCantidadPedido";
            this.txtCantidadPedido.Size = new System.Drawing.Size(103, 20);
            this.txtCantidadPedido.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cantidad Pedido";
            // 
            // lblTotalCarrito
            // 
            this.lblTotalCarrito.AutoSize = true;
            this.lblTotalCarrito.Location = new System.Drawing.Point(641, 325);
            this.lblTotalCarrito.Name = "lblTotalCarrito";
            this.lblTotalCarrito.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCarrito.TabIndex = 18;
            this.lblTotalCarrito.Text = "label6";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(12, 364);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(220, 21);
            this.cmbClientes.TabIndex = 19;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cliente";
            // 
            // dataGridViewRegistroComprasCliente
            // 
            this.dataGridViewRegistroComprasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistroComprasCliente.Location = new System.Drawing.Point(12, 431);
            this.dataGridViewRegistroComprasCliente.Name = "dataGridViewRegistroComprasCliente";
            this.dataGridViewRegistroComprasCliente.Size = new System.Drawing.Size(497, 216);
            this.dataGridViewRegistroComprasCliente.TabIndex = 21;
            // 
            // lblDescuentosAcumulados
            // 
            this.lblDescuentosAcumulados.AutoSize = true;
            this.lblDescuentosAcumulados.Location = new System.Drawing.Point(176, 399);
            this.lblDescuentosAcumulados.Name = "lblDescuentosAcumulados";
            this.lblDescuentosAcumulados.Size = new System.Drawing.Size(35, 13);
            this.lblDescuentosAcumulados.TabIndex = 22;
            this.lblDescuentosAcumulados.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Descuentos Acumulados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total Final";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(641, 353);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(35, 13);
            this.lblDescuento.TabIndex = 27;
            this.lblDescuento.Text = "label6";
            // 
            // lblTotalConDescuento
            // 
            this.lblTotalConDescuento.AutoSize = true;
            this.lblTotalConDescuento.Location = new System.Drawing.Point(641, 383);
            this.lblTotalConDescuento.Name = "lblTotalConDescuento";
            this.lblTotalConDescuento.Size = new System.Drawing.Size(35, 13);
            this.lblTotalConDescuento.TabIndex = 28;
            this.lblTotalConDescuento.Text = "label6";
            // 
            // FRCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 685);
            this.Controls.Add(this.lblTotalConDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDescuentosAcumulados);
            this.Controls.Add(this.dataGridViewRegistroComprasCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblTotalCarrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadPedido);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnElectro);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.btnConfirmarCarrito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lsbCarrito);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FRCompras";
            this.Text = "FRCompras";
            this.Load += new System.EventHandler(this.FRCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroComprasCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.ListBox lsbCarrito;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmarCarrito;
        private System.Windows.Forms.Button btnPintura;
        private System.Windows.Forms.Button btnElectro;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.TextBox txtCantidadPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCarrito;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewRegistroComprasCliente;
        private System.Windows.Forms.Label lblDescuentosAcumulados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotalConDescuento;
    }
}