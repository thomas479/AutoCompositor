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
            this.AddAutoButton = new System.Windows.Forms.Button();
            this.ChangeColourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAutoButton
            // 
            this.AddAutoButton.Location = new System.Drawing.Point(49, 56);
            this.AddAutoButton.Name = "AddAutoButton";
            this.AddAutoButton.Size = new System.Drawing.Size(90, 23);
            this.AddAutoButton.TabIndex = 0;
            this.AddAutoButton.Text = "Add auto";
            this.AddAutoButton.UseVisualStyleBackColor = true;
            this.AddAutoButton.Click += new System.EventHandler(this.AddAutoButton_Click);
            // 
            // ChangeColourButton
            // 
            this.ChangeColourButton.Location = new System.Drawing.Point(49, 97);
            this.ChangeColourButton.Name = "ChangeColourButton";
            this.ChangeColourButton.Size = new System.Drawing.Size(90, 23);
            this.ChangeColourButton.TabIndex = 1;
            this.ChangeColourButton.Text = "Change colour";
            this.ChangeColourButton.UseVisualStyleBackColor = true;
            this.ChangeColourButton.Click += new System.EventHandler(this.ChangeColourButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 747);
            this.Controls.Add(this.ChangeColourButton);
            this.Controls.Add(this.AddAutoButton);
            this.Name = "Form1";
            this.Text = "Auto Compositor Pattern";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAutoButton;
        private System.Windows.Forms.Button ChangeColourButton;
    }
}

