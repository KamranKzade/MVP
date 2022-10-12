namespace MVP.Views
{
    partial class AddView
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
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.numeric_score = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_score)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_first
            // 
            this.txt_first.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_first.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_first.Location = new System.Drawing.Point(19, 91);
            this.txt_first.Name = "txt_first";
            this.txt_first.PlaceholderText = "FirstName";
            this.txt_first.Size = new System.Drawing.Size(175, 29);
            this.txt_first.TabIndex = 0;
            // 
            // txt_last
            // 
            this.txt_last.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_last.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_last.Location = new System.Drawing.Point(19, 161);
            this.txt_last.Name = "txt_last";
            this.txt_last.PlaceholderText = "LastName";
            this.txt_last.Size = new System.Drawing.Size(175, 29);
            this.txt_last.TabIndex = 0;
            // 
            // numeric_score
            // 
            this.numeric_score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numeric_score.DecimalPlaces = 1;
            this.numeric_score.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeric_score.Location = new System.Drawing.Point(19, 224);
            this.numeric_score.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeric_score.Name = "numeric_score";
            this.numeric_score.Size = new System.Drawing.Size(175, 29);
            this.numeric_score.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(226, 91);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(19, 281);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(175, 42);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(226, 281);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(206, 42);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(226, 37);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(206, 36);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date Of Birth";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numeric_score);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.txt_first);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AddView";
            this.Text = "Add Form";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_first;
        private TextBox txt_last;
        private NumericUpDown numeric_score;
        private MonthCalendar monthCalendar1;
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_date;
    }
}