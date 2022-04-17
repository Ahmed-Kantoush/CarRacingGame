namespace CarRacingGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.track_3 = new System.Windows.Forms.PictureBox();
            this.track_2 = new System.Windows.Forms.PictureBox();
            this.track_1 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_game_over = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_res = new System.Windows.Forms.Label();
            this.lbl_hs = new System.Windows.Forms.Label();
            this.track_4 = new System.Windows.Forms.PictureBox();
            this.lbl_note = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::CarRacingGame.Properties.Resources.upside_down_car_clipart_winging_99626;
            this.player.Location = new System.Drawing.Point(206, 479);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 80);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.Color.Transparent;
            this.enemy_2.Image = global::CarRacingGame.Properties.Resources.car_2030056_1280;
            this.enemy_2.Location = new System.Drawing.Point(64, 275);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(50, 80);
            this.enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_2.TabIndex = 4;
            this.enemy_2.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.Transparent;
            this.enemy_1.Image = global::CarRacingGame.Properties.Resources.car_2030056_1280;
            this.enemy_1.Location = new System.Drawing.Point(327, 110);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(50, 80);
            this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy_1.TabIndex = 3;
            this.enemy_1.TabStop = false;
            // 
            // track_3
            // 
            this.track_3.BackColor = System.Drawing.Color.White;
            this.track_3.Location = new System.Drawing.Point(225, 550);
            this.track_3.Name = "track_3";
            this.track_3.Size = new System.Drawing.Size(20, 100);
            this.track_3.TabIndex = 2;
            this.track_3.TabStop = false;
            // 
            // track_2
            // 
            this.track_2.BackColor = System.Drawing.Color.White;
            this.track_2.Location = new System.Drawing.Point(225, 275);
            this.track_2.Name = "track_2";
            this.track_2.Size = new System.Drawing.Size(20, 100);
            this.track_2.TabIndex = 1;
            this.track_2.TabStop = false;
            // 
            // track_1
            // 
            this.track_1.BackColor = System.Drawing.Color.White;
            this.track_1.Location = new System.Drawing.Point(225, 0);
            this.track_1.Name = "track_1";
            this.track_1.Size = new System.Drawing.Size(20, 100);
            this.track_1.TabIndex = 0;
            this.track_1.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Pink;
            this.lbl_score.Location = new System.Drawing.Point(12, 19);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(86, 25);
            this.lbl_score.TabIndex = 6;
            this.lbl_score.Text = "Score: 0";
            // 
            // lbl_game_over
            // 
            this.lbl_game_over.AutoSize = true;
            this.lbl_game_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_game_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game_over.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_game_over.Location = new System.Drawing.Point(292, 53);
            this.lbl_game_over.Name = "lbl_game_over";
            this.lbl_game_over.Size = new System.Drawing.Size(108, 25);
            this.lbl_game_over.TabIndex = 7;
            this.lbl_game_over.Text = "Game over";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_speed.Location = new System.Drawing.Point(277, 19);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(141, 25);
            this.lbl_speed.TabIndex = 8;
            this.lbl_speed.Text = "Speed: 3 MPH";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.BackColor = System.Drawing.Color.Transparent;
            this.lbl_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.ForeColor = System.Drawing.Color.Red;
            this.lbl_res.Location = new System.Drawing.Point(43, 588);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(323, 25);
            this.lbl_res.TabIndex = 9;
            this.lbl_res.Text = "Press \'space\' for restart or click here";
            this.lbl_res.Click += new System.EventHandler(this.lbl_res_Click);
            // 
            // lbl_hs
            // 
            this.lbl_hs.AutoSize = true;
            this.lbl_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hs.ForeColor = System.Drawing.Color.White;
            this.lbl_hs.Location = new System.Drawing.Point(12, 53);
            this.lbl_hs.Name = "lbl_hs";
            this.lbl_hs.Size = new System.Drawing.Size(0, 25);
            this.lbl_hs.TabIndex = 10;
            // 
            // track_4
            // 
            this.track_4.BackColor = System.Drawing.Color.White;
            this.track_4.Location = new System.Drawing.Point(225, 138);
            this.track_4.Name = "track_4";
            this.track_4.Size = new System.Drawing.Size(20, 100);
            this.track_4.TabIndex = 11;
            this.track_4.TabStop = false;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.White;
            this.lbl_note.Location = new System.Drawing.Point(89, 619);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(238, 25);
            this.lbl_note.TabIndex = 12;
            this.lbl_note.Text = "You can use \'B\' for brakes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(432, 653);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.track_4);
            this.Controls.Add(this.lbl_hs);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_game_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.track_3);
            this.Controls.Add(this.track_2);
            this.Controls.Add(this.track_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox track_1;
        private System.Windows.Forms.PictureBox track_2;
        private System.Windows.Forms.PictureBox track_3;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_game_over;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Label lbl_hs;
        private System.Windows.Forms.PictureBox track_4;
        private System.Windows.Forms.Label lbl_note;
    }
}

