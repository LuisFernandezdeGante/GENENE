namespace CapaPresentacion
{
    partial class FrmCamiones
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtUrlFoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoCamion = new System.Windows.Forms.ComboBox();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nudKilometraje = new System.Windows.Forms.NumericUpDown();
            this.chkDisponibilidad = new System.Windows.Forms.CheckBox();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometraje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Camion";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(134, 27);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(157, 20);
            this.txtMatricula.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(134, 264);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(157, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtUrlFoto
            // 
            this.txtUrlFoto.Location = new System.Drawing.Point(132, 447);
            this.txtUrlFoto.Name = "txtUrlFoto";
            this.txtUrlFoto.Size = new System.Drawing.Size(157, 20);
            this.txtUrlFoto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(9, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Capacidad (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.Location = new System.Drawing.Point(11, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kilometraje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.Location = new System.Drawing.Point(12, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "URL Foto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.Location = new System.Drawing.Point(27, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marca";
            // 
            // cboTipoCamion
            // 
            this.cboTipoCamion.FormattingEnabled = true;
            this.cboTipoCamion.Location = new System.Drawing.Point(133, 103);
            this.cboTipoCamion.Name = "cboTipoCamion";
            this.cboTipoCamion.Size = new System.Drawing.Size(157, 21);
            this.cboTipoCamion.TabIndex = 3;
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(134, 190);
            this.nudModelo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(156, 20);
            this.nudModelo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.Location = new System.Drawing.Point(901, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Filtrar por:";
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(1003, 488);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(157, 21);
            this.cboFiltro.TabIndex = 3;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(133, 344);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(156, 20);
            this.nudCapacidad.TabIndex = 4;
            // 
            // nudKilometraje
            // 
            this.nudKilometraje.Location = new System.Drawing.Point(132, 409);
            this.nudKilometraje.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKilometraje.Name = "nudKilometraje";
            this.nudKilometraje.Size = new System.Drawing.Size(156, 20);
            this.nudKilometraje.TabIndex = 4;
            // 
            // chkDisponibilidad
            // 
            this.chkDisponibilidad.AutoSize = true;
            this.chkDisponibilidad.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.chkDisponibilidad.Location = new System.Drawing.Point(132, 492);
            this.chkDisponibilidad.Name = "chkDisponibilidad";
            this.chkDisponibilidad.Size = new System.Drawing.Size(106, 27);
            this.chkDisponibilidad.TabIndex = 5;
            this.chkDisponibilidad.Text = "Disponible";
            this.chkDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Location = new System.Drawing.Point(297, 27);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.Size = new System.Drawing.Size(875, 433);
            this.dgvCamiones.TabIndex = 6;
            this.dgvCamiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamiones_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(864, 548);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(296, 34);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(70, 552);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 33);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(201, 552);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(324, 552);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 33);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(449, 552);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 33);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(578, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCamiones);
            this.Controls.Add(this.chkDisponibilidad);
            this.Controls.Add(this.nudKilometraje);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.nudModelo);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.cboTipoCamion);
            this.Controls.Add(this.txtUrlFoto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCamiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Camiones";
            this.Load += new System.EventHandler(this.FrmCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometraje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtUrlFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoCamion;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.NumericUpDown nudKilometraje;
        private System.Windows.Forms.CheckBox chkDisponibilidad;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}