﻿
namespace Inventarios_Windows.FormsBusqueda
{
    partial class BuscarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProveedores));
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBuscarNombre = new System.Windows.Forms.TextBox();
            this.GbProveedores = new System.Windows.Forms.GroupBox();
            this.GbDatosSeleccionados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.GbBotones = new System.Windows.Forms.GroupBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbProveedores.SuspendLayout();
            this.GbDatosSeleccionados.SuspendLayout();
            this.GbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.Tomato;
            this.PanelTitulo.Controls.Add(this.pictureBox1);
            this.PanelTitulo.Controls.Add(this.TituloLabel);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1099, 76);
            this.PanelTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TituloLabel.Location = new System.Drawing.Point(348, 9);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(455, 57);
            this.TituloLabel.TabIndex = 3;
            this.TituloLabel.Text = "Buscador Proveedor";
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.groupBox3);
            this.PanelGeneral.Controls.Add(this.groupBox2);
            this.PanelGeneral.Controls.Add(this.GbProveedores);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 76);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(1099, 606);
            this.PanelGeneral.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtBuscarCodigo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(483, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(616, 64);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por Razon";
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(4, 27);
            this.TxtBuscarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(608, 30);
            this.TxtBuscarCodigo.TabIndex = 12;
            this.TxtBuscarCodigo.TextChanged += new System.EventHandler(this.TxtBuscarCodigo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBuscarNombre);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(475, 64);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nit";
            // 
            // TxtBuscarNombre
            // 
            this.TxtBuscarNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarNombre.Location = new System.Drawing.Point(4, 27);
            this.TxtBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscarNombre.Name = "TxtBuscarNombre";
            this.TxtBuscarNombre.Size = new System.Drawing.Size(467, 30);
            this.TxtBuscarNombre.TabIndex = 12;
            this.TxtBuscarNombre.TextChanged += new System.EventHandler(this.TxtBuscarNombre_TextChanged);
            // 
            // GbProveedores
            // 
            this.GbProveedores.Controls.Add(this.GbDatosSeleccionados);
            this.GbProveedores.Controls.Add(this.GbBotones);
            this.GbProveedores.Controls.Add(this.DgvProveedores);
            this.GbProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProveedores.Location = new System.Drawing.Point(0, 64);
            this.GbProveedores.Name = "GbProveedores";
            this.GbProveedores.Size = new System.Drawing.Size(1099, 542);
            this.GbProveedores.TabIndex = 0;
            this.GbProveedores.TabStop = false;
            this.GbProveedores.Text = "Registros de Proveedores";
            this.GbProveedores.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GbDatosSeleccionados
            // 
            this.GbDatosSeleccionados.Controls.Add(this.TxtId);
            this.GbDatosSeleccionados.Controls.Add(this.label2);
            this.GbDatosSeleccionados.Controls.Add(this.label1);
            this.GbDatosSeleccionados.Controls.Add(this.TxtRazonSocial);
            this.GbDatosSeleccionados.Controls.Add(this.TxtNit);
            this.GbDatosSeleccionados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbDatosSeleccionados.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatosSeleccionados.Location = new System.Drawing.Point(3, 354);
            this.GbDatosSeleccionados.Name = "GbDatosSeleccionados";
            this.GbDatosSeleccionados.Size = new System.Drawing.Size(1093, 90);
            this.GbDatosSeleccionados.TabIndex = 57;
            this.GbDatosSeleccionados.TabStop = false;
            this.GbDatosSeleccionados.Text = "Datos Seleccionados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nit";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(355, 44);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(729, 30);
            this.TxtRazonSocial.TabIndex = 1;
            // 
            // TxtNit
            // 
            this.TxtNit.Location = new System.Drawing.Point(93, 44);
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(244, 30);
            this.TxtNit.TabIndex = 0;
            // 
            // GbBotones
            // 
            this.GbBotones.Controls.Add(this.BtnSeleccionar);
            this.GbBotones.Controls.Add(this.button2);
            this.GbBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbBotones.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBotones.Location = new System.Drawing.Point(3, 444);
            this.GbBotones.Name = "GbBotones";
            this.GbBotones.Size = new System.Drawing.Size(1093, 95);
            this.GbBotones.TabIndex = 2;
            this.GbBotones.TabStop = false;
            this.GbBotones.Text = "Controles";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Tomato;
            this.BtnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(454, 30);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(180, 51);
            this.BtnSeleccionar.TabIndex = 52;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(944, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvProveedores.Location = new System.Drawing.Point(3, 26);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            this.DgvProveedores.RowHeadersWidth = 51;
            this.DgvProveedores.RowTemplate.Height = 24;
            this.DgvProveedores.Size = new System.Drawing.Size(1093, 322);
            this.DgvProveedores.TabIndex = 0;
            this.DgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducto_CellClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(6, 44);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(81, 30);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // BuscarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 682);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.PanelTitulo);
            this.Name = "BuscarProveedores";
            this.Text = "BuscarArticulos";
            this.Load += new System.EventHandler(this.BuscarArticulos_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelGeneral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbProveedores.ResumeLayout(false);
            this.GbDatosSeleccionados.ResumeLayout(false);
            this.GbDatosSeleccionados.PerformLayout();
            this.GbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbProveedores;
        private System.Windows.Forms.GroupBox GbDatosSeleccionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbBotones;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox TxtBuscarCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox TxtBuscarNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtRazonSocial;
        public System.Windows.Forms.TextBox TxtNit;
        public System.Windows.Forms.TextBox TxtId;
    }
}