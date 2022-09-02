
namespace Problema_BANCO_rediseñado.Presentacion
{
    partial class Info_cliente
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
            this.components = new System.ComponentModel.Container();
            this.lbl_cartelBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_apellidocliente = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BTN_NuevaCuenta = new System.Windows.Forms.Button();
            this.bancoDataSet = new Problema_BANCO_rediseñado.bancoDataSet();
            this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaTableAdapter = new Problema_BANCO_rediseñado.bancoDataSetTableAdapters.cuentaTableAdapter();
            this.bancoDataSet1 = new Problema_BANCO_rediseñado.bancoDataSet();
            this.bancoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbuCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CUENTACLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ult_movCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RestarSaldoDGV = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cartelBienvenida
            // 
            this.lbl_cartelBienvenida.AutoSize = true;
            this.lbl_cartelBienvenida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartelBienvenida.Location = new System.Drawing.Point(315, 9);
            this.lbl_cartelBienvenida.Name = "lbl_cartelBienvenida";
            this.lbl_cartelBienvenida.Size = new System.Drawing.Size(153, 19);
            this.lbl_cartelBienvenida.TabIndex = 0;
            this.lbl_cartelBienvenida.Text = "INFO BIENVENIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "apellido del cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dni del cliente:";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(140, 58);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(153, 20);
            this.txt_nombreCliente.TabIndex = 4;
            // 
            // txt_apellidocliente
            // 
            this.txt_apellidocliente.Location = new System.Drawing.Point(140, 110);
            this.txt_apellidocliente.Name = "txt_apellidocliente";
            this.txt_apellidocliente.Size = new System.Drawing.Size(153, 20);
            this.txt_apellidocliente.TabIndex = 5;
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Location = new System.Drawing.Point(140, 165);
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.Size = new System.Drawing.Size(130, 20);
            this.txt_dniCliente.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BTN_NuevaCuenta
            // 
            this.BTN_NuevaCuenta.Location = new System.Drawing.Point(568, 415);
            this.BTN_NuevaCuenta.Name = "BTN_NuevaCuenta";
            this.BTN_NuevaCuenta.Size = new System.Drawing.Size(108, 23);
            this.BTN_NuevaCuenta.TabIndex = 9;
            this.BTN_NuevaCuenta.Text = "NUEVA CUENTA";
            this.BTN_NuevaCuenta.UseVisualStyleBackColor = true;
            this.BTN_NuevaCuenta.Click += new System.EventHandler(this.BTN_NuevaCuenta_Click);
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuentaBindingSource
            // 
            this.cuentaBindingSource.DataMember = "cuenta";
            this.cuentaBindingSource.DataSource = this.bancoDataSet;
            // 
            // cuentaTableAdapter
            // 
            this.cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // bancoDataSet1
            // 
            this.bancoDataSet1.DataSetName = "bancoDataSet";
            this.bancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoDataSet1BindingSource
            // 
            this.bancoDataSet1BindingSource.DataSource = this.bancoDataSet1;
            this.bancoDataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbuCLM,
            this.TIPO_CUENTACLM,
            this.ult_movCLM,
            this.saldoCLM,
            this.dgv_delete,
            this.RestarSaldoDGV});
            this.dataGridView1.Location = new System.Drawing.Point(41, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbuCLM
            // 
            this.cbuCLM.HeaderText = "CBU";
            this.cbuCLM.Name = "cbuCLM";
            // 
            // TIPO_CUENTACLM
            // 
            this.TIPO_CUENTACLM.HeaderText = "TIPO DE CUENTA";
            this.TIPO_CUENTACLM.Name = "TIPO_CUENTACLM";
            this.TIPO_CUENTACLM.Width = 180;
            // 
            // ult_movCLM
            // 
            this.ult_movCLM.HeaderText = "ULTIMO MOVIMIENTO";
            this.ult_movCLM.Name = "ult_movCLM";
            // 
            // saldoCLM
            // 
            this.saldoCLM.HeaderText = "SALDO ";
            this.saldoCLM.Name = "saldoCLM";
            // 
            // dgv_delete
            // 
            this.dgv_delete.HeaderText = "BORRAR";
            this.dgv_delete.Name = "dgv_delete";
            this.dgv_delete.Text = "BORRAR";
            this.dgv_delete.UseColumnTextForButtonValue = true;
            // 
            // RestarSaldoDGV
            // 
            this.RestarSaldoDGV.HeaderText = "Retiro de dinero";
            this.RestarSaldoDGV.Name = "RestarSaldoDGV";
            this.RestarSaldoDGV.Text = "Retiro de dinero";
            this.RestarSaldoDGV.UseColumnTextForButtonValue = true;
            // 
            // Info_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_NuevaCuenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.txt_apellidocliente);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cartelBienvenida);
            this.Name = "Info_cliente";
            this.Text = "Info_cliente";
            this.Load += new System.EventHandler(this.Info_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cartelBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_apellidocliente;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BTN_NuevaCuenta;
        private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource cuentaBindingSource;
        private bancoDataSetTableAdapters.cuentaTableAdapter cuentaTableAdapter;
        private bancoDataSet bancoDataSet1;
        private System.Windows.Forms.BindingSource bancoDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbuCLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CUENTACLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ult_movCLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoCLM;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_delete;
        private System.Windows.Forms.DataGridViewButtonColumn RestarSaldoDGV;
    }
}