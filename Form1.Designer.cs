namespace MicroDigital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericPower = new System.Windows.Forms.NumericUpDown();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.BoxTime = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.LblAquecimento = new System.Windows.Forms.Label();
            this.comboProgramas = new System.Windows.Forms.ComboBox();
            this.lblCombo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Potência";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(705, 258);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(55, 36);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Iniciar";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(576, 58);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(209, 67);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericPower
            // 
            this.numericPower.Location = new System.Drawing.Point(605, 274);
            this.numericPower.Name = "numericPower";
            this.numericPower.Size = new System.Drawing.Size(47, 20);
            this.numericPower.TabIndex = 10;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(600, 129);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 38);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(658, 128);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 38);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(716, 129);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 36);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(600, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 37);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(658, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 37);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(716, 174);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 37);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(602, 214);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 37);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(658, 214);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 37);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(716, 217);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 35);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(658, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 36);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(602, 300);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(158, 50);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Cancelar / Pausar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BoxTime
            // 
            this.BoxTime.Location = new System.Drawing.Point(626, 38);
            this.BoxTime.Name = "BoxTime";
            this.BoxTime.Size = new System.Drawing.Size(118, 20);
            this.BoxTime.TabIndex = 22;
            this.BoxTime.Visible = false;
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(12, 423);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(776, 18);
            this.lblAlert.TabIndex = 23;
            // 
            // LblAquecimento
            // 
            this.LblAquecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAquecimento.Location = new System.Drawing.Point(14, 38);
            this.LblAquecimento.Name = "LblAquecimento";
            this.LblAquecimento.Size = new System.Drawing.Size(580, 298);
            this.LblAquecimento.TabIndex = 24;
            // 
            // comboProgramas
            // 
            this.comboProgramas.FormattingEnabled = true;
            this.comboProgramas.Location = new System.Drawing.Point(605, 381);
            this.comboProgramas.Name = "comboProgramas";
            this.comboProgramas.Size = new System.Drawing.Size(155, 21);
            this.comboProgramas.TabIndex = 25;
            this.comboProgramas.SelectedIndexChanged += new System.EventHandler(this.comboProgramas_SelectedIndexChanged);
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Location = new System.Drawing.Point(623, 365);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(121, 13);
            this.lblCombo.TabIndex = 26;
            this.lblCombo.Text = "Selecione um programa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.comboProgramas);
            this.Controls.Add(this.LblAquecimento);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.BoxTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.numericPower);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericPower;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox BoxTime;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label LblAquecimento;
        private System.Windows.Forms.ComboBox comboProgramas;
        private System.Windows.Forms.Label lblCombo;
    }
}

