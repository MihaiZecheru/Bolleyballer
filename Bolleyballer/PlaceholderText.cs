using System;

namespace Bolleyballer
{
    partial class Bolleyballer
    {
        private void __init_placeholder_text()
        {
            this.addmember_team1.Text = "Add member";
            this.addmember_team1.GotFocus += new EventHandler(RemoveText1);
            this.addmember_team1.LostFocus += new EventHandler(AddText1);

            this.addmember_team2.Text = "Add member";
            this.addmember_team2.GotFocus += new EventHandler(RemoveText2);
            this.addmember_team2.LostFocus += new EventHandler(AddText2);
        }

        private void RemoveText1(object sender, EventArgs e)
        {
            if (this.addmember_team1.Text == "Add member")
                this.addmember_team1.Text = "";
        }

        private void AddText1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.addmember_team1.Text))
                this.addmember_team1.Text = "Add member";
        }

        private void RemoveText2(object sender, EventArgs e)
        {
            if (this.addmember_team2.Text == "Add member")
                this.addmember_team2.Text = "";
        }

        private void AddText2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.addmember_team2.Text))
                this.addmember_team2.Text = "Add member";
        }
    }
}
