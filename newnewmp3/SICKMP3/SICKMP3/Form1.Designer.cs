using System.Windows.Forms;

namespace SICKMP3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.playpause = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.open = new System.Windows.Forms.Button();
            this.backfor = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SKIP = new System.Windows.Forms.Button();
            this.REPLAY = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toggleimg = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.Label();
            this.positionend = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.Volumename = new System.Windows.Forms.Label();
            this.VolumeValue = new System.Windows.Forms.Label();
            this.clr_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ImageIndex = 1;
            this.btnPlay.ImageList = this.playpause;
            this.btnPlay.Location = new System.Drawing.Point(177, 324);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // playpause
            // 
            this.playpause.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playpause.ImageStream")));
            this.playpause.TransparentColor = System.Drawing.Color.Transparent;
            this.playpause.Images.SetKeyName(0, "icons8-play-60 (1).png");
            this.playpause.Images.SetKeyName(1, "icons8-pause-60 (1).png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.ImageIndex = 2;
            this.open.ImageList = this.backfor;
            this.open.Location = new System.Drawing.Point(319, 339);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(45, 45);
            this.open.TabIndex = 2;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // backfor
            // 
            this.backfor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backfor.ImageStream")));
            this.backfor.TransparentColor = System.Drawing.Color.Transparent;
            this.backfor.Images.SetKeyName(0, "icons8-back-45 (1).png");
            this.backfor.Images.SetKeyName(1, "icons8-for45 (2).png");
            this.backfor.Images.SetKeyName(2, "icons8-search-45.png");
            this.backfor.Images.SetKeyName(3, "icons8-playlist-45 (2).png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SKIP
            // 
            this.SKIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SKIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SKIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SKIP.ImageIndex = 1;
            this.SKIP.ImageList = this.backfor;
            this.SKIP.Location = new System.Drawing.Point(268, 339);
            this.SKIP.Name = "SKIP";
            this.SKIP.Size = new System.Drawing.Size(45, 45);
            this.SKIP.TabIndex = 3;
            this.SKIP.UseVisualStyleBackColor = false;
            this.SKIP.Click += new System.EventHandler(this.SKIP_Click);
            // 
            // REPLAY
            // 
            this.REPLAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.REPLAY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.REPLAY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.REPLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REPLAY.ImageIndex = 0;
            this.REPLAY.ImageList = this.backfor;
            this.REPLAY.Location = new System.Drawing.Point(103, 339);
            this.REPLAY.Name = "REPLAY";
            this.REPLAY.Size = new System.Drawing.Size(45, 45);
            this.REPLAY.TabIndex = 4;
            this.REPLAY.UseVisualStyleBackColor = false;
            this.REPLAY.Click += new System.EventHandler(this.REPLAY_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(103, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 223);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.backfor;
            this.button1.Location = new System.Drawing.Point(52, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Playlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // p_bar
            // 
            this.p_bar.ForeColor = System.Drawing.Color.Black;
            this.p_bar.Location = new System.Drawing.Point(12, 300);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(390, 10);
            this.p_bar.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(12, 408);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // toggleimg
            // 
            this.toggleimg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toggleimg.ImageStream")));
            this.toggleimg.TransparentColor = System.Drawing.Color.Transparent;
            this.toggleimg.Images.SetKeyName(0, "icons8-toggle-on-30.png");
            this.toggleimg.Images.SetKeyName(1, "icons8-toggle-off-30.png");
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageIndex = 1;
            this.button2.Location = new System.Drawing.Point(296, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "DarkMode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.ForeColor = System.Drawing.Color.White;
            this.position.Location = new System.Drawing.Point(63, 313);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(34, 13);
            this.position.TabIndex = 12;
            this.position.Text = "00:00";
            this.position.Click += new System.EventHandler(this.label2_Click);
            // 
            // positionend
            // 
            this.positionend.AutoSize = true;
            this.positionend.ForeColor = System.Drawing.Color.White;
            this.positionend.Location = new System.Drawing.Point(9, 313);
            this.positionend.Name = "positionend";
            this.positionend.Size = new System.Drawing.Size(34, 13);
            this.positionend.TabIndex = 13;
            this.positionend.Text = "00:00";
            this.positionend.Click += new System.EventHandler(this.positionend_Click);
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.ForeColor = System.Drawing.Color.White;
            this.slash.Location = new System.Drawing.Point(45, 313);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(12, 13);
            this.slash.TabIndex = 14;
            this.slash.Text = "/";
            // 
            // Volumename
            // 
            this.Volumename.AutoSize = true;
            this.Volumename.ForeColor = System.Drawing.Color.White;
            this.Volumename.Location = new System.Drawing.Point(22, 431);
            this.Volumename.Name = "Volumename";
            this.Volumename.Size = new System.Drawing.Size(42, 13);
            this.Volumename.TabIndex = 15;
            this.Volumename.Text = "Volume";
            this.Volumename.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // VolumeValue
            // 
            this.VolumeValue.AutoSize = true;
            this.VolumeValue.ForeColor = System.Drawing.Color.White;
            this.VolumeValue.Location = new System.Drawing.Point(119, 431);
            this.VolumeValue.Name = "VolumeValue";
            this.VolumeValue.Size = new System.Drawing.Size(19, 13);
            this.VolumeValue.TabIndex = 16;
            this.VolumeValue.Text = "50";
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_btn.ForeColor = System.Drawing.Color.White;
            this.clr_btn.Location = new System.Drawing.Point(289, 251);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 23);
            this.clr_btn.TabIndex = 17;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Visible = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(414, 481);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.VolumeValue);
            this.Controls.Add(this.Volumename);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.positionend);
            this.Controls.Add(this.position);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.REPLAY);
            this.Controls.Add(this.SKIP);
            this.Controls.Add(this.open);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SICKMP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ImageList playpause;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button SKIP;
        private System.Windows.Forms.Button REPLAY;
        private System.Windows.Forms.ImageList backfor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private ProgressBar p_bar;
        private TrackBar trackBar1;
        private ImageList toggleimg;
        private Button button2;
        private Label position;
        private Label positionend;
        private Label slash;
        private Label Volumename;
        private Label VolumeValue;
        private Button clr_btn;
    }
}

