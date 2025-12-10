namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmGestionClientes
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
            this.btnDC = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.btnEC = new System.Windows.Forms.Button();
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILTRAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "GESTION DE CLIENTES";
            // 
            // btnDC
            // 
            this.btnDC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDC.Location = new System.Drawing.Point(477, 469);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(105, 36);
            this.btnDC.TabIndex = 6;
            this.btnDC.Text = "ELIMINAR";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // btnAC
            // 
            this.btnAC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(125, 469);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(105, 36);
            this.btnAC.TabIndex = 8;
            this.btnAC.Text = "AGREGAR";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // txtBC
            // 
            this.txtBC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBC.Location = new System.Drawing.Point(219, 80);
            this.txtBC.Name = "txtBC";
            this.txtBC.Size = new System.Drawing.Size(363, 29);
            this.txtBC.TabIndex = 9;
            this.txtBC.TextChanged += new System.EventHandler(this.txtBC_TextChanged);
            // 
            // btnEC
            // 
            this.btnEC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEC.Location = new System.Drawing.Point(295, 469);
            this.btnEC.Name = "btnEC";
            this.btnEC.Size = new System.Drawing.Size(105, 36);
            this.btnEC.TabIndex = 10;
            this.btnEC.Text = "EDITAR";
            this.btnEC.UseVisualStyleBackColor = true;
            this.btnEC.Click += new System.EventHandler(this.btnEC_Click);
            // 
            // dvgCliente
            // 
            this.dvgCliente.AllowUserToAddRows = false;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.Location = new System.Drawing.Point(89, 129);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.Size = new System.Drawing.Size(539, 322);
            this.dvgCliente.TabIndex = 11;
            this.dvgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellClick);
            this.dvgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellContentClick);
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(714, 536);
            this.Controls.Add(this.dvgCliente);
            this.Controls.Add(this.btnEC);
            this.Controls.Add(this.txtBC);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGestionClientes";
            this.Text = "FrmGestionClientes";
            this.Load += new System.EventHandler(this.FrmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.Button btnEC;
        private System.Windows.Forms.DataGridView dvgCliente;
    }
}