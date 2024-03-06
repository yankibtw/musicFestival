using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicFestival
{
    public partial class MusicFestivalForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private static Color color = Color.FromArgb(33, 183, 155);
        private Form currentChildForm;
        public MusicFestivalForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);

            menuPanel.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(44, 56, 79);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void festivalsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new Forms.Festival());
        }

        private void actersBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new Forms.ActersForm());
        }

        private void songsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenChildForm(new Forms.Songs());
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm?.Close();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            titleTag.Text = "Главная";

        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleTag.Text = childForm.Text;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
