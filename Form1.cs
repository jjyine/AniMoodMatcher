using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimeMoodMatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Anime
        {
            public string Num { get; set; }
            public string Brain { get; set; }
            public string Emotion { get; set; }
            public string Genre { get; set; }
            public string Title { get; set; }
            public string Why { get; set; }
        }

        List<String> datalist = new List<String>();
        private DataTable animeTable;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 프로젝트정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["Formhistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private List<Anime> LoadAnimeList(string filepath)
        {
            var list = new List<Anime>();

            try
            {
                foreach (var line in File.ReadLines(filepath))
                {
                    var data = line.Split(',');
                    if (data.Length >= 6)
                    {
                        list.Add(new Anime
                        {
                            Num = data[0],
                            Brain = data[1],
                            Emotion = data[2],
                            Genre = data[3],
                            Title = data[4],
                            Why = data[5]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV 읽기 오류: {ex.Message}");
            }

            return list;
        }

        private string GetSelectedRadioText(GroupBox groupbox)
        {
            foreach (RadioButton rb in groupbox.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }


        private void btnResult_Click_1(object sender, EventArgs e)
        {
            try
            {
                //DataTable table = LoadAnimeCsv("anime.csv");
                var animeList = LoadAnimeList("anime.csv");


                string selectedBrain = GetSelectedRadioText(gbBrain);
                string selectedEmotion = GetSelectedRadioText(gbEmotion);
                string selectedGenre = GetSelectedRadioText(gbGenre);



                if (selectedBrain == null || selectedEmotion == null || selectedGenre == null)
                {
                    MessageBox.Show("모든 항목을 선택해주세요.");
                    return;
                }

                //tbResult.Text = $"선택된 뇌 상태: {selectedBrain}\r\n" +
                //       $"선택된 감정: {selectedEmotion}\r\n" +
                //       $"선택된 장르: {selectedGenre}";

                var anime = animeList.FirstOrDefault(a =>
                        a.Brain == selectedBrain &&
                        a.Emotion == selectedEmotion &&
                        a.Genre == selectedGenre
                );


                if (anime != null)
                {
                    tbResult.Text = $"추천 애니: {anime.Title}\r\n{anime.Why}";
                    SaveHistory($"{selectedBrain} {selectedEmotion} {selectedGenre}|{anime.Title} {anime.Why}");
                }
                else
                {
                    tbResult.Text = "조건에 맞는 추천이 없습니다.";
                }
                
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요.\n{ex.Message}", "파일이 없음");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요.\n{ex.Message}", "권한오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한 없음 오류 발생!\n{ex.Message}", "권한 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류 발생!\n{ex.Message}", "알 수 없는 오류");
            }


        }

        public void LoadHistory(string history)
        {
            var parts = history.Split('|');

            var selectpart = parts[0].Split(' ');
            string brain = selectpart[0];
            string emotion = selectpart[1];
            string genre = selectpart[2];

            var resultpart = parts[1].Split(new char[] { ' ' }, 2);
            string title = resultpart[0];
            string why = resultpart[1];

            tbResult.Text = brain + Environment.NewLine +
                    emotion + Environment.NewLine +
                    genre + Environment.NewLine +
                    title + Environment.NewLine +
                    why;
        }
    }
}
