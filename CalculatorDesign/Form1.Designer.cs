namespace CalculatorDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.modulusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.nOneButton = new System.Windows.Forms.Button();
            this.nTwoButton = new System.Windows.Forms.Button();
            this.nThreeButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.nFourButton = new System.Windows.Forms.Button();
            this.nFiveButton = new System.Windows.Forms.Button();
            this.nSixButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.nSevenButton = new System.Windows.Forms.Button();
            this.nEightButton = new System.Windows.Forms.Button();
            this.nNineButton = new System.Windows.Forms.Button();
            this.parenthesisButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.nZeroButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 3);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(277, 40);
            this.label21.TabIndex = 24;
            this.label21.Text = "0";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label22.Location = new System.Drawing.Point(1, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(277, 20);
            this.label22.TabIndex = 22;
            this.label22.Text = "0";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Lavender;
            this.label23.Location = new System.Drawing.Point(243, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 37);
            this.label23.TabIndex = 25;
            this.label23.Text = "×";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            this.label23.MouseEnter += new System.EventHandler(this.label23_MouseEnter);
            this.label23.MouseLeave += new System.EventHandler(this.label23_MouseLeave);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Lavender;
            this.label24.Location = new System.Drawing.Point(207, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 36);
            this.label24.TabIndex = 26;
            this.label24.Text = "⎯";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            this.label24.MouseEnter += new System.EventHandler(this.label24_MouseEnter);
            this.label24.MouseLeave += new System.EventHandler(this.label24_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Lavender;
            this.clearButton.Location = new System.Drawing.Point(8, 187);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 44);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearAll_click);
            this.clearButton.MouseEnter += new System.EventHandler(this.clearButton_MouseEnter);
            this.clearButton.MouseLeave += new System.EventHandler(this.clearButton_MouseLeave);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.Transparent;
            this.divisionButton.FlatAppearance.BorderSize = 0;
            this.divisionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.divisionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.divisionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.ForeColor = System.Drawing.Color.Lavender;
            this.divisionButton.Location = new System.Drawing.Point(77, 187);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(62, 44);
            this.divisionButton.TabIndex = 28;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.operator_click);
            this.divisionButton.MouseEnter += new System.EventHandler(this.divisionButton_MouseEnter);
            this.divisionButton.MouseLeave += new System.EventHandler(this.divisionButton_MouseLeave);
            // 
            // modulusButton
            // 
            this.modulusButton.BackColor = System.Drawing.Color.Transparent;
            this.modulusButton.FlatAppearance.BorderSize = 0;
            this.modulusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.modulusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.modulusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.modulusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulusButton.ForeColor = System.Drawing.Color.Lavender;
            this.modulusButton.Location = new System.Drawing.Point(143, 187);
            this.modulusButton.Name = "modulusButton";
            this.modulusButton.Size = new System.Drawing.Size(62, 44);
            this.modulusButton.TabIndex = 29;
            this.modulusButton.Text = "%";
            this.modulusButton.UseVisualStyleBackColor = false;
            this.modulusButton.MouseEnter += new System.EventHandler(this.modulusButton_MouseEnter);
            this.modulusButton.MouseLeave += new System.EventHandler(this.modulusButton_MouseLeave);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.FlatAppearance.BorderSize = 0;
            this.multiplyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.Color.Lavender;
            this.multiplyButton.Location = new System.Drawing.Point(211, 187);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multiplyButton.Size = new System.Drawing.Size(62, 44);
            this.multiplyButton.TabIndex = 30;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.operator_click);
            this.multiplyButton.MouseEnter += new System.EventHandler(this.multiplyButton_MouseEnter);
            this.multiplyButton.MouseLeave += new System.EventHandler(this.multiplyButton_MouseLeave);
            // 
            // nOneButton
            // 
            this.nOneButton.BackColor = System.Drawing.Color.Transparent;
            this.nOneButton.FlatAppearance.BorderSize = 0;
            this.nOneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nOneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOneButton.ForeColor = System.Drawing.Color.Lavender;
            this.nOneButton.Location = new System.Drawing.Point(7, 364);
            this.nOneButton.Name = "nOneButton";
            this.nOneButton.Size = new System.Drawing.Size(62, 44);
            this.nOneButton.TabIndex = 31;
            this.nOneButton.Text = "1";
            this.nOneButton.UseVisualStyleBackColor = false;
            this.nOneButton.Click += new System.EventHandler(this.number_click);
            this.nOneButton.MouseEnter += new System.EventHandler(this.nOneButton_MouseEnter);
            this.nOneButton.MouseLeave += new System.EventHandler(this.nOneButton_MouseLeave);
            // 
            // nTwoButton
            // 
            this.nTwoButton.BackColor = System.Drawing.Color.Transparent;
            this.nTwoButton.FlatAppearance.BorderSize = 0;
            this.nTwoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nTwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nTwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTwoButton.ForeColor = System.Drawing.Color.Lavender;
            this.nTwoButton.Location = new System.Drawing.Point(75, 364);
            this.nTwoButton.Name = "nTwoButton";
            this.nTwoButton.Size = new System.Drawing.Size(62, 44);
            this.nTwoButton.TabIndex = 32;
            this.nTwoButton.Text = "2";
            this.nTwoButton.UseVisualStyleBackColor = false;
            this.nTwoButton.Click += new System.EventHandler(this.number_click);
            this.nTwoButton.MouseEnter += new System.EventHandler(this.nTwoButton_MouseEnter);
            this.nTwoButton.MouseLeave += new System.EventHandler(this.nTwoButton_MouseLeave);
            // 
            // nThreeButton
            // 
            this.nThreeButton.BackColor = System.Drawing.Color.Transparent;
            this.nThreeButton.FlatAppearance.BorderSize = 0;
            this.nThreeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nThreeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nThreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nThreeButton.ForeColor = System.Drawing.Color.Lavender;
            this.nThreeButton.Location = new System.Drawing.Point(143, 364);
            this.nThreeButton.Name = "nThreeButton";
            this.nThreeButton.Size = new System.Drawing.Size(62, 44);
            this.nThreeButton.TabIndex = 33;
            this.nThreeButton.Text = "3";
            this.nThreeButton.UseVisualStyleBackColor = false;
            this.nThreeButton.Click += new System.EventHandler(this.number_click);
            this.nThreeButton.MouseEnter += new System.EventHandler(this.nThreeButton_MouseEnter);
            this.nThreeButton.MouseLeave += new System.EventHandler(this.nThreeButton_MouseLeave);
            // 
            // substractionButton
            // 
            this.substractionButton.BackColor = System.Drawing.Color.Transparent;
            this.substractionButton.FlatAppearance.BorderSize = 0;
            this.substractionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.substractionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.substractionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.substractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substractionButton.ForeColor = System.Drawing.Color.Lavender;
            this.substractionButton.Location = new System.Drawing.Point(212, 245);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(62, 44);
            this.substractionButton.TabIndex = 34;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = false;
            this.substractionButton.Click += new System.EventHandler(this.operator_click);
            this.substractionButton.MouseEnter += new System.EventHandler(this.substractionButton_MouseEnter);
            this.substractionButton.MouseLeave += new System.EventHandler(this.substractionButton_MouseLeave);
            // 
            // nFourButton
            // 
            this.nFourButton.BackColor = System.Drawing.Color.Transparent;
            this.nFourButton.FlatAppearance.BorderSize = 0;
            this.nFourButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nFourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nFourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFourButton.ForeColor = System.Drawing.Color.Lavender;
            this.nFourButton.Location = new System.Drawing.Point(8, 305);
            this.nFourButton.Name = "nFourButton";
            this.nFourButton.Size = new System.Drawing.Size(62, 44);
            this.nFourButton.TabIndex = 35;
            this.nFourButton.Text = "4";
            this.nFourButton.UseVisualStyleBackColor = false;
            this.nFourButton.Click += new System.EventHandler(this.number_click);
            this.nFourButton.MouseEnter += new System.EventHandler(this.nFourButton_MouseEnter);
            this.nFourButton.MouseLeave += new System.EventHandler(this.nFourButton_MouseLeave);
            // 
            // nFiveButton
            // 
            this.nFiveButton.BackColor = System.Drawing.Color.Transparent;
            this.nFiveButton.FlatAppearance.BorderSize = 0;
            this.nFiveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nFiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nFiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nFiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFiveButton.ForeColor = System.Drawing.Color.Lavender;
            this.nFiveButton.Location = new System.Drawing.Point(76, 305);
            this.nFiveButton.Name = "nFiveButton";
            this.nFiveButton.Size = new System.Drawing.Size(62, 44);
            this.nFiveButton.TabIndex = 36;
            this.nFiveButton.Text = "5";
            this.nFiveButton.UseVisualStyleBackColor = false;
            this.nFiveButton.Click += new System.EventHandler(this.number_click);
            this.nFiveButton.MouseEnter += new System.EventHandler(this.nFiveButton_MouseEnter);
            this.nFiveButton.MouseLeave += new System.EventHandler(this.nFiveButton_MouseLeave);
            // 
            // nSixButton
            // 
            this.nSixButton.BackColor = System.Drawing.Color.Transparent;
            this.nSixButton.FlatAppearance.BorderSize = 0;
            this.nSixButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nSixButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nSixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nSixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nSixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSixButton.ForeColor = System.Drawing.Color.Lavender;
            this.nSixButton.Location = new System.Drawing.Point(144, 305);
            this.nSixButton.Name = "nSixButton";
            this.nSixButton.Size = new System.Drawing.Size(62, 44);
            this.nSixButton.TabIndex = 37;
            this.nSixButton.Text = "6";
            this.nSixButton.UseVisualStyleBackColor = false;
            this.nSixButton.Click += new System.EventHandler(this.number_click);
            this.nSixButton.MouseEnter += new System.EventHandler(this.nSixButton_MouseEnter);
            this.nSixButton.MouseLeave += new System.EventHandler(this.nSixButton_MouseLeave);
            // 
            // additionButton
            // 
            this.additionButton.BackColor = System.Drawing.Color.Transparent;
            this.additionButton.FlatAppearance.BorderSize = 0;
            this.additionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.additionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.additionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.additionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.ForeColor = System.Drawing.Color.Lavender;
            this.additionButton.Location = new System.Drawing.Point(211, 305);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(62, 44);
            this.additionButton.TabIndex = 38;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = false;
            this.additionButton.Click += new System.EventHandler(this.operator_click);
            this.additionButton.MouseEnter += new System.EventHandler(this.additionButton_MouseEnter);
            this.additionButton.MouseLeave += new System.EventHandler(this.additionButton_MouseLeave);
            // 
            // nSevenButton
            // 
            this.nSevenButton.BackColor = System.Drawing.Color.Transparent;
            this.nSevenButton.FlatAppearance.BorderSize = 0;
            this.nSevenButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nSevenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nSevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nSevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nSevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSevenButton.ForeColor = System.Drawing.Color.Lavender;
            this.nSevenButton.Location = new System.Drawing.Point(9, 249);
            this.nSevenButton.Name = "nSevenButton";
            this.nSevenButton.Size = new System.Drawing.Size(62, 44);
            this.nSevenButton.TabIndex = 39;
            this.nSevenButton.Text = "7";
            this.nSevenButton.UseVisualStyleBackColor = false;
            this.nSevenButton.Click += new System.EventHandler(this.number_click);
            this.nSevenButton.MouseEnter += new System.EventHandler(this.nSevenButton_MouseEnter);
            this.nSevenButton.MouseLeave += new System.EventHandler(this.nSevenButton_MouseLeave);
            // 
            // nEightButton
            // 
            this.nEightButton.BackColor = System.Drawing.Color.Transparent;
            this.nEightButton.FlatAppearance.BorderSize = 0;
            this.nEightButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nEightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nEightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nEightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nEightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nEightButton.ForeColor = System.Drawing.Color.Lavender;
            this.nEightButton.Location = new System.Drawing.Point(77, 249);
            this.nEightButton.Name = "nEightButton";
            this.nEightButton.Size = new System.Drawing.Size(62, 44);
            this.nEightButton.TabIndex = 40;
            this.nEightButton.Text = "8";
            this.nEightButton.UseVisualStyleBackColor = false;
            this.nEightButton.Click += new System.EventHandler(this.number_click);
            this.nEightButton.MouseEnter += new System.EventHandler(this.nEightButton_MouseEnter);
            this.nEightButton.MouseLeave += new System.EventHandler(this.nEightButton_MouseLeave);
            // 
            // nNineButton
            // 
            this.nNineButton.BackColor = System.Drawing.Color.Transparent;
            this.nNineButton.FlatAppearance.BorderSize = 0;
            this.nNineButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nNineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nNineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nNineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nNineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNineButton.ForeColor = System.Drawing.Color.Lavender;
            this.nNineButton.Location = new System.Drawing.Point(145, 249);
            this.nNineButton.Name = "nNineButton";
            this.nNineButton.Size = new System.Drawing.Size(62, 44);
            this.nNineButton.TabIndex = 41;
            this.nNineButton.Text = "9";
            this.nNineButton.UseVisualStyleBackColor = false;
            this.nNineButton.Click += new System.EventHandler(this.number_click);
            this.nNineButton.MouseEnter += new System.EventHandler(this.nNineButton_MouseEnter);
            this.nNineButton.MouseLeave += new System.EventHandler(this.nNineButton_MouseLeave);
            // 
            // parenthesisButton
            // 
            this.parenthesisButton.BackColor = System.Drawing.Color.Transparent;
            this.parenthesisButton.FlatAppearance.BorderSize = 0;
            this.parenthesisButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.parenthesisButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.parenthesisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.parenthesisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parenthesisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parenthesisButton.ForeColor = System.Drawing.Color.Lavender;
            this.parenthesisButton.Location = new System.Drawing.Point(213, 360);
            this.parenthesisButton.Name = "parenthesisButton";
            this.parenthesisButton.Size = new System.Drawing.Size(62, 44);
            this.parenthesisButton.TabIndex = 42;
            this.parenthesisButton.Text = "(  )";
            this.parenthesisButton.UseVisualStyleBackColor = false;
            this.parenthesisButton.MouseEnter += new System.EventHandler(this.parenthesisButton_MouseEnter);
            this.parenthesisButton.MouseLeave += new System.EventHandler(this.parenthesisButton_MouseLeave);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.Color.Transparent;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.decimalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.decimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.ForeColor = System.Drawing.Color.Lavender;
            this.decimalButton.Location = new System.Drawing.Point(8, 412);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(62, 44);
            this.decimalButton.TabIndex = 43;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.number_click);
            this.decimalButton.MouseEnter += new System.EventHandler(this.decimalButton_MouseEnter);
            this.decimalButton.MouseLeave += new System.EventHandler(this.decimalButton_MouseLeave);
            // 
            // nZeroButton
            // 
            this.nZeroButton.BackColor = System.Drawing.Color.Transparent;
            this.nZeroButton.FlatAppearance.BorderSize = 0;
            this.nZeroButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.nZeroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nZeroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nZeroButton.ForeColor = System.Drawing.Color.Lavender;
            this.nZeroButton.Location = new System.Drawing.Point(73, 417);
            this.nZeroButton.Name = "nZeroButton";
            this.nZeroButton.Size = new System.Drawing.Size(62, 44);
            this.nZeroButton.TabIndex = 44;
            this.nZeroButton.Text = "0";
            this.nZeroButton.UseVisualStyleBackColor = false;
            this.nZeroButton.Click += new System.EventHandler(this.number_click);
            this.nZeroButton.MouseEnter += new System.EventHandler(this.nZeroButton_MouseEnter);
            this.nZeroButton.MouseLeave += new System.EventHandler(this.nZeroButton_MouseLeave);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.Transparent;
            this.backspaceButton.FlatAppearance.BorderSize = 0;
            this.backspaceButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.backspaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backspaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.ForeColor = System.Drawing.Color.Lavender;
            this.backspaceButton.Location = new System.Drawing.Point(144, 416);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(62, 44);
            this.backspaceButton.TabIndex = 45;
            this.backspaceButton.Text = "⮨";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.backspace_click);
            this.backspaceButton.MouseEnter += new System.EventHandler(this.backspaceButton_MouseEnter);
            this.backspaceButton.MouseLeave += new System.EventHandler(this.backspaceButton_MouseLeave);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.Transparent;
            this.equalsButton.FlatAppearance.BorderSize = 0;
            this.equalsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.equalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.equalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.equalsButton.Location = new System.Drawing.Point(213, 409);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(62, 44);
            this.equalsButton.TabIndex = 46;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.resultValue_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(278, 477);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.nZeroButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.parenthesisButton);
            this.Controls.Add(this.nNineButton);
            this.Controls.Add(this.nEightButton);
            this.Controls.Add(this.nSevenButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.nSixButton);
            this.Controls.Add(this.nFiveButton);
            this.Controls.Add(this.nFourButton);
            this.Controls.Add(this.substractionButton);
            this.Controls.Add(this.nThreeButton);
            this.Controls.Add(this.nTwoButton);
            this.Controls.Add(this.nOneButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.modulusButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button modulusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button nOneButton;
        private System.Windows.Forms.Button nTwoButton;
        private System.Windows.Forms.Button nThreeButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button nFourButton;
        private System.Windows.Forms.Button nFiveButton;
        private System.Windows.Forms.Button nSixButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button nSevenButton;
        private System.Windows.Forms.Button nEightButton;
        private System.Windows.Forms.Button nNineButton;
        private System.Windows.Forms.Button parenthesisButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button nZeroButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button equalsButton;
    }
}

