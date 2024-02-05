namespace Parcial1_LUG
{
    partial class FRInformes
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
            this.lblMaxElectro = new System.Windows.Forms.Label();
            this.lblPinturaMenos = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductosCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStockTotal = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnElectro = new System.Windows.Forms.Button();
            this.btnPintura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaxElectro
            // 
            this.lblMaxElectro.AutoSize = true;
            this.lblMaxElectro.Location = new System.Drawing.Point(12, 244);
            this.lblMaxElectro.Name = "lblMaxElectro";
            this.lblMaxElectro.Size = new System.Drawing.Size(35, 13);
            this.lblMaxElectro.TabIndex = 0;
            this.lblMaxElectro.Text = "label1";
            // 
            // lblPinturaMenos
            // 
            this.lblPinturaMenos.AutoSize = true;
            this.lblPinturaMenos.Location = new System.Drawing.Point(9, 312);
            this.lblPinturaMenos.Name = "lblPinturaMenos";
            this.lblPinturaMenos.Size = new System.Drawing.Size(35, 13);
            this.lblPinturaMenos.TabIndex = 1;
            this.lblPinturaMenos.Text = "label1";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 34);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(693, 150);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto Eléctro más Solicitado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto Pintura menos Solicitado";
            // 
            // dgvProductosCliente
            // 
            this.dgvProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosCliente.Location = new System.Drawing.Point(240, 224);
            this.dgvProductosCliente.Name = "dgvProductosCliente";
            this.dgvProductosCliente.Size = new System.Drawing.Size(465, 150);
            this.dgvProductosCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos Comprados Por Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clientes Ordenados por Descuentos Obtenidos";
            // 
            // dgvStockTotal
            // 
            this.dgvStockTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTotal.Location = new System.Drawing.Point(154, 414);
            this.dgvStockTotal.Name = "dgvStockTotal";
            this.dgvStockTotal.Size = new System.Drawing.Size(551, 150);
            this.dgvStockTotal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock Total";
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(34, 424);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(98, 35);
            this.btnTodo.TabIndex = 10;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnElectro
            // 
            this.btnElectro.Location = new System.Drawing.Point(34, 476);
            this.btnElectro.Name = "btnElectro";
            this.btnElectro.Size = new System.Drawing.Size(98, 35);
            this.btnElectro.TabIndex = 11;
            this.btnElectro.Text = "Electro";
            this.btnElectro.UseVisualStyleBackColor = true;
            this.btnElectro.Click += new System.EventHandler(this.btnElectro_Click);
            // 
            // btnPintura
            // 
            this.btnPintura.Location = new System.Drawing.Point(34, 526);
            this.btnPintura.Name = "btnPintura";
            this.btnPintura.Size = new System.Drawing.Size(98, 35);
            this.btnPintura.TabIndex = 12;
            this.btnPintura.Text = "Pintura";
            this.btnPintura.UseVisualStyleBackColor = true;
            this.btnPintura.Click += new System.EventHandler(this.btnPintura_Click);
            // 
            // FRInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 573);
            this.Controls.Add(this.btnPintura);
            this.Controls.Add(this.btnElectro);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStockTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProductosCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblPinturaMenos);
            this.Controls.Add(this.lblMaxElectro);
            this.Name = "FRInformes";
            this.Text = "FRInformes";
            this.Load += new System.EventHandler(this.FRInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxElectro;
        private System.Windows.Forms.Label lblPinturaMenos;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductosCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStockTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnElectro;
        private System.Windows.Forms.Button btnPintura;
    }
}