namespace Tribunal4
{
    public partial class ExitApp
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
            ListTribunals = new ListBox();
            CurrentTribunal = new TextBox();
            exit = new Button();
            NewTribunalNumber = new TextBox();
            LastName = new TextBox();
            Firstname = new TextBox();
            AddTribunal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TribunalHelpMsg = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ShowTribunals
            // 
            ShowTribunals.Location = new Point(288, 268);
            ShowTribunals.Name = "ShowTribunals";
            ShowTribunals.Size = new Size(201, 43);
            ShowTribunals.TabIndex = 0;
            ShowTribunals.Text = "Show Tribunals List";
            ShowTribunals.UseVisualStyleBackColor = true;
            ShowTribunals.Click += ListTribunalbutton1_Click;
            // 
            // ListTribunals
            // 
            ListTribunals.FormattingEnabled = true;
            ListTribunals.ItemHeight = 20;
            ListTribunals.Location = new Point(160, 73);
            ListTribunals.Name = "ListTribunals";
            ListTribunals.Size = new Size(475, 164);
            ListTribunals.TabIndex = 1;
            ListTribunals.SelectedIndexChanged += ListTribunals_SelectedIndexChanged;
            ListTribunals.MouseDoubleClick += ListTribunals_MouseDoubleClick;
            // 
            // CurrentTribunal
            // 
            CurrentTribunal.Location = new Point(577, 331);
            CurrentTribunal.Name = "CurrentTribunal";
            CurrentTribunal.Size = new Size(177, 27);
            CurrentTribunal.TabIndex = 2;
            CurrentTribunal.TextChanged += textBox1_TextChanged;
            // 
            // exit
            // 
            exit.Location = new Point(704, 1);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click_1;
            // 
            // NewTribunalNumber
            // 
            NewTribunalNumber.Location = new Point(147, 317);
            NewTribunalNumber.Name = "NewTribunalNumber";
            NewTribunalNumber.Size = new Size(187, 27);
            NewTribunalNumber.TabIndex = 4;
            NewTribunalNumber.Text = "ED555/024/XXX";
            NewTribunalNumber.TextChanged += textBox1_TextChanged_1;
            // 
            // LastName
            // 
            LastName.Location = new Point(147, 355);
            LastName.Name = "LastName";
            LastName.Size = new Size(125, 27);
            LastName.TabIndex = 5;
            // 
            // Firstname
            // 
            Firstname.Location = new Point(147, 399);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(125, 27);
            Firstname.TabIndex = 6;
            // 
            // AddTribunal
            // 
            AddTribunal.Location = new Point(337, 399);
            AddTribunal.Name = "AddTribunal";
            AddTribunal.Size = new Size(94, 29);
            AddTribunal.TabIndex = 7;
            AddTribunal.Text = "Add Tribunal";
            AddTribunal.UseVisualStyleBackColor = true;
            AddTribunal.Click += button1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 320);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 8;
            label1.Text = "Ref to Add";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 362);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 9;
            label2.Text = "Lastname to add";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 402);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 10;
            label3.Text = "Firstname to add";
            // 
            // TribunalHelpMsg
            // 
            TribunalHelpMsg.AutoSize = true;
            TribunalHelpMsg.Location = new Point(195, 240);
            TribunalHelpMsg.Name = "TribunalHelpMsg";
            TribunalHelpMsg.Size = new Size(413, 20);
            TribunalHelpMsg.TabIndex = 11;
            TribunalHelpMsg.Text = "Double Click a Tribunal Reference to view key direction dates";
            TribunalHelpMsg.Visible = false;
            TribunalHelpMsg.Click += TribunalHelpMsg_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(288, 10);
            label4.Name = "label4";
            label4.Size = new Size(179, 28);
            label4.TabIndex = 12;
            label4.Text = "Tribunal Manager";
            label4.Click += label4_Click;
            // 
            // ExitApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(TribunalHelpMsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddTribunal);
            Controls.Add(Firstname);
            Controls.Add(LastName);
            Controls.Add(NewTribunalNumber);
            Controls.Add(exit);
            Controls.Add(CurrentTribunal);
            Controls.Add(ListTribunals);
            Controls.Add(ShowTribunals);
            Name = "ExitApp";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShowTribunals;
        private ListBox ListTribunals;
        private TextBox CurrentTribunal;
        private Button exit;
        private TextBox NewTribunalNumber;
        private TextBox LastName;
        private TextBox Firstname;
        private Button AddTribunal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TribunalHelpMsg;
        private Label label4;
    }
}