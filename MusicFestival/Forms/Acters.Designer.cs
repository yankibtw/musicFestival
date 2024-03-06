namespace MusicFestival.Forms
{
    partial class ActersForm
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
            this.countryText = new System.Windows.Forms.Label();
            this.bestMusicText = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.nickText = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.Label();
            this.bestMusicLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.informationActerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.actersGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.actersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // okayBtn
            // 
            this.okayBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayBtn.Location = new System.Drawing.Point(63, 498);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(318, 51);
            this.okayBtn.TabIndex = 28;
            this.okayBtn.Text = "Готово";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Visible = false;
            this.okayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // countryText
            // 
            this.countryText.AutoSize = true;
            this.countryText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryText.Location = new System.Drawing.Point(428, 343);
            this.countryText.Margin = new System.Windows.Forms.Padding(15);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(0, 25);
            this.countryText.TabIndex = 27;
            this.countryText.Visible = false;
            // 
            // bestMusicText
            // 
            this.bestMusicText.AutoSize = true;
            this.bestMusicText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestMusicText.Location = new System.Drawing.Point(428, 398);
            this.bestMusicText.Margin = new System.Windows.Forms.Padding(15);
            this.bestMusicText.Name = "bestMusicText";
            this.bestMusicText.Size = new System.Drawing.Size(0, 25);
            this.bestMusicText.TabIndex = 26;
            this.bestMusicText.Visible = false;
            // 
            // genreText
            // 
            this.genreText.AutoSize = true;
            this.genreText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.Location = new System.Drawing.Point(428, 288);
            this.genreText.Margin = new System.Windows.Forms.Padding(15);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(0, 25);
            this.genreText.TabIndex = 25;
            this.genreText.Visible = false;
            // 
            // nickText
            // 
            this.nickText.AutoSize = true;
            this.nickText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickText.Location = new System.Drawing.Point(428, 233);
            this.nickText.Margin = new System.Windows.Forms.Padding(15);
            this.nickText.Name = "nickText";
            this.nickText.Size = new System.Drawing.Size(0, 25);
            this.nickText.TabIndex = 24;
            this.nickText.Visible = false;
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(428, 177);
            this.idText.Margin = new System.Windows.Forms.Padding(15);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(0, 25);
            this.idText.TabIndex = 23;
            this.idText.Visible = false;
            // 
            // bestMusicLabel
            // 
            this.bestMusicLabel.AutoSize = true;
            this.bestMusicLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestMusicLabel.Location = new System.Drawing.Point(63, 398);
            this.bestMusicLabel.Margin = new System.Windows.Forms.Padding(15);
            this.bestMusicLabel.Name = "bestMusicLabel";
            this.bestMusicLabel.Size = new System.Drawing.Size(135, 25);
            this.bestMusicLabel.TabIndex = 22;
            this.bestMusicLabel.Text = "Лучшая песня";
            this.bestMusicLabel.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(63, 288);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(15);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(60, 25);
            this.genreLabel.TabIndex = 21;
            this.genreLabel.Text = "Жанр";
            this.genreLabel.Visible = false;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(63, 343);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(15);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(77, 25);
            this.countryLabel.TabIndex = 19;
            this.countryLabel.Text = "Страна";
            this.countryLabel.Visible = false;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickLabel.Location = new System.Drawing.Point(63, 233);
            this.nickLabel.Margin = new System.Windows.Forms.Padding(15);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(131, 25);
            this.nickLabel.TabIndex = 20;
            this.nickLabel.Text = "Исполнитель";
            this.nickLabel.Visible = false;
            // 
            // informationActerLabel
            // 
            this.informationActerLabel.AutoSize = true;
            this.informationActerLabel.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationActerLabel.Location = new System.Drawing.Point(56, 113);
            this.informationActerLabel.Name = "informationActerLabel";
            this.informationActerLabel.Size = new System.Drawing.Size(365, 37);
            this.informationActerLabel.TabIndex = 17;
            this.informationActerLabel.Text = "Информация об актере";
            this.informationActerLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(63, 178);
            this.idLabel.Margin = new System.Windows.Forms.Padding(15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 25);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "ID";
            this.idLabel.Visible = false;
            // 
            // actersGridView
            // 
            this.actersGridView.AllowUserToAddRows = false;
            this.actersGridView.AllowUserToDeleteRows = false;
            this.actersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.actersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.actersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.actersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.actersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actersGridView.Location = new System.Drawing.Point(0, 0);
            this.actersGridView.Name = "actersGridView";
            this.actersGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.actersGridView.RowHeadersVisible = false;
            this.actersGridView.RowHeadersWidth = 45;
            this.actersGridView.Size = new System.Drawing.Size(1095, 574);
            this.actersGridView.TabIndex = 16;
            this.actersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actersGridView_CellClick);
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
            this.Title.HeaderText = "Исполнитель";
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
            this.Date.HeaderText = "Страна";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.HeaderText = "Лучшая песня";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // ActersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 574);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.bestMusicText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.nickText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.bestMusicLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.informationActerLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.actersGridView);
            this.Name = "ActersForm";
            this.Text = "Актеры";
            this.Load += new System.EventHandler(this.Acters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.Label countryText;
        private System.Windows.Forms.Label bestMusicText;
        private System.Windows.Forms.Label genreText;
        private System.Windows.Forms.Label nickText;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label bestMusicLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label informationActerLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView actersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}