namespace Mathquizz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            leftMinusLabel = new Label();
            rightMinusLabel = new Label();
            timesLeftLabel = new Label();
            timesRightLabel = new Label();
            dividedLeftLabel = new Label();
            devidedRightLabel = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Difference = new NumericUpDown();
            Product = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 16F);
            timeLabel.Location = new Point(588, 18);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(458, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 1;
            label1.Text = " Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 42);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(245, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 42);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(145, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 42);
            label3.TabIndex = 4;
            label3.Text = "+";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(350, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 42);
            label4.TabIndex = 5;
            label4.Text = "=";
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(397, 70);
            sum.Name = "sum";
            sum.Size = new Size(100, 47);
            sum.TabIndex = 1;
            // 
            // leftMinusLabel
            // 
            leftMinusLabel.Font = new Font("Segoe UI", 18F);
            leftMinusLabel.Location = new Point(50, 152);
            leftMinusLabel.Name = "leftMinusLabel";
            leftMinusLabel.Size = new Size(60, 42);
            leftMinusLabel.TabIndex = 7;
            leftMinusLabel.Text = "?";
            // 
            // rightMinusLabel
            // 
            rightMinusLabel.Font = new Font("Segoe UI", 18F);
            rightMinusLabel.Location = new Point(245, 152);
            rightMinusLabel.Name = "rightMinusLabel";
            rightMinusLabel.Size = new Size(60, 42);
            rightMinusLabel.TabIndex = 8;
            rightMinusLabel.Text = "?";
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 222);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 42);
            timesLeftLabel.TabIndex = 9;
            timesLeftLabel.Text = "?";
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(245, 222);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 42);
            timesRightLabel.TabIndex = 10;
            timesRightLabel.Text = "?";
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 295);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 42);
            dividedLeftLabel.TabIndex = 11;
            dividedLeftLabel.Text = "?";
            // 
            // devidedRightLabel
            // 
            devidedRightLabel.Font = new Font("Segoe UI", 18F);
            devidedRightLabel.Location = new Point(245, 298);
            devidedRightLabel.Name = "devidedRightLabel";
            devidedRightLabel.Size = new Size(60, 42);
            devidedRightLabel.TabIndex = 12;
            devidedRightLabel.Text = "?";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(145, 152);
            label10.Name = "label10";
            label10.Size = new Size(60, 42);
            label10.TabIndex = 13;
            label10.Text = "-";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(145, 222);
            label11.Name = "label11";
            label11.Size = new Size(60, 42);
            label11.TabIndex = 14;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(145, 298);
            label12.Name = "label12";
            label12.Size = new Size(60, 42);
            label12.TabIndex = 15;
            label12.Text = "\\";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(350, 152);
            label13.Name = "label13";
            label13.Size = new Size(60, 42);
            label13.TabIndex = 16;
            label13.Text = "=";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(350, 222);
            label14.Name = "label14";
            label14.Size = new Size(60, 42);
            label14.TabIndex = 17;
            label14.Text = "=";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(350, 298);
            label15.Name = "label15";
            label15.Size = new Size(60, 42);
            label15.TabIndex = 18;
            label15.Text = "=";
            // 
            // Difference
            // 
            Difference.Font = new Font("Segoe UI", 18F);
            Difference.Location = new Point(397, 147);
            Difference.Name = "Difference";
            Difference.Size = new Size(100, 47);
            Difference.TabIndex = 2;
            // 
            // Product
            // 
            Product.Font = new Font("Segoe UI", 18F);
            Product.Location = new Point(397, 217);
            Product.Name = "Product";
            Product.Size = new Size(100, 47);
            Product.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 18F);
            numericUpDown3.Location = new Point(397, 293);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(100, 47);
            numericUpDown3.TabIndex = 4;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(199, 379);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 46);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(823, 508);
            Controls.Add(startButton);
            Controls.Add(numericUpDown3);
            Controls.Add(Product);
            Controls.Add(Difference);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(devidedRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(rightMinusLabel);
            Controls.Add(leftMinusLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)Difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)Product).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown sum;
        private Label leftMinusLabel;
        private Label rightMinusLabel;
        private Label timesLeftLabel;
        private Label timesRightLabel;
        private Label dividedLeftLabel;
        private Label devidedRightLabel;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private NumericUpDown Difference;
        private NumericUpDown Product;
        private NumericUpDown numericUpDown3;
        private Button startButton;
    }
}
