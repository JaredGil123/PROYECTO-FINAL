namespace NewRapshon
{
    partial class FormNewton
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MNR = new System.Windows.Forms.Label();
            this.txtfx = new System.Windows.Forms.TextBox();
            this.txterror = new System.Windows.Forms.TextBox();
            this.txtxo = new System.Windows.Forms.TextBox();
            this.lblfx = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblxo = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // MNR
            // 
            this.MNR.AutoSize = true;
            this.MNR.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MNR.Location = new System.Drawing.Point(226, 22);
            this.MNR.Name = "MNR";
            this.MNR.Size = new System.Drawing.Size(352, 35);
            this.MNR.TabIndex = 0;
            this.MNR.Text = "MÉTODO NEW RAPSHON";
            // 
            // txtfx
            // 
            this.txtfx.Location = new System.Drawing.Point(68, 122);
            this.txtfx.Name = "txtfx";
            this.txtfx.Size = new System.Drawing.Size(100, 22);
            this.txtfx.TabIndex = 1;
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(327, 122);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(100, 22);
            this.txterror.TabIndex = 2;
            // 
            // txtxo
            // 
            this.txtxo.Location = new System.Drawing.Point(568, 122);
            this.txtxo.Name = "txtxo";
            this.txtxo.Size = new System.Drawing.Size(100, 22);
            this.txtxo.TabIndex = 3;
            // 
            // lblfx
            // 
            this.lblfx.AutoSize = true;
            this.lblfx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfx.Location = new System.Drawing.Point(72, 77);
            this.lblfx.Name = "lblfx";
            this.lblfx.Size = new System.Drawing.Size(59, 20);
            this.lblfx.TabIndex = 5;
            this.lblfx.Text = "F(xo):";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblerror.Location = new System.Drawing.Point(323, 77);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(52, 20);
            this.lblerror.TabIndex = 6;
            this.lblerror.Text = "Error";
            // 
            // lblxo
            // 
            this.lblxo.AutoSize = true;
            this.lblxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblxo.Location = new System.Drawing.Point(573, 77);
            this.lblxo.Name = "lblxo";
            this.lblxo.Size = new System.Drawing.Size(37, 20);
            this.lblxo.TabIndex = 7;
            this.lblxo.Text = "Xo:";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Silver;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(566, 192);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(102, 39);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(100, 247);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(584, 169);
            this.data.TabIndex = 9;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.Location = new System.Drawing.Point(133, 192);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 39);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(301, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tabla de iteraciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblxo);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblfx);
            this.Controls.Add(this.txtxo);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.txtfx);
            this.Controls.Add(this.MNR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MNR;
        private System.Windows.Forms.TextBox txtfx;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.TextBox txtxo;
        private System.Windows.Forms.Label lblfx;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblxo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}

