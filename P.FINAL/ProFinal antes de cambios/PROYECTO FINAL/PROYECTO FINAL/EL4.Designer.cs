namespace PROYECTO_FINAL
{
    partial class EL4
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbTamaño = new System.Windows.Forms.GroupBox();
            this.rb33 = new System.Windows.Forms.RadioButton();
            this.rb22 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbMétodos = new System.Windows.Forms.GroupBox();
            this.rbGauss = new System.Windows.Forms.RadioButton();
            this.txtX33 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtX32 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtX31 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtX23 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtX22 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtX21 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtX13 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX12 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTamaño.SuspendLayout();
            this.gbMétodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(195, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(304, 34);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Cerrar el programa";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbTamaño
            // 
            this.gbTamaño.Controls.Add(this.rb33);
            this.gbTamaño.Controls.Add(this.rb22);
            this.gbTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTamaño.Location = new System.Drawing.Point(474, 218);
            this.gbTamaño.Name = "gbTamaño";
            this.gbTamaño.Size = new System.Drawing.Size(200, 55);
            this.gbTamaño.TabIndex = 68;
            this.gbTamaño.TabStop = false;
            this.gbTamaño.Text = "Tamaño de la matriz";
            // 
            // rb33
            // 
            this.rb33.AutoSize = true;
            this.rb33.Location = new System.Drawing.Point(111, 22);
            this.rb33.Name = "rb33";
            this.rb33.Size = new System.Drawing.Size(51, 20);
            this.rb33.TabIndex = 1;
            this.rb33.TabStop = true;
            this.rb33.Text = "3x3";
            this.rb33.UseVisualStyleBackColor = true;
            this.rb33.CheckedChanged += new System.EventHandler(this.rb33_CheckedChanged);
            // 
            // rb22
            // 
            this.rb22.AutoSize = true;
            this.rb22.Location = new System.Drawing.Point(33, 23);
            this.rb22.Name = "rb22";
            this.rb22.Size = new System.Drawing.Size(51, 20);
            this.rb22.TabIndex = 0;
            this.rb22.TabStop = true;
            this.rb22.Text = "2x2";
            this.rb22.UseVisualStyleBackColor = true;
            this.rb22.CheckedChanged += new System.EventHandler(this.rb22_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(368, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 20);
            this.label20.TabIndex = 75;
            this.label20.Text = "=";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(368, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 20);
            this.label19.TabIndex = 74;
            this.label19.Text = "=";
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(392, 180);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(34, 22);
            this.txtR3.TabIndex = 73;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(392, 121);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(34, 22);
            this.txtR2.TabIndex = 72;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(392, 65);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(34, 22);
            this.txtR1.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(368, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 20);
            this.label21.TabIndex = 70;
            this.label21.Text = "=";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(262, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 33);
            this.btnLimpiar.TabIndex = 69;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCalcular.Location = new System.Drawing.Point(126, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 33);
            this.btnCalcular.TabIndex = 67;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbMétodos
            // 
            this.gbMétodos.Controls.Add(this.rbGauss);
            this.gbMétodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMétodos.Location = new System.Drawing.Point(474, 61);
            this.gbMétodos.Name = "gbMétodos";
            this.gbMétodos.Size = new System.Drawing.Size(200, 140);
            this.gbMétodos.TabIndex = 66;
            this.gbMétodos.TabStop = false;
            this.gbMétodos.Text = "Métodos";
            // 
            // rbGauss
            // 
            this.rbGauss.AutoSize = true;
            this.rbGauss.Location = new System.Drawing.Point(6, 57);
            this.rbGauss.Name = "rbGauss";
            this.rbGauss.Size = new System.Drawing.Size(72, 20);
            this.rbGauss.TabIndex = 0;
            this.rbGauss.TabStop = true;
            this.rbGauss.Text = "Gauss";
            this.rbGauss.UseVisualStyleBackColor = true;
            // 
            // txtX33
            // 
            this.txtX33.Location = new System.Drawing.Point(300, 179);
            this.txtX33.Name = "txtX33";
            this.txtX33.Size = new System.Drawing.Size(34, 22);
            this.txtX33.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(348, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 64;
            this.label13.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(332, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "X";
            // 
            // txtX32
            // 
            this.txtX32.Location = new System.Drawing.Point(211, 179);
            this.txtX32.Name = "txtX32";
            this.txtX32.Size = new System.Drawing.Size(34, 22);
            this.txtX32.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(259, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 61;
            this.label15.Text = "2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(243, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "X";
            // 
            // txtX31
            // 
            this.txtX31.Location = new System.Drawing.Point(126, 178);
            this.txtX31.Name = "txtX31";
            this.txtX31.Size = new System.Drawing.Size(34, 22);
            this.txtX31.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(174, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 15);
            this.label17.TabIndex = 58;
            this.label17.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(158, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "X";
            // 
            // txtX23
            // 
            this.txtX23.Location = new System.Drawing.Point(300, 120);
            this.txtX23.Name = "txtX23";
            this.txtX23.Size = new System.Drawing.Size(34, 22);
            this.txtX23.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(348, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 55;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(332, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "X";
            // 
            // txtX22
            // 
            this.txtX22.Location = new System.Drawing.Point(211, 120);
            this.txtX22.Name = "txtX22";
            this.txtX22.Size = new System.Drawing.Size(34, 22);
            this.txtX22.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(259, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(243, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "X";
            // 
            // txtX21
            // 
            this.txtX21.Location = new System.Drawing.Point(126, 119);
            this.txtX21.Name = "txtX21";
            this.txtX21.Size = new System.Drawing.Size(34, 22);
            this.txtX21.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(174, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(158, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "X";
            // 
            // txtX13
            // 
            this.txtX13.Location = new System.Drawing.Point(300, 64);
            this.txtX13.Name = "txtX13";
            this.txtX13.Size = new System.Drawing.Size(34, 22);
            this.txtX13.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(348, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(332, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "X";
            // 
            // txtX12
            // 
            this.txtX12.Location = new System.Drawing.Point(211, 64);
            this.txtX12.Name = "txtX12";
            this.txtX12.Size = new System.Drawing.Size(34, 22);
            this.txtX12.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(259, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(243, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "X";
            // 
            // txtX11
            // 
            this.txtX11.Location = new System.Drawing.Point(126, 63);
            this.txtX11.Name = "txtX11";
            this.txtX11.Size = new System.Drawing.Size(34, 22);
            this.txtX11.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(174, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(158, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "X";
            // 
            // EL4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbTamaño);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtR3);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbMétodos);
            this.Controls.Add(this.txtX33);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtX32);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtX31);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtX23);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtX22);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtX21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtX13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EL4";
            this.Text = "EL4";
            this.Load += new System.EventHandler(this.EL4_Load);
            this.gbTamaño.ResumeLayout(false);
            this.gbTamaño.PerformLayout();
            this.gbMétodos.ResumeLayout(false);
            this.gbMétodos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbTamaño;
        private System.Windows.Forms.RadioButton rb33;
        private System.Windows.Forms.RadioButton rb22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbMétodos;
        private System.Windows.Forms.RadioButton rbGauss;
        private System.Windows.Forms.TextBox txtX33;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtX32;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtX31;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtX23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtX22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtX21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtX13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}