namespace _2._3F
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.TextBox();
            this.AA = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.BB = new System.Windows.Forms.Label();
            this.Vivod = new System.Windows.Forms.Button();
            this.viv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(11, 49);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 0;
            // 
            // AA
            // 
            this.AA.AutoSize = true;
            this.AA.Location = new System.Drawing.Point(12, 33);
            this.AA.Name = "AA";
            this.AA.Size = new System.Drawing.Size(59, 13);
            this.AA.TabIndex = 1;
            this.AA.Text = "Введите А";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(11, 91);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 3;
            // 
            // BB
            // 
            this.BB.AutoSize = true;
            this.BB.Location = new System.Drawing.Point(12, 75);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(65, 13);
            this.BB.TabIndex = 4;
            this.BB.Text = "Введиете B";
            // 
            // Vivod
            // 
            this.Vivod.Location = new System.Drawing.Point(36, 145);
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(75, 23);
            this.Vivod.TabIndex = 0;
            this.Vivod.Text = "вывести";
            this.Vivod.UseVisualStyleBackColor = true;
            this.Vivod.Click += new System.EventHandler(this.Vivod_Click);
            // 
            // viv
            // 
            this.viv.Location = new System.Drawing.Point(160, 49);
            this.viv.Multiline = true;
            this.viv.Name = "viv";
            this.viv.Size = new System.Drawing.Size(221, 62);
            this.viv.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viv);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.BB);
            this.Controls.Add(this.B);
            this.Controls.Add(this.AA);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label AA;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label BB;
        private System.Windows.Forms.Button Vivod;
        private System.Windows.Forms.TextBox viv;
    }
}

