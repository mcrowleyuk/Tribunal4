namespace Tribunal4
{
    public partial class Form1
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
            ShowTribunals = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            CurrentReg = new TextBox();
            SuspendLayout();
            // 
            // ShowTribunals
            // 
            ShowTribunals.Location = new Point(328, 315);
            ShowTribunals.Name = "ShowTribunals";
            ShowTribunals.Size = new Size(201, 43);
            ShowTribunals.TabIndex = 0;
            ShowTribunals.Text = "Show Tribunals List";
            ShowTribunals.UseVisualStyleBackColor = true;
            ShowTribunals.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(160, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(475, 164);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(577, 331);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 2;
            // 
            // CurrentReg
            // 
            CurrentReg.Location = new Point(43, 286);
            CurrentReg.Name = "CurrentReg";
            CurrentReg.Size = new Size(125, 27);
            CurrentReg.TabIndex = 3;
            CurrentReg.Text = "BLANK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentReg);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(ShowTribunals);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShowTribunals;
        private ListBox listBox1;
        private TextBox textBox1;
        public TextBox CurrentReg;
    }
}