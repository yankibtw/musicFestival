using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicFestival.Forms
{
    public partial class ActersForm : Form
    {
        public ActersForm()
        {
            InitializeComponent();
        }

        private void Acters_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            XDocument xmlDocument = XDocument.Load("../../References/acters.xml");
            string jsonText = System.IO.File.ReadAllText("../../References/acters.json");
            JObject jsonObject = JObject.Parse(jsonText);

            DisplayActersInTable(xmlDocument);
        }
        private void DisplayActersInTable(XDocument xmlDocument)
        {
            actersGridView.Rows.Clear();

            foreach (var actersElement in xmlDocument.Root.Elements("artist"))
            {
                string id = actersElement.Element("ID")?.Value ?? "N/A";
                string executor = actersElement.Element("executor")?.Value ?? "N/A";
                string genre = actersElement.Element("genre")?.Value ?? "N/A";
                string country = actersElement.Element("country")?.Value ?? "N/A";
                string title = actersElement.Element("bestMusic")?.Element("title")?.Value ?? "N/A";
                string year = actersElement.Element("bestMusic")?.Element("year")?.Value ?? "N/A";
                string bestMusic = $"{title} ({year})";
                actersGridView.Rows.Add(id, executor, genre, country, bestMusic);
            }
        }
        private void actersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < actersGridView.Rows.Count)
            {
                actersGridView.Visible = false;
                informationActerLabel.Visible = true;
                idLabel.Visible = true;
                idText.Visible = true;
                nickLabel.Visible = true;
                nickText.Visible = true;
                genreLabel.Visible = true;
                genreText.Visible = true;
                countryLabel.Visible = true;
                countryText.Visible = true;
                bestMusicLabel.Visible = true;
                bestMusicText.Visible = true;
                okayBtn.Visible = true;


                DataGridViewRow selectedRow = actersGridView.Rows[e.RowIndex];
                string selectedTitle = selectedRow.Cells["title"].Value.ToString();
                DisplaySingleActersInfo(selectedTitle);
            }
        }

        private void DisplaySingleActersInfo(string selectedTitle)
        {
            JObject jsonObject = JObject.Parse(System.IO.File.ReadAllText("../../References/acters.json"));
            JToken selectedActer = jsonObject["acters"].FirstOrDefault(f => f["executor"].ToString() == selectedTitle);

            if (selectedActer != null)
            {
                idText.Text = selectedActer["ID"].ToString();
                nickText.Text = selectedActer["executor"].ToString();
                genreText.Text = selectedActer["genre"].ToString();
                countryText.Text = selectedActer["country"].ToString();

                string title = selectedActer["bestMusic"].Value<string>("title");
                int year = selectedActer["bestMusic"].Value<int>("year");

                bestMusicText.Text = $"{title} ({year})";

            }
        }
        private void OkayBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            actersGridView.Visible = true;
            informationActerLabel.Visible = false;
            idLabel.Visible = false;
            idText.Visible = false;
            nickLabel.Visible = false;
            nickText.Visible = false;
            genreLabel.Visible = false;
            genreText.Visible = false;
            countryLabel.Visible = false;
            countryText.Visible = false;
            bestMusicLabel.Visible = false;
            bestMusicText.Visible = false;
            okayBtn.Visible = false;
        }

    }
}