namespace Diia
{
    partial class AddCarForm
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
            modelBox = new TextBox();
            brandBox = new TextBox();
            colorBox = new TextBox();
            transportTypeBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonTransportAddConfirmation = new Button();
            SuspendLayout();
            // 
            // modelBox
            // 
            modelBox.Location = new Point(127, 180);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(125, 27);
            modelBox.TabIndex = 0;
            // 
            // brandBox
            // 
            brandBox.Location = new Point(127, 125);
            brandBox.Name = "brandBox";
            brandBox.Size = new Size(125, 27);
            brandBox.TabIndex = 1;
            // 
            // colorBox
            // 
            colorBox.Location = new Point(127, 242);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(125, 27);
            colorBox.TabIndex = 2;
            // 
            // transportTypeBox
            // 
            transportTypeBox.FormattingEnabled = true;
            transportTypeBox.Location = new Point(127, 66);
            transportTypeBox.Name = "transportTypeBox";
            transportTypeBox.Size = new Size(151, 28);
            transportTypeBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(126, 304);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 281);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 6;
            label1.Text = "Manufacture date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 43);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Transport type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 219);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 102);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 157);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 10;
            label5.Text = "Model";
            // 
            // buttonTransportAddConfirmation
            // 
            buttonTransportAddConfirmation.Location = new Point(451, 323);
            buttonTransportAddConfirmation.Name = "buttonTransportAddConfirmation";
            buttonTransportAddConfirmation.Size = new Size(146, 60);
            buttonTransportAddConfirmation.TabIndex = 11;
            buttonTransportAddConfirmation.Text = "Confirm";
            buttonTransportAddConfirmation.UseVisualStyleBackColor = true;
            buttonTransportAddConfirmation.Click += buttonTransportAddConfirmation_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTransportAddConfirmation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(transportTypeBox);
            Controls.Add(colorBox);
            Controls.Add(brandBox);
            Controls.Add(modelBox);
            Name = "AddCarForm";
            Text = "AddCarForm";
            Load += AddCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox modelBox;
        private TextBox brandBox;
        private TextBox colorBox;
        private ComboBox transportTypeBox;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonTransportAddConfirmation;
    }
}