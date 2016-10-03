namespace AutoCompositor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddAutoButton = new System.Windows.Forms.Button();
            this.DiscoButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAutoButton
            // 
            this.AddAutoButton.Location = new System.Drawing.Point(49, 56);
            this.AddAutoButton.Name = "AddAutoButton";
            this.AddAutoButton.Size = new System.Drawing.Size(90, 23);
            this.AddAutoButton.TabIndex = 0;
            this.AddAutoButton.Text = "Add Volvo";
            this.AddAutoButton.UseVisualStyleBackColor = true;
            this.AddAutoButton.Click += new System.EventHandler(this.AddAutoButton_Click);
            // 
            // DiscoButton
            // 
            this.DiscoButton.Location = new System.Drawing.Point(49, 333);
            this.DiscoButton.Name = "DiscoButton";
            this.DiscoButton.Size = new System.Drawing.Size(90, 23);
            this.DiscoButton.TabIndex = 2;
            this.DiscoButton.Text = "Disco";
            this.DiscoButton.UseVisualStyleBackColor = true;
            this.DiscoButton.Click += new System.EventHandler(this.DiscoButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // colorCombo
            // 
            this.colorCombo.FormattingEnabled = true;
            this.colorCombo.Location = new System.Drawing.Point(49, 85);
            this.colorCombo.Name = "colorCombo";
            this.colorCombo.Size = new System.Drawing.Size(90, 21);
            this.colorCombo.TabIndex = 3;
            this.colorCombo.SelectedIndexChanged += new System.EventHandler(this.colorCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Pao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorCombo);
            this.Controls.Add(this.DiscoButton);
            this.Controls.Add(this.AddAutoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Volvo Color Compositor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAutoButton;
        private System.Windows.Forms.Button DiscoButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox colorCombo;
        private System.Windows.Forms.Button button1;
    }
}

