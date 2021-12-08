namespace MusicPlayer_Bunifo
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.fd_form = new Bunifu.UI.WinForms.BunifuFormDock();
            this.ofd_import = new System.Windows.Forms.OpenFileDialog();
            this.timer_track_music = new System.Windows.Forms.Timer(this.components);
            this.pnl_parent = new Bunifu.UI.WinForms.BunifuPanel();
            this.tab_pages_app = new Bunifu.UI.WinForms.BunifuPages();
            this.tp_playing = new System.Windows.Forms.TabPage();
            this.tp_explore = new System.Windows.Forms.TabPage();
            this.btn_import = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_musics = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cl_song_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_albums = new System.Windows.Forms.TabPage();
            this.tp_playlists = new System.Windows.Forms.TabPage();
            this.pnl_top = new Bunifu.UI.WinForms.BunifuPanel();
            this.wmp_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_bottom = new Bunifu.UI.WinForms.BunifuPanel();
            this.hs_trak_music = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_next = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_previous = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_sound_on = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_mute = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_play = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_stop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.hs_sound_volume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.pnl_menu_left = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_premium = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbl_musicplayer = new System.Windows.Forms.Label();
            this.imagebtn_picture_app = new Bunifu.UI.WinForms.BunifuImageButton();
            this.vs_btns_change = new Bunifu.UI.WinForms.BunifuVSlider();
            this.btn_albums = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_playlist = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_state = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_explore = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_settings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_help = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pb_music = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_image_shadow = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_author = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name_song = new System.Windows.Forms.Label();
            this.pnl_parent.SuspendLayout();
            this.tab_pages_app.SuspendLayout();
            this.tp_playing.SuspendLayout();
            this.tp_explore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musics)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_player)).BeginInit();
            this.pnl_bottom.SuspendLayout();
            this.pnl_menu_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_music)).BeginInit();
            this.pnl_image_shadow.SuspendLayout();
            this.SuspendLayout();
            // 
            // fd_form
            // 
            this.fd_form.AllowFormDragging = true;
            this.fd_form.AllowFormDropShadow = false;
            this.fd_form.AllowFormResizing = false;
            this.fd_form.AllowHidingBottomRegion = true;
            this.fd_form.AllowOpacityChangesWhileDragging = false;
            this.fd_form.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.fd_form.BorderOptions.BottomBorder.BorderThickness = 1;
            this.fd_form.BorderOptions.BottomBorder.ShowBorder = true;
            this.fd_form.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.fd_form.BorderOptions.LeftBorder.BorderThickness = 1;
            this.fd_form.BorderOptions.LeftBorder.ShowBorder = true;
            this.fd_form.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.fd_form.BorderOptions.RightBorder.BorderThickness = 1;
            this.fd_form.BorderOptions.RightBorder.ShowBorder = true;
            this.fd_form.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.fd_form.BorderOptions.TopBorder.BorderThickness = 1;
            this.fd_form.BorderOptions.TopBorder.ShowBorder = true;
            this.fd_form.ContainerControl = this;
            this.fd_form.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.fd_form.DockingIndicatorsOpacity = 0.5D;
            this.fd_form.DockingOptions.DockAll = true;
            this.fd_form.DockingOptions.DockBottomLeft = true;
            this.fd_form.DockingOptions.DockBottomRight = true;
            this.fd_form.DockingOptions.DockFullScreen = true;
            this.fd_form.DockingOptions.DockLeft = true;
            this.fd_form.DockingOptions.DockRight = true;
            this.fd_form.DockingOptions.DockTopLeft = true;
            this.fd_form.DockingOptions.DockTopRight = true;
            this.fd_form.FormDraggingOpacity = 0.9D;
            this.fd_form.ParentForm = this;
            this.fd_form.ShowCursorChanges = true;
            this.fd_form.ShowDockingIndicators = true;
            this.fd_form.TitleBarOptions.AllowFormDragging = true;
            this.fd_form.TitleBarOptions.BunifuFormDock = this.fd_form;
            this.fd_form.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.fd_form.TitleBarOptions.TitleBarControl = this.pnl_top;
            this.fd_form.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // ofd_import
            // 
            this.ofd_import.DefaultExt = "*.mp3";
            this.ofd_import.Filter = ".Mp3 | *.mp3";
            this.ofd_import.Multiselect = true;
            // 
            // timer_track_music
            // 
            this.timer_track_music.Enabled = true;
            this.timer_track_music.Interval = 1000;
            this.timer_track_music.Tick += new System.EventHandler(this.timer_track_music_Tick);
            // 
            // pnl_parent
            // 
            this.pnl_parent.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnl_parent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_parent.BackgroundImage")));
            this.pnl_parent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_parent.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_parent.BorderRadius = 3;
            this.pnl_parent.BorderThickness = 1;
            this.pnl_parent.Controls.Add(this.tab_pages_app);
            this.pnl_parent.Controls.Add(this.pnl_top);
            this.pnl_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_parent.Location = new System.Drawing.Point(287, 0);
            this.pnl_parent.Name = "pnl_parent";
            this.pnl_parent.ShowBorders = true;
            this.pnl_parent.Size = new System.Drawing.Size(1113, 796);
            this.pnl_parent.TabIndex = 2;
            // 
            // tab_pages_app
            // 
            this.tab_pages_app.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_pages_app.AllowTransitions = false;
            this.tab_pages_app.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_pages_app.Controls.Add(this.tp_playing);
            this.tab_pages_app.Controls.Add(this.tp_explore);
            this.tab_pages_app.Controls.Add(this.tp_albums);
            this.tab_pages_app.Controls.Add(this.tp_playlists);
            this.tab_pages_app.Location = new System.Drawing.Point(-8, 63);
            this.tab_pages_app.Multiline = true;
            this.tab_pages_app.Name = "tab_pages_app";
            this.tab_pages_app.Page = this.tp_explore;
            this.tab_pages_app.PageIndex = 1;
            this.tab_pages_app.PageName = "tp_explore";
            this.tab_pages_app.PageTitle = "Explore";
            this.tab_pages_app.SelectedIndex = 0;
            this.tab_pages_app.Size = new System.Drawing.Size(1128, 727);
            this.tab_pages_app.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tab_pages_app.Transition = animation1;
            this.tab_pages_app.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tp_playing
            // 
            this.tp_playing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_playing.Controls.Add(this.pnl_image_shadow);
            this.tp_playing.Controls.Add(this.lbl_author);
            this.tp_playing.Controls.Add(this.label3);
            this.tp_playing.Controls.Add(this.label5);
            this.tp_playing.Controls.Add(this.label2);
            this.tp_playing.Controls.Add(this.lbl_name_song);
            this.tp_playing.Controls.Add(this.label1);
            this.tp_playing.Location = new System.Drawing.Point(4, 4);
            this.tp_playing.Name = "tp_playing";
            this.tp_playing.Padding = new System.Windows.Forms.Padding(3);
            this.tp_playing.Size = new System.Drawing.Size(1120, 698);
            this.tp_playing.TabIndex = 0;
            this.tp_playing.Text = "Playing";
            // 
            // tp_explore
            // 
            this.tp_explore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_explore.Controls.Add(this.btn_import);
            this.tp_explore.Controls.Add(this.dgv_musics);
            this.tp_explore.Location = new System.Drawing.Point(4, 4);
            this.tp_explore.Name = "tp_explore";
            this.tp_explore.Padding = new System.Windows.Forms.Padding(3);
            this.tp_explore.Size = new System.Drawing.Size(1120, 698);
            this.tp_explore.TabIndex = 1;
            this.tp_explore.Text = "Explore";
            // 
            // btn_import
            // 
            this.btn_import.Animated = true;
            this.btn_import.BorderRadius = 5;
            this.btn_import.CheckedState.Parent = this.btn_import;
            this.btn_import.CustomImages.Parent = this.btn_import;
            this.btn_import.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_import.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_import.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_import.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_import.DisabledState.Parent = this.btn_import;
            this.btn_import.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.btn_import.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_import.ForeColor = System.Drawing.Color.Black;
            this.btn_import.HoverState.Parent = this.btn_import;
            this.btn_import.Location = new System.Drawing.Point(56, 26);
            this.btn_import.Name = "btn_import";
            this.btn_import.ShadowDecoration.Parent = this.btn_import;
            this.btn_import.Size = new System.Drawing.Size(180, 45);
            this.btn_import.TabIndex = 15;
            this.btn_import.Text = "Import";
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dgv_musics
            // 
            this.dgv_musics.AllowUserToAddRows = false;
            this.dgv_musics.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_musics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_musics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_musics.BackgroundColor = System.Drawing.Color.White;
            this.dgv_musics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_musics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_musics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_musics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_musics.ColumnHeadersHeight = 50;
            this.dgv_musics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_song_title,
            this.cl_size,
            this.cl_author,
            this.cl_length});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_musics.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_musics.EnableHeadersVisualStyles = false;
            this.dgv_musics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgv_musics.Location = new System.Drawing.Point(29, 86);
            this.dgv_musics.MultiSelect = false;
            this.dgv_musics.Name = "dgv_musics";
            this.dgv_musics.ReadOnly = true;
            this.dgv_musics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_musics.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_musics.RowHeadersVisible = false;
            this.dgv_musics.RowHeadersWidth = 51;
            this.dgv_musics.RowTemplate.Height = 50;
            this.dgv_musics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_musics.Size = new System.Drawing.Size(1067, 528);
            this.dgv_musics.TabIndex = 14;
            this.dgv_musics.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.dgv_musics.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgv_musics.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_musics.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_musics.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_musics.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_musics.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_musics.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgv_musics.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.dgv_musics.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_musics.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_musics.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_musics.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_musics.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_musics.ThemeStyle.ReadOnly = true;
            this.dgv_musics.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.dgv_musics.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_musics.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_musics.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_musics.ThemeStyle.RowsStyle.Height = 50;
            this.dgv_musics.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            this.dgv_musics.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_musics.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musics_CellContentDoubleClick);
            // 
            // cl_song_title
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.cl_song_title.DefaultCellStyle = dataGridViewCellStyle3;
            this.cl_song_title.HeaderText = "Song Title";
            this.cl_song_title.MinimumWidth = 6;
            this.cl_song_title.Name = "cl_song_title";
            this.cl_song_title.ReadOnly = true;
            this.cl_song_title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_song_title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_size
            // 
            this.cl_size.HeaderText = "Size";
            this.cl_size.MinimumWidth = 6;
            this.cl_size.Name = "cl_size";
            this.cl_size.ReadOnly = true;
            this.cl_size.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_author
            // 
            this.cl_author.HeaderText = "Author";
            this.cl_author.MinimumWidth = 6;
            this.cl_author.Name = "cl_author";
            this.cl_author.ReadOnly = true;
            this.cl_author.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_length
            // 
            this.cl_length.HeaderText = "Duration";
            this.cl_length.MinimumWidth = 6;
            this.cl_length.Name = "cl_length";
            this.cl_length.ReadOnly = true;
            this.cl_length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tp_albums
            // 
            this.tp_albums.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_albums.Location = new System.Drawing.Point(4, 4);
            this.tp_albums.Name = "tp_albums";
            this.tp_albums.Size = new System.Drawing.Size(1113, 698);
            this.tp_albums.TabIndex = 2;
            this.tp_albums.Text = "Albums";
            // 
            // tp_playlists
            // 
            this.tp_playlists.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_playlists.Location = new System.Drawing.Point(4, 4);
            this.tp_playlists.Name = "tp_playlists";
            this.tp_playlists.Size = new System.Drawing.Size(1113, 698);
            this.tp_playlists.TabIndex = 3;
            this.tp_playlists.Text = "Playlists";
            // 
            // pnl_top
            // 
            this.pnl_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_top.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_top.BackgroundImage")));
            this.pnl_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_top.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_top.BorderRadius = 3;
            this.pnl_top.BorderThickness = 1;
            this.pnl_top.Controls.Add(this.wmp_player);
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.ShowBorders = true;
            this.pnl_top.Size = new System.Drawing.Size(1113, 67);
            this.pnl_top.TabIndex = 0;
            // 
            // wmp_player
            // 
            this.wmp_player.Enabled = true;
            this.wmp_player.Location = new System.Drawing.Point(414, 33);
            this.wmp_player.Name = "wmp_player";
            this.wmp_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_player.OcxState")));
            this.wmp_player.Size = new System.Drawing.Size(489, 10);
            this.wmp_player.TabIndex = 1;
            this.wmp_player.Visible = false;
            this.wmp_player.StatusChange += new System.EventHandler(this.wmp_player_StatusChange);
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveImage = null;
            this.btn_exit.AllowAnimations = true;
            this.btn_exit.AllowBuffering = false;
            this.btn_exit.AllowToggling = false;
            this.btn_exit.AllowZooming = false;
            this.btn_exit.AllowZoomingOnFocus = false;
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_exit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.ErrorImage")));
            this.btn_exit.FadeWhenInactive = false;
            this.btn_exit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_exit.Image = global::MusicPlayer_Bunifo.Properties.Resources.icon_exit;
            this.btn_exit.ImageActive = null;
            this.btn_exit.ImageLocation = null;
            this.btn_exit.ImageMargin = 20;
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.InitialImage")));
            this.btn_exit.Location = new System.Drawing.Point(1054, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Rotation = 0;
            this.btn_exit.ShowActiveImage = true;
            this.btn_exit.ShowCursorChanges = true;
            this.btn_exit.ShowImageBorders = true;
            this.btn_exit.ShowSizeMarkers = false;
            this.btn_exit.Size = new System.Drawing.Size(50, 50);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.ToolTipText = "Exit";
            this.btn_exit.WaitOnLoad = false;
            this.btn_exit.Zoom = 20;
            this.btn_exit.ZoomSpeed = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(18, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(288, 39);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Song Title - Playing";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackgroundColor = System.Drawing.Color.Purple;
            this.pnl_bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_bottom.BackgroundImage")));
            this.pnl_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_bottom.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_bottom.BorderRadius = 3;
            this.pnl_bottom.BorderThickness = 1;
            this.pnl_bottom.Controls.Add(this.hs_trak_music);
            this.pnl_bottom.Controls.Add(this.lbl_time);
            this.pnl_bottom.Controls.Add(this.btn_next);
            this.pnl_bottom.Controls.Add(this.btn_previous);
            this.pnl_bottom.Controls.Add(this.btn_sound_on);
            this.pnl_bottom.Controls.Add(this.btn_mute);
            this.pnl_bottom.Controls.Add(this.btn_play);
            this.pnl_bottom.Controls.Add(this.btn_stop);
            this.pnl_bottom.Controls.Add(this.hs_sound_volume);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(287, 796);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.ShowBorders = true;
            this.pnl_bottom.Size = new System.Drawing.Size(1113, 58);
            this.pnl_bottom.TabIndex = 1;
            // 
            // hs_trak_music
            // 
            this.hs_trak_music.BackColor = System.Drawing.Color.Transparent;
            this.hs_trak_music.HoverState.Parent = this.hs_trak_music;
            this.hs_trak_music.Location = new System.Drawing.Point(237, 19);
            this.hs_trak_music.Name = "hs_trak_music";
            this.hs_trak_music.Size = new System.Drawing.Size(494, 23);
            this.hs_trak_music.TabIndex = 16;
            this.hs_trak_music.ThumbColor = System.Drawing.Color.Magenta;
            this.hs_trak_music.Value = 0;
            this.hs_trak_music.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hs_trak_music_Scroll);
            this.hs_trak_music.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hs_trak_music_MouseUp);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Mukta", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(749, 15);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(61, 30);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00";
            // 
            // btn_next
            // 
            this.btn_next.ActiveImage = null;
            this.btn_next.AllowAnimations = true;
            this.btn_next.AllowBuffering = false;
            this.btn_next.AllowToggling = false;
            this.btn_next.AllowZooming = true;
            this.btn_next.AllowZoomingOnFocus = false;
            this.btn_next.BackColor = System.Drawing.Color.Purple;
            this.btn_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_next.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_next.ErrorImage")));
            this.btn_next.FadeWhenInactive = false;
            this.btn_next.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_next.Image = global::MusicPlayer_Bunifo.Properties.Resources.previous;
            this.btn_next.ImageActive = null;
            this.btn_next.ImageLocation = null;
            this.btn_next.ImageMargin = 20;
            this.btn_next.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_next.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_next.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_next.InitialImage")));
            this.btn_next.Location = new System.Drawing.Point(165, 9);
            this.btn_next.Name = "btn_next";
            this.btn_next.Rotation = 180;
            this.btn_next.ShowActiveImage = false;
            this.btn_next.ShowCursorChanges = true;
            this.btn_next.ShowImageBorders = true;
            this.btn_next.ShowSizeMarkers = false;
            this.btn_next.Size = new System.Drawing.Size(40, 40);
            this.btn_next.TabIndex = 1;
            this.btn_next.ToolTipText = "Previous";
            this.btn_next.WaitOnLoad = false;
            this.btn_next.Zoom = 20;
            this.btn_next.ZoomSpeed = 10;
            // 
            // btn_previous
            // 
            this.btn_previous.ActiveImage = null;
            this.btn_previous.AllowAnimations = true;
            this.btn_previous.AllowBuffering = false;
            this.btn_previous.AllowToggling = false;
            this.btn_previous.AllowZooming = true;
            this.btn_previous.AllowZoomingOnFocus = false;
            this.btn_previous.BackColor = System.Drawing.Color.Purple;
            this.btn_previous.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_previous.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_previous.ErrorImage")));
            this.btn_previous.FadeWhenInactive = false;
            this.btn_previous.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_previous.Image = global::MusicPlayer_Bunifo.Properties.Resources.previous;
            this.btn_previous.ImageActive = null;
            this.btn_previous.ImageLocation = null;
            this.btn_previous.ImageMargin = 20;
            this.btn_previous.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_previous.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_previous.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_previous.InitialImage")));
            this.btn_previous.Location = new System.Drawing.Point(17, 9);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Rotation = 0;
            this.btn_previous.ShowActiveImage = false;
            this.btn_previous.ShowCursorChanges = true;
            this.btn_previous.ShowImageBorders = true;
            this.btn_previous.ShowSizeMarkers = false;
            this.btn_previous.Size = new System.Drawing.Size(40, 40);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.ToolTipText = "";
            this.btn_previous.WaitOnLoad = false;
            this.btn_previous.Zoom = 20;
            this.btn_previous.ZoomSpeed = 10;
            // 
            // btn_sound_on
            // 
            this.btn_sound_on.ActiveImage = null;
            this.btn_sound_on.AllowAnimations = true;
            this.btn_sound_on.AllowBuffering = false;
            this.btn_sound_on.AllowToggling = false;
            this.btn_sound_on.AllowZooming = false;
            this.btn_sound_on.AllowZoomingOnFocus = false;
            this.btn_sound_on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sound_on.BackColor = System.Drawing.Color.Purple;
            this.btn_sound_on.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sound_on.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_on.ErrorImage")));
            this.btn_sound_on.FadeWhenInactive = false;
            this.btn_sound_on.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_sound_on.Image = global::MusicPlayer_Bunifo.Properties.Resources.sound;
            this.btn_sound_on.ImageActive = null;
            this.btn_sound_on.ImageLocation = null;
            this.btn_sound_on.ImageMargin = 20;
            this.btn_sound_on.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_sound_on.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_sound_on.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_sound_on.InitialImage")));
            this.btn_sound_on.Location = new System.Drawing.Point(1042, 3);
            this.btn_sound_on.Name = "btn_sound_on";
            this.btn_sound_on.Rotation = 0;
            this.btn_sound_on.ShowActiveImage = false;
            this.btn_sound_on.ShowCursorChanges = true;
            this.btn_sound_on.ShowImageBorders = true;
            this.btn_sound_on.ShowSizeMarkers = false;
            this.btn_sound_on.Size = new System.Drawing.Size(50, 50);
            this.btn_sound_on.TabIndex = 1;
            this.btn_sound_on.ToolTipText = "Play";
            this.btn_sound_on.WaitOnLoad = false;
            this.btn_sound_on.Zoom = 20;
            this.btn_sound_on.ZoomSpeed = 10;
            // 
            // btn_mute
            // 
            this.btn_mute.ActiveImage = null;
            this.btn_mute.AllowAnimations = true;
            this.btn_mute.AllowBuffering = false;
            this.btn_mute.AllowToggling = false;
            this.btn_mute.AllowZooming = false;
            this.btn_mute.AllowZoomingOnFocus = false;
            this.btn_mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mute.BackColor = System.Drawing.Color.Purple;
            this.btn_mute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_mute.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_mute.ErrorImage")));
            this.btn_mute.FadeWhenInactive = false;
            this.btn_mute.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_mute.Image = global::MusicPlayer_Bunifo.Properties.Resources.mute;
            this.btn_mute.ImageActive = null;
            this.btn_mute.ImageLocation = null;
            this.btn_mute.ImageMargin = 20;
            this.btn_mute.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_mute.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_mute.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_mute.InitialImage")));
            this.btn_mute.Location = new System.Drawing.Point(823, 5);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Rotation = 0;
            this.btn_mute.ShowActiveImage = false;
            this.btn_mute.ShowCursorChanges = true;
            this.btn_mute.ShowImageBorders = true;
            this.btn_mute.ShowSizeMarkers = false;
            this.btn_mute.Size = new System.Drawing.Size(50, 50);
            this.btn_mute.TabIndex = 1;
            this.btn_mute.ToolTipText = "Play";
            this.btn_mute.WaitOnLoad = false;
            this.btn_mute.Zoom = 20;
            this.btn_mute.ZoomSpeed = 10;
            // 
            // btn_play
            // 
            this.btn_play.ActiveImage = null;
            this.btn_play.AllowAnimations = true;
            this.btn_play.AllowBuffering = false;
            this.btn_play.AllowToggling = false;
            this.btn_play.AllowZooming = false;
            this.btn_play.AllowZoomingOnFocus = false;
            this.btn_play.BackColor = System.Drawing.Color.Purple;
            this.btn_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_play.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_play.ErrorImage")));
            this.btn_play.FadeWhenInactive = false;
            this.btn_play.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_play.Image = global::MusicPlayer_Bunifo.Properties.Resources.play;
            this.btn_play.ImageActive = null;
            this.btn_play.ImageLocation = null;
            this.btn_play.ImageMargin = 20;
            this.btn_play.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_play.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btn_play.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_play.InitialImage")));
            this.btn_play.Location = new System.Drawing.Point(63, 5);
            this.btn_play.Name = "btn_play";
            this.btn_play.Rotation = 0;
            this.btn_play.ShowActiveImage = false;
            this.btn_play.ShowCursorChanges = true;
            this.btn_play.ShowImageBorders = true;
            this.btn_play.ShowSizeMarkers = false;
            this.btn_play.Size = new System.Drawing.Size(50, 50);
            this.btn_play.TabIndex = 1;
            this.btn_play.ToolTipText = "Play";
            this.btn_play.WaitOnLoad = false;
            this.btn_play.Zoom = 20;
            this.btn_play.ZoomSpeed = 10;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.ActiveImage = null;
            this.btn_stop.AllowAnimations = true;
            this.btn_stop.AllowBuffering = false;
            this.btn_stop.AllowToggling = false;
            this.btn_stop.AllowZooming = false;
            this.btn_stop.AllowZoomingOnFocus = false;
            this.btn_stop.BackColor = System.Drawing.Color.Purple;
            this.btn_stop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_stop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.ErrorImage")));
            this.btn_stop.FadeWhenInactive = false;
            this.btn_stop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_stop.Image = global::MusicPlayer_Bunifo.Properties.Resources.stop;
            this.btn_stop.ImageActive = null;
            this.btn_stop.ImageLocation = null;
            this.btn_stop.ImageMargin = 20;
            this.btn_stop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_stop.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_stop.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.InitialImage")));
            this.btn_stop.Location = new System.Drawing.Point(119, 9);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Rotation = 0;
            this.btn_stop.ShowActiveImage = false;
            this.btn_stop.ShowCursorChanges = true;
            this.btn_stop.ShowImageBorders = true;
            this.btn_stop.ShowSizeMarkers = false;
            this.btn_stop.Size = new System.Drawing.Size(40, 40);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.ToolTipText = "Stop";
            this.btn_stop.WaitOnLoad = false;
            this.btn_stop.Zoom = 20;
            this.btn_stop.ZoomSpeed = 10;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // hs_sound_volume
            // 
            this.hs_sound_volume.AllowCursorChanges = true;
            this.hs_sound_volume.AllowHomeEndKeysDetection = false;
            this.hs_sound_volume.AllowIncrementalClickMoves = true;
            this.hs_sound_volume.AllowMouseDownEffects = false;
            this.hs_sound_volume.AllowMouseHoverEffects = false;
            this.hs_sound_volume.AllowScrollingAnimations = true;
            this.hs_sound_volume.AllowScrollKeysDetection = true;
            this.hs_sound_volume.AllowScrollOptionsMenu = true;
            this.hs_sound_volume.AllowShrinkingOnFocusLost = false;
            this.hs_sound_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hs_sound_volume.BackColor = System.Drawing.Color.Transparent;
            this.hs_sound_volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hs_sound_volume.BackgroundImage")));
            this.hs_sound_volume.BindingContainer = null;
            this.hs_sound_volume.BorderRadius = 2;
            this.hs_sound_volume.BorderThickness = 1;
            this.hs_sound_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hs_sound_volume.DrawThickBorder = false;
            this.hs_sound_volume.DurationBeforeShrink = 2000;
            this.hs_sound_volume.ElapsedColor = System.Drawing.Color.Magenta;
            this.hs_sound_volume.LargeChange = 10;
            this.hs_sound_volume.Location = new System.Drawing.Point(880, 14);
            this.hs_sound_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hs_sound_volume.Maximum = 100;
            this.hs_sound_volume.Minimum = 0;
            this.hs_sound_volume.MinimumSize = new System.Drawing.Size(0, 31);
            this.hs_sound_volume.MinimumThumbLength = 18;
            this.hs_sound_volume.Name = "hs_sound_volume";
            this.hs_sound_volume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.hs_sound_volume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.hs_sound_volume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.hs_sound_volume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hs_sound_volume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hs_sound_volume.ShrinkSizeLimit = 3;
            this.hs_sound_volume.Size = new System.Drawing.Size(155, 31);
            this.hs_sound_volume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.hs_sound_volume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.hs_sound_volume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.hs_sound_volume.SmallChange = 1;
            this.hs_sound_volume.TabIndex = 0;
            this.hs_sound_volume.ThumbColor = System.Drawing.Color.Violet;
            this.hs_sound_volume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.hs_sound_volume.ThumbLength = 18;
            this.hs_sound_volume.ThumbMargin = 1;
            this.hs_sound_volume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.hs_sound_volume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.hs_sound_volume.Value = 50;
            this.hs_sound_volume.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.hs_sound_volume_Scroll);
            // 
            // pnl_menu_left
            // 
            this.pnl_menu_left.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.pnl_menu_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_menu_left.BackgroundImage")));
            this.pnl_menu_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu_left.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_menu_left.BorderRadius = 3;
            this.pnl_menu_left.BorderThickness = 1;
            this.pnl_menu_left.Controls.Add(this.btn_premium);
            this.pnl_menu_left.Controls.Add(this.lbl_musicplayer);
            this.pnl_menu_left.Controls.Add(this.imagebtn_picture_app);
            this.pnl_menu_left.Controls.Add(this.vs_btns_change);
            this.pnl_menu_left.Controls.Add(this.btn_albums);
            this.pnl_menu_left.Controls.Add(this.btn_playlist);
            this.pnl_menu_left.Controls.Add(this.btn_state);
            this.pnl_menu_left.Controls.Add(this.btn_explore);
            this.pnl_menu_left.Controls.Add(this.btn_settings);
            this.pnl_menu_left.Controls.Add(this.btn_help);
            this.pnl_menu_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu_left.Name = "pnl_menu_left";
            this.pnl_menu_left.ShowBorders = true;
            this.pnl_menu_left.Size = new System.Drawing.Size(287, 854);
            this.pnl_menu_left.TabIndex = 0;
            // 
            // btn_premium
            // 
            this.btn_premium.AllowAnimations = true;
            this.btn_premium.AllowMouseEffects = true;
            this.btn_premium.AllowToggling = false;
            this.btn_premium.AnimationSpeed = 200;
            this.btn_premium.AutoGenerateColors = false;
            this.btn_premium.AutoRoundBorders = false;
            this.btn_premium.AutoSizeLeftIcon = true;
            this.btn_premium.AutoSizeRightIcon = true;
            this.btn_premium.BackColor = System.Drawing.Color.Transparent;
            this.btn_premium.BackColor1 = System.Drawing.Color.DarkOrchid;
            this.btn_premium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_premium.BackgroundImage")));
            this.btn_premium.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_premium.ButtonText = "Premium";
            this.btn_premium.ButtonTextMarginLeft = 0;
            this.btn_premium.ColorContrastOnClick = 45;
            this.btn_premium.ColorContrastOnHover = 45;
            this.btn_premium.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_premium.CustomizableEdges = borderEdges1;
            this.btn_premium.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_premium.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_premium.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_premium.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_premium.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_premium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_premium.ForeColor = System.Drawing.Color.White;
            this.btn_premium.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_premium.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_premium.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_premium.IconMarginLeft = 11;
            this.btn_premium.IconPadding = 10;
            this.btn_premium.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_premium.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_premium.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_premium.IconSize = 25;
            this.btn_premium.IdleBorderColor = System.Drawing.Color.DarkOrchid;
            this.btn_premium.IdleBorderRadius = 1;
            this.btn_premium.IdleBorderThickness = 1;
            this.btn_premium.IdleFillColor = System.Drawing.Color.DarkOrchid;
            this.btn_premium.IdleIconLeftImage = null;
            this.btn_premium.IdleIconRightImage = null;
            this.btn_premium.IndicateFocus = false;
            this.btn_premium.Location = new System.Drawing.Point(72, 182);
            this.btn_premium.Name = "btn_premium";
            this.btn_premium.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_premium.OnDisabledState.BorderRadius = 1;
            this.btn_premium.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_premium.OnDisabledState.BorderThickness = 1;
            this.btn_premium.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_premium.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_premium.OnDisabledState.IconLeftImage = null;
            this.btn_premium.OnDisabledState.IconRightImage = null;
            this.btn_premium.onHoverState.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btn_premium.onHoverState.BorderRadius = 1;
            this.btn_premium.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_premium.onHoverState.BorderThickness = 1;
            this.btn_premium.onHoverState.FillColor = System.Drawing.Color.MediumOrchid;
            this.btn_premium.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_premium.onHoverState.IconLeftImage = null;
            this.btn_premium.onHoverState.IconRightImage = null;
            this.btn_premium.OnIdleState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btn_premium.OnIdleState.BorderRadius = 1;
            this.btn_premium.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_premium.OnIdleState.BorderThickness = 1;
            this.btn_premium.OnIdleState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btn_premium.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_premium.OnIdleState.IconLeftImage = null;
            this.btn_premium.OnIdleState.IconRightImage = null;
            this.btn_premium.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_premium.OnPressedState.BorderRadius = 1;
            this.btn_premium.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_premium.OnPressedState.BorderThickness = 1;
            this.btn_premium.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_premium.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_premium.OnPressedState.IconLeftImage = null;
            this.btn_premium.OnPressedState.IconRightImage = null;
            this.btn_premium.Size = new System.Drawing.Size(150, 39);
            this.btn_premium.TabIndex = 1;
            this.btn_premium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_premium.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_premium.TextMarginLeft = 0;
            this.btn_premium.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_premium.UseDefaultRadiusAndThickness = true;
            // 
            // lbl_musicplayer
            // 
            this.lbl_musicplayer.AutoSize = true;
            this.lbl_musicplayer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_musicplayer.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_musicplayer.Location = new System.Drawing.Point(57, 130);
            this.lbl_musicplayer.Name = "lbl_musicplayer";
            this.lbl_musicplayer.Size = new System.Drawing.Size(189, 39);
            this.lbl_musicplayer.TabIndex = 2;
            this.lbl_musicplayer.Text = "MusicPlayer";
            // 
            // imagebtn_picture_app
            // 
            this.imagebtn_picture_app.ActiveImage = null;
            this.imagebtn_picture_app.AllowAnimations = true;
            this.imagebtn_picture_app.AllowBuffering = false;
            this.imagebtn_picture_app.AllowToggling = false;
            this.imagebtn_picture_app.AllowZooming = true;
            this.imagebtn_picture_app.AllowZoomingOnFocus = false;
            this.imagebtn_picture_app.BackColor = System.Drawing.Color.Gainsboro;
            this.imagebtn_picture_app.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imagebtn_picture_app.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagebtn_picture_app.ErrorImage")));
            this.imagebtn_picture_app.FadeWhenInactive = false;
            this.imagebtn_picture_app.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imagebtn_picture_app.Image = global::MusicPlayer_Bunifo.Properties.Resources.music_image;
            this.imagebtn_picture_app.ImageActive = null;
            this.imagebtn_picture_app.ImageLocation = null;
            this.imagebtn_picture_app.ImageMargin = 20;
            this.imagebtn_picture_app.ImageSize = new System.Drawing.Size(108, 98);
            this.imagebtn_picture_app.ImageZoomSize = new System.Drawing.Size(128, 118);
            this.imagebtn_picture_app.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagebtn_picture_app.InitialImage")));
            this.imagebtn_picture_app.Location = new System.Drawing.Point(81, 12);
            this.imagebtn_picture_app.Name = "imagebtn_picture_app";
            this.imagebtn_picture_app.Rotation = 0;
            this.imagebtn_picture_app.ShowActiveImage = true;
            this.imagebtn_picture_app.ShowCursorChanges = true;
            this.imagebtn_picture_app.ShowImageBorders = true;
            this.imagebtn_picture_app.ShowSizeMarkers = false;
            this.imagebtn_picture_app.Size = new System.Drawing.Size(128, 118);
            this.imagebtn_picture_app.TabIndex = 1;
            this.imagebtn_picture_app.ToolTipText = "";
            this.imagebtn_picture_app.WaitOnLoad = false;
            this.imagebtn_picture_app.Zoom = 20;
            this.imagebtn_picture_app.ZoomSpeed = 10;
            // 
            // vs_btns_change
            // 
            this.vs_btns_change.AllowCursorChanges = true;
            this.vs_btns_change.AllowHomeEndKeysDetection = false;
            this.vs_btns_change.AllowIncrementalClickMoves = true;
            this.vs_btns_change.AllowMouseDownEffects = false;
            this.vs_btns_change.AllowMouseHoverEffects = false;
            this.vs_btns_change.AllowScrollingAnimations = true;
            this.vs_btns_change.AllowScrollKeysDetection = true;
            this.vs_btns_change.AllowScrollOptionsMenu = true;
            this.vs_btns_change.AllowShrinkingOnFocusLost = false;
            this.vs_btns_change.BackColor = System.Drawing.Color.Transparent;
            this.vs_btns_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vs_btns_change.BackgroundImage")));
            this.vs_btns_change.BindingContainer = null;
            this.vs_btns_change.BorderRadius = 2;
            this.vs_btns_change.BorderThickness = 1;
            this.vs_btns_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vs_btns_change.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.vs_btns_change.DrawThickBorder = false;
            this.vs_btns_change.DurationBeforeShrink = 2000;
            this.vs_btns_change.ElapsedColor = System.Drawing.Color.Fuchsia;
            this.vs_btns_change.LargeChange = 10;
            this.vs_btns_change.Location = new System.Drawing.Point(32, 297);
            this.vs_btns_change.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.vs_btns_change.Maximum = 40;
            this.vs_btns_change.Minimum = 0;
            this.vs_btns_change.MinimumSize = new System.Drawing.Size(31, 0);
            this.vs_btns_change.MinimumThumbLength = 18;
            this.vs_btns_change.Name = "vs_btns_change";
            this.vs_btns_change.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.vs_btns_change.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vs_btns_change.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.vs_btns_change.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.vs_btns_change.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.vs_btns_change.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.vs_btns_change.ScrollBarBorderColor = System.Drawing.Color.WhiteSmoke;
            this.vs_btns_change.ScrollBarColor = System.Drawing.Color.WhiteSmoke;
            this.vs_btns_change.ShrinkSizeLimit = 3;
            this.vs_btns_change.Size = new System.Drawing.Size(31, 236);
            this.vs_btns_change.SliderColor = System.Drawing.Color.WhiteSmoke;
            this.vs_btns_change.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.vs_btns_change.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.vs_btns_change.SmallChange = 1;
            this.vs_btns_change.TabIndex = 0;
            this.vs_btns_change.ThumbColor = System.Drawing.Color.Magenta;
            this.vs_btns_change.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.vs_btns_change.ThumbLength = 57;
            this.vs_btns_change.ThumbMargin = 1;
            this.vs_btns_change.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Medium;
            this.vs_btns_change.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.vs_btns_change.Value = 40;
            this.vs_btns_change.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs>(this.vs_btns_change_ValueChanged);
            // 
            // btn_albums
            // 
            this.btn_albums.AllowAnimations = true;
            this.btn_albums.AllowMouseEffects = true;
            this.btn_albums.AllowToggling = false;
            this.btn_albums.AnimationSpeed = 200;
            this.btn_albums.AutoGenerateColors = false;
            this.btn_albums.AutoRoundBorders = false;
            this.btn_albums.AutoSizeLeftIcon = true;
            this.btn_albums.AutoSizeRightIcon = true;
            this.btn_albums.BackColor = System.Drawing.Color.Transparent;
            this.btn_albums.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_albums.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_albums.BackgroundImage")));
            this.btn_albums.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_albums.ButtonText = "Albums";
            this.btn_albums.ButtonTextMarginLeft = 0;
            this.btn_albums.ColorContrastOnClick = 45;
            this.btn_albums.ColorContrastOnHover = 45;
            this.btn_albums.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_albums.CustomizableEdges = borderEdges2;
            this.btn_albums.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_albums.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_albums.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_albums.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_albums.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_albums.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_albums.ForeColor = System.Drawing.Color.Black;
            this.btn_albums.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_albums.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_albums.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_albums.IconMarginLeft = 11;
            this.btn_albums.IconPadding = 10;
            this.btn_albums.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_albums.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_albums.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_albums.IconSize = 25;
            this.btn_albums.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_albums.IdleBorderRadius = 1;
            this.btn_albums.IdleBorderThickness = 1;
            this.btn_albums.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_albums.IdleIconLeftImage = null;
            this.btn_albums.IdleIconRightImage = null;
            this.btn_albums.IndicateFocus = false;
            this.btn_albums.Location = new System.Drawing.Point(71, 411);
            this.btn_albums.Name = "btn_albums";
            this.btn_albums.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_albums.OnDisabledState.BorderRadius = 1;
            this.btn_albums.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_albums.OnDisabledState.BorderThickness = 1;
            this.btn_albums.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_albums.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_albums.OnDisabledState.IconLeftImage = null;
            this.btn_albums.OnDisabledState.IconRightImage = null;
            this.btn_albums.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_albums.onHoverState.BorderRadius = 1;
            this.btn_albums.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_albums.onHoverState.BorderThickness = 1;
            this.btn_albums.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_albums.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_albums.onHoverState.IconLeftImage = null;
            this.btn_albums.onHoverState.IconRightImage = null;
            this.btn_albums.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_albums.OnIdleState.BorderRadius = 1;
            this.btn_albums.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_albums.OnIdleState.BorderThickness = 1;
            this.btn_albums.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_albums.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_albums.OnIdleState.IconLeftImage = null;
            this.btn_albums.OnIdleState.IconRightImage = null;
            this.btn_albums.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_albums.OnPressedState.BorderRadius = 1;
            this.btn_albums.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_albums.OnPressedState.BorderThickness = 1;
            this.btn_albums.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_albums.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_albums.OnPressedState.IconLeftImage = null;
            this.btn_albums.OnPressedState.IconRightImage = null;
            this.btn_albums.Size = new System.Drawing.Size(118, 58);
            this.btn_albums.TabIndex = 0;
            this.btn_albums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_albums.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_albums.TextMarginLeft = 0;
            this.btn_albums.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_albums.UseDefaultRadiusAndThickness = true;
            this.btn_albums.Click += new System.EventHandler(this.btn_albums_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.AllowAnimations = true;
            this.btn_playlist.AllowMouseEffects = true;
            this.btn_playlist.AllowToggling = false;
            this.btn_playlist.AnimationSpeed = 200;
            this.btn_playlist.AutoGenerateColors = false;
            this.btn_playlist.AutoRoundBorders = false;
            this.btn_playlist.AutoSizeLeftIcon = true;
            this.btn_playlist.AutoSizeRightIcon = true;
            this.btn_playlist.BackColor = System.Drawing.Color.Transparent;
            this.btn_playlist.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_playlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_playlist.BackgroundImage")));
            this.btn_playlist.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_playlist.ButtonText = "Playlists";
            this.btn_playlist.ButtonTextMarginLeft = 0;
            this.btn_playlist.ColorContrastOnClick = 45;
            this.btn_playlist.ColorContrastOnHover = 45;
            this.btn_playlist.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_playlist.CustomizableEdges = borderEdges3;
            this.btn_playlist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_playlist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_playlist.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_playlist.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_playlist.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_playlist.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlist.ForeColor = System.Drawing.Color.Black;
            this.btn_playlist.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_playlist.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_playlist.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_playlist.IconMarginLeft = 11;
            this.btn_playlist.IconPadding = 10;
            this.btn_playlist.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_playlist.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_playlist.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_playlist.IconSize = 25;
            this.btn_playlist.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_playlist.IdleBorderRadius = 1;
            this.btn_playlist.IdleBorderThickness = 1;
            this.btn_playlist.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_playlist.IdleIconLeftImage = null;
            this.btn_playlist.IdleIconRightImage = null;
            this.btn_playlist.IndicateFocus = false;
            this.btn_playlist.Location = new System.Drawing.Point(71, 475);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_playlist.OnDisabledState.BorderRadius = 1;
            this.btn_playlist.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_playlist.OnDisabledState.BorderThickness = 1;
            this.btn_playlist.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_playlist.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_playlist.OnDisabledState.IconLeftImage = null;
            this.btn_playlist.OnDisabledState.IconRightImage = null;
            this.btn_playlist.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_playlist.onHoverState.BorderRadius = 1;
            this.btn_playlist.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_playlist.onHoverState.BorderThickness = 1;
            this.btn_playlist.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_playlist.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_playlist.onHoverState.IconLeftImage = null;
            this.btn_playlist.onHoverState.IconRightImage = null;
            this.btn_playlist.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_playlist.OnIdleState.BorderRadius = 1;
            this.btn_playlist.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_playlist.OnIdleState.BorderThickness = 1;
            this.btn_playlist.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_playlist.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_playlist.OnIdleState.IconLeftImage = null;
            this.btn_playlist.OnIdleState.IconRightImage = null;
            this.btn_playlist.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_playlist.OnPressedState.BorderRadius = 1;
            this.btn_playlist.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_playlist.OnPressedState.BorderThickness = 1;
            this.btn_playlist.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_playlist.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_playlist.OnPressedState.IconLeftImage = null;
            this.btn_playlist.OnPressedState.IconRightImage = null;
            this.btn_playlist.Size = new System.Drawing.Size(128, 58);
            this.btn_playlist.TabIndex = 0;
            this.btn_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_playlist.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_playlist.TextMarginLeft = 0;
            this.btn_playlist.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_playlist.UseDefaultRadiusAndThickness = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // btn_state
            // 
            this.btn_state.AllowAnimations = true;
            this.btn_state.AllowMouseEffects = true;
            this.btn_state.AllowToggling = false;
            this.btn_state.AnimationSpeed = 200;
            this.btn_state.AutoGenerateColors = false;
            this.btn_state.AutoRoundBorders = false;
            this.btn_state.AutoSizeLeftIcon = true;
            this.btn_state.AutoSizeRightIcon = true;
            this.btn_state.BackColor = System.Drawing.Color.Transparent;
            this.btn_state.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_state.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_state.BackgroundImage")));
            this.btn_state.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_state.ButtonText = "No Playing...";
            this.btn_state.ButtonTextMarginLeft = 0;
            this.btn_state.ColorContrastOnClick = 45;
            this.btn_state.ColorContrastOnHover = 45;
            this.btn_state.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_state.CustomizableEdges = borderEdges4;
            this.btn_state.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_state.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_state.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_state.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_state.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_state.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_state.ForeColor = System.Drawing.Color.Black;
            this.btn_state.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_state.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_state.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_state.IconMarginLeft = 11;
            this.btn_state.IconPadding = 10;
            this.btn_state.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_state.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_state.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_state.IconSize = 25;
            this.btn_state.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_state.IdleBorderRadius = 1;
            this.btn_state.IdleBorderThickness = 1;
            this.btn_state.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_state.IdleIconLeftImage = null;
            this.btn_state.IdleIconRightImage = null;
            this.btn_state.IndicateFocus = false;
            this.btn_state.Location = new System.Drawing.Point(81, 283);
            this.btn_state.Name = "btn_state";
            this.btn_state.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_state.OnDisabledState.BorderRadius = 1;
            this.btn_state.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_state.OnDisabledState.BorderThickness = 1;
            this.btn_state.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_state.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_state.OnDisabledState.IconLeftImage = null;
            this.btn_state.OnDisabledState.IconRightImage = null;
            this.btn_state.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_state.onHoverState.BorderRadius = 1;
            this.btn_state.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_state.onHoverState.BorderThickness = 1;
            this.btn_state.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_state.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_state.onHoverState.IconLeftImage = null;
            this.btn_state.onHoverState.IconRightImage = null;
            this.btn_state.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_state.OnIdleState.BorderRadius = 1;
            this.btn_state.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_state.OnIdleState.BorderThickness = 1;
            this.btn_state.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_state.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_state.OnIdleState.IconLeftImage = null;
            this.btn_state.OnIdleState.IconRightImage = null;
            this.btn_state.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_state.OnPressedState.BorderRadius = 1;
            this.btn_state.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_state.OnPressedState.BorderThickness = 1;
            this.btn_state.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_state.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_state.OnPressedState.IconLeftImage = null;
            this.btn_state.OnPressedState.IconRightImage = null;
            this.btn_state.Size = new System.Drawing.Size(138, 58);
            this.btn_state.TabIndex = 0;
            this.btn_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_state.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_state.TextMarginLeft = 0;
            this.btn_state.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_state.UseDefaultRadiusAndThickness = true;
            this.btn_state.Click += new System.EventHandler(this.btn_state_Click);
            // 
            // btn_explore
            // 
            this.btn_explore.AllowAnimations = true;
            this.btn_explore.AllowMouseEffects = true;
            this.btn_explore.AllowToggling = false;
            this.btn_explore.AnimationSpeed = 200;
            this.btn_explore.AutoGenerateColors = false;
            this.btn_explore.AutoRoundBorders = false;
            this.btn_explore.AutoSizeLeftIcon = true;
            this.btn_explore.AutoSizeRightIcon = true;
            this.btn_explore.BackColor = System.Drawing.Color.Transparent;
            this.btn_explore.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_explore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_explore.BackgroundImage")));
            this.btn_explore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_explore.ButtonText = "Explore";
            this.btn_explore.ButtonTextMarginLeft = 0;
            this.btn_explore.ColorContrastOnClick = 45;
            this.btn_explore.ColorContrastOnHover = 45;
            this.btn_explore.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_explore.CustomizableEdges = borderEdges5;
            this.btn_explore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_explore.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_explore.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_explore.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_explore.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_explore.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_explore.ForeColor = System.Drawing.Color.Black;
            this.btn_explore.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_explore.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_explore.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_explore.IconMarginLeft = 11;
            this.btn_explore.IconPadding = 10;
            this.btn_explore.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_explore.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_explore.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_explore.IconSize = 25;
            this.btn_explore.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_explore.IdleBorderRadius = 1;
            this.btn_explore.IdleBorderThickness = 1;
            this.btn_explore.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_explore.IdleIconLeftImage = null;
            this.btn_explore.IdleIconRightImage = null;
            this.btn_explore.IndicateFocus = false;
            this.btn_explore.Location = new System.Drawing.Point(71, 347);
            this.btn_explore.Name = "btn_explore";
            this.btn_explore.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_explore.OnDisabledState.BorderRadius = 1;
            this.btn_explore.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_explore.OnDisabledState.BorderThickness = 1;
            this.btn_explore.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_explore.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_explore.OnDisabledState.IconLeftImage = null;
            this.btn_explore.OnDisabledState.IconRightImage = null;
            this.btn_explore.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_explore.onHoverState.BorderRadius = 1;
            this.btn_explore.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_explore.onHoverState.BorderThickness = 1;
            this.btn_explore.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_explore.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_explore.onHoverState.IconLeftImage = null;
            this.btn_explore.onHoverState.IconRightImage = null;
            this.btn_explore.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_explore.OnIdleState.BorderRadius = 1;
            this.btn_explore.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_explore.OnIdleState.BorderThickness = 1;
            this.btn_explore.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_explore.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_explore.OnIdleState.IconLeftImage = null;
            this.btn_explore.OnIdleState.IconRightImage = null;
            this.btn_explore.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_explore.OnPressedState.BorderRadius = 1;
            this.btn_explore.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_explore.OnPressedState.BorderThickness = 1;
            this.btn_explore.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_explore.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_explore.OnPressedState.IconLeftImage = null;
            this.btn_explore.OnPressedState.IconRightImage = null;
            this.btn_explore.Size = new System.Drawing.Size(118, 58);
            this.btn_explore.TabIndex = 0;
            this.btn_explore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_explore.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_explore.TextMarginLeft = 0;
            this.btn_explore.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_explore.UseDefaultRadiusAndThickness = true;
            this.btn_explore.Click += new System.EventHandler(this.btn_explore_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.AllowAnimations = true;
            this.btn_settings.AllowMouseEffects = true;
            this.btn_settings.AllowToggling = false;
            this.btn_settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_settings.AnimationSpeed = 200;
            this.btn_settings.AutoGenerateColors = false;
            this.btn_settings.AutoRoundBorders = false;
            this.btn_settings.AutoSizeLeftIcon = true;
            this.btn_settings.AutoSizeRightIcon = true;
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_settings.ButtonText = "Settings";
            this.btn_settings.ButtonTextMarginLeft = 0;
            this.btn_settings.ColorContrastOnClick = 45;
            this.btn_settings.ColorContrastOnHover = 45;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_settings.CustomizableEdges = borderEdges6;
            this.btn_settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_settings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_settings.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_settings.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_settings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_settings.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.Black;
            this.btn_settings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_settings.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_settings.IconMarginLeft = 11;
            this.btn_settings.IconPadding = 10;
            this.btn_settings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_settings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_settings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_settings.IconSize = 25;
            this.btn_settings.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.IdleBorderRadius = 1;
            this.btn_settings.IdleBorderThickness = 1;
            this.btn_settings.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_settings.IdleIconLeftImage = null;
            this.btn_settings.IdleIconRightImage = null;
            this.btn_settings.IndicateFocus = false;
            this.btn_settings.Location = new System.Drawing.Point(0, 716);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_settings.OnDisabledState.BorderRadius = 1;
            this.btn_settings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_settings.OnDisabledState.BorderThickness = 1;
            this.btn_settings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_settings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_settings.OnDisabledState.IconLeftImage = null;
            this.btn_settings.OnDisabledState.IconRightImage = null;
            this.btn_settings.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.onHoverState.BorderRadius = 1;
            this.btn_settings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_settings.onHoverState.BorderThickness = 1;
            this.btn_settings.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_settings.onHoverState.IconLeftImage = null;
            this.btn_settings.onHoverState.IconRightImage = null;
            this.btn_settings.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.OnIdleState.BorderRadius = 1;
            this.btn_settings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_settings.OnIdleState.BorderThickness = 1;
            this.btn_settings.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_settings.OnIdleState.IconLeftImage = null;
            this.btn_settings.OnIdleState.IconRightImage = null;
            this.btn_settings.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.OnPressedState.BorderRadius = 1;
            this.btn_settings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_settings.OnPressedState.BorderThickness = 1;
            this.btn_settings.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_settings.OnPressedState.IconLeftImage = null;
            this.btn_settings.OnPressedState.IconRightImage = null;
            this.btn_settings.Size = new System.Drawing.Size(287, 58);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_settings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_settings.TextMarginLeft = 0;
            this.btn_settings.TextPadding = new System.Windows.Forms.Padding(-40, 0, 0, 0);
            this.btn_settings.UseDefaultRadiusAndThickness = true;
            // 
            // btn_help
            // 
            this.btn_help.AllowAnimations = true;
            this.btn_help.AllowMouseEffects = true;
            this.btn_help.AllowToggling = false;
            this.btn_help.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_help.AnimationSpeed = 200;
            this.btn_help.AutoGenerateColors = false;
            this.btn_help.AutoRoundBorders = false;
            this.btn_help.AutoSizeLeftIcon = true;
            this.btn_help.AutoSizeRightIcon = true;
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_help.ButtonText = "Help";
            this.btn_help.ButtonTextMarginLeft = 0;
            this.btn_help.ColorContrastOnClick = 45;
            this.btn_help.ColorContrastOnHover = 45;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btn_help.CustomizableEdges = borderEdges7;
            this.btn_help.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_help.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_help.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_help.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_help.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.btn_help.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.Black;
            this.btn_help.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_help.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_help.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_help.IconMarginLeft = 11;
            this.btn_help.IconPadding = 10;
            this.btn_help.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_help.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_help.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_help.IconSize = 25;
            this.btn_help.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_help.IdleBorderRadius = 1;
            this.btn_help.IdleBorderThickness = 1;
            this.btn_help.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_help.IdleIconLeftImage = null;
            this.btn_help.IdleIconRightImage = null;
            this.btn_help.IndicateFocus = false;
            this.btn_help.Location = new System.Drawing.Point(0, 780);
            this.btn_help.Name = "btn_help";
            this.btn_help.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_help.OnDisabledState.BorderRadius = 1;
            this.btn_help.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_help.OnDisabledState.BorderThickness = 1;
            this.btn_help.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_help.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_help.OnDisabledState.IconLeftImage = null;
            this.btn_help.OnDisabledState.IconRightImage = null;
            this.btn_help.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_help.onHoverState.BorderRadius = 1;
            this.btn_help.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_help.onHoverState.BorderThickness = 1;
            this.btn_help.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_help.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_help.onHoverState.IconLeftImage = null;
            this.btn_help.onHoverState.IconRightImage = null;
            this.btn_help.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_help.OnIdleState.BorderRadius = 1;
            this.btn_help.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_help.OnIdleState.BorderThickness = 1;
            this.btn_help.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_help.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_help.OnIdleState.IconLeftImage = null;
            this.btn_help.OnIdleState.IconRightImage = null;
            this.btn_help.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_help.OnPressedState.BorderRadius = 1;
            this.btn_help.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_help.OnPressedState.BorderThickness = 1;
            this.btn_help.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_help.OnPressedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_help.OnPressedState.IconLeftImage = null;
            this.btn_help.OnPressedState.IconRightImage = null;
            this.btn_help.Size = new System.Drawing.Size(287, 58);
            this.btn_help.TabIndex = 0;
            this.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_help.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_help.TextMarginLeft = 0;
            this.btn_help.TextPadding = new System.Windows.Forms.Padding(-50, 0, 0, 0);
            this.btn_help.UseDefaultRadiusAndThickness = true;
            // 
            // pb_music
            // 
            this.pb_music.FillColor = System.Drawing.Color.Gainsboro;
            this.pb_music.ImageRotate = 0F;
            this.pb_music.Location = new System.Drawing.Point(6, 5);
            this.pb_music.Name = "pb_music";
            this.pb_music.ShadowDecoration.Parent = this.pb_music;
            this.pb_music.Size = new System.Drawing.Size(477, 336);
            this.pb_music.TabIndex = 3;
            this.pb_music.TabStop = false;
            // 
            // pnl_image_shadow
            // 
            this.pnl_image_shadow.BackColor = System.Drawing.Color.Transparent;
            this.pnl_image_shadow.Controls.Add(this.pb_music);
            this.pnl_image_shadow.FillColor = System.Drawing.Color.White;
            this.pnl_image_shadow.Location = new System.Drawing.Point(67, 92);
            this.pnl_image_shadow.Name = "pnl_image_shadow";
            this.pnl_image_shadow.ShadowColor = System.Drawing.Color.Black;
            this.pnl_image_shadow.Size = new System.Drawing.Size(477, 336);
            this.pnl_image_shadow.TabIndex = 4;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Mukta", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(751, 500);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(68, 30);
            this.lbl_author.TabIndex = 0;
            this.lbl_author.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mukta", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mukta", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(751, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mukta", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mukta", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(736, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Title";
            // 
            // lbl_name_song
            // 
            this.lbl_name_song.AutoSize = true;
            this.lbl_name_song.Font = new System.Drawing.Font("Mukta", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_song.Location = new System.Drawing.Point(751, 177);
            this.lbl_name_song.Name = "lbl_name_song";
            this.lbl_name_song.Size = new System.Drawing.Size(92, 30);
            this.lbl_name_song.TabIndex = 0;
            this.lbl_name_song.Text = "Song Title";
            this.lbl_name_song.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 854);
            this.Controls.Add(this.pnl_parent);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_menu_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_parent.ResumeLayout(false);
            this.tab_pages_app.ResumeLayout(false);
            this.tp_playing.ResumeLayout(false);
            this.tp_playing.PerformLayout();
            this.tp_explore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musics)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_player)).EndInit();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.pnl_menu_left.ResumeLayout(false);
            this.pnl_menu_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_music)).EndInit();
            this.pnl_image_shadow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnl_menu_left;
        private Bunifu.UI.WinForms.BunifuPanel pnl_bottom;
        private Bunifu.UI.WinForms.BunifuPanel pnl_parent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_settings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_help;
        private Bunifu.UI.WinForms.BunifuVSlider vs_btns_change;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_albums;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_playlist;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_state;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_explore;
        private Bunifu.UI.WinForms.BunifuPanel pnl_top;
        private Bunifu.UI.WinForms.BunifuImageButton btn_exit;
        private Bunifu.UI.WinForms.BunifuImageButton imagebtn_picture_app;
        private System.Windows.Forms.Label lbl_musicplayer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_premium;
        private System.Windows.Forms.Label lbl_title;
        private Bunifu.UI.WinForms.BunifuHSlider hs_sound_volume;
        private Bunifu.UI.WinForms.BunifuImageButton btn_next;
        private Bunifu.UI.WinForms.BunifuImageButton btn_previous;
        private Bunifu.UI.WinForms.BunifuImageButton btn_play;
        private Bunifu.UI.WinForms.BunifuImageButton btn_stop;
        private Bunifu.UI.WinForms.BunifuImageButton btn_mute;
        private Bunifu.UI.WinForms.BunifuImageButton btn_sound_on;
        private Bunifu.UI.WinForms.BunifuPages tab_pages_app;
        private System.Windows.Forms.TabPage tp_playing;
        private System.Windows.Forms.TabPage tp_explore;
        private Bunifu.UI.WinForms.BunifuFormDock fd_form;
        private System.Windows.Forms.TabPage tp_albums;
        private System.Windows.Forms.TabPage tp_playlists;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_musics;
        private Guna.UI2.WinForms.Guna2Button btn_import;
        private System.Windows.Forms.OpenFileDialog ofd_import;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_song_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_length;
        private AxWMPLib.AxWindowsMediaPlayer wmp_player;
        private System.Windows.Forms.Timer timer_track_music;
        private System.Windows.Forms.Label lbl_time;
        private Guna.UI2.WinForms.Guna2TrackBar hs_trak_music;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_image_shadow;
        private Guna.UI2.WinForms.Guna2PictureBox pb_music;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name_song;
        private System.Windows.Forms.Label label1;
    }
}

