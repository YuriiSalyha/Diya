namespace Diia
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
            loginPanel = new Panel();
            CitizenError = new Label();
            IdBox = new TextBox();
            CredentialError = new Label();
            PasswordError = new Label();
            UsernameError = new Label();
            UnderText = new Label();
            ConfirmButton = new CustomComponents.CustomImageButton();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            CloseButton = new FontAwesome.Sharp.IconButton();
            loginPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Transparent;
            loginPanel.BackgroundImage = Properties.Resources.Sample;
            loginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            loginPanel.Controls.Add(CitizenError);
            loginPanel.Controls.Add(IdBox);
            loginPanel.Controls.Add(CredentialError);
            loginPanel.Controls.Add(PasswordError);
            loginPanel.Controls.Add(UsernameError);
            loginPanel.Controls.Add(UnderText);
            loginPanel.Controls.Add(ConfirmButton);
            loginPanel.Controls.Add(PasswordBox);
            loginPanel.Controls.Add(UsernameBox);
            loginPanel.Controls.Add(panel3);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(914, 600);
            loginPanel.TabIndex = 0;
            // 
            // CitizenError
            // 
            CitizenError.AutoSize = true;
            CitizenError.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CitizenError.ForeColor = Color.Red;
            CitizenError.Location = new Point(346, 168);
            CitizenError.Name = "CitizenError";
            CitizenError.Size = new Size(315, 20);
            CitizenError.TabIndex = 11;
            CitizenError.Text = "This citizen ID is already registered";
            CitizenError.Visible = false;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(346, 133);
            IdBox.Margin = new Padding(3, 4, 3, 4);
            IdBox.Name = "IdBox";
            IdBox.PlaceholderText = "Citizen ID";
            IdBox.Size = new Size(210, 27);
            IdBox.TabIndex = 10;
            IdBox.Visible = false;
            // 
            // CredentialError
            // 
            CredentialError.AutoSize = true;
            CredentialError.ForeColor = Color.Red;
            CredentialError.Location = new Point(346, 180);
            CredentialError.Name = "CredentialError";
            CredentialError.Size = new Size(220, 20);
            CredentialError.TabIndex = 9;
            CredentialError.Text = "Incorrect username or password";
            CredentialError.Visible = false;
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(346, 301);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(404, 40);
            PasswordError.TabIndex = 8;
            PasswordError.Text = "Password should be at least 8 characters long\r\nand shouldn't contain any special symbols\r\n";
            PasswordError.Visible = false;
            // 
            // UsernameError
            // 
            UsernameError.AutoSize = true;
            UsernameError.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameError.ForeColor = Color.Red;
            UsernameError.Location = new Point(346, 235);
            UsernameError.Name = "UsernameError";
            UsernameError.Size = new Size(238, 20);
            UsernameError.TabIndex = 7;
            UsernameError.Text = "Username is already taken";
            UsernameError.Visible = false;
            // 
            // UnderText
            // 
            UnderText.AutoSize = true;
            UnderText.Cursor = Cursors.Hand;
            UnderText.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnderText.ForeColor = Color.White;
            UnderText.Location = new Point(327, 395);
            UnderText.Name = "UnderText";
            UnderText.Size = new Size(285, 20);
            UnderText.TabIndex = 6;
            UnderText.Text = "Don't have an account? Sign Up";
            UnderText.Click += label1_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Black;
            ConfirmButton.BackgroundColor = Color.Black;
            ConfirmButton.BorderColor = Color.Black;
            ConfirmButton.BorderRadius = 5;
            ConfirmButton.BorderSize = 0;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(346, 343);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(210, 48);
            ConfirmButton.TabIndex = 5;
            ConfirmButton.Text = "Sign in";
            ConfirmButton.TextColor = Color.White;
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Location = new Point(346, 267);
            PasswordBox.Margin = new Padding(3, 4, 3, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Password";
            PasswordBox.Size = new Size(210, 27);
            PasswordBox.TabIndex = 4;
            // 
            // UsernameBox
            // 
            UsernameBox.Cursor = Cursors.IBeam;
            UsernameBox.Location = new Point(346, 200);
            UsernameBox.Margin = new Padding(3, 4, 3, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Username";
            UsernameBox.Size = new Size(210, 27);
            UsernameBox.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(CloseButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 33);
            panel3.TabIndex = 2;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(0, 221, 210);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(814, 0);
            iconButton1.Margin = new Padding(5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(51, 33);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            CloseButton.IconColor = Color.White;
            CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseButton.IconSize = 20;
            CloseButton.Location = new Point(863, 0);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(51, 33);
            CloseButton.TabIndex = 4;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResizeEnd += LoginForm_ResizeEnd;
            Resize += LoginForm_Resize;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private CustomComponents.CustomImageButton ConfirmButton;
        private Label UnderText;
        private Label PasswordError;
        private Label UsernameError;
        private Label CredentialError;
        private Label CitizenError;
        private TextBox IdBox;
    }
}