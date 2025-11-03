namespace PROYECTO_FINAL
{
    partial class RAICES
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
            this.btnBi = new System.Windows.Forms.Button();
            this.btnRf = new System.Windows.Forms.Button();
            this.btnNr = new System.Windows.Forms.Button();
            this.btnSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBi
            // 
            this.btnBi.Location = new System.Drawing.Point(118, 72);
            this.btnBi.Name = "btnBi";
            this.btnBi.Size = new System.Drawing.Size(189, 113);
            this.btnBi.TabIndex = 0;
            this.btnBi.Text = "BISECCION";
            this.btnBi.UseVisualStyleBackColor = true;
            this.btnBi.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(390, 72);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(188, 113);
            this.btnRf.TabIndex = 1;
            this.btnRf.Text = "REGULA FALSI";
            this.btnRf.UseVisualStyleBackColor = true;
            this.btnRf.Click += new System.EventHandler(this.btnRf_Click);
            // 
            // btnNr
            // 
            this.btnNr.Location = new System.Drawing.Point(118, 226);
            this.btnNr.Name = "btnNr";
            this.btnNr.Size = new System.Drawing.Size(189, 113);
            this.btnNr.TabIndex = 2;
            this.btnNr.Text = "NEWTON RAPHSON";
            this.btnNr.UseVisualStyleBackColor = true;
            this.btnNr.Click += new System.EventHandler(this.btnNewton_Click);
            // 
            // btnSe
            // 
            this.btnSe.Location = new System.Drawing.Point(390, 226);
            this.btnSe.Name = "btnSe";
            this.btnSe.Size = new System.Drawing.Size(188, 113);
            this.btnSe.TabIndex = 3;
            this.btnSe.Text = "SECANTE";
            this.btnSe.UseVisualStyleBackColor = true;
            this.btnSe.Click += new System.EventHandler(this.btnSecante_Click);
            // 
            // RAICES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btnSe);
            this.Controls.Add(this.btnNr);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.btnBi);
            this.Name = "RAICES";
            this.Text = "RAICES";
            this.Load += new System.EventHandler(this.RAICES_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBi;
        private System.Windows.Forms.Button btnRf;
        private System.Windows.Forms.Button btnNr;
        private System.Windows.Forms.Button btnSe;
    }
}