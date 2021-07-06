namespace Inventarios_Windows
{
    partial class ReporteIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteIngresos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtpActual = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.LbFechafinal = new System.Windows.Forms.Label();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Lbfechainicial = new System.Windows.Forms.Label();
            this.DtpFechaIncial = new System.Windows.Forms.DateTimePicker();
            this.DgvIngresos = new System.Windows.Forms.DataGridView();
            this.GbEgresos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresos)).BeginInit();
            this.GbEgresos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 89);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 111);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloLabel.Location = new System.Drawing.Point(371, 22);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(534, 48);
            this.TituloLabel.TabIndex = 5;
            this.TituloLabel.Text = "Reporte de Ingresos  por Dia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtpActual);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtDescripcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BtnConsulta);
            this.groupBox3.Controls.Add(this.LbFechafinal);
            this.groupBox3.Controls.Add(this.DtpFechaFinal);
            this.groupBox3.Controls.Add(this.Lbfechainicial);
            this.groupBox3.Controls.Add(this.DtpFechaIncial);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1315, 130);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por fechas";
            // 
            // DtpActual
            // 
            this.DtpActual.Location = new System.Drawing.Point(903, 31);
            this.DtpActual.Margin = new System.Windows.Forms.Padding(4);
            this.DtpActual.Name = "DtpActual";
            this.DtpActual.Size = new System.Drawing.Size(160, 30);
            this.DtpActual.TabIndex = 8;
            this.DtpActual.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Actual";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(130, 84);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(933, 30);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsulta.Location = new System.Drawing.Point(1088, 26);
            this.BtnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(214, 36);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // LbFechafinal
            // 
            this.LbFechafinal.AutoSize = true;
            this.LbFechafinal.Location = new System.Drawing.Point(415, 37);
            this.LbFechafinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbFechafinal.Name = "LbFechafinal";
            this.LbFechafinal.Size = new System.Drawing.Size(94, 23);
            this.LbFechafinal.TabIndex = 3;
            this.LbFechafinal.Text = "Fecha Final";
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Location = new System.Drawing.Point(517, 32);
            this.DtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaFinal.TabIndex = 2;
            this.DtpFechaFinal.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // Lbfechainicial
            // 
            this.Lbfechainicial.AutoSize = true;
            this.Lbfechainicial.Location = new System.Drawing.Point(21, 35);
            this.Lbfechainicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbfechainicial.Name = "Lbfechainicial";
            this.Lbfechainicial.Size = new System.Drawing.Size(101, 23);
            this.Lbfechainicial.TabIndex = 1;
            this.Lbfechainicial.Text = "Fecha Inicial";
            // 
            // DtpFechaIncial
            // 
            this.DtpFechaIncial.Location = new System.Drawing.Point(130, 32);
            this.DtpFechaIncial.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaIncial.Name = "DtpFechaIncial";
            this.DtpFechaIncial.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaIncial.TabIndex = 0;
            this.DtpFechaIncial.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // DgvIngresos
            // 
            this.DgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIngresos.Location = new System.Drawing.Point(12, 33);
            this.DgvIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvIngresos.Name = "DgvIngresos";
            this.DgvIngresos.RowHeadersWidth = 51;
            this.DgvIngresos.Size = new System.Drawing.Size(1275, 306);
            this.DgvIngresos.TabIndex = 57;
            // 
            // GbEgresos
            // 
            this.GbEgresos.Controls.Add(this.DgvIngresos);
            this.GbEgresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbEgresos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEgresos.Location = new System.Drawing.Point(0, 219);
            this.GbEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.GbEgresos.Name = "GbEgresos";
            this.GbEgresos.Padding = new System.Windows.Forms.Padding(4);
            this.GbEgresos.Size = new System.Drawing.Size(1315, 354);
            this.GbEgresos.TabIndex = 58;
            this.GbEgresos.TabStop = false;
            this.GbEgresos.Text = "Reporte Ingresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Total ingresos:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(271, 32);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(226, 29);
            this.TxtTotal.TabIndex = 58;
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
            this.BtnAgregar.Location = new System.Drawing.Point(885, 21);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(205, 45);
            this.BtnAgregar.TabIndex = 61;
            this.BtnAgregar.Text = "       Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1291, 73);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1098, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 45);
            this.button1.TabIndex = 62;
            this.button1.Text = "       Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbEgresos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteIngresos";
            this.Text = "ReporteGlobal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresos)).EndInit();
            this.GbEgresos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Label LbFechafinal;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.Label Lbfechainicial;
        private System.Windows.Forms.DateTimePicker DtpFechaIncial;
        private System.Windows.Forms.DataGridView DgvIngresos;
        private System.Windows.Forms.GroupBox GbEgresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DateTimePicker DtpActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}