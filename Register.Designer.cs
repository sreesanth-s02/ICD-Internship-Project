namespace Project1ICD
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 24);
            label1.Name = "label1";
            label1.Size = new Size(225, 42);
            label1.TabIndex = 0;
            label1.Text = "Register Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 119);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 162);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 203);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 3;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 248);
            label5.Name = "label5";
            label5.Size = new Size(119, 26);
            label5.TabIndex = 4;
            label5.Text = "Phone_no :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 300);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 5;
            label6.Text = "Email_id :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(236, 347);
            label7.Name = "label7";
            label7.Size = new Size(96, 26);
            label7.TabIndex = 6;
            label7.Text = "User_id :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 30);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 30);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(338, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 30);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 30);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(338, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 30);
            textBox5.TabIndex = 11;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(338, 347);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 30);
            textBox6.TabIndex = 12;
            textBox6.Leave += textBox6_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Location = new Point(213, 402);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(393, 402);
            button2.Name = "button2";
            button2.Size = new Size(105, 44);
            button2.TabIndex = 14;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(784, 526);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}