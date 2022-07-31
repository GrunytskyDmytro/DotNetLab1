namespace ATMFormsApp
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
            this.Sum_Box = new System.Windows.Forms.TextBox();
            this.Dest_Box = new System.Windows.Forms.TextBox();
            this.Auth_button = new System.Windows.Forms.Button();
            this.Button_ShowBalance = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Withdraw_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sum_Box
            // 
            this.Sum_Box.Location = new System.Drawing.Point(6, 21);
            this.Sum_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sum_Box.Name = "Sum_Box";
            this.Sum_Box.PlaceholderText = "Card number";
            this.Sum_Box.Size = new System.Drawing.Size(210, 23);
            this.Sum_Box.TabIndex = 2;
            // 
            // Dest_Box
            // 
            this.Dest_Box.Location = new System.Drawing.Point(6, 52);
            this.Dest_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dest_Box.Name = "Dest_Box";
            this.Dest_Box.PlaceholderText = "Pin code";
            this.Dest_Box.Size = new System.Drawing.Size(210, 23);
            this.Dest_Box.TabIndex = 3;
            // 
            // Auth_button
            // 
            this.Auth_button.BackColor = System.Drawing.Color.Lime;
            this.Auth_button.Location = new System.Drawing.Point(6, 87);
            this.Auth_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(210, 22);
            this.Auth_button.TabIndex = 4;
            this.Auth_button.Text = "Authenticate";
            this.Auth_button.UseVisualStyleBackColor = false;
            this.Auth_button.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // Button_ShowBalance
            // 
            this.Button_ShowBalance.Location = new System.Drawing.Point(6, 14);
            this.Button_ShowBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ShowBalance.Name = "Button_ShowBalance";
            this.Button_ShowBalance.Size = new System.Drawing.Size(108, 37);
            this.Button_ShowBalance.TabIndex = 7;
            this.Button_ShowBalance.Text = "Show balance";
            this.Button_ShowBalance.UseVisualStyleBackColor = true;
            this.Button_ShowBalance.Visible = false;
            this.Button_ShowBalance.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(120, 14);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(108, 37);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Add money";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Visible = false;
            this.Add_Button.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Withdraw_Button
            // 
            this.Withdraw_Button.Location = new System.Drawing.Point(234, 14);
            this.Withdraw_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw_Button.Name = "Withdraw_Button";
            this.Withdraw_Button.Size = new System.Drawing.Size(108, 37);
            this.Withdraw_Button.TabIndex = 9;
            this.Withdraw_Button.Text = "Withdraw money";
            this.Withdraw_Button.UseVisualStyleBackColor = true;
            this.Withdraw_Button.Visible = false;
            this.Withdraw_Button.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(348, 14);
            this.Send_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(108, 37);
            this.Send_Button.TabIndex = 10;
            this.Send_Button.Text = "Send Money";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Visible = false;
            this.Send_Button.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.Red;
            this.Logout_Button.Location = new System.Drawing.Point(189, 240);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(108, 31);
            this.Logout_Button.TabIndex = 11;
            this.Logout_Button.Text = "Log out";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Visible = false;
            this.Logout_Button.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sum_Box);
            this.groupBox1.Controls.Add(this.Dest_Box);
            this.groupBox1.Controls.Add(this.Auth_button);
            this.groupBox1.Location = new System.Drawing.Point(132, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_ShowBalance);
            this.groupBox2.Controls.Add(this.Add_Button);
            this.groupBox2.Controls.Add(this.Withdraw_Button);
            this.groupBox2.Controls.Add(this.Send_Button);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logout_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(501, 321);
            this.MinimumSize = new System.Drawing.Size(501, 321);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox Sum_Box;
        private TextBox Dest_Box;
        private Button Auth_button;
        private Button Button_ShowBalance;
        private Button Add_Button;
        private Button Withdraw_Button;
        private Button Send_Button;
        private Button Logout_Button;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}