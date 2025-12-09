namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmGestionEmpresas
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
            this.dvgEmpresa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBE = new System.Windows.Forms.TextBox();
            this.btnAE = new System.Windows.Forms.Button();
            this.btnEE = new System.Windows.Forms.Button();
            this.btnEM = new System.Windows.Forms.Button();
            this.btnVC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEmpresa
            // 
            this.dvgEmpresa.AllowUserToAddRows = false;
            this.dvgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpresa.Location = new System.Drawing.Point(88, 115);
            this.dvgEmpresa.Name = "dvgEmpresa";
            this.dvgEmpresa.Size = new System.Drawing.Size(464, 322);
            this.dvgEmpresa.TabIndex = 12;
            this.dvgEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmpresa_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "GESTION EMPRESAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "FILTRAR:";
            // 
            // txtBE
            // 
            this.txtBE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBE.Location = new System.Drawing.Point(209, 68);
            this.txtBE.Name = "txtBE";
            this.txtBE.Size = new System.Drawing.Size(283, 29);
            this.txtBE.TabIndex = 15;
            this.txtBE.TextChanged += new System.EventHandler(this.txtBE_TextChanged);
            // 
            // btnAE
            // 
            this.btnAE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAE.Location = new System.Drawing.Point(68, 460);
            this.btnAE.Name = "btnAE";
            this.btnAE.Size = new System.Drawing.Size(105, 36);
            this.btnAE.TabIndex = 16;
            this.btnAE.Text = "AGREGAR";
            this.btnAE.UseVisualStyleBackColor = true;
            this.btnAE.Click += new System.EventHandler(this.btnAE_Click);
            // 
            // btnEE
            // 
            this.btnEE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEE.Location = new System.Drawing.Point(209, 460);
            this.btnEE.Name = "btnEE";
            this.btnEE.Size = new System.Drawing.Size(105, 36);
            this.btnEE.TabIndex = 17;
            this.btnEE.Text = "EDITAR";
            this.btnEE.UseVisualStyleBackColor = true;
            this.btnEE.Click += new System.EventHandler(this.btnEE_Click);
            // 
            // btnEM
            // 
            this.btnEM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM.Location = new System.Drawing.Point(333, 460);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(105, 36);
            this.btnEM.TabIndex = 18;
            this.btnEM.Text = "ELIMINAR";
            this.btnEM.UseVisualStyleBackColor = true;
            this.btnEM.Click += new System.EventHandler(this.btnEM_Click);
            // 
            // btnVC
            // 
            this.btnVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVC.Location = new System.Drawing.Point(468, 460);
            this.btnVC.Name = "btnVC";
            this.btnVC.Size = new System.Drawing.Size(96, 36);
            this.btnVC.TabIndex = 19;
            this.btnVC.Text = "Volver";
            this.btnVC.UseVisualStyleBackColor = true;
            this.btnVC.Click += new System.EventHandler(this.btnVC_Click);
            // 
            // FrmGestionEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 513);
            this.Controls.Add(this.btnVC);
            this.Controls.Add(this.btnEM);
            this.Controls.Add(this.btnEE);
            this.Controls.Add(this.btnAE);
            this.Controls.Add(this.txtBE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGestionEmpresas";
            this.Text = "FrmGestionEmpresas";
            this.Load += new System.EventHandler(this.FrmGestionEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBE;
        private System.Windows.Forms.Button btnAE;
        private System.Windows.Forms.Button btnEE;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.Button btnVC;
    }
}