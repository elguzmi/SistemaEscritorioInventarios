
namespace Inventarios_Windows.FormsBusqueda
{
    partial class AgregarArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCantidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.GbArticulos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvSeleccion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.GbArticulos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.CmbCantidad,
            this.PrecioUnidad,
            this.BtnEditar});
            this.DgvProductos.Location = new System.Drawing.Point(13, 21);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(1028, 168);
            this.DgvProductos.TabIndex = 0;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Btn_Editar);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // CmbCantidad
            // 
            this.CmbCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCantidad.HeaderText = "Cantidad";
            this.CmbCantidad.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.CmbCantidad.MinimumWidth = 6;
            this.CmbCantidad.Name = "CmbCantidad";
            this.CmbCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CmbCantidad.Width = 125;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.HeaderText = "PrecioUnidad";
            this.PrecioUnidad.MinimumWidth = 6;
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioUnidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioUnidad.Width = 125;
            // 
            // BtnEditar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEditar.DefaultCellStyle = dataGridViewCellStyle1;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.HeaderText = "Accion";
            this.BtnEditar.MinimumWidth = 6;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Agregar";
            this.BtnEditar.ToolTipText = "Agregar";
            this.BtnEditar.Width = 125;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCerrar.Location = new System.Drawing.Point(435, 511);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(198, 36);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Terminar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 92);
            this.panel1.TabIndex = 3;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Location = new System.Drawing.Point(330, 10);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(475, 57);
            this.TituloLabel.TabIndex = 5;
            this.TituloLabel.Text = "Seleccionar Articulos";
            // 
            // GbArticulos
            // 
            this.GbArticulos.Controls.Add(this.groupBox1);
            this.GbArticulos.Controls.Add(this.DgvProductos);
            this.GbArticulos.Location = new System.Drawing.Point(-1, 97);
            this.GbArticulos.Name = "GbArticulos";
            this.GbArticulos.Size = new System.Drawing.Size(1069, 408);
            this.GbArticulos.TabIndex = 4;
            this.GbArticulos.TabStop = false;
            this.GbArticulos.Text = "Listado de Articulos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvSeleccion);
            this.groupBox1.Location = new System.Drawing.Point(13, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GbPreseleccion";
            // 
            // DgvSeleccion
            // 
            this.DgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSeleccion.Location = new System.Drawing.Point(6, 21);
            this.DgvSeleccion.Name = "DgvSeleccion";
            this.DgvSeleccion.RowHeadersWidth = 51;
            this.DgvSeleccion.RowTemplate.Height = 24;
            this.DgvSeleccion.Size = new System.Drawing.Size(1022, 156);
            this.DgvSeleccion.TabIndex = 0;
            // 
            // AgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 558);
            this.Controls.Add(this.GbArticulos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "AgregarArticulos";
            this.Text = "AgregarArticulos";
            this.Load += new System.EventHandler(this.AgregarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbArticulos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.GroupBox GbArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn CmbCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvSeleccion;
    }
}