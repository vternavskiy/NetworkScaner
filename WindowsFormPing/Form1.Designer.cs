namespace WindowsFormPing
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
            dataGridView = new DataGridView();
            IPAddress = new DataGridViewTextBoxColumn();
            Hostname = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IPAddress, Hostname });
            dataGridView.Location = new Point(34, 226);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1189, 214);
            dataGridView.TabIndex = 0;
            // 
            // IPAddress
            // 
            IPAddress.HeaderText = "IPAddress";
            IPAddress.MinimumWidth = 8;
            IPAddress.Name = "IPAddress";
            IPAddress.Width = 150;
            // 
            // Hostname
            // 
            Hostname.HeaderText = "Hostname";
            Hostname.MinimumWidth = 8;
            Hostname.Name = "Hostname";
            Hostname.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(34, 86);
            button1.Name = "button1";
            button1.Size = new Size(153, 43);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 31);
            textBox1.TabIndex = 2;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 31);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 481);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn IPAddress;
        private DataGridViewTextBoxColumn Hostname;
    }
}
