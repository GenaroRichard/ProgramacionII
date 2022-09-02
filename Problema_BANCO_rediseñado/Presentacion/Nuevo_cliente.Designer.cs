
namespace Problema_BANCO_rediseñado.Presentacion
{
    partial class Nuevo_cliente
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
            this.txt_nombreNUEVOCLIENTE = new System.Windows.Forms.TextBox();
            this.txt_apellidoNUEVOCLIENTE = new System.Windows.Forms.TextBox();
            this.dni_NUEVOCLIENTE = new System.Windows.Forms.TextBox();
            this.btn_crearCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creando nuevo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del nuevo cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido del nuevo cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI del cliente";
            // 
            // txt_nombreNUEVOCLIENTE
            // 
            this.txt_nombreNUEVOCLIENTE.Location = new System.Drawing.Point(163, 45);
            this.txt_nombreNUEVOCLIENTE.Name = "txt_nombreNUEVOCLIENTE";
            this.txt_nombreNUEVOCLIENTE.Size = new System.Drawing.Size(178, 20);
            this.txt_nombreNUEVOCLIENTE.TabIndex = 4;
            // 
            // txt_apellidoNUEVOCLIENTE
            // 
            this.txt_apellidoNUEVOCLIENTE.Location = new System.Drawing.Point(162, 92);
            this.txt_apellidoNUEVOCLIENTE.Name = "txt_apellidoNUEVOCLIENTE";
            this.txt_apellidoNUEVOCLIENTE.Size = new System.Drawing.Size(178, 20);
            this.txt_apellidoNUEVOCLIENTE.TabIndex = 5;
            // 
            // dni_NUEVOCLIENTE
            // 
            this.dni_NUEVOCLIENTE.Location = new System.Drawing.Point(108, 148);
            this.dni_NUEVOCLIENTE.Name = "dni_NUEVOCLIENTE";
            this.dni_NUEVOCLIENTE.Size = new System.Drawing.Size(178, 20);
            this.dni_NUEVOCLIENTE.TabIndex = 6;
            // 
            // btn_crearCliente
            // 
            this.btn_crearCliente.Location = new System.Drawing.Point(501, 202);
            this.btn_crearCliente.Name = "btn_crearCliente";
            this.btn_crearCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_crearCliente.TabIndex = 7;
            this.btn_crearCliente.Text = "Aceptar";
            this.btn_crearCliente.UseVisualStyleBackColor = true;
            this.btn_crearCliente.Click += new System.EventHandler(this.btn_crearCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_crearCliente);
            this.Controls.Add(this.dni_NUEVOCLIENTE);
            this.Controls.Add(this.txt_apellidoNUEVOCLIENTE);
            this.Controls.Add(this.txt_nombreNUEVOCLIENTE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nuevo_cliente";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Nuevo_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreNUEVOCLIENTE;
        private System.Windows.Forms.TextBox txt_apellidoNUEVOCLIENTE;
        private System.Windows.Forms.TextBox dni_NUEVOCLIENTE;
        private System.Windows.Forms.Button btn_crearCliente;
        private System.Windows.Forms.Button button2;
    }
}