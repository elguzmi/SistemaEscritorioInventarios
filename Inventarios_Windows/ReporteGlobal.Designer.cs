namespace Inventarios_Windows
{
    partial class ReporteGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteGlobal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LbFechafinal = new System.Windows.Forms.Label();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Lbfechainicial = new System.Windows.Forms.Label();
            this.DtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.DgvEgresos = new System.Windows.Forms.DataGridView();
            this.GbEgresos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalEgre = new System.Windows.Forms.TextBox();
            this.GbIngresos = new System.Windows.Forms.GroupBox();
            this.TxtDiferencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotalIng = new System.Windows.Forms.TextBox();
            this.DgvIngresos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEgresos)).BeginInit();
            this.GbEgresos.SuspendLayout();
            this.GbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 89);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TituloLabel.Size = new System.Drawing.Size(568, 48);
            this.TituloLabel.TabIndex = 5;
            this.TituloLabel.Text = "Reporte de ingresos y egresos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnConsultar);
            this.groupBox3.Controls.Add(this.LbFechafinal);
            this.groupBox3.Controls.Add(this.DtpFechaFinal);
            this.groupBox3.Controls.Add(this.Lbfechainicial);
            this.groupBox3.Controls.Add(this.DtpFechaInicial);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1315, 74);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por fechas";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultar.Location = new System.Drawing.Point(1088, 26);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(205, 40);
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
            this.DtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaFinal.TabIndex = 2;
            this.DtpFechaFinal.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
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
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Location = new System.Drawing.Point(140, 31);
            this.DtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.Size = new System.Drawing.Size(265, 30);
            this.DtpFechaInicial.TabIndex = 0;
            this.DtpFechaInicial.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            // 
            // DgvEgresos
            // 
            this.DgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEgresos.Location = new System.Drawing.Point(12, 32);
            this.DgvEgresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvEgresos.Name = "DgvEgresos";
            this.DgvEgresos.RowHeadersWidth = 51;
            this.DgvEgresos.Size = new System.Drawing.Size(635, 337);
            this.DgvEgresos.TabIndex = 57;
            // 
            // GbEgresos
            // 
            this.GbEgresos.Controls.Add(this.label1);
            this.GbEgresos.Controls.Add(this.TxtTotalEgre);
            this.GbEgresos.Controls.Add(this.DgvEgresos);
            this.GbEgresos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEgresos.Location = new System.Drawing.Point(0, 162);
            this.GbEgresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbEgresos.Name = "GbEgresos";
            this.GbEgresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbEgresos.Size = new System.Drawing.Size(664, 435);
            this.GbEgresos.TabIndex = 58;
            this.GbEgresos.TabStop = false;
            this.GbEgresos.Text = "Egresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Total egresos";
            // 
            // TxtTotalEgre
            // 
            this.TxtTotalEgre.Location = new System.Drawing.Point(441, 390);
            this.TxtTotalEgre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTotalEgre.Name = "TxtTotalEgre";
            this.TxtTotalEgre.Size = new System.Drawing.Size(180, 32);
            this.TxtTotalEgre.TabIndex = 58;
            // 
            // GbIngresos
            // 
            this.GbIngresos.Controls.Add(this.label2);
            this.GbIngresos.Controls.Add(this.TxtTotalIng);
            this.GbIngresos.Controls.Add(this.DgvIngresos);
            this.GbIngresos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIngresos.Location = new System.Drawing.Point(664, 162);
            this.GbIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbIngresos.Name = "GbIngresos";
            this.GbIngresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbIngresos.Size = new System.Drawing.Size(651, 435);
            this.GbIngresos.TabIndex = 59;
            this.GbIngresos.TabStop = false;
            this.GbIngresos.Text = "Ingresos";
            // 
            // TxtDiferencia
            // 
            this.TxtDiferencia.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiferencia.Location = new System.Drawing.Point(683, 21);
            this.TxtDiferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDiferencia.Name = "TxtDiferencia";
            this.TxtDiferencia.Size = new System.Drawing.Size(180, 32);
            this.TxtDiferencia.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Diferencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total Ingresos";
            // 
            // TxtTotalIng
            // 
            this.TxtTotalIng.Location = new System.Drawing.Point(433, 384);
            this.TxtTotalIng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTotalIng.Name = "TxtTotalIng";
            this.TxtTotalIng.Size = new System.Drawing.Size(180, 32);
            this.TxtTotalIng.TabIndex = 59;
            // 
            // DgvIngresos
            // 
            this.DgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIngresos.Location = new System.Drawing.Point(12, 32);
            this.DgvIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvIngresos.Name = "DgvIngresos";
            this.DgvIngresos.RowHeadersWidth = 51;
            this.DgvIngresos.Size = new System.Drawing.Size(631, 337);
            this.DgvIngresos.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtDiferencia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 591);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 74);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // ReporteGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbIngresos);
            this.Controls.Add(this.GbEgresos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteGlobal";
            this.Text = "ReporteGlobal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEgresos)).EndInit();
            this.GbEgresos.ResumeLayout(false);
            this.GbEgresos.PerformLayout();
            this.GbIngresos.ResumeLayout(false);
            this.GbIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIngresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker DtpFechaInicial;
        private System.Windows.Forms.DataGridView DgvEgresos;
        private System.Windows.Forms.GroupBox GbEgresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalEgre;
        private System.Windows.Forms.GroupBox GbIngresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotalIng;
        private System.Windows.Forms.DataGridView DgvIngresos;
        private System.Windows.Forms.TextBox TxtDiferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}