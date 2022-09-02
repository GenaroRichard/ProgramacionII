
namespace Problema_BANCO_rediseñado
{
    partial class Retiro_dinero
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lbl_cuentainfo = new System.Windows.Forms.Label();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETIRAR DINERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad a retirar";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(119, 41);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(149, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // lbl_cuentainfo
            // 
            this.lbl_cuentainfo.AutoSize = true;
            this.lbl_cuentainfo.Location = new System.Drawing.Point(26, 115);
            this.lbl_cuentainfo.Name = "lbl_cuentainfo";
            this.lbl_cuentainfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_cuentainfo.TabIndex = 3;
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(119, 68);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(93, 23);
            this.btn_retirar.TabIndex = 4;
            this.btn_retirar.Text = "Retirar dinero";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(479, 105);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(245, 115);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(0, 13);
            this.lbl_saldo.TabIndex = 6;
            // 
            // Retiro_dinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 137);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.lbl_cuentainfo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Retiro_dinero";
            this.Text = "Retiro_dinero";
            this.Load += new System.EventHandler(this.Retiro_dinero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lbl_cuentainfo;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_saldo;
    }
}