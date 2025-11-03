namespace Regula_falsi
{
    partial class FormRegulaF
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
            this.lblFun = new System.Windows.Forms.Label();
            this.txtin1 = new System.Windows.Forms.TextBox();
            this.lblValA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValorb = new System.Windows.Forms.TextBox();
            this.lblPTD = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalc = new System.Windows.Forms.Button();
            this.BtnLim = new System.Windows.Forms.Button();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblespa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFun
            // 
            this.lblFun.AutoSize = true;
            this.lblFun.Location = new System.Drawing.Point(33, 33);
            this.lblFun.Name = "lblFun";
            this.lblFun.Size = new System.Drawing.Size(114, 16);
            this.lblFun.TabIndex = 0;
            this.lblFun.Text = "Ingrese la función:";
            // 
            // txtin1
            // 
            this.txtin1.Location = new System.Drawing.Point(178, 33);
            this.txtin1.Name = "txtin1";
            this.txtin1.Size = new System.Drawing.Size(244, 22);
            this.txtin1.TabIndex = 1;
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(33, 102);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(72, 16);
            this.lblValA.TabIndex = 2;
            this.lblValA.Text = "Valor de a:";
            this.lblValA.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(139, 99);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(95, 22);
            this.txtValorA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor de b:";
            // 
            // tbValorb
            // 
            this.tbValorb.Location = new System.Drawing.Point(375, 99);
            this.tbValorb.Name = "tbValorb";
            this.tbValorb.Size = new System.Drawing.Size(95, 22);
            this.tbValorb.TabIndex = 5;
            // 
            // lblPTD
            // 
            this.lblPTD.AutoSize = true;
            this.lblPTD.Location = new System.Drawing.Point(511, 105);
            this.lblPTD.Name = "lblPTD";
            this.lblPTD.Size = new System.Drawing.Size(260, 16);
            this.lblPTD.TabIndex = 6;
            this.lblPTD.Text = "Proporciona el error o tolerancia deseado:";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(820, 105);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(95, 22);
            this.txtError.TabIndex = 7;
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DGV1.Location = new System.Drawing.Point(57, 234);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(1047, 188);
            this.DGV1.TabIndex = 8;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "a";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "b";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F(a)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "F(b)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "xi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "F(xi)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Error";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(375, 177);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(113, 33);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // BtnLim
            // 
            this.BtnLim.Location = new System.Drawing.Point(561, 177);
            this.BtnLim.Name = "BtnLim";
            this.BtnLim.Size = new System.Drawing.Size(111, 33);
            this.BtnLim.TabIndex = 10;
            this.BtnLim.Text = "Limpiar";
            this.BtnLim.UseVisualStyleBackColor = true;
            this.BtnLim.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(372, 455);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(171, 16);
            this.lblRa.TabIndex = 11;
            this.lblRa.Text = "LA RAÍZ APRÓXIMADA ES:\r\n";
            // 
            // lblespa
            // 
            this.lblespa.AutoSize = true;
            this.lblespa.Location = new System.Drawing.Point(558, 455);
            this.lblespa.Name = "lblespa";
            this.lblespa.Size = new System.Drawing.Size(11, 32);
            this.lblespa.TabIndex = 12;
            this.lblespa.Text = "-\r\n\r\n";
            // 
            // FormRegulaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 500);
            this.Controls.Add(this.lblespa);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.BtnLim);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblPTD);
            this.Controls.Add(this.tbValorb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValA);
            this.Controls.Add(this.txtin1);
            this.Controls.Add(this.lblFun);
            this.Name = "FormRegulaF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFun;
        private System.Windows.Forms.TextBox txtin1;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValorb;
        private System.Windows.Forms.Label lblPTD;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button BtnLim;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblespa;
    }
}

