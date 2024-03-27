namespace PhotoApp
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
            smallsize = new RadioButton();
            groupBox1 = new GroupBox();
            largesize = new RadioButton();
            mediumsize = new RadioButton();
            label1 = new Label();
            amount_value = new TextBox();
            Count_Amount = new Button();
            result_output = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // smallsize
            // 
            smallsize.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smallsize.ForeColor = Color.DarkSlateGray;
            smallsize.Location = new Point(6, 77);
            smallsize.Name = "smallsize";
            smallsize.Size = new Size(241, 53);
            smallsize.TabIndex = 0;
            smallsize.TabStop = true;
            smallsize.Text = " 9 x 12";
            smallsize.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(largesize);
            groupBox1.Controls.Add(mediumsize);
            groupBox1.Controls.Add(smallsize);
            groupBox1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(126, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 282);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // largesize
            // 
            largesize.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            largesize.ForeColor = Color.DarkSlateGray;
            largesize.Location = new Point(6, 223);
            largesize.Name = "largesize";
            largesize.Size = new Size(241, 53);
            largesize.TabIndex = 2;
            largesize.TabStop = true;
            largesize.Text = "18 x 24";
            largesize.UseVisualStyleBackColor = true;
            // 
            // mediumsize
            // 
            mediumsize.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediumsize.ForeColor = Color.DarkSlateGray;
            mediumsize.Location = new Point(6, 151);
            mediumsize.Name = "mediumsize";
            mediumsize.Size = new Size(241, 53);
            mediumsize.TabIndex = 1;
            mediumsize.TabStop = true;
            mediumsize.Text = "12 x 15";
            mediumsize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(83, 566);
            label1.Name = "label1";
            label1.Size = new Size(193, 49);
            label1.TabIndex = 2;
            label1.Text = "Amount : ";
            // 
            // amount_value
            // 
            amount_value.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount_value.Location = new Point(282, 551);
            amount_value.Multiline = true;
            amount_value.Name = "amount_value";
            amount_value.Size = new Size(205, 77);
            amount_value.TabIndex = 3;
            // 
            // Count_Amount
            // 
            Count_Amount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Count_Amount.ForeColor = Color.DarkSlateGray;
            Count_Amount.Location = new Point(533, 567);
            Count_Amount.Name = "Count_Amount";
            Count_Amount.Size = new Size(206, 61);
            Count_Amount.TabIndex = 4;
            Count_Amount.Text = "OK";
            Count_Amount.UseVisualStyleBackColor = true;
            Count_Amount.Click += Count_Amount_Click;
            // 
            // result_output
            // 
            result_output.AutoSize = true;
            result_output.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result_output.ForeColor = Color.DarkSlateGray;
            result_output.Location = new Point(373, 713);
            result_output.Name = "result_output";
            result_output.Size = new Size(0, 42);
            result_output.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(271, 111);
            label2.Name = "label2";
            label2.Size = new Size(334, 49);
            label2.TabIndex = 6;
            label2.Text = "Calculate a price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(112, 712);
            label3.Name = "label3";
            label3.Size = new Size(249, 42);
            label3.TabIndex = 7;
            label3.Text = "Total amount :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(937, 792);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(result_output);
            Controls.Add(Count_Amount);
            Controls.Add(amount_value);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = Color.CadetBlue;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        public RadioButton smallsize;
        public TextBox amount_value;
        public RadioButton largesize;
        public RadioButton mediumsize;
        public Button Count_Amount;
        public Label result_output;
        public Label label3;
    }
}
