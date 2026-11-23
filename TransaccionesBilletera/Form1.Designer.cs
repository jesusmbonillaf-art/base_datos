namespace TransaccionesBilletera
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcesarReversion = new System.Windows.Forms.Button();
            this.btnSolicitarReversion = new System.Windows.Forms.Button();
            this.txtCodigoReversion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblCola = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMostrarArbol = new System.Windows.Forms.Button();
            this.cmbRecorridos = new System.Windows.Forms.ComboBox();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACCIONES DE BILLETERA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(58, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar operación";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(113, 60);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 154);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(113, 116);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cuenta destino";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(113, 87);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cuenta origen";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(113, 25);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOperaciones);
            this.groupBox2.Location = new System.Drawing.Point(12, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial";
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(7, 32);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.Size = new System.Drawing.Size(953, 230);
            this.dgvOperaciones.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultado);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(329, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 177);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar operación";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 55);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(10, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "-";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(184, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(53, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPendientes);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnProcesarReversion);
            this.groupBox4.Controls.Add(this.btnSolicitarReversion);
            this.groupBox4.Controls.Add(this.txtCodigoReversion);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(642, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 365);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reversión";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(7, 138);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(13, 13);
            this.lblPendientes.TabIndex = 5;
            this.lblPendientes.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Solicitudes pendientes:";
            // 
            // btnProcesarReversion
            // 
            this.btnProcesarReversion.Location = new System.Drawing.Point(123, 70);
            this.btnProcesarReversion.Name = "btnProcesarReversion";
            this.btnProcesarReversion.Size = new System.Drawing.Size(111, 23);
            this.btnProcesarReversion.TabIndex = 3;
            this.btnProcesarReversion.Text = "Procesar reversión";
            this.btnProcesarReversion.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarReversion
            // 
            this.btnSolicitarReversion.Location = new System.Drawing.Point(10, 71);
            this.btnSolicitarReversion.Name = "btnSolicitarReversion";
            this.btnSolicitarReversion.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitarReversion.TabIndex = 2;
            this.btnSolicitarReversion.Text = "Solicitar reversión";
            this.btnSolicitarReversion.UseVisualStyleBackColor = true;
            // 
            // txtCodigoReversion
            // 
            this.txtCodigoReversion.Location = new System.Drawing.Point(53, 32);
            this.txtCodigoReversion.Name = "txtCodigoReversion";
            this.txtCodigoReversion.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoReversion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCola);
            this.groupBox5.Controls.Add(this.btnAtender);
            this.groupBox5.Controls.Add(this.lblCola);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(58, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 166);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cola";
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(6, 67);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.Size = new System.Drawing.Size(269, 93);
            this.txtCola.TabIndex = 4;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(181, 27);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 23);
            this.btnAtender.TabIndex = 4;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(73, 32);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(13, 13);
            this.lblCola.TabIndex = 6;
            this.lblCola.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "En cola: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMostrarArbol);
            this.groupBox6.Controls.Add(this.cmbRecorridos);
            this.groupBox6.Controls.Add(this.txtArbol);
            this.groupBox6.Location = new System.Drawing.Point(345, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 166);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Busqueda por código";
            // 
            // btnMostrarArbol
            // 
            this.btnMostrarArbol.Location = new System.Drawing.Point(194, 27);
            this.btnMostrarArbol.Name = "btnMostrarArbol";
            this.btnMostrarArbol.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarArbol.TabIndex = 6;
            this.btnMostrarArbol.Text = "Mostrar";
            this.btnMostrarArbol.UseVisualStyleBackColor = true;
            // 
            // cmbRecorridos
            // 
            this.cmbRecorridos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecorridos.FormattingEnabled = true;
            this.cmbRecorridos.Location = new System.Drawing.Point(9, 29);
            this.cmbRecorridos.Name = "cmbRecorridos";
            this.cmbRecorridos.Size = new System.Drawing.Size(121, 21);
            this.cmbRecorridos.TabIndex = 12;
            // 
            // txtArbol
            // 
            this.txtArbol.Location = new System.Drawing.Point(9, 67);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ReadOnly = true;
            this.txtArbol.Size = new System.Drawing.Size(269, 93);
            this.txtArbol.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 726);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Transacciones de Billetera  ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProcesarReversion;
        private System.Windows.Forms.Button btnSolicitarReversion;
        private System.Windows.Forms.TextBox txtCodigoReversion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMostrarArbol;
        private System.Windows.Forms.ComboBox cmbRecorridos;
        private System.Windows.Forms.TextBox txtArbol;
    }
}

