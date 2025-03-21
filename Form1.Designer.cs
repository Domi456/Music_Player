namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_preview = new Button();
            btn_next = new Button();
            btn_play = new Button();
            btn_pause = new Button();
            btn_stop = new Button();
            btn_open = new Button();
            p_bar = new ProgressBar();
            track_list = new ListBox();
            cover_picbox = new PictureBox();
            player = new AxWMPLib.AxWindowsMediaPlayer();
            track_volume = new TrackBar();
            lebel_vol = new Label();
            volume_label = new Label();
            track_start = new Label();
            track_end = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)cover_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_volume).BeginInit();
            SuspendLayout();
            // 
            // btn_preview
            // 
            btn_preview.FlatStyle = FlatStyle.Flat;
            btn_preview.Font = new Font("Old English Text MT", 14.25F);
            btn_preview.ForeColor = Color.FromArgb(255, 128, 0);
            btn_preview.Location = new Point(12, 383);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(111, 35);
            btn_preview.TabIndex = 0;
            btn_preview.Text = "Previous";
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Click += btn_preview_Click;
            // 
            // btn_next
            // 
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Old English Text MT", 14.25F);
            btn_next.ForeColor = Color.FromArgb(255, 128, 0);
            btn_next.Location = new Point(129, 383);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(118, 35);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_play
            // 
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.Font = new Font("Old English Text MT", 14.25F);
            btn_play.ForeColor = Color.FromArgb(255, 128, 0);
            btn_play.Location = new Point(253, 383);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(136, 35);
            btn_play.TabIndex = 2;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click;
            // 
            // btn_pause
            // 
            btn_pause.FlatStyle = FlatStyle.Flat;
            btn_pause.Font = new Font("Old English Text MT", 14.25F);
            btn_pause.ForeColor = Color.FromArgb(255, 128, 0);
            btn_pause.Location = new Point(395, 383);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(136, 35);
            btn_pause.TabIndex = 3;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_stop
            // 
            btn_stop.FlatStyle = FlatStyle.Flat;
            btn_stop.Font = new Font("Old English Text MT", 14.25F);
            btn_stop.ForeColor = Color.FromArgb(255, 128, 0);
            btn_stop.Location = new Point(537, 383);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(130, 35);
            btn_stop.TabIndex = 4;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_open
            // 
            btn_open.BackColor = Color.Black;
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.Font = new Font("Old English Text MT", 14.25F);
            btn_open.ForeColor = Color.FromArgb(255, 128, 0);
            btn_open.Location = new Point(673, 383);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(136, 35);
            btn_open.TabIndex = 5;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = false;
            btn_open.Click += btn_open_Click;
            // 
            // p_bar
            // 
            p_bar.BackColor = SystemColors.ActiveCaptionText;
            p_bar.ForeColor = Color.FromArgb(255, 128, 0);
            p_bar.Location = new Point(12, 348);
            p_bar.Name = "p_bar";
            p_bar.Size = new Size(797, 19);
            p_bar.Style = ProgressBarStyle.Continuous;
            p_bar.TabIndex = 6;
            p_bar.MouseDown += p_bar_MouseDown;
            // 
            // track_list
            // 
            track_list.BackColor = SystemColors.InfoText;
            track_list.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            track_list.ForeColor = Color.FromArgb(255, 128, 0);
            track_list.FormattingEnabled = true;
            track_list.ItemHeight = 15;
            track_list.Location = new Point(262, 85);
            track_list.Name = "track_list";
            track_list.Size = new Size(496, 244);
            track_list.TabIndex = 7;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // cover_picbox
            // 
            cover_picbox.Image = (Image)resources.GetObject("cover_picbox.Image");
            cover_picbox.Location = new Point(12, 85);
            cover_picbox.Name = "cover_picbox";
            cover_picbox.Size = new Size(244, 244);
            cover_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            cover_picbox.TabIndex = 8;
            cover_picbox.TabStop = false;
            // 
            // player
            // 
            player.Dock = DockStyle.Top;
            player.Enabled = true;
            player.Location = new Point(0, 0);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(821, 68);
            player.TabIndex = 9;
            player.Enter += player_Enter;
            // 
            // track_volume
            // 
            track_volume.Location = new Point(764, 108);
            track_volume.Maximum = 100;
            track_volume.Name = "track_volume";
            track_volume.Orientation = Orientation.Vertical;
            track_volume.Size = new Size(45, 203);
            track_volume.TabIndex = 10;
            track_volume.TickStyle = TickStyle.TopLeft;
            track_volume.Scroll += track_volume_Scroll;
            // 
            // lebel_vol
            // 
            lebel_vol.AutoSize = true;
            lebel_vol.BackColor = SystemColors.ActiveCaptionText;
            lebel_vol.Font = new Font("Old English Text MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lebel_vol.ForeColor = Color.FromArgb(255, 128, 0);
            lebel_vol.Location = new Point(764, 314);
            lebel_vol.Name = "lebel_vol";
            lebel_vol.Size = new Size(51, 19);
            lebel_vol.TabIndex = 11;
            lebel_vol.Text = "Volume";
            // 
            // volume_label
            // 
            volume_label.AutoSize = true;
            volume_label.BackColor = SystemColors.ActiveCaptionText;
            volume_label.Font = new Font("Old English Text MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volume_label.ForeColor = Color.FromArgb(255, 128, 0);
            volume_label.Location = new Point(764, 85);
            volume_label.Name = "volume_label";
            volume_label.Size = new Size(49, 20);
            volume_label.TabIndex = 12;
            volume_label.Text = "100%";
            // 
            // track_start
            // 
            track_start.AutoSize = true;
            track_start.Font = new Font("Old English Text MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track_start.ForeColor = Color.FromArgb(255, 128, 0);
            track_start.Location = new Point(12, 23);
            track_start.Name = "track_start";
            track_start.Size = new Size(90, 38);
            track_start.TabIndex = 13;
            track_start.Text = "00:00";
            // 
            // track_end
            // 
            track_end.AutoSize = true;
            track_end.Font = new Font("Old English Text MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track_end.ForeColor = Color.FromArgb(255, 128, 0);
            track_end.Location = new Point(719, 23);
            track_end.Name = "track_end";
            track_end.Size = new Size(90, 38);
            track_end.TabIndex = 14;
            track_end.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(821, 430);
            Controls.Add(track_end);
            Controls.Add(track_start);
            Controls.Add(volume_label);
            Controls.Add(lebel_vol);
            Controls.Add(track_volume);
            Controls.Add(player);
            Controls.Add(cover_picbox);
            Controls.Add(track_list);
            Controls.Add(p_bar);
            Controls.Add(btn_open);
            Controls.Add(btn_stop);
            Controls.Add(btn_pause);
            Controls.Add(btn_play);
            Controls.Add(btn_next);
            Controls.Add(btn_preview);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Domo player v1";
            ((System.ComponentModel.ISupportInitialize)cover_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_volume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_preview;
        private Button btn_next;
        private Button btn_play;
        private Button btn_pause;
        private Button btn_stop;
        private Button btn_open;
        private ProgressBar p_bar;
        private ListBox track_list;
        private PictureBox cover_picbox;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private TrackBar track_volume;
        private Label lebel_vol;
        private Label volume_label;
        private Label track_start;
        private Label track_end;
        private System.Windows.Forms.Timer timer1;
    }
}
