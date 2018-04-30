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
using TTPlayer.Properties;

namespace TTPlayer
{
    public partial class TTPlayer : Form
    {
        public TTPlayer()
        {
            InitializeComponent();
        }

        private void TTPlayer_Load(object sender, EventArgs e)
        {
            LoadInitializer();
        }
        private void LoadInitializer()
        {
            skinEngineLoad.SkinFile = @"D:\workspace3\TTPlayer\TTPlayer\bin\Debug\skin\DeepGreen.ssk";
            // 给当前picturebox 赋值一张默认的图片
            pictureBox_cover.Image = Image.FromFile(@"D:\workspace3\TTPlayer\TTPlayer\bin\Debug\Images\1.jpg");
            this.Icon = Resources.TTPlayer;
            // 设置pictureBox中的布局
            pictureBox_cover.SizeMode = PictureBoxSizeMode.StretchImage;
            // 取消自动播放功能
            MusicPlayer.settings.autoStart = false;
            // 给当前音乐播放器赋值一个默认的文件播放路劲
            //MusicPlayer.URL = @"D:\Games\Music\还珠格格-你是风儿我是沙电视原版笛曲伴奏.mp3";

        }
        int i = 0;
        private void AKeyChangeSkin_Click(object sender, EventArgs e)
        {
            // 读取所有的皮肤文件
            // 获取皮肤文件夹中所有皮肤的全路径 存储到StylePath数组中
            string[] StylePath = Directory.GetFiles(@"D:\workspace3\TTPlayer\TTPlayer\bin\Debug\skin\");
            // 点击跟换皮肤其实就是去StylePath数组中拿到一个皮肤文件的去路径 赋值给我们的SkinFile
            i++; // 让皮肤发生改变
            // 表示在最后一个皮肤文件有按一个换肤
            if (i == StylePath.Length)
            {
                i = 0;
            }
            skinEngineLoad.SkinFile = StylePath[i];
        }

        private void timer_ChangePicture_Tick(object sender, EventArgs e)
        {
            // 每隔指定的秒数来更换图片
            // 读取我们的图片文件
            string[] imgPath = Directory.GetFiles(@"D:\workspace3\TTPlayer\TTPlayer\bin\Debug\Images");
            i++;
            if (i == imgPath.Length)
            {
                i = 0;
            }
            pictureBox_cover.Image = Image.FromFile(imgPath[i]);
            //Self_Move_Repeat(listBox_SongList);
        }

        /// <summary>
        /// 实现播放器的播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_stop_playing_Click(object sender, EventArgs e)
        {
            if (BTN_stop_playing.Text == "播放")
            {
                // 让播放器开始播放 而不是暂停
                MusicPlayer.Ctlcontrols.play();
                // 将按的文本 改为暂停
                BTN_stop_playing.Text = "暂停";
            }
            else if (BTN_stop_playing.Text == "暂停")
            {
                // 想做的事情 肯定是暂停
                MusicPlayer.Ctlcontrols.pause();
                // 将按的文本 改为播放
                BTN_stop_playing.Text = "播放";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.stop();
            BTN_stop_playing.Text = "播放";
        }
        // 存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        /// <summary>
        /// 选择音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ChooseMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // 在Show之前设置对话框的属性
            // 设置对话框标题
            ofd.Title = "请选择要播放的音乐文件";
            // 设置对话框可以多选
            ofd.Multiselect = true;
            // 设置一下打文件的类型
            ofd.Filter = "音乐文件|*.MP3|所有文件|*.*";
            // 设置打开文件的初始路劲
            ofd.InitialDirectory = @"D:\Games\Music";
            // 显示对话框
            ofd.ShowDialog();

            // 获得我们在对话框中选中的全路径
            string[] filePath = ofd.FileNames;
            // 根据全路径截取文件名 加载listBox列表中
            // 需要将数组中的全路径存储起来
            for (int i = 0; i < filePath.Length; i++)
            {
                // 将全路径存储到集合当中
                listSongs.Add(filePath[i]);
                // 将全路径截取文件名 扔到列表当中
                listBox_SongList.Items.Add(Path.GetFileName/*有扩展名*/(filePath[i]));
                //Path.GetFileNameWithoutExtension/*没有扩展名*/
            }
        }

        /// <summary>
        /// 双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_SongList_DoubleClick(object sender, EventArgs e)
        {
            if (-1 == listBox_SongList.SelectedIndex)
            {
                return;
            }
            // 当我们栓剂某一首音乐文件的时候,  需要找到双击的文件名所对应的全路径
            // 去集合里面哪数据
            MusicPlayer.URL = listSongs[listBox_SongList.SelectedIndex];
            MusicPlayer.Ctlcontrols.play();
            BTN_stop_playing.Text = "暂停";
            // 加载歌词
            LoadLrc();
        }

        /// <summary>
        /// listBox自身已有项去重
        /// </summary>
        /// <param name="listBox">需要去重ListBox</param>
        public void Self_Move_Repeat(ListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox.Items.Count; j++)
                {
                    if (listBox.Items[i].Equals(listBox.Items[j]))
                    {
                        listBox.Items.Remove(listBox.Items[j]);
                    }
                }
            }
        }

        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Previous_Click(object sender, EventArgs e)
        {
            if (-1 == listBox_SongList.SelectedIndex)
            {
                return;
            }
            // 拿到当前选中这一项的索引
            // 获得当前选中项的索引
            int index = listBox_SongList.SelectedIndex;
            // 将之前选中项的索引都给清空, 这样可以确保我们只有一个歌曲被选中
            listBox_SongList.SelectedIndices.Clear();

            index--;
            // 我在第一首歌点击了上一曲
            if (index < 0)
            {
                // 回到最后一首歌
                index = listBox_SongList.Items.Count - 1;
            }
            // 将改变后的索引重新赋值给当前选中项的索引
            listBox_SongList.SelectedIndex = index;
            // 听过索引从泛型集合里面拿到全路劲 赋值给URL的属性
            MusicPlayer.URL = listSongs[index];
            MusicPlayer.Ctlcontrols.play();
        }

