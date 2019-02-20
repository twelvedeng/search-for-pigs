namespace 要了卿命的猪
{
    partial class PigStart
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PigStart));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HaveToKnowKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSToolStripMenuItem,
            this.markMToolStripMenuItem,
            this.exitEToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // StartSToolStripMenuItem
            // 
            this.StartSToolStripMenuItem.Name = "StartSToolStripMenuItem";
            this.StartSToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.StartSToolStripMenuItem.Text = "Start(&S)";
            this.StartSToolStripMenuItem.Click += new System.EventHandler(this.StartSToolStripMenuItem_Click);
            // 
            // markMToolStripMenuItem
            // 
            this.markMToolStripMenuItem.Name = "markMToolStripMenuItem";
            this.markMToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.markMToolStripMenuItem.Text = "Mark(&M)";
            this.markMToolStripMenuItem.Click += new System.EventHandler(this.MarkMToolStripMenuItem_Click);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.ExitEToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseCToolStripMenuItem,
            this.HaveToKnowKToolStripMenuItem,
            this.aboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // chooseCToolStripMenuItem
            // 
            this.chooseCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneToolStripMenuItem,
            this.TwoToolStripMenuItem,
            this.DoToolStripMenuItem});
            this.chooseCToolStripMenuItem.Name = "chooseCToolStripMenuItem";
            this.chooseCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.chooseCToolStripMenuItem.Text = "Choose(&C)";
            // 
            // OneToolStripMenuItem
            // 
            this.OneToolStripMenuItem.Name = "OneToolStripMenuItem";
            this.OneToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.OneToolStripMenuItem.Text = "One";
            this.OneToolStripMenuItem.Click += new System.EventHandler(this.OneToolStripMenuItem_Click);
            // 
            // TwoToolStripMenuItem
            // 
            this.TwoToolStripMenuItem.Name = "TwoToolStripMenuItem";
            this.TwoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.TwoToolStripMenuItem.Text = "Two";
            this.TwoToolStripMenuItem.Click += new System.EventHandler(this.TwoToolStripMenuItem_Click);
            // 
            // DoToolStripMenuItem
            // 
            this.DoToolStripMenuItem.Name = "DoToolStripMenuItem";
            this.DoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DoToolStripMenuItem.Text = "Do it yourself";
            this.DoToolStripMenuItem.Click += new System.EventHandler(this.DoToolStripMenuItem_Click);
            // 
            // HaveToKnowKToolStripMenuItem
            // 
            this.HaveToKnowKToolStripMenuItem.Name = "HaveToKnowKToolStripMenuItem";
            this.HaveToKnowKToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HaveToKnowKToolStripMenuItem.Text = "Have to Know(&K)";
            this.HaveToKnowKToolStripMenuItem.Click += new System.EventHandler(this.HaveToKnowKToolStripMenuItem_Click);
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.AboutAToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel1.ColumnCount = 9;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.pictureBox2, 7, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label1, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label2, 5, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(601, 80);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(35, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(491, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 74);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label1.Location = new System.Drawing.Point(135, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(146, 80);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Pigs";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(319, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(146, 80);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Timer";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PigStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 441);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PigStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "碧野寻猪";
            this.Load += new System.EventHandler(this.PigStart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PigStart_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PigStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PigStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PigStart_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HaveToKnowKToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ToolStripMenuItem OneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwoToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem DoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markMToolStripMenuItem;
    }
}

