using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Media;

namespace Bolleyballer
{
    public partial class Bolleyballer : Form
    {
        public Bolleyballer()
        {
            InitializeComponent();
            this.showscores_outputbox.Hide();
            __init_placeholder_text();
            this.ActiveControl = this.addmember_team1;
        }

        private void declare_winner(int team)
        {
            PlaySound.Win();
            string team_name = team == 1 ? this.teamdisplay_team1.Text : this.teamdisplay_team2.Text;

            string[] team_members;
            if (team == 1)
            {
                team_members = new string[this.memberdisplay_team1.Items.Count];
                for (int i = 0; i < this.memberdisplay_team1.Items.Count; i++)
                    team_members[i] = this.memberdisplay_team1.Items[i].Text.ToString();
            }
            else
            {
                team_members = new string[this.memberdisplay_team2.Items.Count];
                for (int i = 0; i < this.memberdisplay_team1.Items.Count; i++)
                    team_members[i] = this.memberdisplay_team1.Items[i].Text.ToString();
            }

            this.page_game.Dispose();
            this.page_endgame.BringToFront();
            
            // edit label
            this.winning_team_display.Text += team_name + " Won!";
            this.winning_team_display.Location = new System.Drawing.Point((this.winning_team_display.Parent.Width - this.winning_team_display.Width) / 2, this.winning_team_display.Location.Y);

            // award points to members of winning team
            Database.AwardWin(team_members);
            

            this.page_endgame.Visible = true;
        }

        private void add_point(int team)
        {
            PlaySound.Award();
            int score = 0;
            switch (team)
            {
                case 1:
                    score = int.Parse(this.score_team1.Text.Substring(this.score_team1.Text.IndexOf(":") + 1)) + 1;
                    this.score_team1.Text = this.score_team1.Text.Remove(this.score_team1.Text.IndexOf(":") + 1) + " " + score;
                    break;
                case 2:
                    score = int.Parse(this.score_team2.Text.Substring(this.score_team1.Text.IndexOf(":") + 1)) + 1;
                    this.score_team2.Text = this.score_team2.Text.Remove(this.score_team1.Text.IndexOf(":") + 1) + " " + score;
                    break;
            }

            if (score == 21)
                declare_winner(team);
        }

        private void addpoint_team1_Click(object sender, EventArgs e)
        {
            add_point(1);
        }

        private void addpoint_team2_Click(object sender, EventArgs e)
        {
            add_point(2);
        }

        private void startgame_button_Click(object sender, EventArgs e)
        {
            if (this.memberlist_team1.Items.Count == 0 || this.memberlist_team2.Items.Count == 0)
            {
                MessageBox.Show("Add at least one member to each team to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            // get team names
            string team1_name = this.memberlist_team1.Items[0].Text.ToString();
            string team2_name = this.memberlist_team2.Items[0].Text.ToString();

            // get all members
            string[] team1_members = new string[this.memberlist_team1.Items.Count];
            string[] team2_members = new string[this.memberlist_team2.Items.Count];
            for (int i = 0; i < this.memberlist_team1.Items.Count; i++)
                team1_members[i] = this.memberlist_team1.Items[i].Text.ToString();
            for (int i = 0; i < this.memberlist_team2.Items.Count; i++)
                team2_members[i] = this.memberlist_team2.Items[i].Text.ToString();

            // prepare game page
            this.teamdisplay_team1.Text += team1_name;
            this.teamdisplay_team1.Location = new System.Drawing.Point((this.teamdisplay_team1.Parent.Width - this.teamdisplay_team1.Width) / 2, this.teamdisplay_team1.Location.Y);
            this.teamdisplay_team2.Text += team2_name;
            this.teamdisplay_team2.Location = new System.Drawing.Point((this.teamdisplay_team2.Parent.Width - this.teamdisplay_team2.Width) / 2, this.teamdisplay_team2.Location.Y);
            foreach (string member in team1_members)
                this.memberdisplay_team1.Items.Add(member);
            foreach (string member in team2_members)
                this.memberdisplay_team2.Items.Add(member);

            // add players to db
            Database.UpdateExistingPlayers(team1_members);
            Database.UpdateExistingPlayers(team2_members);

            // show game page
            this.page_pregame.Dispose();
            this.page_game.BringToFront();
            this.ActiveControl = this.memberdisplay_team1;
            this.page_pregame.Visible = true;
        }
        
        private void addmember_team1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            char[] chars = { ' ', '.', '!', '?', '1', '2', '3', '4', '5', ',' };
            if (this.addmember_team1.Text.Trim(chars) != "")
                this.memberlist_team1.Items.Add(this.addmember_team1.Text.Trim(chars).ToLower().Substring(0, 1).ToUpper() + this.addmember_team1.Text.Trim(chars).ToLower().Substring(1));
            this.addmember_team1.Text = "";
        }

        private void addmember_team2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            char[] chars = { ' ', '.', '!', '?', '1', '2', '3', '4', '5', ',' };
            if (this.addmember_team2.Text.Trim(chars) != "")
                this.memberlist_team2.Items.Add(this.addmember_team2.Text.Trim(chars).ToLower().Substring(0, 1).ToUpper() + this.addmember_team2.Text.Trim(chars).ToLower().Substring(1));
            this.addmember_team2.Text = "";
        }

