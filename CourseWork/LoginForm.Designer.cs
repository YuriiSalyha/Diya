namespace Diya
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.CitizenError = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.CredentialError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.UsernameError = new System.Windows.Forms.Label();
            this.UnderText = new System.Windows.Forms.Label();
            this.ConfirmButton = new Diya.CustomComponents.CustomImageButton();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.loginPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.BackgroundImage = global::Diya.Properties.Resources.Sample;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.CitizenError);
            this.loginPanel.Controls.Add(this.IdBox);
            this.loginPanel.Controls.Add(this.CredentialError);
            this.loginPanel.Controls.Add(this.PasswordError);
            this.loginPanel.Controls.Add(this.UsernameError);
            this.loginPanel.Controls.Add(this.UnderText);
            this.loginPanel.Controls.Add(this.ConfirmButton);
            this.loginPanel.Controls.Add(this.PasswordBox);
            this.loginPanel.Controls.Add(this.UsernameBox);
            this.loginPanel.Controls.Add(this.panel3);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(800, 450);
            this.loginPanel.TabIndex = 0;
            // 
            // CitizenError
            // 
            this.CitizenError.AutoSize = true;
            this.CitizenError.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CitizenError.ForeColor = System.Drawing.Color.Red;
            this.CitizenError.Location = new System.Drawing.Point(303, 126);
            this.CitizenError.Name = "CitizenError";
            this.CitizenError.Size = new System.Drawing.Size(240, 16);
            this.CitizenError.TabIndex = 11;
            this.CitizenError.Text = "This citizen ID is already registered";
            this.CitizenError.Visible = false;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(303, 100);
            this.IdBox.Name = "IdBox";
            this.IdBox.PlaceholderText = "Citizen ID";
            this.IdBox.Size = new System.Drawing.Size(184, 23);
            this.IdBox.TabIndex = 10;
            this.IdBox.Visible = false;
            // 
            // CredentialError
            // 
            this.CredentialError.AutoSize = true;
            this.CredentialError.ForeColor = System.Drawing.Color.Red;
            this.CredentialError.Location = new System.Drawing.Point(303, 135);
            this.CredentialError.Name = "CredentialError";
            this.CredentialError.Size = new System.Drawing.Size(176, 15);
            this.CredentialError.TabIndex = 9;
            this.CredentialError.Text = "Incorrect username or password";
            this.CredentialError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(303, 226);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(314, 32);
            this.PasswordError.TabIndex = 8;
            this.PasswordError.Text = "Password should be at least 8 characters long\r\nand shouldn\'t contain any special " +
    "symbols\r\n";
            this.PasswordError.Visible = false;
            // 
            // UsernameError
            // 
            this.UsernameError.AutoSize = true;
            this.UsernameError.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(303, 176);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(181, 16);
            this.UsernameError.TabIndex = 7;
            this.UsernameError.Text = "Username is already taken";
            this.UsernameError.Visible = false;
            // 
            // UnderText
            // 
            this.UnderText.AutoSize = true;
            this.UnderText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnderText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnderText.ForeColor = System.Drawing.Color.White;
            this.UnderText.Location = new System.Drawing.Point(286, 296);
            this.UnderText.Name = "UnderText";
            this.UnderText.Size = new System.Drawing.Size(220, 16);
            this.UnderText.TabIndex = 6;
            this.UnderText.Text = "Don\'t have an account? Sign Up";
            this.UnderText.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Black;
            this.ConfirmButton.BackgroundColor = System.Drawing.Color.Black;
            this.ConfirmButton.BorderColor = System.Drawing.Color.Black;
            this.ConfirmButton.BorderRadius = 5;
            this.ConfirmButton.BorderSize = 0;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(303, 257);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(184, 36);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Sign in";
            this.ConfirmButton.TextColor = System.Drawing.Color.White;
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.Location = new System.Drawing.Point(303, 200);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(184, 23);
            this.PasswordBox.TabIndex = 4;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameBox.Location = new System.Drawing.Point(303, 150);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.Size = new System.Drawing.Size(184, 23);
            this.UsernameBox.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.MinimizeButton);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 25);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(712, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 25);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 20;
            this.MinimizeButton.Location = new System.Drawing.Point(1265, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 25);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 20;
            this.CloseButton.Location = new System.Drawing.Point(755, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResizeEnd += new System.EventHandler(this.LoginForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginPanel;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton MinimizeButton;
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