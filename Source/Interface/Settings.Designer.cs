namespace AbsoluteZero {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.start = new System.Windows.Forms.Button();
            this.whitePanel = new System.Windows.Forms.GroupBox();
            this.whiteComputer = new System.Windows.Forms.RadioButton();
            this.whiteHuman = new System.Windows.Forms.RadioButton();
            this.blackPanel = new System.Windows.Forms.GroupBox();
            this.blackComputer = new System.Windows.Forms.RadioButton();
            this.blackHuman = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Chess960 = new System.Windows.Forms.Button();
            this.whitePanel.SuspendLayout();
            this.blackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(12, 123);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(306, 42);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClick);
            // 
            // whitePanel
            // 
            this.whitePanel.Controls.Add(this.whiteComputer);
            this.whitePanel.Controls.Add(this.whiteHuman);
            this.whitePanel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whitePanel.Location = new System.Drawing.Point(14, 12);
            this.whitePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.whitePanel.Name = "whitePanel";
            this.whitePanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.whitePanel.Size = new System.Drawing.Size(146, 100);
            this.whitePanel.TabIndex = 2;
            this.whitePanel.TabStop = false;
            this.whitePanel.Text = "White";
            // 
            // whiteComputer
            // 
            this.whiteComputer.AutoSize = true;
            this.whiteComputer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteComputer.Location = new System.Drawing.Point(15, 62);
            this.whiteComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.whiteComputer.Name = "whiteComputer";
            this.whiteComputer.Size = new System.Drawing.Size(123, 27);
            this.whiteComputer.TabIndex = 1;
            this.whiteComputer.TabStop = true;
            this.whiteComputer.Text = "Computer";
            this.whiteComputer.UseVisualStyleBackColor = true;
            // 
            // whiteHuman
            // 
            this.whiteHuman.AutoSize = true;
            this.whiteHuman.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteHuman.Location = new System.Drawing.Point(15, 26);
            this.whiteHuman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.whiteHuman.Name = "whiteHuman";
            this.whiteHuman.Size = new System.Drawing.Size(90, 27);
            this.whiteHuman.TabIndex = 0;
            this.whiteHuman.TabStop = true;
            this.whiteHuman.Text = "Human";
            this.whiteHuman.UseVisualStyleBackColor = true;
            // 
            // blackPanel
            // 
            this.blackPanel.Controls.Add(this.blackComputer);
            this.blackPanel.Controls.Add(this.blackHuman);
            this.blackPanel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackPanel.Location = new System.Drawing.Point(171, 12);
            this.blackPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blackPanel.Name = "blackPanel";
            this.blackPanel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blackPanel.Size = new System.Drawing.Size(146, 100);
            this.blackPanel.TabIndex = 3;
            this.blackPanel.TabStop = false;
            this.blackPanel.Text = "Black";
            // 
            // blackComputer
            // 
            this.blackComputer.AutoSize = true;
            this.blackComputer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackComputer.Location = new System.Drawing.Point(15, 62);
            this.blackComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blackComputer.Name = "blackComputer";
            this.blackComputer.Size = new System.Drawing.Size(123, 27);
            this.blackComputer.TabIndex = 1;
            this.blackComputer.TabStop = true;
            this.blackComputer.Text = "Computer";
            this.blackComputer.UseVisualStyleBackColor = true;
            // 
            // blackHuman
            // 
            this.blackHuman.AutoSize = true;
            this.blackHuman.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackHuman.Location = new System.Drawing.Point(15, 26);
            this.blackHuman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blackHuman.Name = "blackHuman";
            this.blackHuman.Size = new System.Drawing.Size(90, 27);
            this.blackHuman.TabIndex = 0;
            this.blackHuman.TabStop = true;
            this.blackHuman.Text = "Human";
            this.blackHuman.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Analysis Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AnalysisModeClick);
            // 
            // Chess960
            // 
            this.Chess960.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.Chess960.Location = new System.Drawing.Point(12, 231);
            this.Chess960.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Chess960.Name = "Chess960";
            this.Chess960.Size = new System.Drawing.Size(306, 42);
            this.Chess960.TabIndex = 4;
            this.Chess960.Text = "Chess960";
            this.Chess960.UseVisualStyleBackColor = true;
            this.Chess960.Click += new System.EventHandler(this.Chess960_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 294);
            this.Controls.Add(this.Chess960);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blackPanel);
            this.Controls.Add(this.whitePanel);
            this.Controls.Add(this.start);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.whitePanel.ResumeLayout(false);
            this.whitePanel.PerformLayout();
            this.blackPanel.ResumeLayout(false);
            this.blackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox whitePanel;
        private System.Windows.Forms.RadioButton whiteComputer;
        private System.Windows.Forms.RadioButton whiteHuman;
        private System.Windows.Forms.GroupBox blackPanel;
        private System.Windows.Forms.RadioButton blackComputer;
        private System.Windows.Forms.RadioButton blackHuman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Chess960;
    }
}