namespace iPlayMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mplayerPanel = new System.Windows.Forms.Panel();
            this.volpanel = new System.Windows.Forms.Panel();
            this.voltrkbar = new Login_Theme.LogInTrackBar();
            this.mplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnLoadPlaylist = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.progtrkbar = new Aresio_Theme.AresioTrackBar();
            this.btnPlayAll = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShuf = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            this.btnVol = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmrLabel = new System.Windows.Forms.Timer(this.components);
            this.tmrProg = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mplayerPanel.SuspendLayout();
            this.volpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).BeginInit();
            this.playlistPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mplayerPanel
            // 
            this.mplayerPanel.Controls.Add(this.volpanel);
            this.mplayerPanel.Controls.Add(this.mplayer);
            this.mplayerPanel.Location = new System.Drawing.Point(1, 0);
            this.mplayerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mplayerPanel.Name = "mplayerPanel";
            this.mplayerPanel.Size = new System.Drawing.Size(979, 603);
            this.mplayerPanel.TabIndex = 0;
            // 
            // volpanel
            // 
            this.volpanel.Controls.Add(this.voltrkbar);
            this.volpanel.Location = new System.Drawing.Point(489, 543);
            this.volpanel.Margin = new System.Windows.Forms.Padding(4);
            this.volpanel.Name = "volpanel";
            this.volpanel.Size = new System.Drawing.Size(221, 60);
            this.volpanel.TabIndex = 1;
            this.volpanel.Visible = false;
            // 
            // voltrkbar
            // 
            this.voltrkbar.BackColor = System.Drawing.Color.Transparent;
            this.voltrkbar.BarBaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.voltrkbar.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.voltrkbar.Location = new System.Drawing.Point(4, 15);
            this.voltrkbar.Margin = new System.Windows.Forms.Padding(4);
            this.voltrkbar.Maximum = 100;
            this.voltrkbar.Name = "voltrkbar";
            this.voltrkbar.Size = new System.Drawing.Size(213, 28);
            this.voltrkbar.StripAmountColour = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(119)))), ((int)(((byte)(151)))));
            this.voltrkbar.StripColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.voltrkbar.TabIndex = 0;
            this.voltrkbar.Text = "logInTrackBar1";
            this.voltrkbar.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.voltrkbar.Value = 0;
            this.voltrkbar.ValueChanged += new Login_Theme.LogInTrackBar.ValueChangedEventHandler(this.voltrkbar_ValueChanged);
            // 
            // mplayer
            // 
            this.mplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mplayer.Enabled = true;
            this.mplayer.Location = new System.Drawing.Point(0, 0);
            this.mplayer.Margin = new System.Windows.Forms.Padding(4);
            this.mplayer.Name = "mplayer";
            this.mplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mplayer.OcxState")));
            this.mplayer.Size = new System.Drawing.Size(979, 603);
            this.mplayer.TabIndex = 0;
            // 
            // playlistPanel
            // 
            this.playlistPanel.Controls.Add(this.listView1);
            this.playlistPanel.Location = new System.Drawing.Point(980, 0);
            this.playlistPanel.Margin = new System.Windows.Forms.Padding(4);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(667, 700);
            this.playlistPanel.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Path});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(667, 700);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 208;
            // 
            // Path
            // 
            this.Path.Text = "Song Path";
            this.Path.Width = 268;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnLoadPlaylist);
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Controls.Add(this.lblTotal);
            this.btnPanel.Controls.Add(this.lblCurrent);
            this.btnPanel.Controls.Add(this.progtrkbar);
            this.btnPanel.Controls.Add(this.btnPlayAll);
            this.btnPanel.Controls.Add(this.btnLoad);
            this.btnPanel.Controls.Add(this.btnShuf);
            this.btnPanel.Controls.Add(this.btnRep);
            this.btnPanel.Controls.Add(this.btnVol);
            this.btnPanel.Controls.Add(this.btnPause);
            this.btnPanel.Controls.Add(this.btnPlay);
            this.btnPanel.Location = new System.Drawing.Point(1, 606);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(979, 95);
            this.btnPanel.TabIndex = 2;
            // 
            // btnLoadPlaylist
            // 
            this.btnLoadPlaylist.BackgroundImage = global::iPlayMusic.Properties.Resources.playlist;
            this.btnLoadPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPlaylist.Location = new System.Drawing.Point(705, 32);
            this.btnLoadPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPlaylist.Name = "btnLoadPlaylist";
            this.btnLoadPlaylist.Size = new System.Drawing.Size(57, 53);
            this.btnLoadPlaylist.TabIndex = 14;
            this.btnLoadPlaylist.Tag = "";
            this.toolTip1.SetToolTip(this.btnLoadPlaylist, "Open Playlist");
            this.btnLoadPlaylist.UseVisualStyleBackColor = true;
            this.btnLoadPlaylist.Click += new System.EventHandler(this.btnLoadPlaylist_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::iPlayMusic.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(640, 32);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 53);
            this.btnSave.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnSave, "Save Playlist");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(927, 37);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "00:00";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(4, 37);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(55, 23);
            this.lblCurrent.TabIndex = 10;
            this.lblCurrent.Text = "00:00";
            // 
            // progtrkbar
            // 
            this.progtrkbar.BackColor = System.Drawing.Color.Transparent;
            this.progtrkbar.Location = new System.Drawing.Point(4, 5);
            this.progtrkbar.Margin = new System.Windows.Forms.Padding(4);
            this.progtrkbar.Maximum = 10;
            this.progtrkbar.Name = "progtrkbar";
            this.progtrkbar.Size = new System.Drawing.Size(971, 28);
            this.progtrkbar.TabIndex = 9;
            this.progtrkbar.Text = "aresioTrackBar1";
            this.progtrkbar.Value = 0;
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.BackgroundImage = global::iPlayMusic.Properties.Resources.playall;
            this.btnPlayAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAll.Location = new System.Drawing.Point(532, 42);
            this.btnPlayAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(35, 32);
            this.btnPlayAll.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnPlayAll, "Play All Songs");
            this.btnPlayAll.UseVisualStyleBackColor = true;
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = global::iPlayMusic.Properties.Resources.browse;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(575, 32);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(57, 53);
            this.btnLoad.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLoad, "Select Music");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShuf
            // 
            this.btnShuf.BackgroundImage = global::iPlayMusic.Properties.Resources.shuffle;
            this.btnShuf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShuf.Location = new System.Drawing.Point(235, 42);
            this.btnShuf.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuf.Name = "btnShuf";
            this.btnShuf.Size = new System.Drawing.Size(35, 32);
            this.btnShuf.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnShuf, "Shuffle and Play All Songs");
            this.btnShuf.UseVisualStyleBackColor = true;
            this.btnShuf.Click += new System.EventHandler(this.btnShuf_Click);
            // 
            // btnRep
            // 
            this.btnRep.BackgroundImage = global::iPlayMusic.Properties.Resources.repeat;
            this.btnRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRep.Location = new System.Drawing.Point(277, 42);
            this.btnRep.Margin = new System.Windows.Forms.Padding(4);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(35, 32);
            this.btnRep.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRep, "Repeat One Song");
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // btnVol
            // 
            this.btnVol.BackgroundImage = global::iPlayMusic.Properties.Resources.vol;
            this.btnVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVol.Location = new System.Drawing.Point(489, 42);
            this.btnVol.Margin = new System.Windows.Forms.Padding(4);
            this.btnVol.Name = "btnVol";
            this.btnVol.Size = new System.Drawing.Size(35, 32);
            this.btnVol.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnVol, "Set Volume");
            this.btnVol.UseVisualStyleBackColor = true;
            this.btnVol.Click += new System.EventHandler(this.btnVol_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::iPlayMusic.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Location = new System.Drawing.Point(404, 33);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 49);
            this.btnPause.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPause, "Pause");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(343, 33);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 49);
            this.btnPlay.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPlay, "Play");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tmrLabel
            // 
            this.tmrLabel.Interval = 1;
            this.tmrLabel.Tick += new System.EventHandler(this.tmrLabel_Tick);
            // 
            // tmrProg
            // 
            this.tmrProg.Interval = 1;
            this.tmrProg.Tick += new System.EventHandler(this.tmrProg_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 702);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.mplayerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iPlayMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mplayerPanel.ResumeLayout(false);
            this.volpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mplayer)).EndInit();
            this.playlistPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mplayerPanel;
        private AxWMPLib.AxWindowsMediaPlayer mplayer;
        private System.Windows.Forms.Panel playlistPanel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShuf;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Button btnVol;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlayAll;
        private System.Windows.Forms.Panel volpanel;
        private Aresio_Theme.AresioTrackBar progtrkbar;
        private Login_Theme.LogInTrackBar voltrkbar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer tmrLabel;
        private System.Windows.Forms.Timer tmrProg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadPlaylist;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

