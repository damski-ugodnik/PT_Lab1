
namespace PT_Lab1
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
            this.components = new System.ComponentModel.Container();
            this.Field = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Comma_button = new System.Windows.Forms.Button();
            this.Backspace_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.SinX_button = new System.Windows.Forms.Button();
            this.Sqrt_button = new System.Windows.Forms.Button();
            this.Equal_button = new System.Windows.Forms.Button();
            this.Plus_button = new System.Windows.Forms.Button();
            this.Division_button = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Minus_button = new System.Windows.Forms.Button();
            this.Multiplication_button = new System.Windows.Forms.Button();
            this.OneDividedByX_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MinValueBox = new System.Windows.Forms.TextBox();
            this.MaxValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.historyList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Field.Location = new System.Drawing.Point(32, 15);
            this.Field.Name = "Field";
            this.Field.ShortcutsEnabled = false;
            this.Field.Size = new System.Drawing.Size(312, 45);
            this.Field.TabIndex = 0;
            this.Field.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.Field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Field_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Comma_button);
            this.groupBox1.Controls.Add(this.Backspace_button);
            this.groupBox1.Controls.Add(this.Clear_button);
            this.groupBox1.Controls.Add(this.SinX_button);
            this.groupBox1.Controls.Add(this.Sqrt_button);
            this.groupBox1.Controls.Add(this.Equal_button);
            this.groupBox1.Controls.Add(this.Plus_button);
            this.groupBox1.Controls.Add(this.Division_button);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.Minus_button);
            this.groupBox1.Controls.Add(this.Multiplication_button);
            this.groupBox1.Controls.Add(this.OneDividedByX_button);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(32, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Comma_button
            // 
            this.Comma_button.Location = new System.Drawing.Point(97, 179);
            this.Comma_button.Name = "Comma_button";
            this.Comma_button.Size = new System.Drawing.Size(35, 33);
            this.Comma_button.TabIndex = 3;
            this.Comma_button.Text = ",";
            this.Comma_button.UseVisualStyleBackColor = true;
            this.Comma_button.Click += new System.EventHandler(this.Comma_button_Click);
            // 
            // Backspace_button
            // 
            this.Backspace_button.Location = new System.Drawing.Point(219, 62);
            this.Backspace_button.Name = "Backspace_button";
            this.Backspace_button.Size = new System.Drawing.Size(75, 33);
            this.Backspace_button.TabIndex = 16;
            this.Backspace_button.Text = "backspace";
            this.Backspace_button.UseVisualStyleBackColor = true;
            this.Backspace_button.Click += new System.EventHandler(this.Backspace_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(219, 22);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 34);
            this.Clear_button.TabIndex = 15;
            this.Clear_button.Text = "C";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // SinX_button
            // 
            this.SinX_button.Location = new System.Drawing.Point(152, 22);
            this.SinX_button.Name = "SinX_button";
            this.SinX_button.Size = new System.Drawing.Size(60, 34);
            this.SinX_button.TabIndex = 2;
            this.SinX_button.Text = "sin(x)";
            this.SinX_button.UseVisualStyleBackColor = true;
            this.SinX_button.Click += new System.EventHandler(this.SinX_button_Click);
            // 
            // Sqrt_button
            // 
            this.Sqrt_button.Location = new System.Drawing.Point(81, 22);
            this.Sqrt_button.Name = "Sqrt_button";
            this.Sqrt_button.Size = new System.Drawing.Size(65, 34);
            this.Sqrt_button.TabIndex = 14;
            this.Sqrt_button.Text = "sqrt(x)";
            this.Sqrt_button.UseVisualStyleBackColor = true;
            this.Sqrt_button.Click += new System.EventHandler(this.Sqrt_button_Click);
            // 
            // Equal_button
            // 
            this.Equal_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equal_button.Location = new System.Drawing.Point(219, 101);
            this.Equal_button.Name = "Equal_button";
            this.Equal_button.Size = new System.Drawing.Size(75, 111);
            this.Equal_button.TabIndex = 4;
            this.Equal_button.Text = "=";
            this.Equal_button.UseVisualStyleBackColor = true;
            this.Equal_button.Click += new System.EventHandler(this.Equal_button_Click);
            // 
            // Plus_button
            // 
            this.Plus_button.Location = new System.Drawing.Point(138, 62);
            this.Plus_button.Name = "Plus_button";
            this.Plus_button.Size = new System.Drawing.Size(75, 33);
            this.Plus_button.TabIndex = 5;
            this.Plus_button.Text = "+";
            this.Plus_button.UseVisualStyleBackColor = true;
            this.Plus_button.Click += new System.EventHandler(this.Plus_button_Click);
            // 
            // Division_button
            // 
            this.Division_button.Location = new System.Drawing.Point(138, 179);
            this.Division_button.Name = "Division_button";
            this.Division_button.Size = new System.Drawing.Size(75, 33);
            this.Division_button.TabIndex = 13;
            this.Division_button.Text = "/";
            this.Division_button.UseVisualStyleBackColor = true;
            this.Division_button.Click += new System.EventHandler(this.Division_button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(15, 179);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 33);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Minus_button
            // 
            this.Minus_button.Location = new System.Drawing.Point(137, 101);
            this.Minus_button.Name = "Minus_button";
            this.Minus_button.Size = new System.Drawing.Size(76, 33);
            this.Minus_button.TabIndex = 2;
            this.Minus_button.Text = "-";
            this.Minus_button.UseVisualStyleBackColor = true;
            this.Minus_button.Click += new System.EventHandler(this.Minus_button_Click);
            // 
            // Multiplication_button
            // 
            this.Multiplication_button.Location = new System.Drawing.Point(138, 140);
            this.Multiplication_button.Name = "Multiplication_button";
            this.Multiplication_button.Size = new System.Drawing.Size(75, 33);
            this.Multiplication_button.TabIndex = 3;
            this.Multiplication_button.Text = "x";
            this.Multiplication_button.UseVisualStyleBackColor = true;
            this.Multiplication_button.Click += new System.EventHandler(this.Multiplication_button_Click);
            // 
            // OneDividedByX_button
            // 
            this.OneDividedByX_button.Location = new System.Drawing.Point(15, 22);
            this.OneDividedByX_button.Name = "OneDividedByX_button";
            this.OneDividedByX_button.Size = new System.Drawing.Size(60, 34);
            this.OneDividedByX_button.TabIndex = 12;
            this.OneDividedByX_button.Text = "1/x";
            this.OneDividedByX_button.UseVisualStyleBackColor = true;
            this.OneDividedByX_button.Click += new System.EventHandler(this.OneDividedByX_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(97, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 33);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(56, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 33);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 33);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(97, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 33);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MinValueBox
            // 
            this.MinValueBox.Location = new System.Drawing.Point(32, 397);
            this.MinValueBox.Name = "MinValueBox";
            this.MinValueBox.Size = new System.Drawing.Size(100, 23);
            this.MinValueBox.TabIndex = 2;
            this.MinValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinValueBox_KeyPress);
            // 
            // MaxValueBox
            // 
            this.MaxValueBox.Location = new System.Drawing.Point(226, 397);
            this.MaxValueBox.Name = "MaxValueBox";
            this.MaxValueBox.Size = new System.Drawing.Size(100, 23);
            this.MaxValueBox.TabIndex = 3;
            this.MaxValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxValueBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "MIN VALUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MAX VALUE";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // historyList
            // 
            this.historyList.FormattingEnabled = true;
            this.historyList.ItemHeight = 15;
            this.historyList.Location = new System.Drawing.Point(422, 29);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(202, 409);
            this.historyList.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxValueBox);
            this.Controls.Add(this.MinValueBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Field);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Field;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SinX_button;
        private System.Windows.Forms.Button Sqrt_button;
        private System.Windows.Forms.Button Equal_button;
        private System.Windows.Forms.Button Plus_button;
        private System.Windows.Forms.Button Division_button;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Minus_button;
        private System.Windows.Forms.Button Multiplication_button;
        private System.Windows.Forms.Button OneDividedByX_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Backspace_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Comma_button;
        private System.Windows.Forms.TextBox MinValueBox;
        private System.Windows.Forms.TextBox MaxValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox historyList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