        private void memberdisplay_team1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.memberdisplay_team1.SelectedItems.Clear();
            this.ActiveControl = this.page_game;
        }

        private void memberdisplay_team2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.memberdisplay_team2.SelectedItems.Clear();
            this.ActiveControl = this.page_game;
        }

        private void play_again_button_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            Environment.Exit(0);
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void show_scores_button_Click(object sender, EventArgs e)
        {
            // get all player data
            Dictionary<object, object> _db = await Database.RetrieveDatabase();
            Newtonsoft.Json.Linq.JArray _data = (Newtonsoft.Json.Linq.JArray)_db["data"];
            List<object> db = _data.ToObject<List<object>>();

            // prepare output box
            this.endgame_buttons.Location = new System.Drawing.Point(this.endgame_buttons.Location.X, this.endgame_buttons.Location.Y - 358);
            this.showscores_outputbox.Show();

            // sorted player scores
            List<Tuple<string, int>> players = new List<Tuple<string, int>>();

            for (int i = 0; i < db.Count; i++)
            {
                Newtonsoft.Json.Linq.JObject _player = (Newtonsoft.Json.Linq.JObject)db[i];
                Dictionary<string, object> player = _player.ToObject<Dictionary<string, object>>();
                
                int score = int.Parse((string)player["score"]);
                string name = (string)player["name"];

                players.Add(new Tuple<string, int>(name, score));
            }

            players.Sort((x, y) => x.Item1.CompareTo(x.Item1));
            players.Reverse();

            foreach (Tuple<string, int> player in players)
                this.showscores_outputbox.Items.Add($"{player.Item1}: {player.Item2}");
        }

        private void page_game_keypress_handler(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)49) // 1
                addpoint_team1_Click(null, null);
            else if (e.KeyChar == (char)50) // 2
                addpoint_team2_Click(null, null);
        }


        private void showscores_outputbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showscores_outputbox.ClearSelected();
            this.ActiveControl = this.page_endgame;
        }

        private void memberlist_team1_DoubleClick(object sender, EventArgs e)
        {
            // remove last element from the element
            this.memberlist_team1.Items.RemoveAt(this.memberlist_team1.Items.Count - 1);
        }

        private void memberlist_team2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // remove last element from the element
            this.memberlist_team2.Items.RemoveAt(this.memberlist_team2.Items.Count - 1);
        }

        private void memberdisplay_team1_KeyPress(object sender, KeyPressEventArgs e)
        {
            page_game_keypress_handler(e);
        }

        private void memberdisplay_team2_KeyPress(object sender, KeyPressEventArgs e)
        {
            page_game_keypress_handler(e);
        }

        private void addpoint_team1_KeyPress(object sender, KeyPressEventArgs e)
        {
            page_game_keypress_handler(e);
        }

        private void addpoint_team2_KeyPress(object sender, KeyPressEventArgs e)
        {
            page_game_keypress_handler(e);
        }

        private void addmember_team1_Leave(object sender, EventArgs e)
        {
            this.addmember_team1.Text = "";
        }

        private void addmember_team2_Leave(object sender, EventArgs e)
        {
            this.addmember_team2.Text = "";
        }
    }

    public class PlaySound
    {
        private static bool IsWindows { get; } = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows);
        private static SoundPlayer Sound { get; set; }

        public static async void Award()
        {
            if (!IsWindows) return;
            Sound = new SoundPlayer("award.wav");
            Sound.Play();
        }

        public static async void Win()
        {
            if (!IsWindows) return;
            Sound = new SoundPlayer("win.wav");
            Sound.Play();
        }
    }
}
