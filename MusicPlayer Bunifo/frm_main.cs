using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer_Bunifo
{
    public partial class frm_main : Form
    {
        string Author = "";
        int minute = 0;
        int secound = 0;
        bool StatePlaying = false;
        List<string> files = new List<string>();
        List<string> paths = new List<string>();
        public frm_main()
        {
            InitializeComponent();
            timer_track_music.Stop();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_state_Click(object sender, EventArgs e)
        {
            tab_pages_app.SetPage(0);
        }

        private void btn_explore_Click(object sender, EventArgs e)
        {
            tab_pages_app.SetPage(1);
        }

        private void btn_albums_Click(object sender, EventArgs e)
        {
            tab_pages_app.SetPage(2);
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            tab_pages_app.SetPage(3);
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofd_import.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgv_musics.Rows.Clear();
                files.AddRange(ofd_import.SafeFileNames);
                paths.AddRange(ofd_import.FileNames);
                for (int i = 0; i < files.Count; i++)
                {
                    var index = this.dgv_musics.Rows.Add();
                    this.dgv_musics.Rows[index].Cells[0].Value = files[i];
                    FileInfo fi = new FileInfo(paths[i]);
                    this.dgv_musics.Rows[index].Cells[3].Value = GetLength(paths[i]);
                    this.dgv_musics.Rows[index].Cells[2].Value = GetAuthor(paths[i]);
                }
            }

        }
        private string GetLength(string url)
        {
            var tfile = TagLib.File.Create(url);
            TimeSpan duration = tfile.Properties.Duration;
            string minute_tt = Convert.ToString(duration.Minutes);
            string secound_tt = Convert.ToString(duration.Seconds);
            //int a = Convert.ToInt32(minute_tt) * 60;
            string Total_time = minute_tt.PadLeft(2, '0') + ":" + secound_tt.PadLeft(2, '0');
            return Total_time;
        }
        private void SetMaximum(string url)
        {
            var tfile = TagLib.File.Create(url);
            TimeSpan duration = tfile.Properties.Duration;
            string minute_tt = Convert.ToString(duration.Minutes);
            string secound_tt = Convert.ToString(duration.Seconds);
            int a = Convert.ToInt32(minute_tt) * 60;
            hs_trak_music.Maximum  = a + Convert.ToInt32(secound_tt);

        }
        private string GetAuthor(string url)
        {
            var tfile = TagLib.File.Create(url);
            if (tfile.Tag.FirstAlbumArtist != null)
                return tfile.Tag.FirstAlbumArtist;
            else
                return "None";
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            //
        }

        private void dgv_musics_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                wmp_player.URL = paths[index];
                Author = GetAuthor(wmp_player.URL);
                wmp_player.Ctlcontrols.play();
                StatePlaying = true;
                lbl_author.Text = Author;
                SetMaximum(wmp_player.URL);
                tab_pages_app.SetPage(0);
                pb_music.Image =  GetImageFile(wmp_player.URL);

            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return;
            }
        }

        public Bitmap GetImageFile(string url)
        {
            var mStream = new MemoryStream();
            TagLib.File file = TagLib.File.Create(url);
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                pb_music.Image = Properties.Resources.EmptyImage;
                return null;
            }
        }

        private void hs_sound_volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            wmp_player.settings.volume = hs_sound_volume.Value;
        }

        private void wmp_player_StatusChange(object sender, EventArgs e)
        {
            lbl_title.Text = wmp_player.status.ToString();
            lbl_name_song.Text = GetName(wmp_player.URL);
            if (wmp_player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                StatePlaying = true;
                timer_track_music.Start();
                btn_state.Text = "Playing...";
            }
            else if (wmp_player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                StatePlaying = false;
                timer_track_music.Stop();
                btn_state.Text = "Pause...";
            }
            else
            {
                btn_state.Text = "Stopped...";
            }
        }
        private string GetName(string url)
        {
            return Path.GetFileName(url);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (StatePlaying)
            {
                wmp_player.Ctlcontrols.currentPosition = hs_trak_music.Value;
                StatePlaying = false;
                wmp_player.Ctlcontrols.pause();
            }
            else
            {
                wmp_player.Ctlcontrols.play();
            }
        }

        private void timer_track_music_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = wmp_player.Ctlcontrols.currentPositionString;
            hs_trak_music.Value = (int)wmp_player.Ctlcontrols.currentPosition;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            wmp_player.Ctlcontrols.stop();
        }

        private void hs_trak_music_MouseUp(object sender, MouseEventArgs e)
        {
            timer_track_music.Start();  
            wmp_player.Ctlcontrols.currentPosition = hs_trak_music.Value;
        }

        private void hs_trak_music_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            int value_tb = hs_trak_music.Value;
            minute = value_tb / 60;
            int sec = minute * 60;
            sec = value_tb - sec;
            secound = sec;
            lbl_time.Text = $"{minute.ToString().PadLeft(2, '0')}:{secound.ToString().PadLeft(2, '0')}";
        }

        private void hs_trak_music_MouseDown(object sender, MouseEventArgs e)
        {
            timer_track_music.Stop();
        }

        private void hs_trak_music_Scroll(object sender, ScrollEventArgs e)
        {
            int value_tb = hs_trak_music.Value;
            minute = value_tb / 60;
            int sec = minute * 60;
            sec = value_tb - sec;
            secound = sec;
            lbl_time.Text = $"{minute.ToString().PadLeft(2, '0')}:{secound.ToString().PadLeft(2, '0')}";
        }

        private void vs_btns_change_ValueChanged(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs e)
        {
            if (vs_btns_change.Value == 4)
            {
                tab_pages_app.SetPage(3);
            }
            else if (vs_btns_change.Value == 15)
            {
                tab_pages_app.SetPage(2);
            }
            else if (vs_btns_change.Value == 27)
            {
                tab_pages_app.SetPage(1);
            }
            else if (vs_btns_change.Value == 40)
            {
                tab_pages_app.SetPage(0);
            }
        }
    }
}
