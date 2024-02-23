namespace CourseWork
{
    partial class Services
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
            label1 = new Label();
            buttonAddCar = new Button();
            AddDocuments = new Button();
            seeRealEstate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Services";
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(80, 123);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(160, 78);
            buttonAddCar.TabIndex = 1;
            buttonAddCar.Text = "Add car";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // AddDocuments
            // 
            AddDocuments.Location = new Point(443, 123);
            AddDocuments.Name = "AddDocuments";
            AddDocuments.Size = new Size(160, 78);
            AddDocuments.TabIndex = 3;
            AddDocuments.Text = "Add document";
            AddDocuments.UseVisualStyleBackColor = true;
            AddDocuments.Click += AddDocuments_Click;
            // 
            // seeRealEstate
            // 
            seeRealEstate.Location = new Point(266, 123);
            seeRealEstate.Name = "seeRealEstate";
            seeRealEstate.Size = new Size(155, 78);
            seeRealEstate.TabIndex = 4;
            seeRealEstate.Text = "See real estate";
            seeRealEstate.UseVisualStyleBackColor = true;
            seeRealEstate.Click += seeRealEstate_Click;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 627);
            Controls.Add(seeRealEstate);
            Controls.Add(AddDocuments);
            Controls.Add(buttonAddCar);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Services";
            Text = "Services";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddCar;
        private Button AddDocuments;
        private Button seeRealEstate;
    }
}