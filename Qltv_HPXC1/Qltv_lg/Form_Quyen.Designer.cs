
namespace Qltv_lg
{
    partial class Form_Quyen
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
            this.radio_User = new System.Windows.Forms.RadioButton();
            this.radio_Admin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(174, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permissions to login";
            // 
            // radio_User
            // 
            this.radio_User.AutoSize = true;
            this.radio_User.Checked = true;
            this.radio_User.Location = new System.Drawing.Point(130, 126);
            this.radio_User.Name = "radio_User";
            this.radio_User.Size = new System.Drawing.Size(59, 21);
            this.radio_User.TabIndex = 1;
            this.radio_User.TabStop = true;
            this.radio_User.Text = "User";
            this.radio_User.UseVisualStyleBackColor = true;
            this.radio_User.CheckedChanged += new System.EventHandler(this.radio_User_CheckedChanged);
            // 
            // radio_Admin
            // 
            this.radio_Admin.AutoSize = true;
            this.radio_Admin.Location = new System.Drawing.Point(332, 126);
            this.radio_Admin.Name = "radio_Admin";
            this.radio_Admin.Size = new System.Drawing.Size(68, 21);
            this.radio_Admin.TabIndex = 2;
            this.radio_Admin.Text = "Admin";
            this.radio_Admin.UseVisualStyleBackColor = true;
            this.radio_Admin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_Admin);
            this.Controls.Add(this.radio_User);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form_Quyen";
            this.Text = "Form_Quyen";
            this.Load += new System.EventHandler(this.Form_Quyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_User;
        private System.Windows.Forms.RadioButton radio_Admin;
        private System.Windows.Forms.Button button1;
    }
}