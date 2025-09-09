namespace Calculator
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
            eraseButton = new Button();
            toggleSignButton = new Button();
            button4 = new Button();
            divideButton = new Button();
            button8 = new Button();
            percentButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button9 = new Button();
            button5 = new Button();
            button10 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timesButton = new Button();
            minusButton = new Button();
            plusButton = new Button();
            equalsButton = new Button();
            nButton = new Button();
            button0 = new Button();
            decimalButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button7 = new Button();
            textBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // eraseButton
            // 
            eraseButton.AccessibleDescription = "";
            eraseButton.BackColor = Color.DarkGray;
            eraseButton.Dock = DockStyle.Fill;
            eraseButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            eraseButton.ForeColor = Color.White;
            eraseButton.Location = new Point(3, 3);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(194, 146);
            eraseButton.TabIndex = 0;
            eraseButton.Text = "AC";
            eraseButton.UseVisualStyleBackColor = false;
            eraseButton.Click += eraseButtonClick;
            // 
            // toggleSignButton
            // 
            toggleSignButton.BackColor = Color.DarkGray;
            toggleSignButton.Dock = DockStyle.Fill;
            toggleSignButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            toggleSignButton.ForeColor = Color.White;
            toggleSignButton.Location = new Point(203, 3);
            toggleSignButton.Name = "toggleSignButton";
            toggleSignButton.Size = new Size(194, 146);
            toggleSignButton.TabIndex = 3;
            toggleSignButton.Text = "+/-";
            toggleSignButton.UseVisualStyleBackColor = false;
            toggleSignButton.Click += toggleSignButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 307);
            button4.Name = "button4";
            button4.Size = new Size(194, 146);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += numberButtonClicked;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(255, 128, 0);
            divideButton.Dock = DockStyle.Fill;
            divideButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(603, 3);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(194, 146);
            divideButton.TabIndex = 5;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += operatorButtonClicked;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(203, 155);
            button8.Name = "button8";
            button8.Size = new Size(194, 146);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += numberButtonClicked;
            // 
            // percentButton
            // 
            percentButton.BackColor = Color.DarkGray;
            percentButton.Dock = DockStyle.Fill;
            percentButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            percentButton.ForeColor = Color.White;
            percentButton.Location = new Point(403, 3);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(194, 146);
            percentButton.TabIndex = 7;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = false;
            percentButton.Click += operatorButtonClicked;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(403, 155);
            button9.Name = "button9";
            button9.Size = new Size(194, 146);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += numberButtonClicked;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(203, 307);
            button5.Name = "button5";
            button5.Size = new Size(194, 146);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += numberButtonClicked;
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(403, 307);
            button10.Name = "button10";
            button10.Size = new Size(194, 146);
            button10.TabIndex = 10;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += numberButtonClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 459);
            button1.Name = "button1";
            button1.Size = new Size(194, 146);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += numberButtonClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(203, 459);
            button2.Name = "button2";
            button2.Size = new Size(194, 146);
            button2.TabIndex = 12;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += numberButtonClicked;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(403, 459);
            button3.Name = "button3";
            button3.Size = new Size(194, 146);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += numberButtonClicked;
            // 
            // timesButton
            // 
            timesButton.BackColor = Color.FromArgb(255, 128, 0);
            timesButton.Dock = DockStyle.Fill;
            timesButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            timesButton.ForeColor = Color.White;
            timesButton.Location = new Point(603, 155);
            timesButton.Name = "timesButton";
            timesButton.Size = new Size(194, 146);
            timesButton.TabIndex = 14;
            timesButton.Text = "x";
            timesButton.UseVisualStyleBackColor = false;
            timesButton.Click += operatorButtonClicked;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.FromArgb(255, 128, 0);
            minusButton.Dock = DockStyle.Fill;
            minusButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(603, 307);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(194, 146);
            minusButton.TabIndex = 15;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += operatorButtonClicked;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.FromArgb(255, 128, 0);
            plusButton.Dock = DockStyle.Fill;
            plusButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(603, 459);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(194, 146);
            plusButton.TabIndex = 16;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += operatorButtonClicked;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.FromArgb(255, 128, 0);
            equalsButton.Dock = DockStyle.Fill;
            equalsButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            equalsButton.ForeColor = Color.White;
            equalsButton.Location = new Point(603, 611);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(194, 148);
            equalsButton.TabIndex = 17;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButtonClick;
            // 
            // nButton
            // 
            nButton.BackColor = Color.Gray;
            nButton.Dock = DockStyle.Fill;
            nButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            nButton.ForeColor = Color.White;
            nButton.Location = new Point(3, 611);
            nButton.Name = "nButton";
            nButton.Size = new Size(194, 148);
            nButton.TabIndex = 18;
            nButton.Text = "MR";
            nButton.UseVisualStyleBackColor = false;
            nButton.Click += button18_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.Gray;
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button0.ForeColor = Color.White;
            button0.Location = new Point(203, 611);
            button0.Name = "button0";
            button0.Size = new Size(194, 148);
            button0.TabIndex = 19;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += numberButtonClicked;
            // 
            // decimalButton
            // 
            decimalButton.BackColor = Color.Gray;
            decimalButton.Dock = DockStyle.Fill;
            decimalButton.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            decimalButton.ForeColor = Color.White;
            decimalButton.Location = new Point(403, 611);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(194, 148);
            decimalButton.TabIndex = 20;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = false;
            decimalButton.Click += operatorButtonClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(eraseButton, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button10, 2, 2);
            tableLayoutPanel1.Controls.Add(toggleSignButton, 1, 0);
            tableLayoutPanel1.Controls.Add(percentButton, 2, 0);
            tableLayoutPanel1.Controls.Add(timesButton, 3, 1);
            tableLayoutPanel1.Controls.Add(minusButton, 3, 2);
            tableLayoutPanel1.Controls.Add(decimalButton, 2, 4);
            tableLayoutPanel1.Controls.Add(plusButton, 3, 3);
            tableLayoutPanel1.Controls.Add(button7, 0, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 1);
            tableLayoutPanel1.Controls.Add(button9, 2, 1);
            tableLayoutPanel1.Controls.Add(equalsButton, 3, 4);
            tableLayoutPanel1.Controls.Add(button0, 1, 4);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(nButton, 0, 4);
            tableLayoutPanel1.Controls.Add(divideButton, 3, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(button3, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 249);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 762);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Verdana", 13.875F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 155);
            button7.Name = "button7";
            button7.Size = new Size(194, 146);
            button7.TabIndex = 22;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += numberButtonClicked;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(64, 64, 64);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Tahoma", 31.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(3, 122);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(785, 103);
            textBox.TabIndex = 22;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 1011);
            Controls.Add(textBox);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Rago's Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button eraseButton;
        private Button toggleSignButton;
        private Button button4;
        private Button divideButton;
        private Button button8;
        private Button percentButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button9;
        private Button button5;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button timesButton;
        private Button minusButton;
        private Button plusButton;
        private Button equalsButton;
        private Button nButton;
        private Button button0;
        private Button decimalButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private TextBox textBox;
    }
}
