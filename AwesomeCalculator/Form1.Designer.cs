namespace AwesomeCalculator
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
            this.pane_calc_screen = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNum = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton11 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton16 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton15 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton14 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton18 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEqualto = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pane_calc_screen.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEqualto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane_calc_screen
            // 
            this.pane_calc_screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(79)))), ((int)(((byte)(197)))));
            this.pane_calc_screen.Controls.Add(this.bunifuGradientPanel1);
            this.pane_calc_screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_calc_screen.Location = new System.Drawing.Point(0, 0);
            this.pane_calc_screen.Name = "pane_calc_screen";
            this.pane_calc_screen.Size = new System.Drawing.Size(403, 203);
            this.pane_calc_screen.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pane_calc_screen;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timerAnimate
            // 
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.lblCalculation);
            this.bunifuGradientPanel1.Controls.Add(this.lblResult);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(403, 203);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(367, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 22;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 20;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCalculation
            // 
            this.lblCalculation.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCalculation.Font = new System.Drawing.Font("Segoe UI Semibold", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(219)))), ((int)(((byte)(116)))));
            this.lblCalculation.Location = new System.Drawing.Point(0, 75);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(403, 35);
            this.lblCalculation.TabIndex = 1;
            this.lblCalculation.Text = "0";
            this.lblCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Light", 26.29565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(0, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(403, 93);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(38, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 20;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(134, 35);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 4;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Tag = "/";
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(326, 35);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 5;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Tag = "*";
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(38, 193);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 6;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Tag = "4";
            this.bunifuImageButton8.Zoom = 20;
            this.bunifuImageButton8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(230, 193);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 7;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Tag = "6";
            this.bunifuImageButton7.Zoom = 20;
            this.bunifuImageButton7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(134, 193);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 8;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Tag = "5";
            this.bunifuImageButton6.Zoom = 20;
            this.bunifuImageButton6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(326, 193);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 9;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Tag = "+";
            this.bunifuImageButton5.Zoom = 20;
            this.bunifuImageButton5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.Color.Transparent;
            this.btnNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNum.Image = ((System.Drawing.Image)(resources.GetObject("btnNum.Image")));
            this.btnNum.ImageActive = null;
            this.btnNum.Location = new System.Drawing.Point(38, 114);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(25, 25);
            this.btnNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNum.TabIndex = 10;
            this.btnNum.TabStop = false;
            this.btnNum.Tag = "1";
            this.btnNum.Zoom = 20;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton11
            // 
            this.bunifuImageButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton11.Image")));
            this.bunifuImageButton11.ImageActive = null;
            this.bunifuImageButton11.Location = new System.Drawing.Point(230, 114);
            this.bunifuImageButton11.Name = "bunifuImageButton11";
            this.bunifuImageButton11.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton11.TabIndex = 11;
            this.bunifuImageButton11.TabStop = false;
            this.bunifuImageButton11.Tag = "3";
            this.bunifuImageButton11.Zoom = 20;
            this.bunifuImageButton11.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(134, 114);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 12;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Tag = "2";
            this.bunifuImageButton10.Zoom = 20;
            this.bunifuImageButton10.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(326, 114);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 13;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Tag = "-";
            this.bunifuImageButton9.Zoom = 20;
            this.bunifuImageButton9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton16
            // 
            this.bunifuImageButton16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton16.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton16.Image")));
            this.bunifuImageButton16.ImageActive = null;
            this.bunifuImageButton16.Location = new System.Drawing.Point(38, 272);
            this.bunifuImageButton16.Name = "bunifuImageButton16";
            this.bunifuImageButton16.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton16.TabIndex = 14;
            this.bunifuImageButton16.TabStop = false;
            this.bunifuImageButton16.Tag = "7";
            this.bunifuImageButton16.Zoom = 20;
            this.bunifuImageButton16.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton15
            // 
            this.bunifuImageButton15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton15.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton15.Image")));
            this.bunifuImageButton15.ImageActive = null;
            this.bunifuImageButton15.Location = new System.Drawing.Point(230, 272);
            this.bunifuImageButton15.Name = "bunifuImageButton15";
            this.bunifuImageButton15.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton15.TabIndex = 15;
            this.bunifuImageButton15.TabStop = false;
            this.bunifuImageButton15.Tag = "9";
            this.bunifuImageButton15.Zoom = 20;
            this.bunifuImageButton15.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // bunifuImageButton14
            // 
            this.bunifuImageButton14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton14.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton14.Image")));
            this.bunifuImageButton14.ImageActive = null;
            this.bunifuImageButton14.Location = new System.Drawing.Point(134, 272);
            this.bunifuImageButton14.Name = "bunifuImageButton14";
            this.bunifuImageButton14.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton14.TabIndex = 16;
            this.bunifuImageButton14.TabStop = false;
            this.bunifuImageButton14.Tag = "8";
            this.bunifuImageButton14.Zoom = 20;
            this.bunifuImageButton14.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(230, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 19;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 20;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuImageButton18
            // 
            this.bunifuImageButton18.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton18.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton18.Image")));
            this.bunifuImageButton18.ImageActive = null;
            this.bunifuImageButton18.Location = new System.Drawing.Point(134, 351);
            this.bunifuImageButton18.Name = "bunifuImageButton18";
            this.bunifuImageButton18.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton18.TabIndex = 20;
            this.bunifuImageButton18.TabStop = false;
            this.bunifuImageButton18.Tag = "0";
            this.bunifuImageButton18.Zoom = 20;
            this.bunifuImageButton18.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEqualto
            // 
            this.btnEqualto.BackColor = System.Drawing.Color.Transparent;
            this.btnEqualto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEqualto.Image = ((System.Drawing.Image)(resources.GetObject("btnEqualto.Image")));
            this.btnEqualto.ImageActive = null;
            this.btnEqualto.Location = new System.Drawing.Point(326, 351);
            this.btnEqualto.Name = "btnEqualto";
            this.btnEqualto.Size = new System.Drawing.Size(25, 25);
            this.btnEqualto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEqualto.TabIndex = 21;
            this.btnEqualto.TabStop = false;
            this.btnEqualto.Zoom = 20;
            this.btnEqualto.Click += new System.EventHandler(this.btnEqualto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 24;
            this.label3.Tag = "(";
            this.label3.Text = "(";
            this.label3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 25;
            this.label4.Tag = ")";
            this.label4.Text = ")";
            this.label4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 25);
            this.label5.TabIndex = 26;
            this.label5.Tag = ".";
            this.label5.Text = ".";
            this.label5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 27;
            this.label1.Tag = "%";
            this.label1.Text = "%";
            this.label1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnEqualto);
            this.panel1.Controls.Add(this.bunifuImageButton18);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.bunifuImageButton14);
            this.panel1.Controls.Add(this.bunifuImageButton15);
            this.panel1.Controls.Add(this.bunifuImageButton16);
            this.panel1.Controls.Add(this.bunifuImageButton9);
            this.panel1.Controls.Add(this.bunifuImageButton10);
            this.panel1.Controls.Add(this.bunifuImageButton11);
            this.panel1.Controls.Add(this.btnNum);
            this.panel1.Controls.Add(this.bunifuImageButton5);
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.bunifuImageButton7);
            this.panel1.Controls.Add(this.bunifuImageButton8);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 403);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(403, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pane_calc_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc";
            this.pane_calc_screen.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEqualto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pane_calc_screen;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timerAnimate;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton btnNum;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton11;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton16;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton15;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton14;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton18;
        private Bunifu.Framework.UI.BunifuImageButton btnEqualto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

