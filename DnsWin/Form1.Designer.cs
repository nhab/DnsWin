namespace DnsWin
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
            InterfacesListBox = new ListBox();
            AddDnsButton = new Button();
            textBox1 = new TextBox();
            DnsListBox = new ListBox();
            RemoveDnsButton = new Button();
            SuspendLayout();
            // 
            // InterfacesListBox
            // 
            InterfacesListBox.FormattingEnabled = true;
            InterfacesListBox.ItemHeight = 15;
            InterfacesListBox.Location = new Point(15, 19);
            InterfacesListBox.Name = "InterfacesListBox";
            InterfacesListBox.Size = new Size(439, 139);
            InterfacesListBox.TabIndex = 0;
            InterfacesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddDnsButton
            // 
            AddDnsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddDnsButton.Location = new Point(516, 173);
            AddDnsButton.Name = "AddDnsButton";
            AddDnsButton.Size = new Size(39, 40);
            AddDnsButton.TabIndex = 1;
            AddDnsButton.Text = "+";
            AddDnsButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(563, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 35);
            textBox1.TabIndex = 2;
            // 
            // DnsListBox
            // 
            DnsListBox.FormattingEnabled = true;
            DnsListBox.ItemHeight = 15;
            DnsListBox.Location = new Point(473, 19);
            DnsListBox.Name = "DnsListBox";
            DnsListBox.Size = new Size(301, 139);
            DnsListBox.TabIndex = 0;
            // 
            // RemoveDnsButton
            // 
            RemoveDnsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveDnsButton.Location = new Point(473, 173);
            RemoveDnsButton.Name = "RemoveDnsButton";
            RemoveDnsButton.Size = new Size(39, 40);
            RemoveDnsButton.TabIndex = 1;
            RemoveDnsButton.Text = "-";
            RemoveDnsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 231);
            Controls.Add(textBox1);
            Controls.Add(RemoveDnsButton);
            Controls.Add(AddDnsButton);
            Controls.Add(DnsListBox);
            Controls.Add(InterfacesListBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Dns";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox InterfacesListBox;
        private Button AddDnsButton;
        private TextBox textBox1;
        private ListBox DnsListBox;
        private Button RemoveDnsButton;
    }
}
