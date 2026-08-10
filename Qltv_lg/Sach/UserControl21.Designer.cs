
namespace Qltv_lg.Sach
{
    partial class UserControl21
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.radio_Admin = new System.Windows.Forms.RadioButton();
            this.radio_User = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(244, 177);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 32);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "OK";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // radio_Admin
            // 
            this.radio_Admin.AutoSize = true;
            this.radio_Admin.Location = new System.Drawing.Point(365, 140);
            this.radio_Admin.Name = "radio_Admin";
            this.radio_Admin.Size = new System.Drawing.Size(68, 21);
            this.radio_Admin.TabIndex = 6;
            this.radio_Admin.Text = "Admin";
            this.radio_Admin.UseVisualStyleBackColor = true;
            this.radio_Admin.CheckedChanged += new System.EventHandler(this.radio_Admin_CheckedChanged);
            // 
            // radio_User
            // 
            this.radio_User.AutoSize = true;
            this.radio_User.Location = new System.Drawing.Point(163, 140);
            this.radio_User.Name = "radio_User";
            this.radio_User.Size = new System.Drawing.Size(59, 21);
            this.radio_User.TabIndex = 5;
            this.radio_User.Text = "User";
            this.radio_User.UseVisualStyleBackColor = true;
            this.radio_User.CheckedChanged += new System.EventHandler(this.radio_User_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(207, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Permissions to login";
            // 
            // UserControl21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.radio_Admin);
            this.Controls.Add(this.radio_User);
            this.Controls.Add(this.label1);
            this.Name = "UserControl21";
            this.Size = new System.Drawing.Size(597, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.RadioButton radio_Admin;
        private System.Windows.Forms.RadioButton radio_User;
        private System.Windows.Forms.Label label1;
    }
}