        private void button_NextSong_Click(object sender, EventArgs e)
        {
            if (-1 == listBox_SongList.SelectedIndex)
            {
                return;
            }
            int index = listBox_SongList.SelectedIndex;
            listBox_SongList.SelectedIndices.Clear();
            index++;
            // 说明在最后一首歌 又点击下一首
            if (index == listBox_SongList.Items.Count)
            {
                index = 0;
            }
            listBox_SongList.SelectedIndex = index;
            MusicPlayer.URL = listSongs[index];
            MusicPlayer.Ctlcontrols.play();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 拿到要清除歌曲的数量
            // int Count = listBox_SongList.SelectedIndices.Count;
            int Count = listBox_SongList.SelectedItems.Count;
            for (int i = 0; i < Count; i++)
            {
                // 先删除集合
                listSongs.RemoveAt(listBox_SongList.SelectedIndex);
                // 在删除列表
                listBox_SongList.Items.RemoveAt(listBox_SongList.SelectedIndex);
            }
        }

        /// <summary>
        /// 显示正在播放歌曲的名称
        /// 根据时间差进行下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Play_the_next_song_automatically_Tick(object sender, EventArgs e)
        {
            // 当前正在播放音乐的时候进行显示
            if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label_Display_song_information.Text =
                "已播放: " + MusicPlayer.Ctlcontrols.currentPosition + " / " + MusicPlayer.currentMedia.duration + "\r\n\r\n" +
                "已播放: " + MusicPlayer.Ctlcontrols.currentPositionString + " / " + MusicPlayer.currentMedia.durationString;

                // 要播放的时间 - 已经播放的时间 <= 1
                // 就可以进行下一曲了
                if (MusicPlayer.currentMedia.duration - MusicPlayer.Ctlcontrols.currentPosition <= 1)
                {
                    // 下一曲
                    button_NextSong_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// 播放状态发生改变
        /// 根据播放状态进行下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 当播放器的播放状态发生改变的时候 判断播放器的状态是否到达了Ended, 如果是Ended则进行下一曲
            if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (-1 == listBox_SongList.SelectedIndex)
                {
                    return;
                }
                int index = listBox_SongList.SelectedIndex;
                listBox_SongList.SelectedIndices.Clear();
                index++;
                // 说明在最后一首歌 又点击下一首
                if (index == listBox_SongList.Items.Count)
                {
                    index = 0;
                }
                listBox_SongList.SelectedIndex = index;
                MusicPlayer.URL = listSongs[index];
            }
            if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                // 捕获异常
                try
                {
                    MusicPlayer.Ctlcontrols.play();

                }
                catch { }
            }
        }

        /// <summary>
        /// 加载歌词
        /// </summary>
        void LoadLrc()
        {
            // 判断当前播放的歌曲是否存在歌词文件
            // 获得当前正在播放的歌曲
            string songPath = listSongs[listBox_SongList.SelectedIndex];
            songPath += ".lrc";
            if (File.Exists(songPath)) // 确定指定的文件是否存在
            {
                // 如果存在通过路劲读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath, Encoding.Default/*把乱码去掉*/);
                // 把时间和歌词截取出来 单独进行存放
                FormatLrc(lrcText);
            }
            else
            {
                // 不存在
                label_DynamicLyrics.Text = "------------歌词未找到------------";
            }
        }
        // 存储歌词时间
        List<double> listTime = new List<double>();
        // 存储歌词
        List<String> listLrc = new List<string>();

        // 截取数组中每一行的数据扔到里面去
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="lrcText"></param>
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:15.57]当我和世界不一样
                //lrcTemp[0]  00:15.57
                //lrcTemp[1]  当我和世界不一样

                // 先把括号干掉
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                // 将歌词存到集合中去
                listLrc.Add(lrcTemp[1]);
                //将00:15.57 变成  15.57
                //lrcNewTemp[0] 00  
                //lrcNewTemp[1] 15.57
                string[] lrcNewTemp = lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                // 15.57
                double time = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                // 将最终截取到的时间 扔到ListTime中
                listTime.Add(time);
            }
        }

        /// <summary>
        /// 显示歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Set_time_to_compare_player_time_Tick(object sender, EventArgs e)
        {
            // 获得当前播放器的时间
            double timeOfTheCurrentPlayer = MusicPlayer.Ctlcontrols.currentPosition;
            for (int i = 0; i < listTime.Count - 1; i++)
            {
                if (timeOfTheCurrentPlayer >= listTime[i] && timeOfTheCurrentPlayer < listTime[i + 1])
                {
                    label_DynamicLyrics.Text = listLrc[i];
                }
            }
        }

        /// <summary>
        /// 窗体大小改变，托盘出现或隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TTPlayer_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon.Visible = true;
            }
        }

        /// <summary>
        /// 双击托盘，托盘还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 右击托盘中的退出，则退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 右击托盘中的显示，则还原窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
