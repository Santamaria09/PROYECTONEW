namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmGestonProductos
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
            this.dvgGestionp = new System.Windows.Forms.DataGridView();
            this.btnVv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNproducto = new System.Windows.Forms.TextBox();
            this.txtSproducto = new System.Windows.Forms.TextBox();
            this.txtPproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPeso = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.cboEA = new System.Windows.Forms.ComboBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGestionp)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgGestionp
            // 
            this.dvgGestionp.AllowUserToAddRows = false;
            this.dvgGestionp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGestionp.Location = new System.Drawing.Point(55, 117);
            this.dvgGestionp.Name = "dvgGestionp";
            this.dvgGestionp.Size = new System.Drawing.Size(440, 322);
            this.dvgGestionp.TabIndex = 12;
            this.dvgGestionp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGestionp_CellClick);
            // 
            // btnVv
            // 
            this.btnVv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVv.Location = new System.Drawing.Point(80, 461);
            this.btnVv.Name = "btnVv";
            this.btnVv.Size = new System.Drawing.Size(75, 29);
            this.btnVv.TabIndex = 14;
            this.btnVv.Text = "Volver";
            this.btnVv.UseVisualStyleBackColor = true;
            this.btnVv.Click += new System.EventHandler(this.btnVv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "FILTRAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "GESTION DE PRODUCTOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNproducto
            // 
            this.txtNproducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNproducto.Location = new System.Drawing.Point(518, 118);
            this.txtNproducto.Name = "txtNproducto";
            this.txtNproducto.Size = new System.Drawing.Size(141, 29);
            this.txtNproducto.TabIndex = 18;
            // 
            // txtSproducto
            // 
            this.txtSproducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSproducto.Location = new System.Drawing.Point(518, 210);
            this.txtSproducto.Name = "txtSproducto";
            this.txtSproducto.Size = new System.Drawing.Size(138, 29);
            this.txtSproducto.TabIndex = 19;
            // 
            // txtPproducto
            // 
            this.txtPproducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPproducto.Location = new System.Drawing.Point(518, 305);
            this.txtPproducto.Name = "txtPproducto";
            this.txtPproducto.Size = new System.Drawing.Size(138, 29);
            this.txtPproducto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Serie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Peso:";
            // 
            // cboPeso
            // 
            this.cboPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeso.FormattingEnabled = true;
            this.cboPeso.Location = new System.Drawing.Point(703, 118);
            this.cboPeso.Name = "cboPeso";
            this.cboPeso.Size = new System.Drawing.Size(112, 29);
            this.cboPeso.TabIndex = 26;
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(703, 305);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(112, 29);
            this.cboEstado.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Empresa:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(703, 210);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(112, 29);
            this.cboEmpresa.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(555, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Stock:";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(621, 374);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(138, 29);
            this.txtstock.TabIndex = 31;
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(703, 434);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(96, 29);
            this.btnLIMPIAR.TabIndex = 32;
            this.btnLIMPIAR.Text = "LIMPIAR";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // cboEA
            // 
            this.cboEA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEA.FormattingEnabled = true;
            this.cboEA.Location = new System.Drawing.Point(152, 67);
            this.cboEA.Name = "cboEA";
            this.cboEA.Size = new System.Drawing.Size(254, 29);
            this.cboEA.TabIndex = 34;
            this.cboEA.SelectedIndexChanged += new System.EventHandler(this.cboEA_SelectedIndexChanged);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Location = new System.Drawing.Point(539, 434);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(103, 29);
            this.btnAGREGAR.TabIndex = 35;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // FrmGestonProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 513);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.cboEA);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPproducto);
            this.Controls.Add(this.txtSproducto);
            this.Controls.Add(this.txtNproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVv);
            this.Controls.Add(this.dvgGestionp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestonProductos";
            this.Text = "FrmGestonProductos";
            this.Load += new System.EventHandler(this.FrmGestonProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGestionp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgGestionp;
        private System.Windows.Forms.Button btnVv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNproducto;
        private System.Windows.Forms.TextBox txtSproducto;
        private System.Windows.Forms.TextBox txtPproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPeso;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.ComboBox cboEA;
        private System.Windows.Forms.Button btnAGREGAR;
    }
}