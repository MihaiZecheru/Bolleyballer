﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bolleyballer
{
    public partial class Bolleyballer : Form
    {
        public Bolleyballer()
        {
            InitializeComponent();
            __init_placeholder_text();
            this.ActiveControl = this.addmember_team1;
        }

        private void declare_winner(int team)
        {
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
            Database db = new Database();
            string command =
                "UPDATE wins " +
                "SET score = score + 1 " +
                "WHERE name IN (";

            for (int i = 0; i < team_members.Length; i++)
            {
                command += team_members[i];
                if (i != team_members.Length) command += ", ";
            }
            command += ");";
            db.Execute(command);

            this.page_endgame.Visible = true;
        }

        private void add_point(int team)
        {
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
            if (this.memberlist_team1.Items.Count == 0 || this.memberlist_team1.Items.Count == 0)
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
            Database db = new Database();
            foreach (string member in team1_members)
            {
                string command =
                "INSERT INTO wins (name, score) " +
                $"VALUES (\'{member}\', 0);";
                db.Execute(command);
            }
            foreach (string member in team2_members)
            {
                string command =
                "INSERT INTO wins (name, score) " +
                $"VALUES (\'{member}\', 0);";
                db.Execute(command);
            }

            // show game page
            this.page_pregame.Dispose();
            this.page_game.BringToFront();
            this.ActiveControl = this.score_team1;
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

        private void show_scores_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}