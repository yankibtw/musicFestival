namespace MusicFestival.Forms
{
    partial class Songs
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
            this.okayBtn = new System.Windows.Forms.Button();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.songInfo = new System.Windows.Forms.Label();
            this.songsGridView = new System.Windows.Forms.DataGridView();
            this.albumLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.durationText = new System.Windows.Forms.Label();
            this.releaseDateText = new System.Windows.Forms.Label();
            this.albumText = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // okayBtn
            // 
            this.okayBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayBtn.Location = new System.Drawing.Point(63, 583);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(318, 51);
            this.okayBtn.TabIndex = 41;
            this.okayBtn.Text = "Готово";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Visible = false;
            this.okayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateLabel.Location = new System.Drawing.Point(63, 453);
            this.releaseDateLabel.Margin = new System.Windows.Forms.Padding(15);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(66, 25);
            this.releaseDateLabel.TabIndex = 35;
            this.releaseDateLabel.Text = "Релиз";
            this.releaseDateLabel.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(63, 343);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(15);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(60, 25);
            this.genreLabel.TabIndex = 34;
            this.genreLabel.Text = "Жанр";
            this.genreLabel.Visible = false;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(63, 398);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(15);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(142, 25);
            this.durationLabel.TabIndex = 32;
            this.durationLabel.Text = "Длительность";
            this.durationLabel.Visible = false;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(63, 288);
            this.artistLabel.Margin = new System.Windows.Forms.Padding(15);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(131, 25);
            this.artistLabel.TabIndex = 33;
            this.artistLabel.Text = "Исполнитель";
            this.artistLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(63, 178);
            this.idLabel.Margin = new System.Windows.Forms.Padding(15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 25);
            this.idLabel.TabIndex = 31;
            this.idLabel.Text = "ID";
            this.idLabel.Visible = false;
            // 
            // songInfo
            // 
            this.songInfo.AutoSize = true;
            this.songInfo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfo.Location = new System.Drawing.Point(56, 113);
            this.songInfo.Name = "songInfo";
            this.songInfo.Size = new System.Drawing.Size(328, 37);
            this.songInfo.TabIndex = 30;
            this.songInfo.Text = "Информация о песне";
            this.songInfo.Visible = false;
            // 
            // songsGridView
            // 
            this.songsGridView.AllowUserToAddRows = false;
            this.songsGridView.AllowUserToDeleteRows = false;
            this.songsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.songsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.songsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.acters,
            this.Genre,
            this.Date,
            this.City,
            this.album});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.songsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songsGridView.Location = new System.Drawing.Point(0, 0);
            this.songsGridView.Name = "songsGridView";
            this.songsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.songsGridView.RowHeadersVisible = false;
            this.songsGridView.RowHeadersWidth = 45;
            this.songsGridView.Size = new System.Drawing.Size(1178, 669);
            this.songsGridView.TabIndex = 29;
            this.songsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songsGridView_CellClick);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.Location = new System.Drawing.Point(63, 508);
            this.albumLabel.Margin = new System.Windows.Forms.Padding(15);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(81, 25);
            this.albumLabel.TabIndex = 42;
            this.albumLabel.Text = "Альбом";
            this.albumLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(63, 233);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 25);
            this.titleLabel.TabIndex = 43;
            this.titleLabel.Text = "Название";
            this.titleLabel.Visible = false;
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(354, 178);
            this.idText.Margin = new System.Windows.Forms.Padding(15);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(0, 25);
            this.idText.TabIndex = 44;
            this.idText.Visible = false;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(354, 233);
            this.titleText.Margin = new System.Windows.Forms.Padding(15);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(0, 25);
            this.titleText.TabIndex = 45;
            this.titleText.Visible = false;
            // 
            // artistText
            // 
            this.artistText.AutoSize = true;
            this.artistText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistText.Location = new System.Drawing.Point(354, 288);
            this.artistText.Margin = new System.Windows.Forms.Padding(15);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(0, 25);
            this.artistText.TabIndex = 46;
            this.artistText.Visible = false;
            // 
            // genreText
            // 
            this.genreText.AutoSize = true;
            this.genreText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.Location = new System.Drawing.Point(354, 343);
            this.genreText.Margin = new System.Windows.Forms.Padding(15);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(0, 25);
            this.genreText.TabIndex = 47;
            this.genreText.Visible = false;
            // 
            // durationText
            // 
            this.durationText.AutoSize = true;
            this.durationText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationText.Location = new System.Drawing.Point(354, 398);
            this.durationText.Margin = new System.Windows.Forms.Padding(15);
            this.durationText.Name = "durationText";
            this.durationText.Size = new System.Drawing.Size(0, 25);
            this.durationText.TabIndex = 48;
            this.durationText.Visible = false;
            // 
            // releaseDateText
            // 
            this.releaseDateText.AutoSize = true;
            this.releaseDateText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateText.Location = new System.Drawing.Point(354, 453);
            this.releaseDateText.Margin = new System.Windows.Forms.Padding(15);
            this.releaseDateText.Name = "releaseDateText";
            this.releaseDateText.Size = new System.Drawing.Size(0, 25);
            this.releaseDateText.TabIndex = 49;
            this.releaseDateText.Visible = false;
            // 
            // albumText
            // 
            this.albumText.AutoSize = true;
            this.albumText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumText.Location = new System.Drawing.Point(354, 508);
            this.albumText.Margin = new System.Windows.Forms.Padding(15);
            this.albumText.Name = "albumText";
            this.albumText.Size = new System.Drawing.Size(0, 25);
            this.albumText.TabIndex = 50;
            this.albumText.Visible = false;
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
            // acters
            // 
            this.acters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acters.HeaderText = "Исполнитель";
            this.acters.Name = "acters";
            this.acters.ReadOnly = true;
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
            this.Date.HeaderText = "Длительность";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.HeaderText = "Релиз";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // album
            // 
            this.album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.album.HeaderText = "Альбом";
            this.album.Name = "album";
            this.album.ReadOnly = true;
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 669);
            this.Controls.Add(this.albumText);
            this.Controls.Add(this.releaseDateText);
            this.Controls.Add(this.durationText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.songInfo);
            this.Controls.Add(this.songsGridView);
            this.Name = "Songs";
            this.Text = "Песни";
            this.Load += new System.EventHandler(this.Songs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label songInfo;
        private System.Windows.Forms.DataGridView songsGridView;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label artistText;
        private System.Windows.Forms.Label genreText;
        private System.Windows.Forms.Label durationText;
        private System.Windows.Forms.Label releaseDateText;
        private System.Windows.Forms.Label albumText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn acters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn album;
    }
}