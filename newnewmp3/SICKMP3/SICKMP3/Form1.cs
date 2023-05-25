using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;


namespace SICKMP3
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private string selectedFilePath = "";
        private bool isPaused = false;
        private double currentPosition = 0;
        private bool isFastForwarding = false;
        private double fastForwardPosition = 0.0;
        private string songname = "";
        private bool isFirstFileSelected = true;

        
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3|WAV FIles (*.wav)|*.wav|All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)  
            {
                isFirstFileSelected = listBox1.Items.Count == 0;
                foreach(string fileName in openFileDialog.FileNames){
                    if (!listBox1.Items.Contains(fileName))
                    {
                        
                        listBox1.Items.Add(fileName);
                        
                    }
                    
                    

                }
                
                
                    selectedFilePath = openFileDialog.FileName;
                    

                    isFirstFileSelected = false;
                    player.controls.stop();
                    player.URL = selectedFilePath;
                    

                    player.controls.play();
                    isPaused = false;
                    btnPlay.ImageIndex = 0;

                    songname = System.IO.Path.GetFileNameWithoutExtension(selectedFilePath);
                    label1.Text = "Song:" + songname;

                
                
                

               
            }
        }
        /* here is the pause and play button, the function to play from the current position where it was stopped
         * ,the function to play-pause. */ 
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(selectedFilePath))

            {

                if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    if (!isPaused)
                    {
                        if (isFastForwarding) 
                        {
                            player.controls.currentPosition = fastForwardPosition;
                            isFastForwarding = false;
                        }
                        player.URL = selectedFilePath;
                        player.controls.play();
                        isPaused = false;
                        btnPlay.ImageIndex = 0;

                    }
                    else if (isPaused && player.playState != WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        player.controls.currentPosition = currentPosition;
                        player.controls.play();
                        isPaused = false;
                        btnPlay.ImageIndex = 0;
                    }
                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    isPaused = true;
                    currentPosition = player.controls.currentPosition;
                    player.controls.pause();
                    btnPlay.ImageIndex = 1;
                }
                else
                {
                    player.URL = selectedFilePath;
                    player.controls.play();
                    btnPlay.ImageIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("NO FILE SELECTED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        /*this is the code for a prototype pause button before implementation
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                isPaused = true;
                currentPosition = player.controls.currentPosition;
                player.controls.pause();
            }
        }
        */
        //this part gives us the possibility to skip the song in the listbox
        private void SKIP_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible && listBox1.SelectedIndex < listBox1.Items.Count -1)
            {

                
                    listBox1.SelectedIndex++;
                    listBox1.Visible = true;
                    clr_btn.Visible = true;
                



            }
            else if(!listBox1.Visible && listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
                    listBox1.Visible=false;
                clr_btn.Visible = false;
                
            }
            
        }
        //this part gives us the possiblity to play the song before
        private void REPLAY_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible && listBox1.SelectedIndex > 0)
            {
                
                    listBox1.SelectedIndex--;
                listBox1.Visible = true;
                clr_btn.Visible = true;

            }
            else if(!listBox1.Visible && listBox1.SelectedIndex > 0)
            {
                
                    listBox1.SelectedIndex --;
                    listBox1.Visible = false;
                clr_btn.Visible = false;
                
            }

        }
        //this part is there to make another easy access to the list where the played or is going to play songs can be seen 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            clr_btn.Visible = !clr_btn.Visible; 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                selectedFilePath = listBox1.SelectedItem.ToString();
                player.URL = selectedFilePath;
                player.controls.stop();
                player.controls.play();
                isPaused = false;
                btnPlay.ImageIndex = 0;
                clr_btn.Visible=false;
                listBox1.Visible = false;
                songname = System.IO.Path.GetFileNameWithoutExtension(selectedFilePath);
                label1.Text = "Song:" + songname;
                
            }

            

        }
        // this is the button with the playlist image where it also shows the listbox like the picturebox
        private void Playlist_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            clr_btn.Visible = !clr_btn.Visible;

        }
        //this part is 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            songname = selectedFilePath.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //this part can show the current position of the song on the progressbar.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.controls.currentItem.duration;
                p_bar.Value = (int)player.controls.currentPosition;
               
                position.Text = player.controls.currentPositionString;
                positionend.Text = player.controls.currentItem.durationString;
                

            }
        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "Whitemode")
            {
                button2.Text = "Whitemode";
                this.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                Image newImage = Properties.Resources.vinylwhite;
                pictureBox1.Image = newImage;
                listBox1.BackColor = Color.FromArgb(203, 203, 203);
                listBox1.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                position.ForeColor = Color.Black;
                positionend.ForeColor = Color.Black;
                slash.ForeColor = Color.Black; 
                Volumename.ForeColor = Color.Black;
                VolumeValue.ForeColor = Color.Black;
                clr_btn.ForeColor = Color.Black;
                clr_btn.BackColor = Color.FromArgb(203, 203, 203);
            }
            else
            {
                button2.Text = "Darkmode";
                this.BackColor = Color.FromArgb(46, 48, 71);
                Image newImage = Properties.Resources.vinylblack;
                pictureBox1.Image = newImage;
                listBox1.BackColor = Color.FromArgb(64,64, 64);
                listBox1.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                position.ForeColor = Color.White;
                positionend.ForeColor = Color.White;
                slash.ForeColor = Color.White; 
                Volumename.ForeColor= Color.White;
                VolumeValue.ForeColor = Color.White;
                clr_btn.ForeColor = Color.White; 
                clr_btn.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            
            VolumeValue.Text = trackBar1.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void positionend_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    } 
}
