namespace projLeds
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.btnLed8 = new System.Windows.Forms.Button();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.btnLed3 = new System.Windows.Forms.Button();
            this.btnLed4 = new System.Windows.Forms.Button();
            this.btnLed5 = new System.Windows.Forms.Button();
            this.btnLed6 = new System.Windows.Forms.Button();
            this.btnLed7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnLed1
            // 
            this.btnLed1.Location = new System.Drawing.Point(610, 199);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(75, 23);
            this.btnLed1.TabIndex = 1;
            this.btnLed1.Tag = "1";
            this.btnLed1.Text = "Led 1";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed8
            // 
            this.btnLed8.Location = new System.Drawing.Point(43, 199);
            this.btnLed8.Name = "btnLed8";
            this.btnLed8.Size = new System.Drawing.Size(75, 23);
            this.btnLed8.TabIndex = 2;
            this.btnLed8.Tag = "8";
            this.btnLed8.Text = "Led 8";
            this.btnLed8.UseVisualStyleBackColor = true;
            this.btnLed8.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed2
            // 
            this.btnLed2.Location = new System.Drawing.Point(529, 199);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(75, 23);
            this.btnLed2.TabIndex = 3;
            this.btnLed2.Tag = "2";
            this.btnLed2.Text = "Led 2";
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed3
            // 
            this.btnLed3.Location = new System.Drawing.Point(448, 199);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(75, 23);
            this.btnLed3.TabIndex = 4;
            this.btnLed3.Tag = "3";
            this.btnLed3.Text = "Led 3";
            this.btnLed3.UseVisualStyleBackColor = true;
            this.btnLed3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed4
            // 
            this.btnLed4.Location = new System.Drawing.Point(367, 199);
            this.btnLed4.Name = "btnLed4";
            this.btnLed4.Size = new System.Drawing.Size(75, 23);
            this.btnLed4.TabIndex = 5;
            this.btnLed4.Tag = "4";
            this.btnLed4.Text = "Led 4";
            this.btnLed4.UseVisualStyleBackColor = true;
            this.btnLed4.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed5
            // 
            this.btnLed5.Location = new System.Drawing.Point(286, 199);
            this.btnLed5.Name = "btnLed5";
            this.btnLed5.Size = new System.Drawing.Size(75, 23);
            this.btnLed5.TabIndex = 6;
            this.btnLed5.Tag = "5";
            this.btnLed5.Text = "Led 5";
            this.btnLed5.UseVisualStyleBackColor = true;
            this.btnLed5.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed6
            // 
            this.btnLed6.Location = new System.Drawing.Point(205, 199);
            this.btnLed6.Name = "btnLed6";
            this.btnLed6.Size = new System.Drawing.Size(75, 23);
            this.btnLed6.TabIndex = 7;
            this.btnLed6.Tag = "6";
            this.btnLed6.Text = "Led 6";
            this.btnLed6.UseVisualStyleBackColor = true;
            this.btnLed6.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLed7
            // 
            this.btnLed7.Location = new System.Drawing.Point(124, 199);
            this.btnLed7.Name = "btnLed7";
            this.btnLed7.Size = new System.Drawing.Size(75, 23);
            this.btnLed7.TabIndex = 8;
            this.btnLed7.Tag = "7";
            this.btnLed7.Text = "Led 7";
            this.btnLed7.UseVisualStyleBackColor = true;
            this.btnLed7.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLed7);
            this.Controls.Add(this.btnLed6);
            this.Controls.Add(this.btnLed5);
            this.Controls.Add(this.btnLed4);
            this.Controls.Add(this.btnLed3);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.btnLed8);
            this.Controls.Add(this.btnLed1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.Button btnLed8;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.Button btnLed3;
        private System.Windows.Forms.Button btnLed4;
        private System.Windows.Forms.Button btnLed5;
        private System.Windows.Forms.Button btnLed6;
        private System.Windows.Forms.Button btnLed7;
        private System.Windows.Forms.Label label2;
    }
}

