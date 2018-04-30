namespace TTPlayer
{
    partial class TTPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTPlayer));
            this.skinEngineLoad = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.AKeyChangeSkin = new System.Windows.Forms.Button();
            this.pictureBox_cover = new System.Windows.Forms.PictureBox();
            this.timer_ChangePicture = new System.Windows.Forms.Timer(this.components);
            this.BTN_stop_playing = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBox_SongList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_Del = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ChooseMusic = new System.Windows.Forms.Button();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_NextSong = new System.Windows.Forms.Button();
            this.timer_Play_the_next_song_automatically = new System.Windows.Forms.Timer(this.components);
            this.label_Display_song_information = new System.Windows.Forms.Label();
            this.label_DynamicLyrics = new System.Windows.Forms.Label();
            this.timer_Set_time_to_compare_player_time = new System.Windows.Forms.Timer(this.components);
            this.groupBox_SongList = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_tray_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).BeginInit();
            this.contextMenuStrip_Del.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.groupBox_SongList.SuspendLayout();
            this.contextMenuStrip_tray_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngineLoad
            // 
            this.skinEngineLoad.SerialNumber = "";
            this.skinEngineLoad.SkinFile = null;
            // 
            // AKeyChangeSkin
            // 
            this.AKeyChangeSkin.Location = new System.Drawing.Point(342, 34);
            this.AKeyChangeSkin.Name = "AKeyChangeSkin";
            this.AKeyChangeSkin.Size = new System.Drawing.Size(87, 23);
            this.AKeyChangeSkin.TabIndex = 0;
            this.AKeyChangeSkin.Text = "一键换肤";
            this.AKeyChangeSkin.UseVisualStyleBackColor = true;
            this.AKeyChangeSkin.Click += new System.EventHandler(this.AKeyChangeSkin_Click);
            // 
            // pictureBox_cover
            // 
            this.pictureBox_cover.Location = new System.Drawing.Point(2, 0);
            this.pictureBox_cover.Name = "pictureBox_cover";
            this.pictureBox_cover.Size = new System.Drawing.Size(325, 331);
            this.pictureBox_cover.TabIndex = 2;
            this.pictureBox_cover.TabStop = false;
            // 
            // timer_ChangePicture
            // 
            this.timer_ChangePicture.Enabled = true;
            this.timer_ChangePicture.Interval = 2000;
            this.timer_ChangePicture.Tick += new System.EventHandler(this.timer_ChangePicture_Tick);
            // 
            // BTN_stop_playing
            // 
            this.BTN_stop_playing.Location = new System.Drawing.Point(342, 91);
            this.BTN_stop_playing.Name = "BTN_stop_playing";
            this.BTN_stop_playing.Size = new System.Drawing.Size(87, 23);
            this.BTN_stop_playing.TabIndex = 3;
            this.BTN_stop_playing.Text = "播放";
            this.BTN_stop_playing.UseVisualStyleBackColor = true;
            this.BTN_stop_playing.Click += new System.EventHandler(this.BTN_stop_playing_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(342, 148);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(87, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listBox_SongList
            // 
            this.listBox_SongList.ContextMenuStrip = this.contextMenuStrip_Del;
            this.listBox_SongList.FormattingEnabled = true;
            this.listBox_SongList.HorizontalScrollbar = true;
            this.listBox_SongList.ItemHeight = 12;
            this.listBox_SongList.Location = new System.Drawing.Point(13, 21);
            this.listBox_SongList.Name = "listBox_SongList";
            this.listBox_SongList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_SongList.Size = new System.Drawing.Size(261, 184);
            this.listBox_SongList.Sorted = true;
            this.listBox_SongList.TabIndex = 5;
            this.listBox_SongList.DoubleClick += new System.EventHandler(this.listBox_SongList_DoubleClick);
            // 
            // contextMenuStrip_Del
            // 
            this.contextMenuStrip_Del.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip_Del.Name = "contextMenuStrip_Del";
            this.contextMenuStrip_Del.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // button_ChooseMusic
            // 
            this.button_ChooseMusic.Location = new System.Drawing.Point(342, 205);
            this.button_ChooseMusic.Name = "button_ChooseMusic";
            this.button_ChooseMusic.Size = new System.Drawing.Size(87, 23);
            this.button_ChooseMusic.TabIndex = 6;
            this.button_ChooseMusic.Text = "选择音乐";
            this.button_ChooseMusic.UseVisualStyleBackColor = true;
            this.button_ChooseMusic.Click += new System.EventHandler(this.button_ChooseMusic_Click);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(2, -1);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(325, 376);
            this.MusicPlayer.TabIndex = 1;
            this.MusicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MusicPlayer_PlayStateChange);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(342, 262);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(87, 23);
            this.button_Previous.TabIndex = 7;
            this.button_Previous.Text = "上一曲";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_NextSong
            // 
            this.button_NextSong.Location = new System.Drawing.Point(342, 319);
            this.button_NextSong.Name = "button_NextSong";
            this.button_NextSong.Size = new System.Drawing.Size(87, 23);
            this.button_NextSong.TabIndex = 8;
            this.button_NextSong.Text = "下一曲";
            this.button_NextSong.UseVisualStyleBackColor = true;
            this.button_NextSong.Click += new System.EventHandler(this.button_NextSong_Click);
            // 
            // timer_Play_the_next_song_automatically
            // 
            this.timer_Play_the_next_song_automatically.Enabled = true;
            this.timer_Play_the_next_song_automatically.Interval = 1000;
            this.timer_Play_the_next_song_automatically.Tick += new System.EventHandler(this.timer_Play_the_next_song_automatically_Tick);
            // 
            // label_Display_song_information
            // 
            this.label_Display_song_information.AutoSize = true;
            this.label_Display_song_information.Location = new System.Drawing.Point(503, 251);
            this.label_Display_song_information.Name = "label_Display_song_information";
            this.label_Display_song_information.Size = new System.Drawing.Size(53, 12);
            this.label_Display_song_information.TabIndex = 9;
            this.label_Display_song_information.Text = "播放信息";
            // 
            // label_DynamicLyrics
            // 
            this.label_DynamicLyrics.AutoSize = true;
            this.label_DynamicLyrics.Location = new System.Drawing.Point(505, 319);
            this.label_DynamicLyrics.Name = "label_DynamicLyrics";
            this.label_DynamicLyrics.Size = new System.Drawing.Size(53, 12);
            this.label_DynamicLyrics.TabIndex = 10;
            this.label_DynamicLyrics.Text = "显示歌词";
            // 
            // timer_Set_time_to_compare_player_time
            // 
            this.timer_Set_time_to_compare_player_time.Enabled = true;
            this.timer_Set_time_to_compare_player_time.Interval = 1000;
            this.timer_Set_time_to_compare_player_time.Tick += new System.EventHandler(this.timer_Set_time_to_compare_player_time_Tick);
            // 
            // groupBox_SongList
            // 
            this.groupBox_SongList.Controls.Add(this.listBox_SongList);
            this.groupBox_SongList.Location = new System.Drawing.Point(445, 8);
            this.groupBox_SongList.Name = "groupBox_SongList";
            this.groupBox_SongList.Size = new System.Drawing.Size(291, 219);
            this.groupBox_SongList.TabIndex = 11;
            this.groupBox_SongList.TabStop = false;
            this.groupBox_SongList.Text = "歌曲列表";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_tray_menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "天天静听";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip_tray_menu
            // 
            this.contextMenuStrip_tray_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip_tray_menu.Name = "contextMenuStrip_tray_menu";
            this.contextMenuStrip_tray_menu.Size = new System.Drawing.Size(101, 54);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // TTPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 378);
            this.Controls.Add(this.groupBox_SongList);
            this.Controls.Add(this.label_DynamicLyrics);
            this.Controls.Add(this.label_Display_song_information);
            this.Controls.Add(this.button_NextSong);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_ChooseMusic);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.BTN_stop_playing);
            this.Controls.Add(this.pictureBox_cover);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.AKeyChangeSkin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 417);
            this.MinimumSize = new System.Drawing.Size(758, 417);
            this.Name = "TTPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天天静听";
            this.Load += new System.EventHandler(this.TTPlayer_Load);
            this.Resize += new System.EventHandler(this.TTPlayer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).EndInit();
            this.contextMenuStrip_Del.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.groupBox_SongList.ResumeLayout(false);
            this.contextMenuStrip_tray_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngineLoad;
        private System.Windows.Forms.Button AKeyChangeSkin;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.PictureBox pictureBox_cover;
        private System.Windows.Forms.Timer timer_ChangePicture;
        private System.Windows.Forms.Button BTN_stop_playing;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBox_SongList;
        private System.Windows.Forms.Button button_ChooseMusic;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_NextSong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Del;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Play_the_next_song_automatically;
        private System.Windows.Forms.Label label_Display_song_information;
        private System.Windows.Forms.Label label_DynamicLyrics;
        private System.Windows.Forms.Timer timer_Set_time_to_compare_player_time;
        private System.Windows.Forms.GroupBox groupBox_SongList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_tray_menu;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

