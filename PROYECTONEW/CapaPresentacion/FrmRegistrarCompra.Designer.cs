namespace PROYECTONEW.CapaPresentacion
{
    partial class FrmProductos
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
            this.dvgComprad = new System.Windows.Forms.DataGridView();
            this.btnACompra = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cboECompra = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgCompra = new System.Windows.Forms.DataGridView();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComprad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompra)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgComprad
            // 
            this.dvgComprad.AllowUserToAddRows = false;
            this.dvgComprad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComprad.Location = new System.Drawing.Point(398, 21);
            this.dvgComprad.Name = "dvgComprad";
            this.dvgComprad.ReadOnly = true;
            this.dvgComprad.Size = new System.Drawing.Size(420, 223);
            this.dvgComprad.TabIndex = 3;
            this.dvgComprad.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgComprad_CellEndEdit);
            // 
            // btnACompra
            // 
            this.btnACompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACompra.Location = new System.Drawing.Point(25, 268);
            this.btnACompra.Name = "btnACompra";
            this.btnACompra.Size = new System.Drawing.Size(96, 39);
            this.btnACompra.TabIndex = 5;
            this.btnACompra.Text = "Agregar";
            this.btnACompra.UseVisualStyleBackColor = true;
            this.btnACompra.Click += new System.EventHandler(this.btnACompra_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1143, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cboECompra
            // 
            this.cboECompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboECompra.FormattingEnabled = true;
            this.cboECompra.Location = new System.Drawing.Point(109, 26);
            this.cboECompra.Name = "cboECompra";
            this.cboECompra.Size = new System.Drawing.Size(224, 29);
            this.cboECompra.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpCompra);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboECompra);
            this.panel1.Location = new System.Drawing.Point(49, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 74);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha:";
            // 
            // dtpCompra
            // 
            this.dtpCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCompra.Location = new System.Drawing.Point(499, 23);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(277, 29);
            this.dtpCompra.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Empresa:";
            // 
            // dvgCompra
            // 
            this.dvgCompra.AllowUserToAddRows = false;
            this.dvgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompra.Location = new System.Drawing.Point(20, 21);
            this.dvgCompra.Name = "dvgCompra";
            this.dvgCompra.ReadOnly = true;
            this.dvgCompra.Size = new System.Drawing.Size(341, 223);
            this.dvgCompra.TabIndex = 24;
            this.dvgCompra.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompra_CellContentDoubleClick);
            this.dvgCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompra_CellDoubleClick);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarC.Location = new System.Drawing.Point(460, 268);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(96, 39);
            this.btnLimpiarC.TabIndex = 12;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarC.Location = new System.Drawing.Point(634, 268);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(129, 39);
            this.btnEliminarC.TabIndex = 25;
            this.btnEliminarC.Text = "Eliminar Fila";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "TOTAL:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnvolver);
            this.panel2.Controls.Add(this.btnRegistrarC);
            this.panel2.Controls.Add(this.dvgCompra);
            this.panel2.Controls.Add(this.btnEliminarC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dvgComprad);
            this.panel2.Controls.Add(this.btnLimpiarC);
            this.panel2.Controls.Add(this.btnACompra);
            this.panel2.Location = new System.Drawing.Point(49, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 398);
            this.panel2.TabIndex = 26;
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(732, 365);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(96, 30);
            this.btnvolver.TabIndex = 26;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarC.Location = new System.Drawing.Point(198, 268);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(163, 39);
            this.btnRegistrarC.TabIndex = 26;
            this.btnRegistrarC.Text = "Registrar Compra";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "PUNTO DISTRIBUICION EMMANUEL";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmProductos";
            this.Text = "Estado:";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgComprad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgComprad;
        private System.Windows.Forms.Button btnACompra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboECompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgCompra;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Label label3;
    }
}