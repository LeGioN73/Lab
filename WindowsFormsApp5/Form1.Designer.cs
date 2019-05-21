namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lab6 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.TextBox();
            this.Lab1N1S = new System.Windows.Forms.TextBox();
            this.Lab1N1V = new System.Windows.Forms.TextBox();
            this.Lab1box = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lab1N2F = new System.Windows.Forms.TextBox();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearLab1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Lab2box = new System.Windows.Forms.GroupBox();
            this.InputLab2 = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.RandInptL2 = new System.Windows.Forms.Button();
            this.OutputLab2 = new System.Windows.Forms.TextBox();
            this.Lab3box = new System.Windows.Forms.GroupBox();
            this.Lab3Input = new System.Windows.Forms.TextBox();
            this.ApplyL3 = new System.Windows.Forms.Button();
            this.Lab3Output = new System.Windows.Forms.TextBox();
            this.Lab4box = new System.Windows.Forms.GroupBox();
            this.Lab4Out = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenFileL4 = new System.Windows.Forms.Button();
            this.ApplyL4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.Lab1box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Lab2box.SuspendLayout();
            this.Lab3box.SuspendLayout();
            this.Lab4box.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(860, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lab №1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(860, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lab №2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(860, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = " Lab №4 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(7, 125);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(860, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Lab №3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 230);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(860, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Lab №5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lab6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 391);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LaBox";
            // 
            // Lab6
            // 
            this.Lab6.Location = new System.Drawing.Point(6, 283);
            this.Lab6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab6.Name = "Lab6";
            this.Lab6.Size = new System.Drawing.Size(860, 45);
            this.Lab6.TabIndex = 4;
            this.Lab6.Text = "Lab №6";
            this.Lab6.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 540);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(110, 79);
            this.Home.TabIndex = 6;
            this.Home.Text = "На главную";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(219, 87);
            this.b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(112, 26);
            this.b.TabIndex = 7;
            this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // Lab1N1S
            // 
            this.Lab1N1S.Location = new System.Drawing.Point(429, 125);
            this.Lab1N1S.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1N1S.Name = "Lab1N1S";
            this.Lab1N1S.ReadOnly = true;
            this.Lab1N1S.Size = new System.Drawing.Size(112, 26);
            this.Lab1N1S.TabIndex = 8;
            // 
            // Lab1N1V
            // 
            this.Lab1N1V.Location = new System.Drawing.Point(429, 87);
            this.Lab1N1V.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1N1V.Name = "Lab1N1V";
            this.Lab1N1V.ReadOnly = true;
            this.Lab1N1V.Size = new System.Drawing.Size(112, 26);
            this.Lab1N1V.TabIndex = 9;
            // 
            // Lab1box
            // 
            this.Lab1box.Controls.Add(this.label6);
            this.Lab1box.Controls.Add(this.label5);
            this.Lab1box.Controls.Add(this.Lab1N2F);
            this.Lab1box.Controls.Add(this.InputA);
            this.Lab1box.Controls.Add(this.InputX);
            this.Lab1box.Controls.Add(this.pictureBox1);
            this.Lab1box.Controls.Add(this.label4);
            this.Lab1box.Controls.Add(this.label3);
            this.Lab1box.Controls.Add(this.label2);
            this.Lab1box.Controls.Add(this.label1);
            this.Lab1box.Controls.Add(this.clearLab1);
            this.Lab1box.Controls.Add(this.Lab1N1S);
            this.Lab1box.Controls.Add(this.Lab1N1V);
            this.Lab1box.Controls.Add(this.b);
            this.Lab1box.Controls.Add(this.label7);
            this.Lab1box.Location = new System.Drawing.Point(171, 15);
            this.Lab1box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1box.Name = "Lab1box";
            this.Lab1box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1box.Size = new System.Drawing.Size(731, 604);
            this.Lab1box.TabIndex = 10;
            this.Lab1box.TabStop = false;
            this.Lab1box.Text = "Lab1Box";
            this.Lab1box.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "a=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "F=";
            // 
            // Lab1N2F
            // 
            this.Lab1N2F.Location = new System.Drawing.Point(354, 442);
            this.Lab1N2F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab1N2F.Name = "Lab1N2F";
            this.Lab1N2F.ReadOnly = true;
            this.Lab1N2F.Size = new System.Drawing.Size(280, 26);
            this.Lab1N2F.TabIndex = 19;
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(144, 477);
            this.InputA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(112, 26);
            this.InputA.TabIndex = 18;
            this.InputA.TextChanged += new System.EventHandler(this.InputX_TextChanged);
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(144, 442);
            this.InputX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(112, 26);
            this.InputX.TabIndex = 17;
            this.InputX.TextChanged += new System.EventHandler(this.InputX_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApProgLab.Properties.Resources.Screenshot_6;
            this.pictureBox1.Location = new System.Drawing.Point(44, 191);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 243);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "Составить программу для нахождения объема и полной\r\n поверхности куба, ребро кото" +
    "рого b.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "V=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "S=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите b =";
            // 
            // clearLab1
            // 
            this.clearLab1.Location = new System.Drawing.Point(498, 525);
            this.clearLab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearLab1.Name = "clearLab1";
            this.clearLab1.Size = new System.Drawing.Size(197, 71);
            this.clearLab1.TabIndex = 10;
            this.clearLab1.Text = "Сбросить";
            this.clearLab1.UseVisualStyleBackColor = true;
            this.clearLab1.Click += new System.EventHandler(this.clearLab1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "x=";
            // 
            // Lab2box
            // 
            this.Lab2box.Controls.Add(this.InputLab2);
            this.Lab2box.Controls.Add(this.apply);
            this.Lab2box.Controls.Add(this.RandInptL2);
            this.Lab2box.Controls.Add(this.OutputLab2);
            this.Lab2box.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab2box.Location = new System.Drawing.Point(141, 15);
            this.Lab2box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab2box.Name = "Lab2box";
            this.Lab2box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab2box.Size = new System.Drawing.Size(731, 604);
            this.Lab2box.TabIndex = 11;
            this.Lab2box.TabStop = false;
            this.Lab2box.Visible = false;
            // 
            // InputLab2
            // 
            this.InputLab2.Location = new System.Drawing.Point(7, 20);
            this.InputLab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputLab2.Multiline = true;
            this.InputLab2.Name = "InputLab2";
            this.InputLab2.Size = new System.Drawing.Size(349, 503);
            this.InputLab2.TabIndex = 9;
            this.InputLab2.TextChanged += new System.EventHandler(this.InputLab2_TextChanged);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(363, 554);
            this.apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(332, 42);
            this.apply.TabIndex = 13;
            this.apply.Text = "Выполнить";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // RandInptL2
            // 
            this.RandInptL2.Location = new System.Drawing.Point(8, 554);
            this.RandInptL2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RandInptL2.Name = "RandInptL2";
            this.RandInptL2.Size = new System.Drawing.Size(349, 42);
            this.RandInptL2.TabIndex = 10;
            this.RandInptL2.Text = "Заполнить массив случайными числами";
            this.RandInptL2.UseVisualStyleBackColor = true;
            this.RandInptL2.Click += new System.EventHandler(this.RandInptL2_Click);
            // 
            // OutputLab2
            // 
            this.OutputLab2.Location = new System.Drawing.Point(363, 20);
            this.OutputLab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputLab2.Multiline = true;
            this.OutputLab2.Name = "OutputLab2";
            this.OutputLab2.ReadOnly = true;
            this.OutputLab2.Size = new System.Drawing.Size(349, 503);
            this.OutputLab2.TabIndex = 8;
            // 
            // Lab3box
            // 
            this.Lab3box.Controls.Add(this.Lab3Input);
            this.Lab3box.Controls.Add(this.ApplyL3);
            this.Lab3box.Controls.Add(this.Lab3Output);
            this.Lab3box.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab3box.Location = new System.Drawing.Point(141, 15);
            this.Lab3box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab3box.Name = "Lab3box";
            this.Lab3box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab3box.Size = new System.Drawing.Size(731, 604);
            this.Lab3box.TabIndex = 14;
            this.Lab3box.TabStop = false;
            this.Lab3box.Text = "L3B";
            this.Lab3box.Visible = false;
            // 
            // Lab3Input
            // 
            this.Lab3Input.Location = new System.Drawing.Point(7, 20);
            this.Lab3Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab3Input.Multiline = true;
            this.Lab3Input.Name = "Lab3Input";
            this.Lab3Input.Size = new System.Drawing.Size(349, 503);
            this.Lab3Input.TabIndex = 9;
            // 
            // ApplyL3
            // 
            this.ApplyL3.Location = new System.Drawing.Point(363, 554);
            this.ApplyL3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplyL3.Name = "ApplyL3";
            this.ApplyL3.Size = new System.Drawing.Size(332, 42);
            this.ApplyL3.TabIndex = 13;
            this.ApplyL3.Text = "Выполнить";
            this.ApplyL3.UseVisualStyleBackColor = true;
            this.ApplyL3.Click += new System.EventHandler(this.ApplyL3_Click);
            // 
            // Lab3Output
            // 
            this.Lab3Output.Location = new System.Drawing.Point(363, 20);
            this.Lab3Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab3Output.Multiline = true;
            this.Lab3Output.Name = "Lab3Output";
            this.Lab3Output.ReadOnly = true;
            this.Lab3Output.Size = new System.Drawing.Size(349, 503);
            this.Lab3Output.TabIndex = 8;
            // 
            // Lab4box
            // 
            this.Lab4box.Controls.Add(this.Lab4Out);
            this.Lab4box.Controls.Add(this.flowLayoutPanel1);
            this.Lab4box.Location = new System.Drawing.Point(150, 20);
            this.Lab4box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lab4box.Name = "Lab4box";
            this.Lab4box.Size = new System.Drawing.Size(741, 600);
            this.Lab4box.TabIndex = 15;
            this.Lab4box.TabStop = false;
            this.Lab4box.Text = "Lab4box";
            this.Lab4box.Visible = false;
            // 
            // Lab4Out
            // 
            this.Lab4Out.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab4Out.Location = new System.Drawing.Point(6, 25);
            this.Lab4Out.Name = "Lab4Out";
            this.Lab4Out.Size = new System.Drawing.Size(732, 521);
            this.Lab4Out.TabIndex = 2;
            this.Lab4Out.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OpenFileL4);
            this.flowLayoutPanel1.Controls.Add(this.ApplyL4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 549);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OpenFileL4
            // 
            this.OpenFileL4.Location = new System.Drawing.Point(600, 3);
            this.OpenFileL4.Name = "OpenFileL4";
            this.OpenFileL4.Size = new System.Drawing.Size(132, 39);
            this.OpenFileL4.TabIndex = 0;
            this.OpenFileL4.Text = "Open File";
            this.OpenFileL4.UseVisualStyleBackColor = true;
            this.OpenFileL4.Click += new System.EventHandler(this.OpenFileL4_Click);
            // 
            // ApplyL4
            // 
            this.ApplyL4.Location = new System.Drawing.Point(462, 3);
            this.ApplyL4.Name = "ApplyL4";
            this.ApplyL4.Size = new System.Drawing.Size(132, 39);
            this.ApplyL4.TabIndex = 1;
            this.ApplyL4.Text = "Выполнить";
            this.ApplyL4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 634);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Lab4box);
            this.Controls.Add(this.Lab2box);
            this.Controls.Add(this.Lab3box);
            this.Controls.Add(this.Lab1box);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Lab";
            this.groupBox1.ResumeLayout(false);
            this.Lab1box.ResumeLayout(false);
            this.Lab1box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Lab2box.ResumeLayout(false);
            this.Lab2box.PerformLayout();
            this.Lab3box.ResumeLayout(false);
            this.Lab3box.PerformLayout();
            this.Lab4box.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox Lab1N1S;
        private System.Windows.Forms.TextBox Lab1N1V;
        private System.Windows.Forms.GroupBox Lab1box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearLab1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Lab1N2F;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Lab2box;
        private System.Windows.Forms.TextBox InputLab2;
        private System.Windows.Forms.TextBox OutputLab2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button RandInptL2;
        private System.Windows.Forms.GroupBox Lab3box;
        private System.Windows.Forms.TextBox Lab3Input;
        private System.Windows.Forms.Button ApplyL3;
        private System.Windows.Forms.TextBox Lab3Output;
        private System.Windows.Forms.GroupBox Lab4box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OpenFileL4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox Lab4Out;
        private System.Windows.Forms.Button ApplyL4;
        private System.Windows.Forms.Button Lab6;
    }
}

