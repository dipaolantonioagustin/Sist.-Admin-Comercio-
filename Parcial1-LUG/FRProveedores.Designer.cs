namespace Parcial1_LUG
{
    partial class FRProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(202, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(355, 299);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(71, 50);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(125, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(71, 89);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(125, 20);
            this.txtCuit.TabIndex = 2;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(71, 12);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(125, 20);
            this.txtIdProveedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CUIL";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(106, 131);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(90, 33);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // FRProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 331);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "FRProveedores";
            this.Text = "FRProveedores";
            this.Load += new System.EventHandler(this.FRProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlta;
    }
}