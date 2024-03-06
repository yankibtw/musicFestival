using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicFestival.Forms
{
    public partial class Festival : Form
    {
        private Label informationLabel;

        public Festival()
        {
            InitializeComponent();
        }
        private void Festival_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            XDocument xmlDocument = XDocument.Load("../../References/festivals.xml");
            string jsonText = System.IO.File.ReadAllText("../../References/festivals.json");
            JObject jsonObject = JObject.Parse(jsonText);

            DisplayFestivalsInTable(xmlDocument);
        }


        private void DisplayFestivalsInTable(XDocument xmlDocument)
        {
            festivalGridView.Rows.Clear();

            foreach (var festivalElement in xmlDocument.Root.Elements("festival"))
            {
                string id = festivalElement.Element("ID")?.Value ?? "N/A";
                string title = festivalElement.Element("title")?.Value ?? "N/A";
                string genre = festivalElement.Element("genre")?.Value ?? "N/A";
                string day = festivalElement.Element("fullDateStart")?.Element("day")?.Value ?? "N/A";
                string month = festivalElement.Element("fullDateStart")?.Element("month")?.Value ?? "N/A";
                string year = festivalElement.Element("fullDateStart")?.Element("year")?.Value ?? "N/A";
                string cities = festivalElement.Element("TheСitiesOfTheEvent")?.Value ?? "N/A";
                string date = $"{day} {month} {year}";

                festivalGridView.Rows.Add(id, title, genre, date, cities);
            }
        }

        private void dataGridViewFestivals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < festivalGridView.Rows.Count)
            {
                festivalGridView.Visible = false;
                informationLabel.Visible = true;
                idLabel.Visible = true;
                idText.Visible = true;
                titleLabel.Visible = true;
                titleText.Visible = true;
                genreLabel.Visible = true;
                genreText.Visible = true;
                dateLabel.Visible = true;
                dateText.Visible = true;
                cityLabel.Visible = true;
                cityText.Visible = true;
                okayBtn.Visible = true;


                DataGridViewRow selectedRow = festivalGridView.Rows[e.RowIndex];
                string selectedTitle = selectedRow.Cells["Title"].Value.ToString();
                DisplaySingleFestivalInfo(selectedTitle);
            }
        }

        private void DisplaySingleFestivalInfo(string selectedTitle)
        {
            JObject jsonObject = JObject.Parse(System.IO.File.ReadAllText("../../References/festivals.json"));
            JToken selectedFestival = jsonObject["festivals"].FirstOrDefault(f => f["title"].ToString() == selectedTitle);

            if (selectedFestival != null)
            {
                idText.Text = selectedFestival["ID"].ToString();
                titleText.Text = selectedFestival["title"].ToString();
                genreText.Text = selectedFestival["genre"].ToString();

                int day = selectedFestival["fullDateStart"].Value<int>("day");
                string month = selectedFestival["fullDateStart"].Value<string>("month");
                int year = selectedFestival["fullDateStart"].Value<int>("year");

                dateText.Text = $"{day} {month} {year}";
                cityText.Text = selectedFestival["TheСitiesOfTheEvent"].ToString();
            }
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            festivalGridView.Visible = true;
            informationLabel.Visible = false;
            idLabel.Visible = false;
            idText.Visible = false;
            titleLabel.Visible = false;
            titleText.Visible = false;
            genreLabel.Visible = false;
            genreText.Visible = false;
            dateLabel.Visible = false;
            dateText.Visible = false;
            cityLabel.Visible = false;
            cityText.Visible = false;
            okayBtn.Visible = false;
        }

    }
}


