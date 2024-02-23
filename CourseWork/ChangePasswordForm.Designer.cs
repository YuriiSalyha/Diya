namespace Diia
{
    partial class ChangePasswordForm
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
            confirmPasswordButton = new Button();
            newPasswordBox = new TextBox();
            repeatPasswordBox = new TextBox();
            SuspendLayout();
            // 
            // confirmPasswordButton
            // 
            confirmPasswordButton.Location = new Point(103, 198);
            confirmPasswordButton.Name = "confirmPasswordButton";
            confirmPasswordButton.Size = new Size(94, 29);
            confirmPasswordButton.TabIndex = 0;
            confirmPasswordButton.Text = "Confirm";
            confirmPasswordButton.UseVisualStyleBackColor = true;
            confirmPasswordButton.Click += confirmPasswordButton_Click;
            // 
            // newPasswordBox
            // 
            newPasswordBox.Location = new Point(72, 68);
            newPasswordBox.Name = "newPasswordBox";
            newPasswordBox.Size = new Size(125, 27);
            newPasswordBox.TabIndex = 1;
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(72, 120);
            repeatPasswordBox.Name = "repeatPasswordBox";
            repeatPasswordBox.Size = new Size(125, 27);
            repeatPasswordBox.TabIndex = 2;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 450);
            Controls.Add(repeatPasswordBox);
            Controls.Add(newPasswordBox);
            Controls.Add(confirmPasswordButton);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmPasswordButton;
        private TextBox newPasswordBox;
        private TextBox repeatPasswordBox;
    }
}