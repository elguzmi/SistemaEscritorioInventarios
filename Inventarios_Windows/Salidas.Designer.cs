namespace Inventarios_Windows
{
    partial class Salidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TextId = new System.Windows.Forms.Label();
            this.GbArticulos = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.IdF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.GbProductos = new System.Windows.Forms.GroupBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCantidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.GbDatos.SuspendLayout();
            this.GbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            this.GbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.PanelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.BtnNuevo);
            this.panelGeneral.Controls.Add(this.BtnAgregar);
            this.panelGeneral.Controls.Add(this.GbDatos);
            this.panelGeneral.Controls.Add(this.GbArticulos);
            this.panelGeneral.Controls.Add(this.GbProductos);
            this.panelGeneral.Controls.Add(this.PanelEncabezado);
            this.panelGeneral.Location = new System.Drawing.Point(-4, -2);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1313, 667);
            this.panelGeneral.TabIndex = 0;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(20, 610);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(159, 44);
            this.BtnNuevo.TabIndex = 58;
            this.BtnNuevo.Text = "      Limpiar";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(202, 610);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(205, 45);
            this.BtnAgregar.TabIndex = 59;
            this.BtnAgregar.Text = "       Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.dateTimePicker1);
            this.GbDatos.Controls.Add(this.label1);
            this.GbDatos.Controls.Add(this.TextNombre);
            this.GbDatos.Controls.Add(this.TxtNombre);
            this.GbDatos.Controls.Add(this.TxtId);
            this.GbDatos.Controls.Add(this.TextId);
            this.GbDatos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatos.Location = new System.Drawing.Point(8, 93);
            this.GbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.GbDatos.Size = new System.Drawing.Size(785, 153);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos Salida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 32);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha Entrada";
            // 
            // TextNombre
            // 
            this.TextNombre.AutoSize = true;
            this.TextNombre.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(19, 74);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(78, 50);
            this.TextNombre.TabIndex = 12;
            this.TextNombre.Text = "Nombre\r\n Salida";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(105, 94);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(493, 30);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(110, 33);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(131, 30);
            this.TxtId.TabIndex = 10;
            // 
            // TextId
            // 
            this.TextId.AutoSize = true;
            this.TextId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextId.Location = new System.Drawing.Point(19, 33);
            this.TextId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(83, 25);
            this.TextId.TabIndex = 9;
            this.TextId.Text = "Id Salida";
            // 
            // GbArticulos
            // 
            this.GbArticulos.Controls.Add(this.BtnEliminar);
            this.GbArticulos.Controls.Add(this.DgvFactura);
            this.GbArticulos.Controls.Add(this.label5);
            this.GbArticulos.Controls.Add(this.TxtTotal);
            this.GbArticulos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbArticulos.Location = new System.Drawing.Point(4, 246);
            this.GbArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.GbArticulos.Name = "GbArticulos";
            this.GbArticulos.Padding = new System.Windows.Forms.Padding(4);
            this.GbArticulos.Size = new System.Drawing.Size(789, 355);
            this.GbArticulos.TabIndex = 61;
            this.GbArticulos.TabStop = false;
            this.GbArticulos.Text = "Listado de Articulos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(291, 300);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(196, 45);
            this.BtnEliminar.TabIndex = 62;
            this.BtnEliminar.Text = "  Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DgvFactura
            // 
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdF,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Cantidad,
            this.PrecioVenta,
            this.Total,
            this.BtnBorrar});
            this.DgvFactura.Location = new System.Drawing.Point(10, 31);
            this.DgvFactura.Margin = new System.Windows.Forms.Padding(4);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.ReadOnly = true;
            this.DgvFactura.RowHeadersWidth = 51;
            this.DgvFactura.Size = new System.Drawing.Size(775, 262);
            this.DgvFactura.TabIndex = 0;
            // 
            // IdF
            // 
            this.IdF.HeaderText = "IdF";
            this.IdF.MinimumWidth = 6;
            this.IdF.Name = "IdF";
            this.IdF.ReadOnly = true;
            this.IdF.Visible = false;
            this.IdF.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codígo";
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total ";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Total.Width = 125;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.HeaderText = "Borrar";
            this.BtnBorrar.MinimumWidth = 6;
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.ReadOnly = true;
            this.BtnBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnBorrar.Visible = false;
            this.BtnBorrar.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(639, 307);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(146, 30);
            this.TxtTotal.TabIndex = 21;
            // 
            // GbProductos
            // 
            this.GbProductos.Controls.Add(this.DgvProductos);
            this.GbProductos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProductos.Location = new System.Drawing.Point(804, 92);
            this.GbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.GbProductos.Name = "GbProductos";
            this.GbProductos.Padding = new System.Windows.Forms.Padding(4);
            this.GbProductos.Size = new System.Drawing.Size(505, 571);
            this.GbProductos.TabIndex = 15;
            this.GbProductos.TabStop = false;
            this.GbProductos.Text = "Selección de producto";
            this.GbProductos.Enter += new System.EventHandler(this.GbProductos_Enter);
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CmbCantidad,
            this.PrecioUnidad,
            this.BtnEditar});
            this.DgvProductos.Location = new System.Drawing.Point(7, 32);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(491, 528);
            this.DgvProductos.TabIndex = 65;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Btn_Editar);
            this.DgvProductos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvProductos_DataError);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.HeaderText = "Accion";
            this.BtnEditar.MinimumWidth = 6;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Agregar";
            this.BtnEditar.ToolTipText = "Agregar";
            this.BtnEditar.Width = 125;
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.Color.ForestGreen;
            this.PanelEncabezado.Controls.Add(this.pictureBox1);
            this.PanelEncabezado.Controls.Add(this.PanelBody);
            this.PanelEncabezado.Controls.Add(this.TituloLabel);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PanelEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(1313, 85);
            this.PanelEncabezado.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PanelBody
            // 
            this.PanelBody.Location = new System.Drawing.Point(0, 105);
            this.PanelBody.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1285, 550);
            this.PanelBody.TabIndex = 1;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Location = new System.Drawing.Point(544, 11);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(179, 57);
            this.TituloLabel.TabIndex = 4;
            this.TituloLabel.Text = "Salidas";
            // 
            // Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 663);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Salidas";
            this.Text = "Salida";
            this.panelGeneral.ResumeLayout(false);
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbArticulos.ResumeLayout(false);
            this.GbArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            this.GbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextNombre;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label TextId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox GbProductos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbArticulos;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn CmbCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
    }
}