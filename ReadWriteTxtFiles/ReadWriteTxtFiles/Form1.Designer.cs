
namespace ReadWriteTxtFiles
{
    partial class ReadWriteTxtFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.ReadFilesRTB = new System.Windows.Forms.RichTextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(99, 21);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(162, 20);
            this.FirstNameTb.TabIndex = 4;
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(99, 56);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(162, 20);
            this.LastNameTb.TabIndex = 5;
            // 
            // GenderCb
            // 
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(99, 94);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(162, 21);
            this.GenderCb.TabIndex = 6;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(99, 127);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(162, 87);
            this.AddressTb.TabIndex = 7;
            this.AddressTb.TextChanged += new System.EventHandler(this.AddressTb_TextChanged);
            // 
            // ReadFilesRTB
            // 
            this.ReadFilesRTB.Location = new System.Drawing.Point(310, 18);
            this.ReadFilesRTB.Name = "ReadFilesRTB";
            this.ReadFilesRTB.Size = new System.Drawing.Size(311, 250);
            this.ReadFilesRTB.TabIndex = 9;
            this.ReadFilesRTB.Text = "";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(138, 245);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReadWriteTxtFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 346);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ReadFilesRTB);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReadWriteTxtFiles";
            this.ShowIcon = false;
            this.Text = "Read/Write.txt Files";
            this.Load += new System.EventHandler(this.ReadWriteTxtFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.RichTextBox ReadFilesRTB;
        private System.Windows.Forms.Button CreateBtn;
    }
}

