namespace CG_lab1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.зображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBorderColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBgColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseHexagonColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawCircleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.borderColor = new System.Windows.Forms.Button();
            this.circleBgColor = new System.Windows.Forms.Button();
            this.hexagonBgColor = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.clearCoordinatePlane = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stepByStep = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зображенняToolStripMenuItem,
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // зображенняToolStripMenuItem
            // 
            this.зображенняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseBorderColorMenuItem,
            this.chooseBgColorMenuItem,
            this.chooseHexagonColorMenuItem,
            this.drawCircleMenuItem,
            this.clearItemsMenuItem});
            this.зображенняToolStripMenuItem.Name = "зображенняToolStripMenuItem";
            this.зображенняToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.зображенняToolStripMenuItem.Text = "Зображення";
            // 
            // chooseBorderColorMenuItem
            // 
            this.chooseBorderColorMenuItem.Name = "chooseBorderColorMenuItem";
            this.chooseBorderColorMenuItem.Size = new System.Drawing.Size(234, 22);
            this.chooseBorderColorMenuItem.Text = "Вибрати колір контуру";
            this.chooseBorderColorMenuItem.Click += new System.EventHandler(this.borderColor_Click);
            // 
            // chooseBgColorMenuItem
            // 
            this.chooseBgColorMenuItem.Name = "chooseBgColorMenuItem";
            this.chooseBgColorMenuItem.Size = new System.Drawing.Size(234, 22);
            this.chooseBgColorMenuItem.Text = "Вибрати колір кола";
            this.chooseBgColorMenuItem.Click += new System.EventHandler(this.circleBgColor_Click);
            // 
            // chooseHexagonColorMenuItem
            // 
            this.chooseHexagonColorMenuItem.Name = "chooseHexagonColorMenuItem";
            this.chooseHexagonColorMenuItem.Size = new System.Drawing.Size(234, 22);
            this.chooseHexagonColorMenuItem.Text = "Вибрати колір шестикутника";
            this.chooseHexagonColorMenuItem.Click += new System.EventHandler(this.hexagonBgColor_Click);
            // 
            // drawCircleMenuItem
            // 
            this.drawCircleMenuItem.Name = "drawCircleMenuItem";
            this.drawCircleMenuItem.Size = new System.Drawing.Size(234, 22);
            this.drawCircleMenuItem.Text = "Намалювати";
            this.drawCircleMenuItem.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // clearItemsMenuItem
            // 
            this.clearItemsMenuItem.Name = "clearItemsMenuItem";
            this.clearItemsMenuItem.Size = new System.Drawing.Size(234, 22);
            this.clearItemsMenuItem.Text = "Очистити";
            this.clearItemsMenuItem.Click += new System.EventHandler(this.clearCoordinatePlane_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(75, 20);
            this.helpMenuItem.Text = "Допомога";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exitMenuItem.Text = "Вихід";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(496, 500);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть координати центру кола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "X0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(649, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "R";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(557, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введіть радіус кола";
            // 
            // borderColor
            // 
            this.borderColor.BackColor = System.Drawing.Color.DarkGray;
            this.borderColor.Location = new System.Drawing.Point(534, 148);
            this.borderColor.Name = "borderColor";
            this.borderColor.Size = new System.Drawing.Size(166, 29);
            this.borderColor.TabIndex = 17;
            this.borderColor.Text = "Виберіть колір контуру";
            this.borderColor.UseVisualStyleBackColor = false;
            this.borderColor.Click += new System.EventHandler(this.borderColor_Click);
            // 
            // circleBgColor
            // 
            this.circleBgColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circleBgColor.Location = new System.Drawing.Point(534, 183);
            this.circleBgColor.Name = "circleBgColor";
            this.circleBgColor.Size = new System.Drawing.Size(166, 29);
            this.circleBgColor.TabIndex = 18;
            this.circleBgColor.Text = "Виберіть колір кола";
            this.circleBgColor.UseVisualStyleBackColor = false;
            this.circleBgColor.Click += new System.EventHandler(this.circleBgColor_Click);
            // 
            // hexagonBgColor
            // 
            this.hexagonBgColor.BackColor = System.Drawing.Color.IndianRed;
            this.hexagonBgColor.Location = new System.Drawing.Point(533, 218);
            this.hexagonBgColor.Name = "hexagonBgColor";
            this.hexagonBgColor.Size = new System.Drawing.Size(166, 29);
            this.hexagonBgColor.TabIndex = 19;
            this.hexagonBgColor.Text = "Виберіть колір шестикутника";
            this.hexagonBgColor.UseVisualStyleBackColor = false;
            this.hexagonBgColor.Click += new System.EventHandler(this.hexagonBgColor_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.Location = new System.Drawing.Point(547, 265);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(138, 36);
            this.drawCircle.TabIndex = 20;
            this.drawCircle.Text = "Намалювати";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // clearCoordinatePlane
            // 
            this.clearCoordinatePlane.Location = new System.Drawing.Point(547, 307);
            this.clearCoordinatePlane.Name = "clearCoordinatePlane";
            this.clearCoordinatePlane.Size = new System.Drawing.Size(138, 36);
            this.clearCoordinatePlane.TabIndex = 22;
            this.clearCoordinatePlane.Text = "Очистити";
            this.clearCoordinatePlane.UseVisualStyleBackColor = true;
            this.clearCoordinatePlane.Click += new System.EventHandler(this.clearCoordinatePlane_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Проміжні результати";
            // 
            // stepByStep
            // 
            this.stepByStep.Location = new System.Drawing.Point(514, 388);
            this.stepByStep.Name = "stepByStep";
            this.stepByStep.ReadOnly = true;
            this.stepByStep.Size = new System.Drawing.Size(206, 149);
            this.stepByStep.TabIndex = 24;
            this.stepByStep.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 551);
            this.Controls.Add(this.stepByStep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearCoordinatePlane);
            this.Controls.Add(this.drawCircle);
            this.Controls.Add(this.hexagonBgColor);
            this.Controls.Add(this.circleBgColor);
            this.Controls.Add(this.borderColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(746, 590);
            this.MinimumSize = new System.Drawing.Size(746, 590);
            this.Name = "Form1";
            this.Text = "Computer Graphic - Lab 1,  Kochulab Andrij";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseBorderColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseBgColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawCircleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button borderColor;
        private System.Windows.Forms.Button circleBgColor;
        private System.Windows.Forms.Button hexagonBgColor;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.Button clearCoordinatePlane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox stepByStep;
        private System.Windows.Forms.ToolStripMenuItem chooseHexagonColorMenuItem;
    }
}

