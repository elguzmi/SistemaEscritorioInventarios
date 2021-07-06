namespace Inventarios_Windows
{
    partial class RevisarEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisarEntradas));
            this.Dgv_Entradas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.Detalles = new System.Windows.Forms.GroupBox();
            this.TxtIdDetalles = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.DgvDetalles = new System.Windows.Forms.DataGridView();
            this.Entradas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Entradas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).BeginInit();
            this.Entradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Entradas
            // 
            this.Dgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Fecha,
            this.Proveedor,
            this.Total,
            this.Estado,
            this.BtnDetalles});
            this.Dgv_Entradas.Location = new System.Drawing.Point(13, 28);
            this.Dgv_Entradas.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Entradas.Name = "Dgv_Entradas";
            this.Dgv_Entradas.RowHeadersWidth = 51;
            this.Dgv_Entradas.Size = new System.Drawing.Size(923, 462);
            this.Dgv_Entradas.TabIndex = 0;
            this.Dgv_Entradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id Entrada";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Valor Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // BtnDetalles
            // 
            this.BtnDetalles.HeaderText = "Detalles";
            this.BtnDetalles.MinimumWidth = 6;
            this.BtnDetalles.Name = "BtnDetalles";
            this.BtnDetalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnDetalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnDetalles.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 82);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 106);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Location = new System.Drawing.Point(461, 10);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(385, 57);
            this.TituloLabel.TabIndex = 4;
            this.TituloLabel.Text = "Revisar Entradas";
            this.TituloLabel.Click += new System.EventHandler(this.TituloLabel_Click);
            // 
            // Detalles
            // 
            this.Detalles.Controls.Add(this.TxtIdDetalles);
            this.Detalles.Controls.Add(this.Label1);
            this.Detalles.Controls.Add(this.BtnCambiar);
            this.Detalles.Controls.Add(this.DgvDetalles);
            this.Detalles.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.Location = new System.Drawing.Point(949, 89);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(347, 522);
            this.Detalles.TabIndex = 58;
            this.Detalles.TabStop = false;
            this.Detalles.Text = "Detalles";
            // 
            // TxtIdDetalles
            // 
            this.TxtIdDetalles.Location = new System.Drawing.Point(192, 28);
            this.TxtIdDetalles.Name = "TxtIdDetalles";
            this.TxtIdDetalles.ReadOnly = true;
            this.TxtIdDetalles.Size = new System.Drawing.Size(95, 29);
            this.TxtIdDetalles.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Detalles de la entrada:";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(111, 424);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(157, 44);
            this.BtnCambiar.TabIndex = 1;
            this.BtnCambiar.Text = "Cambiar Estado";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // DgvDetalles
            // 
            this.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalles.Location = new System.Drawing.Point(6, 69);
            this.DgvDetalles.Name = "DgvDetalles";
            this.DgvDetalles.RowHeadersWidth = 51;
            this.DgvDetalles.RowTemplate.Height = 24;
            this.DgvDetalles.Size = new System.Drawing.Size(328, 349);
            this.DgvDetalles.TabIndex = 0;
            // 
            // Entradas
            // 
            this.Entradas.Controls.Add(this.Dgv_Entradas);
            this.Entradas.Dock = System.Windows.Forms.DockStyle.Left;
            this.Entradas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entradas.Location = new System.Drawing.Point(0, 82);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(943, 581);
            this.Entradas.TabIndex = 60;
            this.Entradas.TabStop = false;
            this.Entradas.Text = "Tabla de entradas";
            // 
            // RevisarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 663);
            this.Controls.Add(this.Entradas);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RevisarEntradas";
            this.Text = "RevisarStock";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Entradas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Detalles.ResumeLayout(false);
            this.Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).EndInit();
            this.Entradas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Entradas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDetalles;
        private System.Windows.Forms.GroupBox Detalles;
        private System.Windows.Forms.TextBox TxtIdDetalles;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.DataGridView DgvDetalles;
        private System.Windows.Forms.GroupBox Entradas;
    }
}