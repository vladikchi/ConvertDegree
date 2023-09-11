namespace WindowsFormsApp1
{
    partial class Converter
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
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConverter1 = new System.Windows.Forms.Button();
            this.buttonConverter2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxF1.Location = new System.Drawing.Point(12, 72);
            this.textBoxF1.Multiline = true;
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(149, 40);
            this.textBoxF1.TabIndex = 0;
            this.textBoxF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxF1.TextChanged += new System.EventHandler(this.textBoxF1_TextChanged);
            // 
            // textBoxC2
            // 
            this.textBoxC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxC2.Location = new System.Drawing.Point(385, 118);
            this.textBoxC2.Multiline = true;
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(149, 40);
            this.textBoxC2.TabIndex = 3;
            this.textBoxC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxC2.TextChanged += new System.EventHandler(this.textBoxC2_TextChanged);
            // 
            // textBoxC1
            // 
            this.textBoxC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC1.Location = new System.Drawing.Point(12, 118);
            this.textBoxC1.Multiline = true;
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(149, 40);
            this.textBoxC1.TabIndex = 2;
            this.textBoxC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxC1.TextChanged += new System.EventHandler(this.textBoxC1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "°F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "°C";
            // 
            // buttonConverter1
            // 
            this.buttonConverter1.Location = new System.Drawing.Point(224, 72);
            this.buttonConverter1.Name = "buttonConverter1";
            this.buttonConverter1.Size = new System.Drawing.Size(153, 40);
            this.buttonConverter1.TabIndex = 6;
            this.buttonConverter1.Text = "Конвертировать";
            this.buttonConverter1.UseVisualStyleBackColor = true;
            this.buttonConverter1.Click += new System.EventHandler(this.buttonConverter1_Click);
            // 
            // buttonConverter2
            // 
            this.buttonConverter2.Location = new System.Drawing.Point(224, 118);
            this.buttonConverter2.Name = "buttonConverter2";
            this.buttonConverter2.Size = new System.Drawing.Size(153, 40);
            this.buttonConverter2.TabIndex = 7;
            this.buttonConverter2.Text = "Конвертировать";
            this.buttonConverter2.UseVisualStyleBackColor = true;
            this.buttonConverter2.Click += new System.EventHandler(this.buttonConverter2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Формула перевода Фаренгейта (°F) в Цельсий (°C) и наоборот Цельсия (°C) в Фаренге" +
    "йт (°F):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цельсий х 1,8 + 32 = Фаренгейт                                           Пример: " +
    "10°C x 1,8 + 32 = 50°F\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Фаренгейт — 32) : 1,8 = Цельсий                                         Пример: " +
    "(50°F - 32) : 1,8 = 10°C\r\n";
            // 
            // textBoxF2
            // 
            this.textBoxF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxF2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxF2.Location = new System.Drawing.Point(385, 72);
            this.textBoxF2.Multiline = true;
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(149, 40);
            this.textBoxF2.TabIndex = 3;
            this.textBoxF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 170);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConverter2);
            this.Controls.Add(this.buttonConverter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.textBoxF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConverter1;
        private System.Windows.Forms.Button buttonConverter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxF2;
    }
}

