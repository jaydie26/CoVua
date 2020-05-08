namespace Chess_Programming
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnNewGame = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece1 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece2 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlTimer2 = new System.Windows.Forms.Panel();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.pnlTimer1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.pnlPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(840, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(840, 97);
            this.ribbonPanel1.TabIndex = 1;
        
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.ribbonBar7.Location = new System.Drawing.Point(90, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(66, 94);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar7.TabIndex = 5;
            this.ribbonBar7.Text = "Thoát";
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageFixedSize = new System.Drawing.Size(51, 51);
            this.btnExit.ImagePaddingHorizontal = 6;
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExit.Name = "btnExit";
            this.btnExit.RibbonWordWrap = false;
            this.btnExit.SubItemsExpandWidth = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNewGame});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(87, 94);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Trò Chơi";
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoCollapseOnClick = false;
            this.btnNewGame.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNewGame.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGame.Image")));
            this.btnNewGame.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnNewGame.ImagePaddingHorizontal = 6;
            this.btnNewGame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNewGame.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.RibbonWordWrap = false;
            this.btnNewGame.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnNewGame.SubItemsExpandWidth = 14;
            this.btnNewGame.Text = "Chơi Đơn";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // pnlCapturedPiece1
            // 
            this.pnlCapturedPiece1.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece1.Location = new System.Drawing.Point(446, 3);
            this.pnlCapturedPiece1.Name = "pnlCapturedPiece1";
            this.pnlCapturedPiece1.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece1.TabIndex = 1;
            this.pnlCapturedPiece1.Visible = false;
            // 
            // pnlCapturedPiece2
            // 
            this.pnlCapturedPiece2.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece2.Location = new System.Drawing.Point(446, 212);
            this.pnlCapturedPiece2.Name = "pnlCapturedPiece2";
            this.pnlCapturedPiece2.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece2.TabIndex = 2;
            this.pnlCapturedPiece2.Visible = false;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.Red;
            this.pnlPlayer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPlayer2.BackgroundImage")));
            this.pnlPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer2.Controls.Add(this.label1);
            this.pnlPlayer2.Controls.Add(this.Pic2);
            this.pnlPlayer2.Controls.Add(this.pnlTimer2);
            this.pnlPlayer2.Location = new System.Drawing.Point(498, 287);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(199, 265);
            this.pnlPlayer2.TabIndex = 8;
            this.pnlPlayer2.Visible = false;
            // 
            // pnlTimer2
            // 
            this.pnlTimer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTimer2.BackgroundImage")));
            this.pnlTimer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer2.Location = new System.Drawing.Point(33, 26);
            this.pnlTimer2.Name = "pnlTimer2";
            this.pnlTimer2.Size = new System.Drawing.Size(137, 50);
            this.pnlTimer2.TabIndex = 5;
            this.pnlTimer2.Visible = false;
            // 
            // Pic2
            // 
            this.Pic2.Image = ((System.Drawing.Image)(resources.GetObject("Pic2.Image")));
            this.Pic2.Location = new System.Drawing.Point(33, 82);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(137, 120);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic2.TabIndex = 7;
            this.Pic2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(53, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "  Jaydie";
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPlayer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPlayer1.BackgroundImage")));
            this.pnlPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer1.Controls.Add(this.label2);
            this.pnlPlayer1.Controls.Add(this.pnlTimer1);
            this.pnlPlayer1.Controls.Add(this.Pic1);
            this.pnlPlayer1.Location = new System.Drawing.Point(498, 16);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(199, 265);
            this.pnlPlayer1.TabIndex = 9;
            this.pnlPlayer1.Visible = false;
            // 
            // Pic1
            // 
            this.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(33, 79);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(137, 120);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic1.TabIndex = 6;
            this.Pic1.TabStop = false;
            // 
            // pnlTimer1
            // 
            this.pnlTimer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTimer1.BackgroundImage")));
            this.pnlTimer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer1.Location = new System.Drawing.Point(33, 28);
            this.pnlTimer1.Name = "pnlTimer1";
            this.pnlTimer1.Size = new System.Drawing.Size(137, 45);
            this.pnlTimer1.TabIndex = 4;
            this.pnlTimer1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(64, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dương";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.pnlPlayer1);
            this.ribbonClientPanel1.Controls.Add(this.pnlPlayer2);
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece2);
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece1);
            this.ribbonClientPanel1.Controls.Add(this.panel1);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(4, 155);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(840, 530);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 1;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // frmMain
            // 
            this.BottomLeftCornerSize = 0;
            this.BottomRightCornerSize = 0;
            this.ClientSize = new System.Drawing.Size(848, 687);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.Command AppCommandTheme;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnNewGame;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCapturedPiece1;
        private System.Windows.Forms.Panel pnlCapturedPiece2;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.Panel pnlTimer2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTimer1;
        private System.Windows.Forms.PictureBox Pic1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
    }
}