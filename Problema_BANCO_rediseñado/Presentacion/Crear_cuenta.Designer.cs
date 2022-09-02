
namespace Problema_BANCO_rediseñado.Presentacion
{
    partial class Crear_cuenta
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
            this.lblCreandoCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_tiposCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTNGuardarCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDocumetoCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreandoCuenta
            // 
            this.lblCreandoCuenta.AutoSize = true;
            this.lblCreandoCuenta.Location = new System.Drawing.Point(254, 9);
            this.lblCreandoCuenta.Name = "lblCreandoCuenta";
            this.lblCreandoCuenta.Size = new System.Drawing.Size(110, 13);
            this.lblCreandoCuenta.TabIndex = 0;
            this.lblCreandoCuenta.Text = " CREANDO CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de cuenta:";
            // 
            // CB_tiposCuenta
            // 
            this.CB_tiposCuenta.FormattingEnabled = true;
            this.CB_tiposCuenta.Location = new System.Drawing.Point(137, 39);
            this.CB_tiposCuenta.Name = "CB_tiposCuenta";
            this.CB_tiposCuenta.Size = new System.Drawing.Size(300, 21);
            this.CB_tiposCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ultimo Movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(137, 131);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(123, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // BTNGuardarCuenta
            // 
            this.BTNGuardarCuenta.Location = new System.Drawing.Point(137, 157);
            this.BTNGuardarCuenta.Name = "BTNGuardarCuenta";
            this.BTNGuardarCuenta.Size = new System.Drawing.Size(110, 23);
            this.BTNGuardarCuenta.TabIndex = 7;
            this.BTNGuardarCuenta.Text = "CREAR CUENTA";
            this.BTNGuardarCuenta.UseVisualStyleBackColor = true;
            this.BTNGuardarCuenta.Click += new System.EventHandler(this.BTNGuardarCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(557, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDocumetoCliente
            // 
            this.lblDocumetoCliente.AutoSize = true;
            this.lblDocumetoCliente.Location = new System.Drawing.Point(13, 212);
            this.lblDocumetoCliente.Name = "lblDocumetoCliente";
            this.lblDocumetoCliente.Size = new System.Drawing.Size(149, 13);
            this.lblDocumetoCliente.TabIndex = 9;
            this.lblDocumetoCliente.Text = "DOCUMENTO DEL CLIENTE";
            // 
            // Crear_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 237);
            this.Controls.Add(this.lblDocumetoCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BTNGuardarCuenta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_tiposCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreandoCuenta);
            this.Name = "Crear_cuenta";
            this.Text = "Crear_cuenta";
            this.Load += new System.EventHandler(this.Crear_cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreandoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_tiposCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BTNGuardarCuenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDocumetoCliente;
    }
}