namespace MVP.Views
{
    partial class UpdateView
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numeric_score = new System.Windows.Forms.NumericUpDown();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_first = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_score)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(303, 22);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(255, 45);
            this.lbl_date.TabIndex = 11;
            this.lbl_date.Text = "Date Of Birth";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(303, 348);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(235, 56);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(67, 348);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 56);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(303, 94);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // numeric_score
            // 
            this.numeric_score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numeric_score.DecimalPlaces = 1;
            this.numeric_score.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeric_score.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_score.Location = new System.Drawing.Point(67, 272);
            this.numeric_score.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numeric_score.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeric_score.Name = "numeric_score";
            this.numeric_score.Size = new System.Drawing.Size(200, 34);
            this.numeric_score.TabIndex = 7;
            // 
            // txt_last
            // 
            this.txt_last.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_last.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_last.Location = new System.Drawing.Point(67, 188);
            this.txt_last.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_last.Name = "txt_last";
            this.txt_last.PlaceholderText = "LastName";
            this.txt_last.Size = new System.Drawing.Size(199, 34);
            this.txt_last.TabIndex = 5;
            // 
            // txt_first
            // 
            this.txt_first.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_first.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_first.Location = new System.Drawing.Point(67, 94);
            this.txt_first.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_first.Name = "txt_first";
            this.txt_first.PlaceholderText = "FirstName";
            this.txt_first.Size = new System.Drawing.Size(199, 34);
            this.txt_first.TabIndex = 6;
            // 
            // UpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numeric_score);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.txt_first);
            this.Name = "UpdateView";
            this.Text = "UpdateView";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_date;
        private Button btn_cancel;
        private Button btn_save;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numeric_score;
        private TextBox txt_last;
        private TextBox txt_first;
    }
}