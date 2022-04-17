using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        bool hacks = false;
        public Form1()
        {
            InitializeComponent();
        }

        bool over = false;
        int PlayerSpeed = 3;
        int hs = 0;

        private void Gameover()
        {
            if (player.Bounds.IntersectsWith(enemy_1.Bounds) || player.Bounds.IntersectsWith(enemy_2.Bounds))
            {
                over = true;
                lbl_res.Visible = true;
                timer1.Enabled = false;
                lbl_game_over.Visible = true;
                lbl_speed.Text = "Speed: 0 MPH";
                lbl_note.Show();
            }
        }

        void Res()
        {
            over = false;
            lbl_res.Hide();
            lbl_game_over.Hide();
            timer1.Enabled = true;
            PlayerSpeed = 3;
            enemy_1.Top = -245;
            enemy_2.Top = -80;
            lbl_score.Text = "Score: 0";
            lbl_speed.Text = "Speed: 3 MPH";
            lbl_hs.Visible = true;
            lbl_note.Hide();
            hs = hs > score ? hs : score;
            score = 0;
            lbl_hs.Text = "High score: " + Convert.ToString(hs);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_game_over.Hide();
            lbl_res.Hide();
            lbl_hs.Hide();
            lbl_note.Hide();
            track_4.Hide();
        }

        private void track_line(int speed)
        {
            track_1.Top += speed;
            track_2.Top += speed;
            track_3.Top += speed;
            if (track_1.Top >= 550 && track_1.Top <= 650)
            {
                track_4.Visible = true;
                track_4.Top = track_1.Top - 650;
            }
            else if (track_1.Top > 650)
            {
                track_1.Top = track_4.Top + speed;
                track_4.Visible = false;
            }

            if (track_2.Top >= 550 && track_2.Top <= 650)
            {
                track_4.Visible = true;
                track_4.Top = track_2.Top - 650;
            }
            else if (track_2.Top > 650)
            {
                track_2.Top = track_4.Top + speed;
                track_4.Visible = false;
            }

            if (track_3.Top >= 550 && track_3.Top <= 650)
            {
                track_4.Visible = true;
                track_4.Top = track_3.Top - 650;
            }
            else if (track_3.Top > 650)
            {
                track_3.Top = track_4.Top + speed;
                track_4.Visible = false;
            }

            Random rnd = new Random();
            int x, y;
            if (enemy_1.Top >= 700)
            {
                x = rnd.Next(200, 300);
                enemy_1.Location = new Point(x, -50);
            }
            else if (enemy_1.Top <= -250)
            {
                x = rnd.Next(220, 300);
                enemy_1.Location = new Point(x, 500);
            }
            else
            {
                enemy_1.Top += speed - 5;
            }

            if (enemy_2.Top > 700)
            {
                y = rnd.Next(0, 150);
                enemy_2.Location = new Point(y, -50);
            }
            else if (enemy_2.Top <= -250)
            {
                y = rnd.Next(0, 150);
                enemy_2.Location = new Point(y, 500);
            }
            else
            {
                enemy_2.Top += speed - 5;
            }
        }

        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            track_line(PlayerSpeed);
            Gameover();
            if (hacks)
            {
                if (Math.Abs(player.Left - enemy_1.Left) < 50 && Math.Abs(player.Top - enemy_1.Top) < 300)
                    if (enemy_1.Left > 200 && enemy_1.Left < 250)
                        player.Left += 50 - (player.Left - enemy_1.Left);
                    else
                        player.Left -= 50 - (enemy_1.Left - player.Left);

                if (Math.Abs(player.Left - enemy_2.Left) < 50 && Math.Abs(player.Top - enemy_2.Top) < 300)
                    if (enemy_2.Left > 100 && enemy_2.Left < 150)
                        player.Left -= 50 - (enemy_2.Left - player.Left);
                    else
                        player.Left += 50 - player.Left + enemy_2.Left;
            }

            if (enemy_1.Top > 700)
            {
                score += 10;
                lbl_score.Text = "Score: " + score;
            }
            else if (enemy_2.Top > 700)
            {
                score += 10;
                lbl_score.Text = "Score: " + score;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!over)
            {
                if (e.KeyCode == Keys.Enter)
                    hacks = !hacks;

                if (e.KeyCode == Keys.B)
                {
                    if (PlayerSpeed > 5)
                    {
                        PlayerSpeed -= 5;
                    }
                    else
                    {
                        PlayerSpeed = 0;
                    }
                }
                else if (e.KeyCode == Keys.Left && !hacks)
                {
                    if (player.Left > 25)
                    {
                        player.Left += -35;
                    }
                }
                else if (e.KeyCode == Keys.Right && !hacks)
                {
                    if (player.Right < 290)
                    {
                        player.Left += 35;
                    }
                }

                else if (e.KeyCode == Keys.Up)
                {
                    if (PlayerSpeed < 30)
                    {
                        PlayerSpeed++;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (PlayerSpeed > 0)
                    {
                        PlayerSpeed--;
                    }
                }
                lbl_speed.Text = "Speed: " + PlayerSpeed + " MPH";
            }
            else if (e.KeyCode == Keys.Space)
                Res();

        }

        private void lbl_res_Click(object sender, EventArgs e)
        {
            Res();
        }
    }
}
