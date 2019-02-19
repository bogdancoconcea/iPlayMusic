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
using System.Runtime.InteropServices;

namespace iPlayMusic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            mplayer.uiMode = "none";
            mplayer.enableContextMenu = false;
            mplayer.settings.volume = 50;
            voltrkbar.Value = mplayer.settings.volume;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "E:\\";
            ofd.Filter = "MP3 Audio File (*.mp3)|*mp3|Windows Media Audio (*.wma)|*.wma|WAV Audio File (*.wav)|*.wav|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = false;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string[] fileNameAndPath = ofd.FileNames;
                            string[] filename = ofd.SafeFileNames;

                            for (int i = 0; i < ofd.SafeFileNames.Count(); i++)
                            {
                                string[] saveItem = new string[2];
                                saveItem[0] = filename[i];
                                saveItem[1] = fileNameAndPath[i];

                                ListViewItem lvi = new ListViewItem(saveItem);
                                listView1.Items.Add(lvi);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Couldn't read file from disk.");
                }
            }
            mplayer.settings.volume = 50;
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = mplayer.playlistCollection.newPlaylist("My Playlist") ;
            WMPLib.IWMPMedia media;
            for (int i = 0; i< listView1.Items.Count; i++)
            {
                int j = 1;
                media = mplayer.newMedia(listView1.Items[i].SubItems[j].Text);
                playlist.appendItem(media);
                j++;

                mplayer.currentPlaylist = playlist;
                mplayer.Ctlcontrols.play();
                tmrLabel.Start();
                tmrProg.Start();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selectedFile = listView1.FocusedItem.SubItems[1].Text;
            mplayer.URL = @selectedFile;
            tmrLabel.Start();
            tmrProg.Start();
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            if (volpanel.Visible == false)
            {
                volpanel.Visible = true;
            }
            else
            {
                volpanel.Visible = false;
            }
        }

        private void voltrkbar_ValueChanged()
        {
            mplayer.settings.volume = voltrkbar.Value;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mplayer.Ctlcontrols.play();
            tmrProg.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mplayer.Ctlcontrols.pause();
            tmrProg.Stop();
        }

        private void tmrLabel_Tick(object sender, EventArgs e)
        {
            lblCurrent.Text = mplayer.Ctlcontrols.currentPositionString;
            lblTotal.Text = mplayer.currentMedia.durationString;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            mplayer.settings.setMode("loop", true);
        }

        private void tmrProg_Tick(object sender, EventArgs e)
        {
            progtrkbar.Maximum = (int)mplayer.currentMedia.duration;
            progtrkbar.Value = (int)this.mplayer.Ctlcontrols.currentPosition;
        }

        private void btnShuf_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection list = listView1.Items;
            Random r = new Random();
            int n = list.Count;
            while (n>1)
            {
                n--;
                int k = r.Next(n + 1);
                ListViewItem v1 = (ListViewItem)list[k];
                ListViewItem v2 = (ListViewItem)list[n];
                list[k] = new ListViewItem();
                list[n] = new ListViewItem();
                list[k] = v2;
                list[n] = v1;
            }
            WMPLib.IWMPPlaylist playlist = mplayer.playlistCollection.newPlaylist("My Playlist");
            WMPLib.IWMPMedia media;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int j = 1;
                media = mplayer.newMedia(listView1.Items[i].SubItems[j].Text);
                playlist.appendItem(media);
                j++;

                mplayer.currentPlaylist = playlist;
                mplayer.Ctlcontrols.play();
                tmrLabel.Start();
                tmrProg.Start();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save the Playlist";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            sw.WriteLine("{0}{1}{2}", item.SubItems[0].Text, "*", item.SubItems[1].Text);
                        }
                    }
                }
            }
        }

        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open the Playlist";
            ofd.Filter = "Text File (.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName.ToString();
                listView1.Items.Clear();
                using (StreamReader sr = new StreamReader(filename))
                {
                    string rf = sr.ReadLine();
                    while (rf != null)
                    {

                        try
                        {
                             string[] str = rf.Split('*');
                             ListViewItem item = new ListViewItem(str[0]);
                             item.SubItems.Add(str[1]);
                             listView1.Items.Add(item);
                             rf = sr.ReadLine();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    sr.Close();
                    sr.Dispose();
                    mplayer.settings.volume = 50;
                    voltrkbar.Value = mplayer.settings.volume;
                }
            }
        }
    }
}
