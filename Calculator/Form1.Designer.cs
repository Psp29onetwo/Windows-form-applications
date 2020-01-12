namespace Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modulo = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modulo);
            this.groupBox1.Controls.Add(this.Screen);
            this.groupBox1.Controls.Add(this.addition);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.subtraction);
            this.groupBox1.Controls.Add(this.multiplication);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.equals);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.one);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 421);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // modulo
            // 
            this.modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulo.Location = new System.Drawing.Point(218, 290);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(72, 44);
            this.modulo.TabIndex = 35;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.getOperators);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.White;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Screen.Location = new System.Drawing.Point(29, 37);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(339, 65);
            this.Screen.TabIndex = 34;
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(326, 125);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(72, 44);
            this.addition.TabIndex = 33;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.getOperators);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(326, 125);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 44);
            this.button13.TabIndex = 32;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.getOperators);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(326, 180);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(72, 44);
            this.subtraction.TabIndex = 31;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.getOperators);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(326, 230);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(72, 44);
            this.multiplication.TabIndex = 30;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.getOperators);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(326, 290);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(72, 44);
            this.division.TabIndex = 29;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.getOperators);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(2, 289);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(72, 44);
            this.equals.TabIndex = 28;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(108, 290);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 44);
            this.button11.TabIndex = 26;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.getDigits);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(218, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 44);
            this.button7.TabIndex = 24;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.getDigits);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 44);
            this.button8.TabIndex = 23;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.getDigits);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(2, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 44);
            this.button9.TabIndex = 22;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.getDigits);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.getDigits);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 44);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.getDigits);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(2, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 44);
            this.button6.TabIndex = 19;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.getDigits);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.getDigits);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.getDigits);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(2, 125);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(72, 44);
            this.one.TabIndex = 16;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.getDigits);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 446);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button modulo;
    }
}

