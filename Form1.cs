using System.IO;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player.uiMode = "none";
            track_volume.Value = 50;
            volume_label.Text = "50%";
            //ReplaceProgressBar();
        }

        string[] paths, files;

        private void btn_open_Click(object sender, EventArgs e)
        {
            track_list.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                files = dialog.FileNames;
                paths = dialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    track_list.Items.Add(files[i]);
                }
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                cover_picbox.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {
                cover_picbox.ImageLocation = "C:\\Users\\domie\\OneDrive\\Képek\\Saved Pictures\\misc\\Luki_Menta.jpg";
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex += 1;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex -= 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
                //p_bar.Invalidate();
                try
                {
                    track_start.Text = player.Ctlcontrols.currentPositionString;
                    track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }

                if ((int)player.Ctlcontrols.currentPosition == (int)player.Ctlcontrols.currentItem.duration)
                {
                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex += 1;
                    }
                }
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            volume_label.Text = track_volume.Value.ToString() + "%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void player_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
