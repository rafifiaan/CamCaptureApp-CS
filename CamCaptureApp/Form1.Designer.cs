namespace CamCaptureApp
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
            WebcamList = new ComboBox();
            buttonStart = new Button();
            buttonExit = new Button();
            buttonCapture = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonSaveImg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // WebcamList
            // 
            WebcamList.BackColor = SystemColors.Window;
            WebcamList.FormattingEnabled = true;
            WebcamList.Location = new Point(49, 42);
            WebcamList.Margin = new Padding(4, 5, 4, 5);
            WebcamList.Name = "WebcamList";
            WebcamList.Size = new Size(231, 33);
            WebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.Menu;
            buttonStart.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = SystemColors.ControlText;
            buttonStart.Location = new Point(1033, 25);
            buttonStart.Margin = new Padding(4, 5, 4, 5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(134, 50);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Menu;
            buttonExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlText;
            buttonExit.Location = new Point(1033, 509);
            buttonExit.Margin = new Padding(4, 5, 4, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(134, 50);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.BackColor = SystemColors.Menu;
            buttonCapture.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCapture.ForeColor = SystemColors.ControlText;
            buttonCapture.Location = new Point(714, 509);
            buttonCapture.Margin = new Padding(4, 5, 4, 5);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(134, 50);
            buttonCapture.TabIndex = 6;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = false;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(142, 165);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(999, 302);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(502, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(494, 296);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonSaveImg
            // 
            buttonSaveImg.BackColor = SystemColors.Menu;
            buttonSaveImg.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSaveImg.ForeColor = SystemColors.ControlText;
            buttonSaveImg.Location = new Point(874, 509);
            buttonSaveImg.Margin = new Padding(4, 5, 4, 5);
            buttonSaveImg.Name = "buttonSaveImg";
            buttonSaveImg.Size = new Size(134, 50);
            buttonSaveImg.TabIndex = 8;
            buttonSaveImg.Text = "Save";
            buttonSaveImg.UseVisualStyleBackColor = false;
            buttonSaveImg.Click += buttonSaveImg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 442);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(339, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 57);
            label2.TabIndex = 10;
            label2.Text = "Camera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(786, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 57);
            label3.TabIndex = 11;
            label3.Text = "Capture";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1240, 593);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveImg);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCapture);
            Controls.Add(buttonExit);
            Controls.Add(buttonStart);
            Controls.Add(WebcamList);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "CamCapture";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox WebcamList;
        private Button buttonStart;
        private Button buttonExit;
        private Button buttonCapture;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxBefore;
        private PictureBox pictureBoxAfter;
        private Button buttonSaveImg;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}