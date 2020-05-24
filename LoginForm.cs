using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Internshala_Project
{
    public partial class LoginForm : Form
    {
        private string default_username_text = "Enter Username";
        private string default_password_text = "Enter Password";
        private Point lastPoint;
        public LoginForm()
        {
            InitializeComponent();
        }

        /*Closing Application Event*/
        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        /*TextBox Hover Styling*/
        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == default_username_text)
            {
                tb_username.Clear();
            }
            pb_username.Image = Properties.Resources.username_2;
            pb_username.SizeMode = PictureBoxSizeMode.Zoom;
            panel1.BackColor = Color.FromArgb(111, 52, 209);
            tb_username.ForeColor = Color.FromArgb(111, 52, 209);
        }

        /*TextBox Hover Styling*/
        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_username.Text))
            {
                tb_username.Text = default_username_text;
            }
            pb_username.Image = Properties.Resources.username_1;
            panel1.BackColor = Color.FromArgb(62, 170, 61);
            tb_username.ForeColor = Color.FromArgb(62, 170, 61);
        }

        /*TextBox Hover Styling*/
        private void tb_password_Enter(object sender, EventArgs e)
        {
            if(tb_password.Text == default_password_text)
            {
                tb_password.Clear();
            }
            tb_password.PasswordChar = '•';
            pb_password.Image = Properties.Resources.password_2;
            panel2.BackColor = Color.FromArgb(111, 52, 209);
            tb_password.ForeColor = Color.FromArgb(111, 52, 209);
        }

        /*TextBox Hover Styling*/
        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_password.Text))
            {
                tb_password.Text = default_password_text;
                tb_password.PasswordChar = '\u0000';
            }
            pb_password.Image = Properties.Resources.password_1;
            panel2.BackColor = Color.FromArgb(62, 170, 61);
            tb_password.ForeColor = Color.FromArgb(62, 170, 61);
        }

        /*Closing Button Hover Image Changer*/
        private void pb_close_MouseEnter(object sender, EventArgs e)
        {
            pb_close.Image = Properties.Resources.close_2;
        }

        /*Closing Button Hover Image Changer*/
        private void pb_close_MouseLeave(object sender, EventArgs e)
        {
            pb_close.Image = Properties.Resources.close_1;
        }

        /*Login Button Hover Styling*/
        private void bt_login_MouseEnter(object sender, EventArgs e)
        {
            bt_login.BackColor = Color.FromArgb(111, 52, 209);
        }

        /*Login Button Hover Styling*/
        private void bt_login_MouseLeave(object sender, EventArgs e)
        {
            bt_login.BackColor = Color.FromArgb(62, 170, 61);
        }

        /*Login Button Click Event*/
        private void bt_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_username.Text)|string.IsNullOrEmpty(tb_password.Text)|tb_username.Text.Equals(default_username_text)|tb_password.Text.Equals(default_password_text))
            {
                MessageBox.Show("Please fill all fields!","Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bt_login.Visible = false;
                /* loading class object creating for start loading */
                using (loading load = new loading(StartLoading))
                {
                    load.ShowDialog(this);
                }
                MessageBox.Show("Login Successfully!", "Message", MessageBoxButtons.OK, 0);
                bt_login.Visible = true;
            }
        }

        /*Functionality for Progress Bar loading for 5 seconds*/
        private void StartLoading()
        {
            for (int i=0;i<500;i++)
            {
                Thread.Sleep(5);
            }
        }

        /*for Application move on screen*/
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        /*for Application move on screen*/
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
            lastPoint = new Point(e.X, e.Y);
        }

        /*for Application move on screen*/
        private void pb_logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        /*for Application move on screen*/
        private void pb_logo_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
