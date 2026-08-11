
namespace Qltv_lg
{
    partial class Fm_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Login));
            this.bt_Login = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Ck_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Lb_CreatAccount = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lb_Content = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_UsernameSg = new System.Windows.Forms.TextBox();
            this.text_PassWordSg = new System.Windows.Forms.TextBox();
            this.bt_Sigin = new System.Windows.Forms.Button();
            this.txt_Re_EnterPassWord = new System.Windows.Forms.TextBox();
            this.Pn_Sign = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.svgImageBox6 = new DevExpress.XtraEditors.SvgImageBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.svgImageBox5 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox4 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox3 = new DevExpress.XtraEditors.SvgImageBox();
            this.Bt_BackLogin = new System.Windows.Forms.Button();
            this.CheckPasswordold_new = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pn_Login = new System.Windows.Forms.Panel();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pn_Sign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).BeginInit();
            this.Pn_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.Transparent;
            this.bt_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Login.FlatAppearance.BorderSize = 2;
            this.bt_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Login.Location = new System.Drawing.Point(148, 342);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(164, 65);
            this.bt_Login.TabIndex = 1;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.Gray;
            this.txt_UserName.Location = new System.Drawing.Point(85, 128);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(262, 43);
            this.txt_UserName.TabIndex = 2;
            this.txt_UserName.Text = "Username";
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            this.txt_UserName.Enter += new System.EventHandler(this.txt_Username_Enter);
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UserName_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Gray;
            this.txt_Password.Location = new System.Drawing.Point(85, 212);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(260, 48);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.Text = "Password";
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_PassWord_Leave);
            // 
            // Ck_ShowPassword
            // 
            this.Ck_ShowPassword.AutoSize = true;
            this.Ck_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.Ck_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ck_ShowPassword.Location = new System.Drawing.Point(85, 293);
            this.Ck_ShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ck_ShowPassword.Name = "Ck_ShowPassword";
            this.Ck_ShowPassword.Size = new System.Drawing.Size(164, 24);
            this.Ck_ShowPassword.TabIndex = 4;
            this.Ck_ShowPassword.Text = "Show Password";
            this.Ck_ShowPassword.UseVisualStyleBackColor = false;
            this.Ck_ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // Lb_CreatAccount
            // 
            this.Lb_CreatAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatAccount.Appearance.Options.UseFont = true;
            this.Lb_CreatAccount.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.Lb_CreatAccount.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.Lb_CreatAccount.AppearanceHovered.ForeColor = System.Drawing.Color.Aqua;
            this.Lb_CreatAccount.AppearanceHovered.Options.UseBackColor = true;
            this.Lb_CreatAccount.AppearanceHovered.Options.UseForeColor = true;
            this.Lb_CreatAccount.Location = new System.Drawing.Point(259, 293);
            this.Lb_CreatAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lb_CreatAccount.Name = "Lb_CreatAccount";
            this.Lb_CreatAccount.Size = new System.Drawing.Size(130, 21);
            this.Lb_CreatAccount.TabIndex = 5;
            this.Lb_CreatAccount.Text = "Create Account";
            this.Lb_CreatAccount.Click += new System.EventHandler(this.Lb_CreatAccount_Click);
            // 
            // lb_Content
            // 
            this.lb_Content.BackColor = System.Drawing.Color.Transparent;
            this.lb_Content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Content.ForeColor = System.Drawing.Color.Aqua;
            this.lb_Content.Location = new System.Drawing.Point(279, 20);
            this.lb_Content.Name = "lb_Content";
            this.lb_Content.Size = new System.Drawing.Size(421, 46);
            this.lb_Content.TabIndex = 8;
            this.lb_Content.Tag = "";
            this.lb_Content.Text = "LIBRARIAN";
            this.lb_Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login In Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_UsernameSg
            // 
            this.text_UsernameSg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.text_UsernameSg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_UsernameSg.ForeColor = System.Drawing.Color.Gray;
            this.text_UsernameSg.Location = new System.Drawing.Point(143, 92);
            this.text_UsernameSg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_UsernameSg.Multiline = true;
            this.text_UsernameSg.Name = "text_UsernameSg";
            this.text_UsernameSg.Size = new System.Drawing.Size(198, 43);
            this.text_UsernameSg.TabIndex = 11;
            this.text_UsernameSg.Text = "Username";
            this.text_UsernameSg.TextChanged += new System.EventHandler(this.text_UsernameSg_TextChanged);
            this.text_UsernameSg.Enter += new System.EventHandler(this.txt_UsernameSg_Enter);
            this.text_UsernameSg.Leave += new System.EventHandler(this.txt_UsernameSg_Leave);
            // 
            // text_PassWordSg
            // 
            this.text_PassWordSg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.text_PassWordSg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PassWordSg.ForeColor = System.Drawing.Color.Gray;
            this.text_PassWordSg.Location = new System.Drawing.Point(143, 152);
            this.text_PassWordSg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_PassWordSg.Multiline = true;
            this.text_PassWordSg.Name = "text_PassWordSg";
            this.text_PassWordSg.PasswordChar = '*';
            this.text_PassWordSg.Size = new System.Drawing.Size(198, 43);
            this.text_PassWordSg.TabIndex = 12;
            this.text_PassWordSg.Text = "Password Old";
            this.text_PassWordSg.Enter += new System.EventHandler(this.txt_PasswordSg_Enter);
            this.text_PassWordSg.Leave += new System.EventHandler(this.txt_PasswordSg_Leave);
            // 
            // bt_Sigin
            // 
            this.bt_Sigin.BackColor = System.Drawing.Color.Transparent;
            this.bt_Sigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sigin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Sigin.Location = new System.Drawing.Point(188, 383);
            this.bt_Sigin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Sigin.Name = "bt_Sigin";
            this.bt_Sigin.Size = new System.Drawing.Size(154, 64);
            this.bt_Sigin.TabIndex = 14;
            this.bt_Sigin.Text = "Sigin";
            this.bt_Sigin.UseVisualStyleBackColor = false;
            this.bt_Sigin.Click += new System.EventHandler(this.bt_Sigin_Click);
            // 
            // txt_Re_EnterPassWord
            // 
            this.txt_Re_EnterPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Re_EnterPassWord.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Re_EnterPassWord.ForeColor = System.Drawing.Color.Gray;
            this.txt_Re_EnterPassWord.Location = new System.Drawing.Point(143, 212);
            this.txt_Re_EnterPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Re_EnterPassWord.Multiline = true;
            this.txt_Re_EnterPassWord.Name = "txt_Re_EnterPassWord";
            this.txt_Re_EnterPassWord.PasswordChar = '*';
            this.txt_Re_EnterPassWord.Size = new System.Drawing.Size(198, 43);
            this.txt_Re_EnterPassWord.TabIndex = 17;
            this.txt_Re_EnterPassWord.Text = "Password New";
            this.txt_Re_EnterPassWord.Enter += new System.EventHandler(this.txt_Re_EnterPassword_Enter);
            this.txt_Re_EnterPassWord.Leave += new System.EventHandler(this.txt_Re_EnterPassword_Leave);
            // 
            // Pn_Sign
            // 
            this.Pn_Sign.BackColor = System.Drawing.Color.Transparent;
            this.Pn_Sign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pn_Sign.Controls.Add(this.radioButton2);
            this.Pn_Sign.Controls.Add(this.radioButton1);
            this.Pn_Sign.Controls.Add(this.svgImageBox6);
            this.Pn_Sign.Controls.Add(this.txt_Name);
            this.Pn_Sign.Controls.Add(this.svgImageBox5);
            this.Pn_Sign.Controls.Add(this.svgImageBox4);
            this.Pn_Sign.Controls.Add(this.svgImageBox3);
            this.Pn_Sign.Controls.Add(this.Bt_BackLogin);
            this.Pn_Sign.Controls.Add(this.CheckPasswordold_new);
            this.Pn_Sign.Controls.Add(this.label3);
            this.Pn_Sign.Controls.Add(this.text_UsernameSg);
            this.Pn_Sign.Controls.Add(this.bt_Sigin);
            this.Pn_Sign.Controls.Add(this.txt_Re_EnterPassWord);
            this.Pn_Sign.Controls.Add(this.text_PassWordSg);
            this.Pn_Sign.Location = new System.Drawing.Point(616, 45);
            this.Pn_Sign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pn_Sign.Name = "Pn_Sign";
            this.Pn_Sign.Size = new System.Drawing.Size(502, 466);
            this.Pn_Sign.TabIndex = 19;
            this.Pn_Sign.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Silver;
            this.radioButton2.Location = new System.Drawing.Point(309, 325);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 22);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Admin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Silver;
            this.radioButton1.Location = new System.Drawing.Point(143, 324);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 22);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // svgImageBox6
            // 
            this.svgImageBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox6.BackgroundImage")));
            this.svgImageBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.svgImageBox6.Location = new System.Drawing.Point(337, 270);
            this.svgImageBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox6.Name = "svgImageBox6";
            this.svgImageBox6.Size = new System.Drawing.Size(45, 44);
            this.svgImageBox6.TabIndex = 26;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Gray;
            this.txt_Name.Location = new System.Drawing.Point(144, 270);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(198, 43);
            this.txt_Name.TabIndex = 25;
            this.txt_Name.Text = "Name";
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // svgImageBox5
            // 
            this.svgImageBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox5.BackgroundImage")));
            this.svgImageBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svgImageBox5.Location = new System.Drawing.Point(336, 152);
            this.svgImageBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox5.Name = "svgImageBox5";
            this.svgImageBox5.Size = new System.Drawing.Size(47, 44);
            this.svgImageBox5.TabIndex = 24;
            // 
            // svgImageBox4
            // 
            this.svgImageBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox4.BackgroundImage")));
            this.svgImageBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svgImageBox4.Location = new System.Drawing.Point(336, 212);
            this.svgImageBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox4.Name = "svgImageBox4";
            this.svgImageBox4.Size = new System.Drawing.Size(47, 44);
            this.svgImageBox4.TabIndex = 23;
            this.svgImageBox4.Click += new System.EventHandler(this.svgImageBox4_Click);
            // 
            // svgImageBox3
            // 
            this.svgImageBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox3.BackgroundImage")));
            this.svgImageBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.svgImageBox3.Location = new System.Drawing.Point(336, 92);
            this.svgImageBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox3.Name = "svgImageBox3";
            this.svgImageBox3.Size = new System.Drawing.Size(45, 44);
            this.svgImageBox3.TabIndex = 22;
            // 
            // Bt_BackLogin
            // 
            this.Bt_BackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_BackLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bt_BackLogin.Image = ((System.Drawing.Image)(resources.GetObject("Bt_BackLogin.Image")));
            this.Bt_BackLogin.Location = new System.Drawing.Point(-2, -2);
            this.Bt_BackLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_BackLogin.Name = "Bt_BackLogin";
            this.Bt_BackLogin.Size = new System.Drawing.Size(75, 50);
            this.Bt_BackLogin.TabIndex = 21;
            this.Bt_BackLogin.UseVisualStyleBackColor = true;
            this.Bt_BackLogin.Click += new System.EventHandler(this.Bt_BackLogin_Click);
            // 
            // CheckPasswordold_new
            // 
            this.CheckPasswordold_new.AutoSize = true;
            this.CheckPasswordold_new.BackColor = System.Drawing.Color.Transparent;
            this.CheckPasswordold_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPasswordold_new.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckPasswordold_new.Location = new System.Drawing.Point(143, 349);
            this.CheckPasswordold_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckPasswordold_new.Name = "CheckPasswordold_new";
            this.CheckPasswordold_new.Size = new System.Drawing.Size(164, 24);
            this.CheckPasswordold_new.TabIndex = 20;
            this.CheckPasswordold_new.Text = "Show Password";
            this.CheckPasswordold_new.UseVisualStyleBackColor = false;
            this.CheckPasswordold_new.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(157, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 47);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sigin In Here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pn_Login
            // 
            this.Pn_Login.BackColor = System.Drawing.Color.Transparent;
            this.Pn_Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pn_Login.Controls.Add(this.svgImageBox2);
            this.Pn_Login.Controls.Add(this.svgImageBox1);
            this.Pn_Login.Controls.Add(this.label2);
            this.Pn_Login.Controls.Add(this.txt_UserName);
            this.Pn_Login.Controls.Add(this.Ck_ShowPassword);
            this.Pn_Login.Controls.Add(this.Lb_CreatAccount);
            this.Pn_Login.Controls.Add(this.txt_Password);
            this.Pn_Login.Controls.Add(this.bt_Login);
            this.Pn_Login.Location = new System.Drawing.Point(254, 121);
            this.Pn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pn_Login.Name = "Pn_Login";
            this.Pn_Login.Size = new System.Drawing.Size(502, 466);
            this.Pn_Login.TabIndex = 20;
            this.Pn_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_Login_Paint);
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox2.BackgroundImage")));
            this.svgImageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svgImageBox2.Location = new System.Drawing.Point(343, 212);
            this.svgImageBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(47, 48);
            this.svgImageBox2.TabIndex = 18;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svgImageBox1.BackgroundImage")));
            this.svgImageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.svgImageBox1.Location = new System.Drawing.Point(346, 128);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(45, 46);
            this.svgImageBox1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1003, 642);
            this.Controls.Add(this.Pn_Login);
            this.Controls.Add(this.Pn_Sign);
            this.Controls.Add(this.lb_Content);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Fm_Login.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Fm_Login.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm_Login";
            this.Text = "Application Quản Lý Thư Viện";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLg_Close);
            this.Load += new System.EventHandler(this.Fm_Login_Load);
            this.Pn_Sign.ResumeLayout(false);
            this.Pn_Sign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).EndInit();
            this.Pn_Login.ResumeLayout(false);
            this.Pn_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.CheckBox Ck_ShowPassword;
        private DevExpress.XtraEditors.HyperlinkLabelControl Lb_CreatAccount;
        private System.Windows.Forms.Label lb_Content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_UsernameSg;
        private System.Windows.Forms.TextBox text_PassWordSg;
        private System.Windows.Forms.Button bt_Sigin;
        private System.Windows.Forms.TextBox txt_Re_EnterPassWord;
        private System.Windows.Forms.Panel Pn_Sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pn_Login;
        private System.Windows.Forms.Button Bt_BackLogin;
        private System.Windows.Forms.CheckBox CheckPasswordold_new;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private System.Windows.Forms.TextBox txt_Password;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox5;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox4;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox3;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox6;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

