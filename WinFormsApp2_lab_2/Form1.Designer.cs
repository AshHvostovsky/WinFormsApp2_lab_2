namespace WinFormsApp2_lab_2
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
            txtBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(149, 58);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(242, 23);
            txtBox.TabIndex = 0;
            txtBox.KeyDown += txtBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите предложение";
            // 
            // button1
            // 
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(376, 23);
            button1.TabIndex = 2;
            button1.Text = "Определить повторяющиеся буквы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 37);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(343, 30);
            label2.TabIndex = 4;
            label2.Text = "Дано предложение. Определить, сколько в нем одинаковых соседних букв. Пробелы не учитывать.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 120);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Повторяющиеся буквы";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}
