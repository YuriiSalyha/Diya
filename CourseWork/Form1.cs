using Diya;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Controls;

namespace CourseWork
{
    public partial class Form1 : Form
    {

        string configPath = System.IO.Path.Combine(Environment.CurrentDirectory, "config.json");
        private int borderSize = 2;
        Size formSize;
        private Form activeForm = null;
        Config cfg;
        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            AdjustItems();
            LoginCheck();
            openChildForm(new NewsFeed());

            this.Padding = new Padding(borderSize); // Border size
            this.BackColor = Color.Black; // Border color
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            //Updating config
            Config newCfg = new Config();
            string output = JsonConvert.SerializeObject(newCfg);
            File.WriteAllText(configPath, output);
            this.Visible = false;
            LoginCheck();
        }

        private void LoginCheck()
        {
            var json = File.ReadAllText(configPath);
            cfg = JsonConvert.DeserializeObject<Config>(json);
            if ((DateTime.Now.Subtract(cfg.loginDate).TotalDays >= 7) && cfg.login == true)
            {
                MessageBox.Show("Your previous login session has expired, please login again");
                Config newCfg = new Config();
                string output = JsonConvert.SerializeObject(newCfg);
                File.WriteAllText(configPath, output);
            }
            if (!cfg.login)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                using (LoginForm form = new LoginForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.Visible = true;
                        openChildForm(new NewsFeed());
                    }
                    else
                    {
                        Application.Exit();
                    }

                }
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e) // title bar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int resizeAreaSize = 10;

            // Represents client area of the window
            const int HTCLIENT = 1;
            // Represents every border
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the mouse pointer is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); // Gets screen point coordinates                       
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {

                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
            AdjustItems();
        }

        private void AdjustItems()
        {
            if (label1.Visible) // Checks if menu is collapsed
            {
                panelSide.Width = Convert.ToInt32(this.Width * 0.25);
                btnMenu.Width = panelSide.Width - label1.Width;
            }
            else
            {
                panelSide.Width = Convert.ToInt32(this.Width * 0.1);
                btnMenu.Width = panelSide.Width;
            }

            panelMenu.Height = Convert.ToInt32((this.Height * 0.8));
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu(true);
            //CollapseMenu();
        }

        // instead of hiding label, move it outside of frame
        #region Animation
        int sizeChange = 0;
        int targetSize = 0;
        
        private void resizeSidePanelAnim()
        {
            timer1.Interval = 10;
            if (panelSide.Width == Convert.ToInt32(this.Width * 0.2))
            {
                targetSize = Convert.ToInt32(this.Width * 0.1);
                timer2.Tick += new EventHandler(timer1_Tick_decrease);
                sizeChange = -Convert.ToInt32(this.Width * 0.02);
                timer2.Interval = 1;
                panelSide.SuspendLayout();
                timer2.Start();
            }
            else
            {
                targetSize = Convert.ToInt32(this.Width * 0.2);
                timer1.Tick += new EventHandler(timer1_Tick);
                sizeChange = Convert.ToInt32(this.Width * 0.02);
                timer1.Interval = 1;
                panelSide.SuspendLayout();
                timer1.Start();
            }

            
            
        }

        private void timer1_Tick_decrease(object sender, EventArgs e) 
        {
            if (panelSide.Width == targetSize)
            {
                panelSide.ResumeLayout();
                timer2.Stop();          
                label1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                btnMenu.Width = panelSide.Width;
                foreach (System.Windows.Forms.Button menuButton in panelMenu.Controls.OfType<System.Windows.Forms.Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding();
                }
            }
            else
            {
                panelSide.Width += sizeChange;
                if (panelSide.Width < targetSize)
                {
                    panelSide.Width = targetSize;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelSide.Width == targetSize)
            {
                panelSide.ResumeLayout();
                timer1.Stop();
                label1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Width = panelSide.Width - label1.Width;
                foreach (System.Windows.Forms.Button menuButton in panelMenu.Controls.OfType<System.Windows.Forms.Button>())
                {
                    menuButton.Text = " " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
            else
            {
                panelSide.Width += sizeChange;
                if (panelSide.Width > targetSize)
                {
                    panelSide.Width = targetSize;
                }
            }

        }
        #endregion

        private void CollapseMenu(bool playAnimation = false)
        {
            if (this.panelSide.Width > Convert.ToInt32(this.Width * 0.1))
            {
                if(playAnimation) 
                {
                    resizeSidePanelAnim();
                }
                else 
                {
                    panelSide.Width = Convert.ToInt32(this.Width * 0.1);
                    label1.Visible = false;
                    btnMenu.Dock = DockStyle.Top;
                    btnMenu.Width = panelSide.Width;
                    foreach (System.Windows.Forms.Button menuButton in panelMenu.Controls.OfType<System.Windows.Forms.Button>())
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                        menuButton.Padding = new Padding();
                    }
                }

            }
            else
            {
                //panelSide.Width = 170;
                if (playAnimation)
                {
                    resizeSidePanelAnim();
                }
                else
                {
                    panelSide.SuspendLayout();
                    panelSide.Width = Convert.ToInt32(this.Width * 0.2);
                    label1.Visible = true;
                    btnMenu.Dock = DockStyle.None;
                    btnMenu.Width = panelSide.Width - label1.Width;
                    panelSide.ResumeLayout();
                    foreach (System.Windows.Forms.Button menuButton in panelMenu.Controls.OfType<System.Windows.Forms.Button>())
                    {
                        menuButton.Text = " " + menuButton.Tag.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(childForm);
            pagePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void iconButton3_Click(object sender, EventArgs e) // News feed button
        {
            openChildForm(new NewsFeed());
        }

        private void iconButton4_Click(object sender, EventArgs e) // Documents
        {
            openChildForm(new Documents());
        }

        private void iconButton2_Click(object sender, EventArgs e) // Services
        {
            openChildForm(new Services());
        }

        private void MenuButton_Click(object sender, EventArgs e) // Menu
        {
            openChildForm(new Menu());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}