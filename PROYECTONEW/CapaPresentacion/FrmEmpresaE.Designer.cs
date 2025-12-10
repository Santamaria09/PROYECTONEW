namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmEmpresaE
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtET = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtED = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnGE = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PROYECTONEW.Properties.Resources.agregar_usuario;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(80, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "     Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTONEW.Properties.Resources.telefono;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(80, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "     Teléfono:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PROYECTONEW.Properties.Resources.clavo;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(80, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "    Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtET
            // 
            this.txtET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtET.Location = new System.Drawing.Point(191, 190);
            this.txtET.Name = "txtET";
            this.txtET.Size = new System.Drawing.Size(182, 29);
            this.txtET.TabIndex = 11;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEN.Location = new System.Drawing.Point(191, 101);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(182, 29);
            this.txtEN.TabIndex = 12;
            // 
            // txtED
            // 
            this.txtED.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtED.Location = new System.Drawing.Point(191, 277);
            this.txtED.Name = "txtED";
            this.txtED.Size = new System.Drawing.Size(182, 29);
            this.txtED.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(158, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 21);
            this.label.TabIndex = 14;
            this.label.Text = "ELIMINAR EMPRESA";
            // 
            // btnGE
            // 
            this.btnGE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGE.Location = new System.Drawing.Point(248, 370);
            this.btnGE.Name = "btnGE";
            this.btnGE.Size = new System.Drawing.Size(100, 36);
            this.btnGE.TabIndex = 23;
            this.btnGE.Text = "Cancelar";
            this.btnGE.UseVisualStyleBackColor = true;
            this.btnGE.Click += new System.EventHandler(this.btnGE_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(104, 370);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(100, 36);
            this.btnE.TabIndex = 25;
            this.btnE.Text = "Eliminar";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // FrmEmpresaE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 469);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnGE);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtED);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtET);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FrmEmpresaE";
            this.Text = "FrmEmpresa";
            this.Load += new System.EventHandler(this.FrmEmpresaE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtET;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtED;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnGE;
        private System.Windows.Forms.Button btnE;
    }
}