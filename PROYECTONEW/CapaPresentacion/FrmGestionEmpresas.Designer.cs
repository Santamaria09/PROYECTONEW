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
            this.dvgEmppresa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBE = new System.Windows.Forms.TextBox();
            this.btnAE = new System.Windows.Forms.Button();
            this.btnEC = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnVC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmppresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEmppresa
            // 
            this.dvgEmppresa.AllowUserToAddRows = false;
            this.dvgEmppresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmppresa.Location = new System.Drawing.Point(88, 131);
            this.dvgEmppresa.Name = "dvgEmppresa";
            this.dvgEmppresa.Size = new System.Drawing.Size(539, 322);
            this.dvgEmppresa.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "GESTION EMPRESAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "FILTRAR:";
            // 
            // txtBE
            // 
            this.txtBE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBE.Location = new System.Drawing.Point(209, 84);
            this.txtBE.Name = "txtBE";
            this.txtBE.Size = new System.Drawing.Size(363, 29);
            this.txtBE.TabIndex = 15;
            // 
            // btnAE
            // 
            this.btnAE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAE.Location = new System.Drawing.Point(128, 471);
            this.btnAE.Name = "btnAE";
            this.btnAE.Size = new System.Drawing.Size(105, 36);
            this.btnAE.TabIndex = 16;
            this.btnAE.Text = "AGREGAR";
            this.btnAE.UseVisualStyleBackColor = true;
            // 
            // btnEC
            // 
            this.btnEC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEC.Location = new System.Drawing.Point(304, 471);
            this.btnEC.Name = "btnEC";
            this.btnEC.Size = new System.Drawing.Size(105, 36);
            this.btnEC.TabIndex = 17;
            this.btnEC.Text = "EDITAR";
            this.btnEC.UseVisualStyleBackColor = true;
            // 
            // btnDC
            // 
            this.btnDC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDC.Location = new System.Drawing.Point(484, 471);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(105, 36);
            this.btnDC.TabIndex = 18;
            this.btnDC.Text = "ELIMINAR";
            this.btnDC.UseVisualStyleBackColor = true;
            // 
            // btnVC
            // 
            this.btnVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVC.Location = new System.Drawing.Point(583, 27);
            this.btnVC.Name = "btnVC";
            this.btnVC.Size = new System.Drawing.Size(90, 36);
            this.btnVC.TabIndex = 19;
            this.btnVC.Text = "Volver";
            this.btnVC.UseVisualStyleBackColor = true;
            // 
            // FrmGestionEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 539);
            this.Controls.Add(this.btnVC);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.btnEC);
            this.Controls.Add(this.btnAE);
            this.Controls.Add(this.txtBE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgEmppresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionEmpresas";
            this.Text = "FrmGestionEmpresas";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmppresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmppresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBE;
        private System.Windows.Forms.Button btnAE;
        private System.Windows.Forms.Button btnEC;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnVC;
    }
}