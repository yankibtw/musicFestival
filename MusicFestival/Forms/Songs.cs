using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MusicFestival.Forms
{
    public partial class Songs : Form
    {
        public Songs()
        {
            InitializeComponent();
        }

        private void Songs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            XDocument xmlDocument = XDocument.Load("../../References/songs.xml");
            string jsonText = System.IO.File.ReadAllText("../../References/songs.json");
            JObject jsonObject = JObject.Parse(jsonText);

            DisplaySongsInTable(xmlDocument);
        }
        private void DisplaySongsInTable(XDocument xmlDocument)
        {
            songsGridView.Rows.Clear();

            foreach (var songElement in xmlDocument.Root.Elements("song"))
            {
                string id = songElement.Element("ID")?.Value ?? "N/A";
                string title = songElement.Element("title")?.Value ?? "N/A";
                string artist = songElement.Element("artist")?.Value ?? "N/A";
                string genre = songElement.Element("genre")?.Value ?? "N/A";
                string duration = songElement.Element("duration")?.Value ?? "N/A";
                string releaseDate = songElement.Element("releaseDate")?.Value ?? "N/A";
                string albumTitle = songElement.Element("album")?.Element("name")?.Value ?? "N/A";
                string albumReleaseYear = songElement.Element("album")?.Element("releaseYear")?.Value ?? "N/A";
                string album = $"{albumTitle} ({albumReleaseYear})";
                songsGridView.Rows.Add(id, title, artist, genre, duration, releaseDate, album);
            }
        }
        private void songsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < songsGridView.Rows.Count)
            {
                songsGridView.Visible = false;
                songInfo.Visible = true;
                idLabel.Visible = true;
                idText.Visible = true;
                titleLabel.Visible = true;
                titleText.Visible = true;
                artistLabel.Visible = true;
                artistText.Visible = true;
                genreLabel.Visible = true;
                genreText.Visible = true;
                durationLabel.Visible = true;
                durationText.Visible = true;
                releaseDateLabel.Visible = true;
                releaseDateText.Visible = true;
                albumLabel.Visible = true;
                albumText.Visible = true;
                okayBtn.Visible = true;


                DataGridViewRow selectedRow = songsGridView.Rows[e.RowIndex];
                string selectedTitle = selectedRow.Cells["ID"].Value.ToString();
                DisplaySingleSongInfo(selectedTitle);
            }
        }

        private void DisplaySingleSongInfo(string selectedTitle)
        {
            JObject jsonObject = JObject.Parse(System.IO.File.ReadAllText("../../References/songs.json"));
            JToken selectedSong = jsonObject["songs"].FirstOrDefault(f => f["ID"].ToString() == selectedTitle);

            if (selectedSong != null)
            {
                idText.Text = selectedSong["ID"].ToString();
                titleText.Text = selectedSong["title"].ToString();
                artistText.Text = selectedSong["artist"].ToString();
                genreText.Text = selectedSong["genre"].ToString();
                durationText.Text = selectedSong["duration"].ToString();
                releaseDateText.Text = selectedSong["releaseDate"].ToString();

                string albumTitle = selectedSong["album"].Value<string>("name");
                int albumReleaseYear = selectedSong["album"].Value<int>("releaseYear");

                albumText.Text = $"{albumTitle} ({albumReleaseYear})";

            }
        }
        private void OkayBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            songsGridView.Visible = true;
            songInfo.Visible = false;
            idLabel.Visible = false;
            idText.Visible = false;
            titleLabel.Visible = false;
            titleText.Visible = false;
            artistLabel.Visible = false;
            artistText.Visible = false;
            genreLabel.Visible = false;
            genreText.Visible = false;
            durationLabel.Visible = false;
            durationText.Visible = false;
            releaseDateLabel.Visible = false;
            releaseDateText.Visible = false;
            albumLabel.Visible = false;
            albumText.Visible = false;
            okayBtn.Visible = false;
        }

    }
}

