namespace Bolleyballer
{
    partial class Bolleyballer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bolleyballer));
            this.page_game = new System.Windows.Forms.Panel();
            this.box_team2 = new System.Windows.Forms.GroupBox();
            this.score_team2 = new System.Windows.Forms.Label();
            this.addpoint_team2 = new System.Windows.Forms.Button();
            this.memberdisplay_team2 = new System.Windows.Forms.ListView();
            this.member_label2 = new System.Windows.Forms.Label();
            this.teamdisplay_team2 = new System.Windows.Forms.Label();
            this.box_team1 = new System.Windows.Forms.GroupBox();
            this.score_team1 = new System.Windows.Forms.Label();
            this.addpoint_team1 = new System.Windows.Forms.Button();
            this.memberdisplay_team1 = new System.Windows.Forms.ListView();
            this.member_label1 = new System.Windows.Forms.Label();
            this.teamdisplay_team1 = new System.Windows.Forms.Label();
            this.page_pregame = new System.Windows.Forms.Panel();
            this.pregame_container = new System.Windows.Forms.GroupBox();
            this.startgame_button = new System.Windows.Forms.Button();
            this.addmember_team2 = new System.Windows.Forms.TextBox();
            this.addmember_team1 = new System.Windows.Forms.TextBox();
            this.memberlist_team2 = new System.Windows.Forms.ListView();
            this.memberlist_team1 = new System.Windows.Forms.ListView();
            this.lbl_pregame = new System.Windows.Forms.Label();
            this.page_endgame = new System.Windows.Forms.Panel();
            this.showscores_outputbox = new System.Windows.Forms.ListBox();
            this.endgame_buttons = new System.Windows.Forms.GroupBox();
            this.show_scores_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.play_again_button = new System.Windows.Forms.Button();
            this.winning_team_display = new System.Windows.Forms.Label();
            this.page_game.SuspendLayout();
            this.box_team2.SuspendLayout();
            this.box_team1.SuspendLayout();
            this.page_pregame.SuspendLayout();
            this.pregame_container.SuspendLayout();
            this.page_endgame.SuspendLayout();
            this.endgame_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // page_game
            // 
            this.page_game.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.page_game.Controls.Add(this.box_team2);
            this.page_game.Controls.Add(this.box_team1);
            this.page_game.Location = new System.Drawing.Point(0, 0);
            this.page_game.Name = "page_game";
            this.page_game.Size = new System.Drawing.Size(1910, 965);
            this.page_game.TabIndex = 0;
            // 
            // box_team2
            // 
            this.box_team2.Controls.Add(this.score_team2);
            this.box_team2.Controls.Add(this.addpoint_team2);
            this.box_team2.Controls.Add(this.memberdisplay_team2);
            this.box_team2.Controls.Add(this.member_label2);
            this.box_team2.Controls.Add(this.teamdisplay_team2);
            this.box_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.box_team2.Location = new System.Drawing.Point(1050, 72);
            this.box_team2.Name = "box_team2";
            this.box_team2.Size = new System.Drawing.Size(764, 875);
            this.box_team2.TabIndex = 1;
            this.box_team2.TabStop = false;
            // 
            // score_team2
            // 
            this.score_team2.AutoSize = true;
            this.score_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.score_team2.Location = new System.Drawing.Point(230, 504);
            this.score_team2.Name = "score_team2";
            this.score_team2.Size = new System.Drawing.Size(364, 98);
            this.score_team2.TabIndex = 5;
            this.score_team2.Text = "Score: 0";
            // 
            // addpoint_team2
            // 
            this.addpoint_team2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addpoint_team2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpoint_team2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addpoint_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.addpoint_team2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addpoint_team2.Location = new System.Drawing.Point(45, 671);
            this.addpoint_team2.Name = "addpoint_team2";
            this.addpoint_team2.Size = new System.Drawing.Size(683, 176);
            this.addpoint_team2.TabIndex = 4;
            this.addpoint_team2.Text = "Add Point";
            this.addpoint_team2.UseVisualStyleBackColor = false;
            this.addpoint_team2.Click += new System.EventHandler(this.addpoint_team2_Click);
            this.addpoint_team2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addpoint_team2_KeyPress);
            // 
            // memberdisplay_team2
            // 
            this.memberdisplay_team2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memberdisplay_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberdisplay_team2.HideSelection = false;
            this.memberdisplay_team2.Location = new System.Drawing.Point(45, 222);
            this.memberdisplay_team2.Name = "memberdisplay_team2";
            this.memberdisplay_team2.Size = new System.Drawing.Size(683, 213);
            this.memberdisplay_team2.TabIndex = 3;
            this.memberdisplay_team2.UseCompatibleStateImageBehavior = false;
            this.memberdisplay_team2.View = System.Windows.Forms.View.List;
            this.memberdisplay_team2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.memberdisplay_team2_ItemSelectionChanged);
            this.memberdisplay_team2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memberdisplay_team2_KeyPress);
            // 
            // member_label2
            // 
            this.member_label2.AutoSize = true;
            this.member_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.member_label2.Location = new System.Drawing.Point(38, 169);
            this.member_label2.Name = "member_label2";
            this.member_label2.Size = new System.Drawing.Size(167, 39);
            this.member_label2.TabIndex = 2;
            this.member_label2.Text = "Members:";
            // 
            // teamdisplay_team2
            // 
            this.teamdisplay_team2.AutoSize = true;
            this.teamdisplay_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.teamdisplay_team2.Location = new System.Drawing.Point(282, 71);
            this.teamdisplay_team2.Name = "teamdisplay_team2";
            this.teamdisplay_team2.Size = new System.Drawing.Size(199, 69);
            this.teamdisplay_team2.TabIndex = 1;
            this.teamdisplay_team2.Text = "Team ";
            // 
            // box_team1
            // 
            this.box_team1.Controls.Add(this.score_team1);
            this.box_team1.Controls.Add(this.addpoint_team1);
            this.box_team1.Controls.Add(this.memberdisplay_team1);
            this.box_team1.Controls.Add(this.member_label1);
            this.box_team1.Controls.Add(this.teamdisplay_team1);
            this.box_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.box_team1.Location = new System.Drawing.Point(103, 72);
            this.box_team1.Name = "box_team1";
            this.box_team1.Size = new System.Drawing.Size(764, 875);
            this.box_team1.TabIndex = 0;
            this.box_team1.TabStop = false;
            // 
            // score_team1
            // 
            this.score_team1.AutoSize = true;
            this.score_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.score_team1.Location = new System.Drawing.Point(222, 504);
            this.score_team1.Name = "score_team1";
            this.score_team1.Size = new System.Drawing.Size(364, 98);
            this.score_team1.TabIndex = 4;
            this.score_team1.Text = "Score: 0";
            // 
            // addpoint_team1
            // 
            this.addpoint_team1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addpoint_team1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpoint_team1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addpoint_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.addpoint_team1.Location = new System.Drawing.Point(45, 671);
            this.addpoint_team1.Name = "addpoint_team1";
            this.addpoint_team1.Size = new System.Drawing.Size(683, 176);
            this.addpoint_team1.TabIndex = 3;
            this.addpoint_team1.TabStop = false;
            this.addpoint_team1.Text = "Add Point";
            this.addpoint_team1.UseVisualStyleBackColor = false;
            this.addpoint_team1.Click += new System.EventHandler(this.addpoint_team1_Click);
            this.addpoint_team1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addpoint_team1_KeyPress);
            // 
            // memberdisplay_team1
            // 
            this.memberdisplay_team1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memberdisplay_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberdisplay_team1.HideSelection = false;
            this.memberdisplay_team1.Location = new System.Drawing.Point(45, 222);
            this.memberdisplay_team1.Name = "memberdisplay_team1";
            this.memberdisplay_team1.Size = new System.Drawing.Size(683, 213);
            this.memberdisplay_team1.TabIndex = 2;
            this.memberdisplay_team1.TabStop = false;
            this.memberdisplay_team1.UseCompatibleStateImageBehavior = false;
            this.memberdisplay_team1.View = System.Windows.Forms.View.List;
            this.memberdisplay_team1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.memberdisplay_team1_ItemSelectionChanged);
            this.memberdisplay_team1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memberdisplay_team1_KeyPress);
            // 
            // member_label1
            // 
            this.member_label1.AutoSize = true;
            this.member_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.member_label1.Location = new System.Drawing.Point(38, 169);
            this.member_label1.Name = "member_label1";
            this.member_label1.Size = new System.Drawing.Size(167, 39);
            this.member_label1.TabIndex = 1;
            this.member_label1.Text = "Members:";
            // 
            // teamdisplay_team1
            // 
            this.teamdisplay_team1.AutoSize = true;
            this.teamdisplay_team1.Location = new System.Drawing.Point(282, 71);
            this.teamdisplay_team1.Name = "teamdisplay_team1";
            this.teamdisplay_team1.Size = new System.Drawing.Size(199, 69);
            this.teamdisplay_team1.TabIndex = 0;
            this.teamdisplay_team1.Text = "Team ";
            // 
            // page_pregame
            // 
            this.page_pregame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.page_pregame.Controls.Add(this.pregame_container);
            this.page_pregame.Controls.Add(this.lbl_pregame);
            this.page_pregame.Location = new System.Drawing.Point(0, 0);
            this.page_pregame.Name = "page_pregame";
            this.page_pregame.Size = new System.Drawing.Size(1880, 1041);
            this.page_pregame.TabIndex = 5;
            // 
            // pregame_container
            // 
            this.pregame_container.Controls.Add(this.startgame_button);
            this.pregame_container.Controls.Add(this.addmember_team2);
            this.pregame_container.Controls.Add(this.addmember_team1);
            this.pregame_container.Controls.Add(this.memberlist_team2);
            this.pregame_container.Controls.Add(this.memberlist_team1);
            this.pregame_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.pregame_container.Location = new System.Drawing.Point(464, 215);
            this.pregame_container.Name = "pregame_container";
            this.pregame_container.Size = new System.Drawing.Size(992, 510);
            this.pregame_container.TabIndex = 100;
            this.pregame_container.TabStop = false;
            // 
            // startgame_button
            // 
            this.startgame_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startgame_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startgame_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.startgame_button.Location = new System.Drawing.Point(40, 400);
            this.startgame_button.Name = "startgame_button";
            this.startgame_button.Size = new System.Drawing.Size(919, 81);
            this.startgame_button.TabIndex = 3;
            this.startgame_button.Text = "Start Game";
            this.startgame_button.UseVisualStyleBackColor = false;
            this.startgame_button.Click += new System.EventHandler(this.startgame_button_Click);
            // 
            // addmember_team2
            // 
            this.addmember_team2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addmember_team2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addmember_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addmember_team2.Location = new System.Drawing.Point(555, 312);
            this.addmember_team2.MaxLength = 3000;
            this.addmember_team2.Name = "addmember_team2";
            this.addmember_team2.Size = new System.Drawing.Size(404, 38);
            this.addmember_team2.TabIndex = 2;
            this.addmember_team2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addmember_team2_KeyDown);
            this.addmember_team2.Leave += new System.EventHandler(this.addmember_team2_Leave);
            // 
            // addmember_team1
            // 
            this.addmember_team1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addmember_team1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addmember_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addmember_team1.Location = new System.Drawing.Point(40, 312);
            this.addmember_team1.MaxLength = 3000;
            this.addmember_team1.Name = "addmember_team1";
            this.addmember_team1.Size = new System.Drawing.Size(404, 38);
            this.addmember_team1.TabIndex = 1;
            this.addmember_team1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addmember_team1_KeyDown);
            this.addmember_team1.Leave += new System.EventHandler(this.addmember_team1_Leave);
            // 
            // memberlist_team2
            // 
            this.memberlist_team2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memberlist_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.memberlist_team2.HideSelection = false;
            this.memberlist_team2.LabelWrap = false;
            this.memberlist_team2.Location = new System.Drawing.Point(555, 84);
            this.memberlist_team2.Name = "memberlist_team2";
            this.memberlist_team2.Size = new System.Drawing.Size(404, 208);
            this.memberlist_team2.TabIndex = 100;
            this.memberlist_team2.TabStop = false;
            this.memberlist_team2.UseCompatibleStateImageBehavior = false;
            this.memberlist_team2.View = System.Windows.Forms.View.List;
            this.memberlist_team2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.memberlist_team2_MouseDoubleClick);
            // 
            // memberlist_team1
            // 
            this.memberlist_team1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.memberlist_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.memberlist_team1.HideSelection = false;
            this.memberlist_team1.LabelWrap = false;
            this.memberlist_team1.Location = new System.Drawing.Point(40, 79);
            this.memberlist_team1.Name = "memberlist_team1";
            this.memberlist_team1.Size = new System.Drawing.Size(404, 208);
            this.memberlist_team1.TabIndex = 100;
            this.memberlist_team1.TabStop = false;
            this.memberlist_team1.UseCompatibleStateImageBehavior = false;
            this.memberlist_team1.View = System.Windows.Forms.View.List;
            this.memberlist_team1.DoubleClick += new System.EventHandler(this.memberlist_team1_DoubleClick);
            // 
            // lbl_pregame
            // 
            this.lbl_pregame.AutoSize = true;
            this.lbl_pregame.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.lbl_pregame.Location = new System.Drawing.Point(699, 101);
            this.lbl_pregame.Name = "lbl_pregame";
            this.lbl_pregame.Size = new System.Drawing.Size(609, 91);
            this.lbl_pregame.TabIndex = 0;
            this.lbl_pregame.Text = "Pre-game Menu";
            // 
            // page_endgame
            // 
            this.page_endgame.Controls.Add(this.page_pregame);
            this.page_endgame.Controls.Add(this.showscores_outputbox);
            this.page_endgame.Controls.Add(this.endgame_buttons);
            this.page_endgame.Controls.Add(this.page_game);
            this.page_endgame.Controls.Add(this.winning_team_display);
            this.page_endgame.Location = new System.Drawing.Point(0, 0);
            this.page_endgame.Name = "page_endgame";
            this.page_endgame.Size = new System.Drawing.Size(1920, 1136);
            this.page_endgame.TabIndex = 101;
            // 
            // showscores_outputbox
            // 
            this.showscores_outputbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.showscores_outputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.showscores_outputbox.FormattingEnabled = true;
            this.showscores_outputbox.ItemHeight = 25;
            this.showscores_outputbox.Location = new System.Drawing.Point(475, 376);
            this.showscores_outputbox.Name = "showscores_outputbox";
            this.showscores_outputbox.Size = new System.Drawing.Size(969, 304);
            this.showscores_outputbox.TabIndex = 2;
            this.showscores_outputbox.SelectedIndexChanged += new System.EventHandler(this.showscores_outputbox_SelectedIndexChanged);
            // 
            // endgame_buttons
            // 
            this.endgame_buttons.Controls.Add(this.show_scores_button);
            this.endgame_buttons.Controls.Add(this.quit_button);
            this.endgame_buttons.Controls.Add(this.play_again_button);
            this.endgame_buttons.Location = new System.Drawing.Point(475, 381);
            this.endgame_buttons.Name = "endgame_buttons";
            this.endgame_buttons.Size = new System.Drawing.Size(969, 315);
            this.endgame_buttons.TabIndex = 1;
            this.endgame_buttons.TabStop = false;
            // 
            // show_scores_button
            // 
            this.show_scores_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.show_scores_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_scores_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_scores_button.Location = new System.Drawing.Point(355, 32);
            this.show_scores_button.Name = "show_scores_button";
            this.show_scores_button.Size = new System.Drawing.Size(262, 250);
            this.show_scores_button.TabIndex = 2;
            this.show_scores_button.Text = "Show Scores";
            this.show_scores_button.UseVisualStyleBackColor = false;
            this.show_scores_button.Click += new System.EventHandler(this.show_scores_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button.Location = new System.Drawing.Point(681, 32);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(262, 250);
            this.quit_button.TabIndex = 3;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // play_again_button
            // 
            this.play_again_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.play_again_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_again_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again_button.Location = new System.Drawing.Point(32, 32);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(262, 250);
            this.play_again_button.TabIndex = 1;
            this.play_again_button.Text = "Play Again";
            this.play_again_button.UseVisualStyleBackColor = false;
            this.play_again_button.Click += new System.EventHandler(this.play_again_button_Click);
            // 
            // winning_team_display
            // 
            this.winning_team_display.AutoSize = true;
            this.winning_team_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.winning_team_display.Location = new System.Drawing.Point(808, 158);
            this.winning_team_display.Name = "winning_team_display";
            this.winning_team_display.Size = new System.Drawing.Size(0, 113);
            this.winning_team_display.TabIndex = 0;
            // 
            // Bolleyballer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.page_endgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bolleyballer";
            this.Text = "Bolleyballer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.page_game.ResumeLayout(false);
            this.box_team2.ResumeLayout(false);
            this.box_team2.PerformLayout();
            this.box_team1.ResumeLayout(false);
            this.box_team1.PerformLayout();
            this.page_pregame.ResumeLayout(false);
            this.page_pregame.PerformLayout();
            this.pregame_container.ResumeLayout(false);
            this.pregame_container.PerformLayout();
            this.page_endgame.ResumeLayout(false);
            this.page_endgame.PerformLayout();
            this.endgame_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel page_game;
        private System.Windows.Forms.GroupBox box_team1;
        private System.Windows.Forms.GroupBox box_team2;
        private System.Windows.Forms.Label teamdisplay_team1;
        private System.Windows.Forms.Label teamdisplay_team2;
        private System.Windows.Forms.Label member_label1;
        private System.Windows.Forms.Label member_label2;
        private System.Windows.Forms.ListView memberdisplay_team1;
        private System.Windows.Forms.ListView memberdisplay_team2;
        private System.Windows.Forms.Button addpoint_team1;
        private System.Windows.Forms.Button addpoint_team2;
        private System.Windows.Forms.Label score_team1;
        private System.Windows.Forms.Label score_team2;
        private System.Windows.Forms.Panel page_pregame;
        private System.Windows.Forms.Label lbl_pregame;
        private System.Windows.Forms.GroupBox pregame_container;
        private System.Windows.Forms.Button startgame_button;
        private System.Windows.Forms.ListView memberlist_team1;
        private System.Windows.Forms.ListView memberlist_team2;
        private System.Windows.Forms.TextBox addmember_team1;
        private System.Windows.Forms.TextBox addmember_team2;
        private System.Windows.Forms.Panel page_endgame;
        private System.Windows.Forms.Label winning_team_display;
        private System.Windows.Forms.GroupBox endgame_buttons;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button play_again_button;
        private System.Windows.Forms.Button show_scores_button;
        private System.Windows.Forms.ListBox showscores_outputbox;
    }
}

