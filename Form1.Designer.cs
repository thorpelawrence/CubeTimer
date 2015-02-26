namespace cube
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inspectTimerText = new System.Windows.Forms.Label();
            this.inspectTimer = new System.Windows.Forms.Timer(this.components);
            this.scrambleText = new System.Windows.Forms.Label();
            this.delTimeButton = new System.Windows.Forms.Button();
            this.savedTimes = new System.Windows.Forms.ListBox();
            this.delAllTimesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.lowestTimeLabel = new System.Windows.Forms.Label();
            this.averageTimeText = new System.Windows.Forms.Label();
            this.lowestTimeText = new System.Windows.Forms.Label();
            this.highestTimeText = new System.Windows.Forms.Label();
            this.highestTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerText
            // 
            this.timerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.ForeColor = System.Drawing.Color.Red;
            this.timerText.Location = new System.Drawing.Point(12, 9);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(340, 66);
            this.timerText.TabIndex = 0;
            this.timerText.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inspectTimerText
            // 
            this.inspectTimerText.AutoSize = true;
            this.inspectTimerText.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectTimerText.ForeColor = System.Drawing.Color.Yellow;
            this.inspectTimerText.Location = new System.Drawing.Point(358, 47);
            this.inspectTimerText.Name = "inspectTimerText";
            this.inspectTimerText.Size = new System.Drawing.Size(97, 20);
            this.inspectTimerText.TabIndex = 1;
            this.inspectTimerText.Text = "00:00:00";
            this.inspectTimerText.Visible = false;
            // 
            // inspectTimer
            // 
            this.inspectTimer.Tick += new System.EventHandler(this.inspectTimer_Tick);
            // 
            // scrambleText
            // 
            this.scrambleText.AutoSize = true;
            this.scrambleText.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrambleText.ForeColor = System.Drawing.Color.Cyan;
            this.scrambleText.Location = new System.Drawing.Point(21, 75);
            this.scrambleText.Name = "scrambleText";
            this.scrambleText.Size = new System.Drawing.Size(20, 22);
            this.scrambleText.TabIndex = 2;
            this.scrambleText.Text = "-";
            // 
            // delTimeButton
            // 
            this.delTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delTimeButton.Location = new System.Drawing.Point(104, 0);
            this.delTimeButton.Name = "delTimeButton";
            this.delTimeButton.Size = new System.Drawing.Size(25, 25);
            this.delTimeButton.TabIndex = 4;
            this.delTimeButton.TabStop = false;
            this.delTimeButton.Text = "-";
            this.delTimeButton.UseVisualStyleBackColor = true;
            this.delTimeButton.Click += new System.EventHandler(this.delTimeButton_Click);
            // 
            // savedTimes
            // 
            this.savedTimes.BackColor = System.Drawing.Color.Black;
            this.savedTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedTimes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedTimes.ForeColor = System.Drawing.Color.White;
            this.savedTimes.FormattingEnabled = true;
            this.savedTimes.ItemHeight = 19;
            this.savedTimes.Location = new System.Drawing.Point(0, 0);
            this.savedTimes.Name = "savedTimes";
            this.savedTimes.ScrollAlwaysVisible = true;
            this.savedTimes.Size = new System.Drawing.Size(98, 152);
            this.savedTimes.TabIndex = 3;
            this.savedTimes.TabStop = false;
            this.savedTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savedTimes_KeyDown);
            // 
            // delAllTimesButton
            // 
            this.delAllTimesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAllTimesButton.Location = new System.Drawing.Point(104, 127);
            this.delAllTimesButton.Name = "delAllTimesButton";
            this.delAllTimesButton.Size = new System.Drawing.Size(60, 25);
            this.delAllTimesButton.TabIndex = 11;
            this.delAllTimesButton.TabStop = false;
            this.delAllTimesButton.Text = "DEL-A";
            this.delAllTimesButton.UseVisualStyleBackColor = true;
            this.delAllTimesButton.Click += new System.EventHandler(this.delAllTimesButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.averageTimeLabel);
            this.panel2.Controls.Add(this.lowestTimeLabel);
            this.panel2.Controls.Add(this.averageTimeText);
            this.panel2.Controls.Add(this.lowestTimeText);
            this.panel2.Controls.Add(this.highestTimeText);
            this.panel2.Controls.Add(this.highestTimeLabel);
            this.panel2.Location = new System.Drawing.Point(212, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 152);
            this.panel2.TabIndex = 8;
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.AutoSize = true;
            this.averageTimeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTimeLabel.ForeColor = System.Drawing.Color.White;
            this.averageTimeLabel.Location = new System.Drawing.Point(3, 6);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(81, 19);
            this.averageTimeLabel.TabIndex = 6;
            this.averageTimeLabel.Text = "Average:";
            // 
            // lowestTimeLabel
            // 
            this.lowestTimeLabel.AutoSize = true;
            this.lowestTimeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestTimeLabel.ForeColor = System.Drawing.Color.White;
            this.lowestTimeLabel.Location = new System.Drawing.Point(3, 100);
            this.lowestTimeLabel.Name = "lowestTimeLabel";
            this.lowestTimeLabel.Size = new System.Drawing.Size(72, 19);
            this.lowestTimeLabel.TabIndex = 10;
            this.lowestTimeLabel.Text = "Lowest:";
            // 
            // averageTimeText
            // 
            this.averageTimeText.AutoSize = true;
            this.averageTimeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTimeText.ForeColor = System.Drawing.Color.White;
            this.averageTimeText.Location = new System.Drawing.Point(3, 25);
            this.averageTimeText.Name = "averageTimeText";
            this.averageTimeText.Size = new System.Drawing.Size(81, 19);
            this.averageTimeText.TabIndex = 5;
            this.averageTimeText.Text = "00:00:00";
            // 
            // lowestTimeText
            // 
            this.lowestTimeText.AutoSize = true;
            this.lowestTimeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestTimeText.ForeColor = System.Drawing.Color.White;
            this.lowestTimeText.Location = new System.Drawing.Point(3, 119);
            this.lowestTimeText.Name = "lowestTimeText";
            this.lowestTimeText.Size = new System.Drawing.Size(81, 19);
            this.lowestTimeText.TabIndex = 9;
            this.lowestTimeText.Text = "00:00:00";
            // 
            // highestTimeText
            // 
            this.highestTimeText.AutoSize = true;
            this.highestTimeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestTimeText.ForeColor = System.Drawing.Color.White;
            this.highestTimeText.Location = new System.Drawing.Point(3, 81);
            this.highestTimeText.Name = "highestTimeText";
            this.highestTimeText.Size = new System.Drawing.Size(81, 19);
            this.highestTimeText.TabIndex = 7;
            this.highestTimeText.Text = "00:00:00";
            // 
            // highestTimeLabel
            // 
            this.highestTimeLabel.AutoSize = true;
            this.highestTimeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestTimeLabel.ForeColor = System.Drawing.Color.White;
            this.highestTimeLabel.Location = new System.Drawing.Point(3, 62);
            this.highestTimeLabel.Name = "highestTimeLabel";
            this.highestTimeLabel.Size = new System.Drawing.Size(81, 19);
            this.highestTimeLabel.TabIndex = 8;
            this.highestTimeLabel.Text = "Highest:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.delAllTimesButton);
            this.panel1.Controls.Add(this.savedTimes);
            this.panel1.Controls.Add(this.delTimeButton);
            this.panel1.Location = new System.Drawing.Point(25, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 152);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(789, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scrambleText);
            this.Controls.Add(this.inspectTimerText);
            this.Controls.Add(this.timerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cube";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label inspectTimerText;
        private System.Windows.Forms.Timer inspectTimer;
        private System.Windows.Forms.Label scrambleText;
        private System.Windows.Forms.Button delTimeButton;
        private System.Windows.Forms.ListBox savedTimes;
        private System.Windows.Forms.Button delAllTimesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label averageTimeLabel;
        private System.Windows.Forms.Label lowestTimeLabel;
        private System.Windows.Forms.Label averageTimeText;
        private System.Windows.Forms.Label lowestTimeText;
        private System.Windows.Forms.Label highestTimeText;
        private System.Windows.Forms.Label highestTimeLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

