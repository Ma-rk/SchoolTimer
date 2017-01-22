namespace SchoolTimer
{
    partial class SchoolTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolTimer));
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_sprint = new System.Windows.Forms.Label();
            this.label_break = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_currentTime
            // 
            this.label_currentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.Font = new System.Drawing.Font("Dotum", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_currentTime.Location = new System.Drawing.Point(115, 12);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(30, 29);
            this.label_currentTime.TabIndex = 0;
            this.label_currentTime.Text = "-";
            // 
            // label_sprint
            // 
            this.label_sprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sprint.AutoSize = true;
            this.label_sprint.Font = new System.Drawing.Font("Dotum", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_sprint.Location = new System.Drawing.Point(71, 61);
            this.label_sprint.Name = "label_sprint";
            this.label_sprint.Size = new System.Drawing.Size(118, 37);
            this.label_sprint.TabIndex = 1;
            this.label_sprint.Text = "45:00";
            // 
            // label_break
            // 
            this.label_break.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_break.AutoSize = true;
            this.label_break.Font = new System.Drawing.Font("Dotum", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_break.Location = new System.Drawing.Point(71, 114);
            this.label_break.Name = "label_break";
            this.label_break.Size = new System.Drawing.Size(118, 37);
            this.label_break.TabIndex = 2;
            this.label_break.Text = "15:00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_break, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_currentTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_sprint, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 159);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SchoolTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolTimer";
            this.Text = "Timer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_sprint;
        private System.Windows.Forms.Label label_break;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

