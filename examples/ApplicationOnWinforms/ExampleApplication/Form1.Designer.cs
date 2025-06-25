namespace ExampleApplication
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
            shutdown = new Button();
            reboot = new Button();
            label1 = new Label();
            progress = new ProgressBar();
            progress0 = new Button();
            progress100 = new Button();
            SuspendLayout();
            // 
            // shutdown
            // 
            shutdown.Location = new Point(12, 12);
            shutdown.Name = "shutdown";
            shutdown.Size = new Size(224, 74);
            shutdown.TabIndex = 0;
            shutdown.Text = "shutdown";
            shutdown.UseVisualStyleBackColor = true;
            shutdown.Click += shutdown_Click;
            // 
            // reboot
            // 
            reboot.Location = new Point(12, 92);
            reboot.Name = "reboot";
            reboot.Size = new Size(224, 74);
            reboot.TabIndex = 1;
            reboot.Text = "reboot";
            reboot.UseVisualStyleBackColor = true;
            reboot.Click += reboot_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(410, 12);
            label1.Name = "label1";
            label1.Size = new Size(578, 65);
            label1.TabIndex = 2;
            label1.Text = "winbox winforms example";
            // 
            // progress
            // 
            progress.Dock = DockStyle.Bottom;
            progress.Location = new Point(0, 766);
            progress.Name = "progress";
            progress.Size = new Size(1000, 34);
            progress.TabIndex = 3;
            // 
            // progress0
            // 
            progress0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progress0.Location = new Point(12, 726);
            progress0.Name = "progress0";
            progress0.Size = new Size(112, 34);
            progress0.TabIndex = 4;
            progress0.Text = "0%";
            progress0.UseVisualStyleBackColor = true;
            progress0.Click += progress0_Click;
            // 
            // progress100
            // 
            progress100.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progress100.Location = new Point(130, 726);
            progress100.Name = "progress100";
            progress100.Size = new Size(112, 34);
            progress100.TabIndex = 5;
            progress100.Text = "100%";
            progress100.UseVisualStyleBackColor = true;
            progress100.Click += progress100_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1000, 800);
            ControlBox = false;
            Controls.Add(progress100);
            Controls.Add(progress0);
            Controls.Add(progress);
            Controls.Add(label1);
            Controls.Add(reboot);
            Controls.Add(shutdown);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shutdown;
        private Button reboot;
        private Label label1;
        private ProgressBar progress;
        private Button progress0;
        private Button progress100;
    }
}
