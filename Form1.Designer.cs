namespace калькулятор
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minys = new System.Windows.Forms.Button();
            this.umnogit = new System.Windows.Forms.Button();
            this.razdelit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(30, 99);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 42);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minys
            // 
            this.Minys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minys.Location = new System.Drawing.Point(30, 147);
            this.Minys.Name = "Minys";
            this.Minys.Size = new System.Drawing.Size(75, 40);
            this.Minys.TabIndex = 3;
            this.Minys.Text = "-";
            this.Minys.UseVisualStyleBackColor = true;
            this.Minys.Click += new System.EventHandler(this.Minys_Click);
            // 
            // umnogit
            // 
            this.umnogit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umnogit.Location = new System.Drawing.Point(30, 193);
            this.umnogit.Name = "umnogit";
            this.umnogit.Size = new System.Drawing.Size(75, 46);
            this.umnogit.TabIndex = 4;
            this.umnogit.Text = "*";
            this.umnogit.UseVisualStyleBackColor = true;
            this.umnogit.Click += new System.EventHandler(this.umnogit_Click);
            // 
            // razdelit
            // 
            this.razdelit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razdelit.Location = new System.Drawing.Point(30, 245);
            this.razdelit.Name = "razdelit";
            this.razdelit.Size = new System.Drawing.Size(75, 43);
            this.razdelit.TabIndex = 5;
            this.razdelit.Text = "/";
            this.razdelit.UseVisualStyleBackColor = true;
            this.razdelit.Click += new System.EventHandler(this.razdelit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.razdelit);
            this.Controls.Add(this.umnogit);
            this.Controls.Add(this.Minys);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minys;
        private System.Windows.Forms.Button umnogit;
        private System.Windows.Forms.Button razdelit;
        private System.Windows.Forms.Label label1;
    }
}

