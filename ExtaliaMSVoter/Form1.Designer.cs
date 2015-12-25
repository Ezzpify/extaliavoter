namespace ExtaliaMSVoter
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.cb_Xtreme = new System.Windows.Forms.CheckBox();
            this.cb_Ultimate = new System.Windows.Forms.CheckBox();
            this.timer_Vote = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(256, 7);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 22);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sites:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(87, 8);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(163, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // cb_Xtreme
            // 
            this.cb_Xtreme.AutoSize = true;
            this.cb_Xtreme.Checked = true;
            this.cb_Xtreme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Xtreme.Location = new System.Drawing.Point(87, 38);
            this.cb_Xtreme.Name = "cb_Xtreme";
            this.cb_Xtreme.Size = new System.Drawing.Size(95, 17);
            this.cb_Xtreme.TabIndex = 5;
            this.cb_Xtreme.Text = "Xtreme (2,000)";
            this.cb_Xtreme.UseVisualStyleBackColor = true;
            // 
            // cb_Ultimate
            // 
            this.cb_Ultimate.AutoSize = true;
            this.cb_Ultimate.Checked = true;
            this.cb_Ultimate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Ultimate.Location = new System.Drawing.Point(87, 61);
            this.cb_Ultimate.Name = "cb_Ultimate";
            this.cb_Ultimate.Size = new System.Drawing.Size(100, 17);
            this.cb_Ultimate.TabIndex = 6;
            this.cb_Ultimate.Text = "Ultimate (1,000)";
            this.cb_Ultimate.UseVisualStyleBackColor = true;
            // 
            // timer_Vote
            // 
            this.timer_Vote.Interval = 60000;
            this.timer_Vote.Tick += new System.EventHandler(this.timer_Vote_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 90);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(353, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateLabel
            // 
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 17);
            this.dateLabel.Text = "Last vote: n/a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 112);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cb_Ultimate);
            this.Controls.Add(this.cb_Xtreme);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(369, 138);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtaliaMS Auto voter";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.CheckBox cb_Xtreme;
        private System.Windows.Forms.CheckBox cb_Ultimate;
        private System.Windows.Forms.Timer timer_Vote;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dateLabel;
    }
}

