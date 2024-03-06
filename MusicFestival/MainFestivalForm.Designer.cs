namespace MusicFestival
{
    partial class MusicFestivalForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicFestivalForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.songsBtn = new FontAwesome.Sharp.IconButton();
            this.actersBtn = new FontAwesome.Sharp.IconButton();
            this.festivalBtn = new FontAwesome.Sharp.IconButton();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTag = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.songsBtn);
            this.menuPanel.Controls.Add(this.actersBtn);
            this.menuPanel.Controls.Add(this.festivalBtn);
            this.menuPanel.Controls.Add(this.mainLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 617);
            this.menuPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.exitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.exitBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 35;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 552);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(300, 65);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "  Выход";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // songsBtn
            // 
            this.songsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.songsBtn.FlatAppearance.BorderSize = 0;
            this.songsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsBtn.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.songsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.songsBtn.IconChar = FontAwesome.Sharp.IconChar.MicrophoneAlt;
            this.songsBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.songsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.songsBtn.IconSize = 35;
            this.songsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songsBtn.Location = new System.Drawing.Point(0, 386);
            this.songsBtn.Name = "songsBtn";
            this.songsBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.songsBtn.Size = new System.Drawing.Size(300, 65);
            this.songsBtn.TabIndex = 6;
            this.songsBtn.Text = "  Песни";
            this.songsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.songsBtn.UseVisualStyleBackColor = true;
            this.songsBtn.Click += new System.EventHandler(this.songsBtn_Click);
            // 
            // actersBtn
            // 
            this.actersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actersBtn.FlatAppearance.BorderSize = 0;
            this.actersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actersBtn.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.actersBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.actersBtn.IconChar = FontAwesome.Sharp.IconChar.Napster;
            this.actersBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.actersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actersBtn.IconSize = 35;
            this.actersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actersBtn.Location = new System.Drawing.Point(-3, 315);
            this.actersBtn.Name = "actersBtn";
            this.actersBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.actersBtn.Size = new System.Drawing.Size(300, 65);
            this.actersBtn.TabIndex = 5;
            this.actersBtn.Text = "  Исполнители";
            this.actersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.actersBtn.UseVisualStyleBackColor = true;
            this.actersBtn.Click += new System.EventHandler(this.actersBtn_Click);
            // 
            // festivalBtn
            // 
            this.festivalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.festivalBtn.FlatAppearance.BorderSize = 0;
            this.festivalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.festivalBtn.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.festivalBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.festivalBtn.IconChar = FontAwesome.Sharp.IconChar.SchoolFlag;
            this.festivalBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.festivalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.festivalBtn.IconSize = 35;
            this.festivalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.festivalBtn.Location = new System.Drawing.Point(-3, 244);
            this.festivalBtn.Name = "festivalBtn";
            this.festivalBtn.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.festivalBtn.Size = new System.Drawing.Size(300, 65);
            this.festivalBtn.TabIndex = 4;
            this.festivalBtn.Text = "  Фестивали";
            this.festivalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.festivalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.festivalBtn.UseVisualStyleBackColor = true;
            this.festivalBtn.Click += new System.EventHandler(this.festivalsBtn_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.BackgroundImage = global::MusicFestival.Properties.Resources.festival;
            this.mainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainLogo.Location = new System.Drawing.Point(75, 35);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(150, 150);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            this.mainLogo.Click += new System.EventHandler(this.mainLogo_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.titlePanel.Controls.Add(this.titleTag);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titlePanel.Location = new System.Drawing.Point(300, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(634, 60);
            this.titlePanel.TabIndex = 1;
            // 
            // titleTag
            // 
            this.titleTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTag.AutoSize = true;
            this.titleTag.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.titleTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleTag.Location = new System.Drawing.Point(299, 14);
            this.titleTag.Name = "titleTag";
            this.titleTag.Size = new System.Drawing.Size(114, 32);
            this.titleTag.TabIndex = 0;
            this.titleTag.Text = "Главная";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(300, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(634, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(300, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(634, 548);
            this.panelDesktop.TabIndex = 3;
            // 
            // MusicFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 617);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicFestivalForm";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleTag;
        private FontAwesome.Sharp.IconButton festivalBtn;
        private FontAwesome.Sharp.IconButton songsBtn;
        private FontAwesome.Sharp.IconButton actersBtn;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton exitBtn;
    }
}

