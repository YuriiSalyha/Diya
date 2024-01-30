using System.Runtime.InteropServices;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;
        //Size formSize;
        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            openChildForm(new NewsFeed());
            this.Padding = new Padding(borderSize); // Border size
            this.BackColor = Color.Black; // Border color
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam,int lParam);

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal) 
            {
                this.WindowState = FormWindowState.Maximized;
                FullscreenButton.IconChar =  FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                FullscreenButton.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e) // title bar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;

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
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
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
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
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
            if (m.Msg==WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
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
            //formSize = this.ClientSize;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelSide.Width > 150)
            {
                panelSide.Width = 100;
                label1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding();
                }
            }
            else
            {
                panelSide.Width = 170;
                label1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = " " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private Form activeForm = null;
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
    }
}