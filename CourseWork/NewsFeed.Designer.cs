namespace CourseWork
{
    partial class NewsFeed
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "News";
            // 
            // NewsPanel
            // 
            this.NewsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewsPanel.Location = new System.Drawing.Point(0, 82);
            this.NewsPanel.Name = "NewsPanel";
            this.NewsPanel.Size = new System.Drawing.Size(630, 388);
            this.NewsPanel.TabIndex = 1;
            // 
            // NewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.Controls.Add(this.NewsPanel);
            this.Controls.Add(this.label1);
            this.Name = "NewsFeed";
            this.Text = "NewsFeed";
            this.Resize += new System.EventHandler(this.NewsFeed_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Diia.CustomComponents.CustomImageButton customImageButton1;
        private FlowLayoutPanel NewsPanel;
    }
}