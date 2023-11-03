using System.Drawing;
using System.Windows.Forms;

namespace QuickCalculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 90);
            textBox1.TabIndex = 19;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.UseWaitCursor = true;
            textBox1.WordWrap = false;
            // 
            // button1
            // 
            button1.Location = new Point(4, 237);
            button1.Name = "button1";
            button1.Size = new Size(65, 55);
            button1.TabIndex = 20;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(67, 237);
            button2.Name = "button2";
            button2.Size = new Size(65, 55);
            button2.TabIndex = 21;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(130, 237);
            button3.Name = "button3";
            button3.Size = new Size(65, 55);
            button3.TabIndex = 22;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 186);
            button4.Name = "button4";
            button4.Size = new Size(65, 55);
            button4.TabIndex = 23;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(67, 186);
            button5.Name = "button5";
            button5.Size = new Size(65, 55);
            button5.TabIndex = 24;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(130, 186);
            button6.Name = "button6";
            button6.Size = new Size(65, 55);
            button6.TabIndex = 25;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(4, 135);
            button7.Name = "button7";
            button7.Size = new Size(65, 55);
            button7.TabIndex = 26;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(67, 135);
            button8.Name = "button8";
            button8.Size = new Size(65, 55);
            button8.TabIndex = 27;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(130, 135);
            button9.Name = "button9";
            button9.Size = new Size(65, 55);
            button9.TabIndex = 28;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(4, 291);
            button10.Name = "button10";
            button10.Size = new Size(65, 55);
            button10.TabIndex = 29;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(194, 291);
            button11.Name = "button11";
            button11.Size = new Size(65, 55);
            button11.TabIndex = 30;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(67, 291);
            button12.Name = "button12";
            button12.Size = new Size(65, 55);
            button12.TabIndex = 31;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(130, 291);
            button13.Name = "button13";
            button13.Size = new Size(65, 55);
            button13.TabIndex = 32;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(194, 237);
            button14.Name = "button14";
            button14.Size = new Size(65, 55);
            button14.TabIndex = 33;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(194, 186);
            button15.Name = "button15";
            button15.Size = new Size(65, 55);
            button15.TabIndex = 34;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(194, 135);
            button16.Name = "button16";
            button16.Size = new Size(65, 55);
            button16.TabIndex = 35;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(194, 103);
            button17.Name = "button17";
            button17.Size = new Size(65, 33);
            button17.TabIndex = 36;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 363);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            MaximumSize = new Size(279, 402);
            MinimumSize = new Size(279, 402);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;

    }
}

