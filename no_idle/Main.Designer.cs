namespace no_idle
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            notifyIcon = new NotifyIcon(components);
            intervalInput = new NumericUpDown();
            intervalLabel = new Label();
            button = new Button();
            timerPointer = new System.Windows.Forms.Timer(components);
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            timerProgress = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)intervalInput).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            // 
            // intervalInput
            // 
            intervalInput.Location = new Point(143, 17);
            intervalInput.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            intervalInput.Name = "intervalInput";
            intervalInput.Size = new Size(65, 27);
            intervalInput.TabIndex = 0;
            intervalInput.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // intervalLabel
            // 
            intervalLabel.AutoSize = true;
            intervalLabel.Location = new Point(12, 19);
            intervalLabel.Name = "intervalLabel";
            intervalLabel.Size = new Size(115, 20);
            intervalLabel.TabIndex = 1;
            intervalLabel.Text = "Interval seconds";
            // 
            // button
            // 
            button.Location = new Point(230, 15);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 4;
            button.Text = "Start";
            button.UseVisualStyleBackColor = true;
            button.Click += Button_Click;
            // 
            // timerPointer
            // 
            timerPointer.Tick += TimerPointer_Tick;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel, progressBar });
            statusStrip.Location = new Point(0, 63);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(345, 26);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(28, 20);
            statusLabel.Text = "0,0";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 18);
            // 
            // timerProgress
            // 
            timerProgress.Tick += TimerProgress_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 89);
            Controls.Add(statusStrip);
            Controls.Add(button);
            Controls.Add(intervalLabel);
            Controls.Add(intervalInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "No Idle";
            MouseDoubleClick += Main_MouseDoubleClick;
            Resize += Main_Resize;
            ((System.ComponentModel.ISupportInitialize)intervalInput).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon;
        private NumericUpDown intervalInput;
        private Label intervalLabel;
        private Button button;
        private System.Windows.Forms.Timer timerPointer;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStripProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgress;
    }
}
