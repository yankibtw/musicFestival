namespace MusicFestival.Forms
{
    partial class Festival
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.festivalGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.okayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.festivalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // festivalGridView
            // 
            this.festivalGridView.AllowUserToAddRows = false;
            this.festivalGridView.AllowUserToDeleteRows = false;
            this.festivalGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.festivalGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.festivalGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.festivalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.festivalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Genre,
            this.Date,
            this.City});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.festivalGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.festivalGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.festivalGridView.Location = new System.Drawing.Point(0, 0);
            this.festivalGridView.Name = "festivalGridView";
            this.festivalGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.festivalGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.festivalGridView.RowHeadersVisible = false;
            this.festivalGridView.RowHeadersWidth = 45;
            this.festivalGridView.Size = new System.Drawing.Size(1223, 598);
            this.festivalGridView.TabIndex = 0;
            this.festivalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFestivals_CellClick);
           
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Дата проведения";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.HeaderText = "Место проведения";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(56, 113);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(402, 37);
            this.informationLabel.TabIndex = 2;
            this.informationLabel.Text = "Информация о фестивале";
            this.informationLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(63, 178);
            this.idLabel.Margin = new System.Windows.Forms.Padding(15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 25);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            this.idLabel.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(63, 288);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(15);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(60, 25);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Жанр";
            this.genreLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(63, 233);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Название";
            this.titleLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(63, 343);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(171, 25);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Дата проведения";
            this.dateLabel.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(63, 398);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(15);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(185, 25);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "Место проведения";
            this.cityLabel.Visible = false;
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(428, 177);
            this.idText.Margin = new System.Windows.Forms.Padding(15);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(0, 25);
            this.idText.TabIndex = 10;
            this.idText.Visible = false;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(428, 233);
            this.titleText.Margin = new System.Windows.Forms.Padding(15);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(0, 25);
            this.titleText.TabIndex = 11;
            this.titleText.Visible = false;
            // 
            // genreText
            // 
            this.genreText.AutoSize = true;
            this.genreText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.Location = new System.Drawing.Point(428, 288);
            this.genreText.Margin = new System.Windows.Forms.Padding(15);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(0, 25);
            this.genreText.TabIndex = 12;
            this.genreText.Visible = false;
            // 
            // cityText
            // 
            this.cityText.AutoSize = true;
            this.cityText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.Location = new System.Drawing.Point(428, 398);
            this.cityText.Margin = new System.Windows.Forms.Padding(15);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(0, 25);
            this.cityText.TabIndex = 13;
            this.cityText.Visible = false;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(428, 343);
            this.dateText.Margin = new System.Windows.Forms.Padding(15);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(0, 25);
            this.dateText.TabIndex = 14;
            this.dateText.Visible = false;
            // 
            // okayBtn
            // 
            this.okayBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayBtn.Location = new System.Drawing.Point(63, 498);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(318, 51);
            this.okayBtn.TabIndex = 15;
            this.okayBtn.Text = "Готово";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Visible = false;
            this.okayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // Festival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 598);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.festivalGridView);
            this.Name = "Festival";
            this.Text = "Фестивали";
            this.Load += new System.EventHandler(this.Festival_Load);
            ((System.ComponentModel.ISupportInitialize)(this.festivalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView festivalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label genreText;
        private System.Windows.Forms.Label cityText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Button okayBtn;
    }
}