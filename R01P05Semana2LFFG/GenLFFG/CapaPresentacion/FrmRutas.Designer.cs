namespace CapaPresentacion
{
    partial class FrmRutas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.chkATiempo = new System.Windows.Forms.CheckBox();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nudChofer = new System.Windows.Forms.NumericUpDown();
            this.nudCamion = new System.Windows.Forms.NumericUpDown();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chofer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(2, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(2, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(2, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(2, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Llegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.Location = new System.Drawing.Point(2, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Distancia";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(138, 143);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(199, 20);
            this.txtOrigen.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(138, 208);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(199, 20);
            this.txtDestino.TabIndex = 1;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.Location = new System.Drawing.Point(142, 276);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(195, 20);
            this.dtpSalida.TabIndex = 2;
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLlegada.Location = new System.Drawing.Point(142, 347);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(195, 20);
            this.dtpLlegada.TabIndex = 2;
            // 
            // chkATiempo
            // 
            this.chkATiempo.AutoSize = true;
            this.chkATiempo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.chkATiempo.Location = new System.Drawing.Point(138, 465);
            this.chkATiempo.Name = "chkATiempo";
            this.chkATiempo.Size = new System.Drawing.Size(98, 27);
            this.chkATiempo.TabIndex = 3;
            this.chkATiempo.Text = "A Tiempo";
            this.chkATiempo.UseVisualStyleBackColor = true;
            // 
            // dgvRutas
            // 
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(360, 19);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.Size = new System.Drawing.Size(812, 473);
            this.dgvRutas.TabIndex = 4;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuta_CellClick);
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Todas",
            "A Tiempo",
            "A Destiempo"});
            this.cboFiltro.Location = new System.Drawing.Point(937, 536);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(191, 21);
            this.cboFiltro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(862, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Filtro:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(20, 571);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 36);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(149, 571);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(263, 571);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 36);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(377, 571);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(490, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(734, 571);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(394, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nudChofer
            // 
            this.nudChofer.Location = new System.Drawing.Point(138, 9);
            this.nudChofer.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudChofer.Name = "nudChofer";
            this.nudChofer.Size = new System.Drawing.Size(199, 20);
            this.nudChofer.TabIndex = 7;
            // 
            // nudCamion
            // 
            this.nudCamion.Location = new System.Drawing.Point(138, 70);
            this.nudCamion.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudCamion.Name = "nudCamion";
            this.nudCamion.Size = new System.Drawing.Size(199, 20);
            this.nudCamion.TabIndex = 7;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(138, 415);
            this.nudDistancia.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(199, 20);
            this.nudDistancia.TabIndex = 7;
            // 
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.nudCamion);
            this.Controls.Add(this.nudChofer);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.chkATiempo);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRutas";
            this.Text = "Gestión de Rutas";
            this.Load += new System.EventHandler(this.FrmRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.CheckBox chkATiempo;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudChofer;
        private System.Windows.Forms.NumericUpDown nudCamion;
        private System.Windows.Forms.NumericUpDown nudDistancia;
    }
}