namespace FinanzasApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblConfiguracion = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBalance = new System.Windows.Forms.PictureBox();
            this.pictureBoxReportes = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.btnNuevoMovimiento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pnlBalance);
            this.panel1.Controls.Add(this.pnlReportes);
            this.panel1.Controls.Add(this.pnlDashboard);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 682);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblConfiguracion);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(0, 565);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 47);
            this.panel6.TabIndex = 3;
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracion.Location = new System.Drawing.Point(83, 16);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(82, 15);
            this.lblConfiguracion.TabIndex = 1;
            this.lblConfiguracion.Text = "Configuracion";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPerfil);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 612);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 47);
            this.panel5.TabIndex = 3;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(83, 16);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(34, 15);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "Perfil";
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Controls.Add(this.pictureBoxBalance);
            this.pnlBalance.Location = new System.Drawing.Point(0, 193);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(203, 47);
            this.pnlBalance.TabIndex = 2;
            this.pnlBalance.Click += new System.EventHandler(this.pnlBalance_Click);
            this.pnlBalance.MouseLeave += new System.EventHandler(this.pnlBalance_MouseLeave);
            this.pnlBalance.MouseHover += new System.EventHandler(this.pnlBalance_MouseHover);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(83, 16);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(48, 15);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance";
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.lblReportes);
            this.pnlReportes.Controls.Add(this.pictureBoxReportes);
            this.pnlReportes.Location = new System.Drawing.Point(0, 146);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(203, 47);
            this.pnlReportes.TabIndex = 1;
            this.pnlReportes.Click += new System.EventHandler(this.pnlReportes_Click);
            this.pnlReportes.MouseLeave += new System.EventHandler(this.pnlReportes_MouseLeave);
            this.pnlReportes.MouseHover += new System.EventHandler(this.pnlReportes_MouseHover);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(83, 16);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(53, 15);
            this.lblReportes.TabIndex = 1;
            this.lblReportes.Text = "Reportes";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Controls.Add(this.pictureBoxDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(0, 99);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(203, 47);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.MouseLeave += new System.EventHandler(this.pnlDashboard_MouseLeave);
            this.pnlDashboard.MouseHover += new System.EventHandler(this.pnlDashboard_MouseHover);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(83, 16);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(65, 15);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido, Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMovimientos.ColumnHeadersHeight = 40;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMonto,
            this.colConcepto,
            this.colTipoMovimiento,
            this.colFecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMovimientos.EnableHeadersVisualStyles = false;
            this.dgvMovimientos.GridColor = System.Drawing.Color.LightSlateGray;
            this.dgvMovimientos.Location = new System.Drawing.Point(263, 383);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.RowTemplate.Height = 30;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(509, 231);
            this.dgvMovimientos.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.FillWeight = 99.8336F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colMonto
            // 
            this.colMonto.FillWeight = 100.3976F;
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            // 
            // colConcepto
            // 
            this.colConcepto.FillWeight = 101.7452F;
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            // 
            // colTipoMovimiento
            // 
            this.colTipoMovimiento.FillWeight = 99.50166F;
            this.colTipoMovimiento.HeaderText = "Tipo";
            this.colTipoMovimiento.Name = "colTipoMovimiento";
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 98.522F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnNuevoMovimiento);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(230, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 179);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saldo disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "S/. 20000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "CARD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(230, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Movimientos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBalance
            // 
            this.pictureBoxBalance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBalance.Image")));
            this.pictureBoxBalance.Location = new System.Drawing.Point(40, 8);
            this.pictureBoxBalance.Name = "pictureBoxBalance";
            this.pictureBoxBalance.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBalance.TabIndex = 0;
            this.pictureBoxBalance.TabStop = false;
            // 
            // pictureBoxReportes
            // 
            this.pictureBoxReportes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReportes.Image")));
            this.pictureBoxReportes.Location = new System.Drawing.Point(40, 8);
            this.pictureBoxReportes.Name = "pictureBoxReportes";
            this.pictureBoxReportes.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReportes.TabIndex = 0;
            this.pictureBoxReportes.TabStop = false;
            // 
            // pictureBoxDashboard
            // 
            this.pictureBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboard.Image")));
            this.pictureBoxDashboard.Location = new System.Drawing.Point(40, 4);
            this.pictureBoxDashboard.Name = "pictureBoxDashboard";
            this.pictureBoxDashboard.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDashboard.TabIndex = 0;
            this.pictureBoxDashboard.TabStop = false;
            // 
            // btnNuevoMovimiento
            // 
            this.btnNuevoMovimiento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMovimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoMovimiento.Location = new System.Drawing.Point(185, 125);
            this.btnNuevoMovimiento.Name = "btnNuevoMovimiento";
            this.btnNuevoMovimiento.Size = new System.Drawing.Size(130, 34);
            this.btnNuevoMovimiento.TabIndex = 5;
            this.btnNuevoMovimiento.Text = "Nuevo movimiento...";
            this.btnNuevoMovimiento.UseVisualStyleBackColor = true;
            this.btnNuevoMovimiento.Click += new System.EventHandler(this.btnNuevoMovimiento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(833, 682);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pictureBoxDashboard;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.PictureBox pictureBoxReportes;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pictureBoxBalance;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblConfiguracion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNuevoMovimiento;
    }
}

