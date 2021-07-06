namespace Inventarios_Windows
{
    partial class ReporteUtilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteUtilidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LbFechafinal = new System.Windows.Forms.Label();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Lbfechainicial = new System.Windows.Forms.Label();
            this.DtpFechaIncial = new System.Windows.Forms.DateTimePicker();
            this.DgvUtilidad = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbUtilidad = new System.Windows.Forms.GroupBox();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.TxtUtilidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotalC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalIngresos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUtilidad)).BeginInit();
            this.GbUtilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 87);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(853, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, -36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Location = new System.Drawing.Point(461, 30);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(362, 48);
            this.TituloLabel.TabIndex = 5;
            this.TituloLabel.Text = "Reporte de Utilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnConsultar);
            this.groupBox3.Controls.Add(this.LbFechafinal);
            this.groupBox3.Controls.Add(this.DtpFechaFinal);
            this.groupBox3.Controls.Add(this.Lbfechainicial);
            this.groupBox3.Controls.Add(this.DtpFechaIncial);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1315, 74);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por fechas";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Location = new System.Drawing.Point(1087, 31);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(199, 32);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LbFechafinal
            // 
            this.LbFechafinal.AutoSize = true;
            this.LbFechafinal.Location = new System.Drawing.Point(603, 36);
            this.LbFechafinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbFechafinal.Name = "LbFechafinal";
            this.LbFechafinal.Size = new System.Drawing.Size(94, 23);
            this.LbFechafinal.TabIndex = 3;
            this.LbFechafinal.Text = "Fecha Final";
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Location = new System.Drawing.Point(711, 31);
            this.DtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaFinal.TabIndex = 2;
            // 
            // Lbfechainicial
            // 
            this.Lbfechainicial.AutoSize = true;
            this.Lbfechainicial.Location = new System.Drawing.Point(12, 38);
            this.Lbfechainicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbfechainicial.Name = "Lbfechainicial";
            this.Lbfechainicial.Size = new System.Drawing.Size(101, 23);
            this.Lbfechainicial.TabIndex = 1;
            this.Lbfechainicial.Text = "Fecha Inicial";
            // 
            // DtpFechaIncial
            // 
            this.DtpFechaIncial.Location = new System.Drawing.Point(140, 31);
            this.DtpFechaIncial.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaIncial.Name = "DtpFechaIncial";
            this.DtpFechaIncial.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaIncial.TabIndex = 0;
            // 
            // DgvUtilidad
            // 
            this.DgvUtilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUtilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.PrecioCompra,
            this.PrecioVenta,
            this.TotalVenta,
            this.TotalCompra});
            this.DgvUtilidad.Location = new System.Drawing.Point(12, 32);
            this.DgvUtilidad.Margin = new System.Windows.Forms.Padding(4);
            this.DgvUtilidad.Name = "DgvUtilidad";
            this.DgvUtilidad.RowHeadersWidth = 51;
            this.DgvUtilidad.Size = new System.Drawing.Size(1287, 379);
            this.DgvUtilidad.TabIndex = 57;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 125;
            // 
            // TotalVenta
            // 
            this.TotalVenta.HeaderText = "TotalVenta";
            this.TotalVenta.MinimumWidth = 6;
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Width = 125;
            // 
            // TotalCompra
            // 
            this.TotalCompra.HeaderText = "TotalCompra";
            this.TotalCompra.MinimumWidth = 6;
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.Width = 125;
            // 
            // GbUtilidad
            // 
            this.GbUtilidad.Controls.Add(this.BtnExportar);
            this.GbUtilidad.Controls.Add(this.TxtUtilidad);
            this.GbUtilidad.Controls.Add(this.label3);
            this.GbUtilidad.Controls.Add(this.TxtTotalC);
            this.GbUtilidad.Controls.Add(this.label2);
            this.GbUtilidad.Controls.Add(this.label1);
            this.GbUtilidad.Controls.Add(this.TxtTotalIngresos);
            this.GbUtilidad.Controls.Add(this.DgvUtilidad);
            this.GbUtilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbUtilidad.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbUtilidad.Location = new System.Drawing.Point(0, 161);
            this.GbUtilidad.Margin = new System.Windows.Forms.Padding(4);
            this.GbUtilidad.Name = "GbUtilidad";
            this.GbUtilidad.Padding = new System.Windows.Forms.Padding(4);
            this.GbUtilidad.Size = new System.Drawing.Size(1315, 497);
            this.GbUtilidad.TabIndex = 58;
            this.GbUtilidad.TabStop = false;
            this.GbUtilidad.Text = "Utilidad";
            this.GbUtilidad.Enter += new System.EventHandler(this.GbUtilidad_Enter);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(20, 446);
            this.BtnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(100, 39);
            this.BtnExportar.TabIndex = 64;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // TxtUtilidad
            // 
            this.TxtUtilidad.Location = new System.Drawing.Point(1087, 446);
            this.TxtUtilidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUtilidad.Name = "TxtUtilidad";
            this.TxtUtilidad.Size = new System.Drawing.Size(180, 32);
            this.TxtUtilidad.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1000, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Utilidad";
            // 
            // TxtTotalC
            // 
            this.TxtTotalC.Location = new System.Drawing.Point(779, 446);
            this.TxtTotalC.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotalC.Name = "TxtTotalC";
            this.TxtTotalC.Size = new System.Drawing.Size(180, 32);
            this.TxtTotalC.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total Costos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Total Ventas";
            // 
            // TxtTotalIngresos
            // 
            this.TxtTotalIngresos.Location = new System.Drawing.Point(415, 446);
            this.TxtTotalIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotalIngresos.Name = "TxtTotalIngresos";
            this.TxtTotalIngresos.Size = new System.Drawing.Size(180, 32);
            this.TxtTotalIngresos.TabIndex = 58;
            // 
            // ReporteUtilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 665);
            this.Controls.Add(this.GbUtilidad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteUtilidad";
            this.Text = "ReporteGlobal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUtilidad)).EndInit();
            this.GbUtilidad.ResumeLayout(false);
            this.GbUtilidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LbFechafinal;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.Label Lbfechainicial;
        private System.Windows.Forms.DateTimePicker DtpFechaIncial;
        private System.Windows.Forms.DataGridView DgvUtilidad;
        private System.Windows.Forms.GroupBox GbUtilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalIngresos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.TextBox TxtUtilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompra;
    }
}