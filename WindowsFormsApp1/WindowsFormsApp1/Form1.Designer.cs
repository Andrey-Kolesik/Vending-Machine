namespace WindowsFormsApp1
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tea = new System.Windows.Forms.Label();
            this.coffee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coffeemilk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.juice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.summ = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.circleButton4 = new WindowsFormsApp1.CircleButton();
            this.circleButton3 = new WindowsFormsApp1.CircleButton();
            this.circleButton2 = new WindowsFormsApp1.CircleButton();
            this.circleButton1 = new WindowsFormsApp1.CircleButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Violet;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(14, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "мой кошелек";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(116, 27);
            this.label1.MinimumSize = new System.Drawing.Size(550, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Чай  -  13 руб";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tea
            // 
            this.tea.AutoSize = true;
            this.tea.BackColor = System.Drawing.Color.BurlyWood;
            this.tea.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tea.Location = new System.Drawing.Point(581, 36);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(85, 39);
            this.tea.TabIndex = 4;
            this.tea.Text = "(10) ";
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.BackColor = System.Drawing.Color.BurlyWood;
            this.coffee.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffee.Location = new System.Drawing.Point(581, 120);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(85, 39);
            this.coffee.TabIndex = 7;
            this.coffee.Text = "(20) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(116, 111);
            this.label4.MinimumSize = new System.Drawing.Size(550, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 60);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кофе  -  18 руб";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coffeemilk
            // 
            this.coffeemilk.AutoSize = true;
            this.coffeemilk.BackColor = System.Drawing.Color.BurlyWood;
            this.coffeemilk.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeemilk.Location = new System.Drawing.Point(581, 206);
            this.coffeemilk.Name = "coffeemilk";
            this.coffeemilk.Size = new System.Drawing.Size(85, 39);
            this.coffeemilk.TabIndex = 10;
            this.coffeemilk.Text = "(20) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(116, 197);
            this.label6.MinimumSize = new System.Drawing.Size(550, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(550, 60);
            this.label6.TabIndex = 9;
            this.label6.Text = "Кофе с молоком  -  21 руб";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // juice
            // 
            this.juice.AutoSize = true;
            this.juice.BackColor = System.Drawing.Color.BurlyWood;
            this.juice.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.juice.Location = new System.Drawing.Point(581, 290);
            this.juice.Name = "juice";
            this.juice.Size = new System.Drawing.Size(85, 39);
            this.juice.TabIndex = 13;
            this.juice.Text = "(15) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(116, 281);
            this.label8.MinimumSize = new System.Drawing.Size(550, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(550, 60);
            this.label8.TabIndex = 12;
            this.label8.Text = "Сок  -  35 руб";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(240, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "кошелек VM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // summ
            // 
            this.summ.AutoSize = true;
            this.summ.BackColor = System.Drawing.Color.Lime;
            this.summ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summ.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summ.Location = new System.Drawing.Point(819, 441);
            this.summ.MinimumSize = new System.Drawing.Size(130, 40);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(130, 40);
            this.summ.TabIndex = 15;
            this.summ.Text = "0 руб";
            this.summ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(819, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 58);
            this.button3.TabIndex = 16;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Violet;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(466, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 77);
            this.button4.TabIndex = 17;
            this.button4.Text = "сдача";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // circleButton4
            // 
            this.circleButton4.BackColor = System.Drawing.Color.IndianRed;
            this.circleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleButton4.FlatAppearance.BorderSize = 0;
            this.circleButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleButton4.Location = new System.Drawing.Point(14, 278);
            this.circleButton4.Name = "circleButton4";
            this.circleButton4.Size = new System.Drawing.Size(84, 63);
            this.circleButton4.TabIndex = 11;
            this.circleButton4.UseVisualStyleBackColor = false;
            this.circleButton4.Click += new System.EventHandler(this.circleButton4_Click);
            // 
            // circleButton3
            // 
            this.circleButton3.BackColor = System.Drawing.Color.IndianRed;
            this.circleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleButton3.FlatAppearance.BorderSize = 0;
            this.circleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleButton3.Location = new System.Drawing.Point(14, 194);
            this.circleButton3.Name = "circleButton3";
            this.circleButton3.Size = new System.Drawing.Size(84, 63);
            this.circleButton3.TabIndex = 8;
            this.circleButton3.UseVisualStyleBackColor = false;
            this.circleButton3.Click += new System.EventHandler(this.circleButton3_Click);
            // 
            // circleButton2
            // 
            this.circleButton2.BackColor = System.Drawing.Color.IndianRed;
            this.circleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleButton2.FlatAppearance.BorderSize = 0;
            this.circleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleButton2.Location = new System.Drawing.Point(14, 114);
            this.circleButton2.Name = "circleButton2";
            this.circleButton2.Size = new System.Drawing.Size(84, 63);
            this.circleButton2.TabIndex = 5;
            this.circleButton2.UseVisualStyleBackColor = false;
            this.circleButton2.Click += new System.EventHandler(this.circleButton2_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.BackColor = System.Drawing.Color.IndianRed;
            this.circleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleButton1.Location = new System.Drawing.Point(14, 27);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(84, 63);
            this.circleButton1.TabIndex = 2;
            this.circleButton1.UseVisualStyleBackColor = false;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 508);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.juice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.circleButton4);
            this.Controls.Add(this.coffeemilk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.circleButton3);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circleButton2);
            this.Controls.Add(this.tea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private CircleButton circleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tea;
        private System.Windows.Forms.Label coffee;
        private System.Windows.Forms.Label label4;
        private CircleButton circleButton2;
        private System.Windows.Forms.Label coffeemilk;
        private System.Windows.Forms.Label label6;
        private CircleButton circleButton3;
        private System.Windows.Forms.Label juice;
        private System.Windows.Forms.Label label8;
        private CircleButton circleButton4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label summ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

