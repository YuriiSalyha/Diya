namespace CourseWork
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
            components = new System.ComponentModel.Container();
            panelSide = new Panel();
            panelLogo = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelMenu = new Panel();
            MenuButton = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            MinimizeButton = new FontAwesome.Sharp.IconButton();
            FullscreenButton = new FontAwesome.Sharp.IconButton();
            CloseButton = new FontAwesome.Sharp.IconButton();
            DesktopPanel = new Panel();
            pagePanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panelSide.SuspendLayout();
            panelLogo.SuspendLayout();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            DesktopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = SystemColors.ActiveCaptionText;
            panelSide.Controls.Add(panelLogo);
            panelSide.Controls.Add(panelMenu);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Margin = new Padding(3, 4, 3, 4);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(194, 627);
            panelSide.TabIndex = 0;
            panelSide.Tag = "panelSide";
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnMenu);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(194, 93);
            panelLogo.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.White;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.Location = new Point(139, 27);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 48);
            btnMenu.TabIndex = 2;
            btnMenu.Tag = " ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(138, 62);
            label1.TabIndex = 2;
            label1.Tag = "Logo";
            label1.Text = "Logo";
            label1.Click += label1_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(MenuButton);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton6);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Dock = DockStyle.Bottom;
            panelMenu.Location = new Point(0, 94);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(194, 533);
            panelMenu.TabIndex = 1;
            // 
            // MenuButton
            // 
            MenuButton.Cursor = Cursors.Hand;
            MenuButton.Dock = DockStyle.Top;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MenuButton.ForeColor = Color.White;
            MenuButton.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            MenuButton.IconColor = Color.White;
            MenuButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            MenuButton.IconSize = 36;
            MenuButton.ImageAlign = ContentAlignment.TopCenter;
            MenuButton.Location = new Point(0, 228);
            MenuButton.Margin = new Padding(3, 4, 3, 4);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(194, 76);
            MenuButton.TabIndex = 5;
            MenuButton.Tag = "Menu";
            MenuButton.Text = "Menu";
            MenuButton.TextAlign = ContentAlignment.BottomCenter;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bolt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 36;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(0, 152);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(194, 76);
            iconButton2.TabIndex = 2;
            iconButton2.Tag = "Services";
            iconButton2.Text = "Services";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton6
            // 
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.Dock = DockStyle.Bottom;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.TopCenter;
            iconButton6.Location = new Point(0, 440);
            iconButton6.Margin = new Padding(3, 4, 3, 4);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(194, 93);
            iconButton6.TabIndex = 6;
            iconButton6.Tag = "Log Off";
            iconButton6.Text = "Log Off";
            iconButton6.TextAlign = ContentAlignment.BottomCenter;
            iconButton6.UseVisualStyleBackColor = true;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton4
            // 
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Passport;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 36;
            iconButton4.ImageAlign = ContentAlignment.TopCenter;
            iconButton4.Location = new Point(0, 76);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(194, 76);
            iconButton4.TabIndex = 4;
            iconButton4.Tag = "Documents";
            iconButton4.Text = "Documents";
            iconButton4.TextAlign = ContentAlignment.BottomCenter;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.IconSize = 36;
            iconButton3.ImageAlign = ContentAlignment.TopCenter;
            iconButton3.Location = new Point(0, 0);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(194, 76);
            iconButton3.TabIndex = 3;
            iconButton3.Tag = "News Feed";
            iconButton3.Text = "News Feed";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(MinimizeButton);
            panel3.Controls.Add(FullscreenButton);
            panel3.Controls.Add(CloseButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 33);
            panel3.TabIndex = 1;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(0, 221, 210);
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            MinimizeButton.IconColor = Color.White;
            MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinimizeButton.IconSize = 20;
            MinimizeButton.Location = new Point(760, 0);
            MinimizeButton.Margin = new Padding(5);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(51, 33);
            MinimizeButton.TabIndex = 4;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // FullscreenButton
            // 
            FullscreenButton.BackColor = Color.DeepSkyBlue;
            FullscreenButton.Cursor = Cursors.Hand;
            FullscreenButton.Dock = DockStyle.Right;
            FullscreenButton.FlatStyle = FlatStyle.Flat;
            FullscreenButton.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            FullscreenButton.IconColor = Color.White;
            FullscreenButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FullscreenButton.IconSize = 20;
            FullscreenButton.Location = new Point(812, 0);
            FullscreenButton.Margin = new Padding(3, 4, 3, 4);
            FullscreenButton.Name = "FullscreenButton";
            FullscreenButton.Size = new Size(51, 33);
            FullscreenButton.TabIndex = 4;
            FullscreenButton.UseVisualStyleBackColor = false;
            FullscreenButton.Click += FullscreenButton_Click;
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
            // DesktopPanel
            // 
            DesktopPanel.BackColor = Color.White;
            DesktopPanel.Controls.Add(pagePanel);
            DesktopPanel.Controls.Add(panelSide);
            DesktopPanel.Dock = DockStyle.Fill;
            DesktopPanel.Location = new Point(0, 33);
            DesktopPanel.Margin = new Padding(3, 4, 3, 4);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(914, 627);
            DesktopPanel.TabIndex = 2;
            // 
            // pagePanel
            // 
            pagePanel.Dock = DockStyle.Fill;
            pagePanel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pagePanel.Location = new Point(194, 0);
            pagePanel.Margin = new Padding(3, 4, 3, 4);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(720, 627);
            pagePanel.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 660);
            Controls.Add(DesktopPanel);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "меню";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResizeEnd += Form1_ResizeEnd;
            Resize += Form1_Resize;
            panelSide.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            DesktopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton MenuButton;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton FullscreenButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private Panel DesktopPanel;
        private Panel panelMenu;
        private Panel pagePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}