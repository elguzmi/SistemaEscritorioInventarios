namespace Inventarios_Windows
{
    partial class Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entradas));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.GbProductos = new System.Windows.Forms.GroupBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCantidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdP = new System.Windows.Forms.TextBox();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.TxtRazon = new System.Windows.Forms.TextBox();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.GbArticulosAdd = new System.Windows.Forms.GroupBox();
            this.DgvEntradas = new System.Windows.Forms.DataGridView();
            this.IdF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.Label();
            this.TxtNombreEntrada = new System.Windows.Forms.TextBox();
            this.TxtIdEntrada = new System.Windows.Forms.TextBox();
            this.TextId = new System.Windows.Forms.Label();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            this.GbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.GbDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbArticulosAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradas)).BeginInit();
            this.PanelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.GbProductos);
            this.panelGeneral.Controls.Add(this.GbDatos);
            this.panelGeneral.Controls.Add(this.PanelEncabezado);
            this.panelGeneral.Location = new System.Drawing.Point(-4, -2);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1315, 665);
            this.panelGeneral.TabIndex = 0;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // GbProductos
            // 
            this.GbProductos.Controls.Add(this.DgvProductos);
            this.GbProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.GbProductos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProductos.Location = new System.Drawing.Point(805, 85);
            this.GbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.GbProductos.Name = "GbProductos";
            this.GbProductos.Padding = new System.Windows.Forms.Padding(4);
            this.GbProductos.Size = new System.Drawing.Size(510, 580);
            this.GbProductos.TabIndex = 62;
            this.GbProductos.TabStop = false;
            this.GbProductos.Text = "Selección de producto";
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
            this.Btn_Add});
            this.DgvProductos.Location = new System.Drawing.Point(5, 23);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(491, 529);
            this.DgvProductos.TabIndex = 66;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellContentClick);
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
            // Btn_Add
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Add.DefaultCellStyle = dataGridViewCellStyle1;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Add.HeaderText = "Accion";
            this.Btn_Add.MinimumWidth = 6;
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.ToolTipText = "Agregar";
            this.Btn_Add.Width = 125;
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.groupBox2);
            this.GbDatos.Controls.Add(this.GbArticulosAdd);
            this.GbDatos.Controls.Add(this.dateTimePicker1);
            this.GbDatos.Controls.Add(this.label1);
            this.GbDatos.Controls.Add(this.TextNombre);
            this.GbDatos.Controls.Add(this.TxtNombreEntrada);
            this.GbDatos.Controls.Add(this.TxtIdEntrada);
            this.GbDatos.Controls.Add(this.TextId);
            this.GbDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.GbDatos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatos.Location = new System.Drawing.Point(0, 85);
            this.GbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.GbDatos.Size = new System.Drawing.Size(797, 580);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos Entrada";
            this.GbDatos.Enter += new System.EventHandler(this.GbDatos_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIdP);
            this.groupBox2.Controls.Add(this.TxtNit);
            this.groupBox2.Controls.Add(this.TxtRazon);
            this.groupBox2.Controls.Add(this.BtnProveedor);
            this.groupBox2.Location = new System.Drawing.Point(9, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 80);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Proveedor";
            // 
            // TxtIdP
            // 
            this.TxtIdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdP.Location = new System.Drawing.Point(17, 31);
            this.TxtIdP.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdP.Name = "TxtIdP";
            this.TxtIdP.ReadOnly = true;
            this.TxtIdP.Size = new System.Drawing.Size(50, 30);
            this.TxtIdP.TabIndex = 22;
            this.TxtIdP.Visible = false;
            // 
            // TxtNit
            // 
            this.TxtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit.Location = new System.Drawing.Point(75, 32);
            this.TxtNit.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.ReadOnly = true;
            this.TxtNit.Size = new System.Drawing.Size(147, 30);
            this.TxtNit.TabIndex = 21;
            // 
            // TxtRazon
            // 
            this.TxtRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazon.Location = new System.Drawing.Point(230, 32);
            this.TxtRazon.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRazon.Name = "TxtRazon";
            this.TxtRazon.ReadOnly = true;
            this.TxtRazon.Size = new System.Drawing.Size(320, 30);
            this.TxtRazon.TabIndex = 20;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Location = new System.Drawing.Point(558, 26);
            this.BtnProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(216, 40);
            this.BtnProveedor.TabIndex = 20;
            this.BtnProveedor.Text = "Agregar Proveedor";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // GbArticulosAdd
            // 
            this.GbArticulosAdd.Controls.Add(this.DgvEntradas);
            this.GbArticulosAdd.Controls.Add(this.label2);
            this.GbArticulosAdd.Controls.Add(this.TxtTotal);
            this.GbArticulosAdd.Controls.Add(this.BtnAgregar);
            this.GbArticulosAdd.Controls.Add(this.BtnNuevo);
            this.GbArticulosAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbArticulosAdd.Location = new System.Drawing.Point(8, 214);
            this.GbArticulosAdd.Margin = new System.Windows.Forms.Padding(4);
            this.GbArticulosAdd.Name = "GbArticulosAdd";
            this.GbArticulosAdd.Padding = new System.Windows.Forms.Padding(4);
            this.GbArticulosAdd.Size = new System.Drawing.Size(781, 362);
            this.GbArticulosAdd.TabIndex = 61;
            this.GbArticulosAdd.TabStop = false;
            this.GbArticulosAdd.Text = "Articulos Entrantes";
            this.GbArticulosAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DgvEntradas
            // 
            this.DgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdF,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Cantidad,
            this.PrecioVenta,
            this.Total,
            this.BtnBorrar});
            this.DgvEntradas.Location = new System.Drawing.Point(1, 23);
            this.DgvEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.DgvEntradas.Name = "DgvEntradas";
            this.DgvEntradas.ReadOnly = true;
            this.DgvEntradas.RowHeadersWidth = 51;
            this.DgvEntradas.Size = new System.Drawing.Size(773, 264);
            this.DgvEntradas.TabIndex = 68;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valor Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(593, 306);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(175, 32);
            this.TxtTotal.TabIndex = 67;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Orange;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(152, 297);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(169, 47);
            this.BtnAgregar.TabIndex = 59;
            this.BtnAgregar.Text = "       Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Orange;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(8, 297);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(139, 49);
            this.BtnNuevo.TabIndex = 58;
            this.BtnNuevo.Text = "      Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 32);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 43);
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
            this.TextNombre.Location = new System.Drawing.Point(17, 98);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(147, 25);
            this.TextNombre.TabIndex = 12;
            this.TextNombre.Text = "Nombre Entrada";
            // 
            // TxtNombreEntrada
            // 
            this.TxtNombreEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEntrada.Location = new System.Drawing.Point(172, 98);
            this.TxtNombreEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreEntrada.Name = "TxtNombreEntrada";
            this.TxtNombreEntrada.Size = new System.Drawing.Size(604, 30);
            this.TxtNombreEntrada.TabIndex = 11;
            // 
            // TxtIdEntrada
            // 
            this.TxtIdEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdEntrada.Location = new System.Drawing.Point(120, 44);
            this.TxtIdEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdEntrada.Name = "TxtIdEntrada";
            this.TxtIdEntrada.ReadOnly = true;
            this.TxtIdEntrada.Size = new System.Drawing.Size(56, 30);
            this.TxtIdEntrada.TabIndex = 10;
            // 
            // TextId
            // 
            this.TextId.AutoSize = true;
            this.TextId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextId.Location = new System.Drawing.Point(17, 44);
            this.TextId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(96, 25);
            this.TextId.TabIndex = 9;
            this.TextId.Text = "Id Entrada";
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.Color.Orange;
            this.PanelEncabezado.Controls.Add(this.pictureBox1);
            this.PanelEncabezado.Controls.Add(this.PanelBody);
            this.PanelEncabezado.Controls.Add(this.TituloLabel);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PanelEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(1315, 85);
            this.PanelEncabezado.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 93);
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
            this.TituloLabel.Location = new System.Drawing.Point(491, 11);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(213, 57);
            this.TituloLabel.TabIndex = 4;
            this.TituloLabel.Text = "Entradas";
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 663);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.panelGeneral.ResumeLayout(false);
            this.GbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbArticulosAdd.ResumeLayout(false);
            this.GbArticulosAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradas)).EndInit();
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
        public System.Windows.Forms.TextBox TxtNombreEntrada;
        public System.Windows.Forms.TextBox TxtIdEntrada;
        private System.Windows.Forms.Label TextId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbArticulosAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox TxtNit;
        public System.Windows.Forms.TextBox TxtRazon;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.GroupBox GbProductos;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridView DgvEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn CmbCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Add;
        public System.Windows.Forms.TextBox TxtIdP;
    }
}