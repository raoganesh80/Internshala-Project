namespace Internshala_Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_login = new System.Windows.Forms.Button();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(582, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.Control;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Aller", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.tb_username.HideSelection = false;
            this.tb_username.Location = new System.Drawing.Point(625, 156);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(207, 19);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "Enter Username";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Aller", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.tb_password.HideSelection = false;
            this.tb_password.Location = new System.Drawing.Point(625, 226);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(207, 19);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "Enter Password";
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.panel2.Location = new System.Drawing.Point(582, 253);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 6;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.Font = new System.Drawing.Font("Aller Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(643, 302);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(129, 40);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            this.bt_login.MouseEnter += new System.EventHandler(this.bt_login_MouseEnter);
            this.bt_login.MouseLeave += new System.EventHandler(this.bt_login_MouseLeave);
            // 
            // pb_close
            // 
            this.pb_close.Image = global::Internshala_Project.Properties.Resources.close_1;
            this.pb_close.Location = new System.Drawing.Point(923, 0);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(40, 40);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 9;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseEnter += new System.EventHandler(this.pb_close_MouseEnter);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave);
            // 
            // pb_password
            // 
            this.pb_password.Image = global::Internshala_Project.Properties.Resources.password_1;
            this.pb_password.Location = new System.Drawing.Point(582, 219);
            this.pb_password.Margin = new System.Windows.Forms.Padding(4);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(35, 27);
            this.pb_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_password.TabIndex = 8;
            this.pb_password.TabStop = false;
            // 
            // pb_username
            // 
            this.pb_username.BackColor = System.Drawing.SystemColors.Control;
            this.pb_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_username.Image = global::Internshala_Project.Properties.Resources.username_1;
            this.pb_username.Location = new System.Drawing.Point(582, 149);
            this.pb_username.Margin = new System.Windows.Forms.Padding(4);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(35, 27);
            this.pb_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_username.TabIndex = 5;
            this.pb_username.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(-252, -89);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(816, 676);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            this.pb_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_logo_MouseDown);
            this.pb_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_logo_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(963, 492);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Button bt_login;
    }
}

