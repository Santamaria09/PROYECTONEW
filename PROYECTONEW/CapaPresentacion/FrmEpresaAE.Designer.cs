namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmEpresaAE
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
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtTE = new System.Windows.Forms.TextBox();
            this.txtNE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnVC = new System.Windows.Forms.Button();
            this.btnGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDE
            // 
            this.txtDE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDE.Location = new System.Drawing.Point(208, 266);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(182, 29);
            this.txtDE.TabIndex = 2;
            // 
            // txtTE
            // 
            this.txtTE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTE.Location = new System.Drawing.Point(208, 179);
            this.txtTE.Name = "txtTE";
            this.txtTE.Size = new System.Drawing.Size(182, 29);
            this.txtTE.TabIndex = 3;
            // 
            // txtNE
            // 
            this.txtNE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNE.Location = new System.Drawing.Point(208, 95);
            this.txtNE.Name = "txtNE";
            this.txtNE.Size = new System.Drawing.Size(182, 29);
            this.txtNE.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTONEW.Properties.Resources.telefono;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(87, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "     Teléfono:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PROYECTONEW.Properties.Resources.agregar_usuario;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(87, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "     Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PROYECTONEW.Properties.Resources.clavo;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(87, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "    Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(194, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 21);
            this.label.TabIndex = 9;
            this.label.Text = "EMPRESA";
            // 
            // btnVC
            // 
            this.btnVC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVC.Location = new System.Drawing.Point(259, 362);
            this.btnVC.Name = "btnVC";
            this.btnVC.Size = new System.Drawing.Size(101, 36);
            this.btnVC.TabIndex = 20;
            this.btnVC.Text = "Volver";
            this.btnVC.UseVisualStyleBackColor = true;
            this.btnVC.Click += new System.EventHandler(this.btnVC_Click);
            // 
            // btnGE
            // 
            this.btnGE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGE.Location = new System.Drawing.Point(120, 362);
            this.btnGE.Name = "btnGE";
            this.btnGE.Size = new System.Drawing.Size(100, 36);
            this.btnGE.TabIndex = 22;
            this.btnGE.Text = "Guardar";
            this.btnGE.UseVisualStyleBackColor = true;
            this.btnGE.Click += new System.EventHandler(this.btnGE_Click);
            // 
            // FrmEpresaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 465);
            this.Controls.Add(this.btnGE);
            this.Controls.Add(this.btnVC);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNE);
            this.Controls.Add(this.txtTE);
            this.Controls.Add(this.txtDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmEpresaAE";
            this.Text = "FrmEpresaAE";
            this.Load += new System.EventHandler(this.FrmEpresaAE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtTE;
        private System.Windows.Forms.TextBox txtNE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnVC;
        private System.Windows.Forms.Button btnGE;
    }
}