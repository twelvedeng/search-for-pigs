using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 要了卿命的猪
{
    public partial class PigStart : Form
    {
        public int nWidth;  //定义农场宽度
        public int nHeight; //定义农场高度
        public int nPignum; //定义猪的个数

        bool bMark;       //是否使用标记
        bool bMouseLeft;  //鼠标左键是否被按下
        bool bMouseRight; //鼠标右键是否被按下

        const int MAXWIDTH = 64;      //最大宽度
        const int MAXHEIGHT = 32;     //最大高度

        int[,] pPig = new int[MAXWIDTH, MAXHEIGHT];      //第一类数据
        int[,] pState = new int[MAXWIDTH, MAXHEIGHT];    //第二类数据

        int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };    //x坐标偏移量
        int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 };    //y坐标偏移量
        int[] px = new int[] { 1, -1, 0, 0 ,1,-1,1,-1};        //四个方向x坐标偏移量
        int[] py = new int[] { 0, 0, -1, 1,0,0,1,-1 };         //四个方向y坐标偏移量

        Point MouseFocus;    //高亮点记录
        bool bGame;          //游戏是否结束

        public PigStart()
        {
            InitializeComponent();

            this.DoubleBuffered = true;//开启双缓冲

            //初始化游戏参数
            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nPignum = Properties.Settings.Default.Pignum;

            //初始化
            bMark = Properties.Settings.Default.Mark;
            markMToolStripMenuItem.Checked = bMark;

            //调用类实现对应功能
            UpdateSize();
            SelectLevel();
           
        }/// <summary>
        /// 系统关于对话框（API）
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="szApp">标题文本</param>
        /// <param name="szOtherStuff">内容文本</param>
        /// param name="hIcon">图标句柄</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        /// <summary>
        /// 游戏参数设置
        /// </summary>
        /// <param name="nWidth">农场宽度</param>
        /// <param name="nHeight">农场高度</param>
        /// <param name="nPignum">猪的个数</param>
        private void SetGame(int Width,int Height,int Pignum)
        {
            nWidth = Width;
            nHeight = Height;
            nPignum = Pignum;
            UpdateSize();
        }

        /// <summary>
        /// 设置游戏等级为一
        /// </summary>
        private void One()
        {
            SetGame(16, 10, 10);
        }

        /// <summary>
        /// 设置游戏等级为二
        /// </summary>
        private void Two()
        {
            SetGame(20, 16, 15);
        }

        /// <summary>
        /// 自定义游戏等级
        /// </summary>
        private void SelectLevel()
        {
            if (nWidth == 16 && nHeight == 10 && nPignum == 10)
            {
                OneToolStripMenuItem.Checked = true;
                TwoToolStripMenuItem.Checked = false;
                DoToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 20 && nHeight == 16 && nPignum == 15)
            {
                OneToolStripMenuItem.Checked = false;
                TwoToolStripMenuItem.Checked = true;
                DoToolStripMenuItem.Checked = false;
            }
            else
            {
                OneToolStripMenuItem.Checked = false;
                TwoToolStripMenuItem.Checked = false;
                DoToolStripMenuItem.Checked = true;
            }
        }

        /// <summary>
        /// 游戏攻略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HaveToKnowKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择好等级难度后就可以开始游戏，如果未进行选择则默认第一关。" +"         " +
                "         " + "左键单击翻开农场方格，右键用白菜标记出你认为有猪的地方。"+"                     "+"当你不确定是否有猪时，请双击右键，将会出现问号标识。");
        }

        private void OneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16;nHeight = 10;nPignum = 10;
            SelectLevel();
            UpdateSize();
        }
        private void TwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 20;nHeight = 16;nPignum = 15;
            SelectLevel();
            UpdateSize();
        }

        /// <summary>
        /// 创建绘图句柄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PigStart_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }

        private void PaintGame(Graphics g)
        {
            g.Clear(Color.White);//清空绘图区
            //农场在玩家面前显示时最好保持上下左右6px的偏移量使整体协调
            int nOffX = 6;    //x方向偏移量
            int nOffY = 6 + menuStrip1.Height;       //y方向偏移量
            for(int i = 1; i <= nWidth; i++)    //绘制行
            {
                for (int j = 1; j <= nHeight; j++)    //绘制列
                {
                    // 第一个参数为笔刷，这里采用内置笔刷SkyBlue
                    // 第二个参数为方块的参数，这里采用左上角坐标以及长宽的形式给出
                    // 34表示每个猪区域的大小，再加上偏移量就是我们当前猪区域的起始位置，由于要空出1px的间隔，因此还需要加1
                    // 由此可以的到每个方块在农场中的位置，然后利用循环绘制出来
                    if (pState[i, j] != 1)//未点开
                    {
                        //绘制背景
                        if (i == MouseFocus.X && j == MouseFocus.Y)//是否为高亮点
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SkyBlue)), new Rectangle(nOffX + 34 * (i - 1) + 1, nOffY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.SkyBlue, new Rectangle(nOffX + 34 * (i - 1) + 1, nOffY + 34 * (j - 1) + 1, 32, 32));//绘制农场方块
                        }

                        //绘制标记
                        if (pState[i, j] == 2)
                        {
                            g.DrawImage(Properties.Resources.Cabbage, nOffX + 34 * (i - 1) + 1 + 4, nOffY + 34 * (j - 1) + 1 + 2);//绘制白菜
                        }
                        if (pState[i, j] == 3)
                        {
                            g.DrawImage(Properties.Resources.Doubt, nOffX + 34 * (i - 1) + 1 + 4, nOffY + 34 * (j - 1) + 1 + 2);//绘制问号
                        }
                    }
                    else if (pState[i, j] == 1)//点开
                    {
                        
                            //绘制背景
                            if (MouseFocus.X == i && MouseFocus.Y == j)
                            {
                                g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.WhiteSmoke)), new Rectangle(nOffX + 34 * (i - 1) + 1, nOffY + 34 * (j - 1) + 1, 32, 32));
                            }
                            else
                            {
                                g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(nOffX + 34 * (i - 1) + 1, nOffY + 34 * (j - 1) + 1, 32, 32));
                            }

                            //绘制数字
                            if (pPig[i, j] > 0)
                            {
                                Brush draw = new SolidBrush(Color.SandyBrown);    //定义钢笔
                                //各个猪数量的颜色
                                if (pPig[i, j] == 2) { draw = new SolidBrush(Color.SeaGreen); }
                                if (pPig[i, j] == 3) { draw = new SolidBrush(Color.Orange); }
                                if (pPig[i, j] == 4) { draw = new SolidBrush(Color.SaddleBrown); }
                                if (pPig[i, j] == 5) { draw = new SolidBrush(Color.SeaShell); }
                                if (pPig[i, j] == 6) { draw = new SolidBrush(Color.PaleGreen); }
                                if (pPig[i, j] == 7) { draw = new SolidBrush(Color.CornflowerBlue); }
                                if (pPig[i, j] == 8) { draw = new SolidBrush(Color.Purple); }
                                SizeF Size = g.MeasureString(pPig[i, j].ToString(), new Font("Consolas", 16));
                                g.DrawString(pPig[i, j].ToString(), new Font("Consolas", 16), draw, nOffX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);

                            }
                        //绘制猪
                        if (pPig[i, j] == -1)
                        {
                            g.DrawImage(Properties.Resources.Pigs, nOffX + 34 * (i - 1) + 1 + 4, nOffY + 34 * (j - 1) + 1 + 2);//画猪
                        }
                        
                    }
                }
            }
        }
        /// <summary>
        /// 自动更新窗口大小
        /// </summary>
        private void UpdateSize()
        {
            int nOffX = this.Width - this.ClientSize.Width;    //包含了窗口标题栏和上下边框的高度
            int nOffY = this.Height - this.ClientSize.Height;    //包含了左右边框的宽度
            int nAdditionY = menuStrip1.Height + TableLayoutPanel1.Height;    //包含了菜单栏以及下方显示栏的高度
            this.Width = 12 + 34 * nWidth + nOffX;    //设置窗口高度，34为每个方块的高度，12为上下总空隙（6px+6px），再加上偏移量
            this.Height = 12 + 34 * nHeight + nAdditionY + nOffY;    //设置窗口宽度
            StartSToolStripMenuItem_Click(new object(), new EventArgs());    //调用新建游戏函数
        }
       
      
        private void DoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doityourself diy = new Doityourself(this);//将本身作为参数传递过去
            diy.ShowDialog();
            UpdateSize();
        }

        
        private void ExitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出这个游戏吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "PigStart", "A PigStart game using Csharp language", this.Icon.Handle);
        }

        //游戏过程中是否进行标记
        private void MarkMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markMToolStripMenuItem.Checked = bMark = !bMark;
        }

       
        private void PigStart_Load(object sender, EventArgs e)
        {

        }

        
        private void StartSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //以下两行清空数组
            Array.Clear(pPig, 0, pPig.Length);
            Array.Clear(pState, 0, pState.Length);
            //初始化猪数据
            Random rand = new Random();
            //重新设置高亮点
            MouseFocus.X = 0;MouseFocus.Y = 0;
            for(int i = 1; i <= nPignum;)    //猪的总数
            {
                //随机猪的坐标(x,y)
                int x = rand.Next(nWidth) + 1;
                int y = rand.Next(nHeight) + 1;
                if (pPig[x, y] != -1)
                {
                    pPig[x, y] = -1; i++;
                }
            }
            for(int i = 1; i <= nWidth; i++)    //枚举宽度
            {
                for(int j = 1; j <= nHeight; j++)    //枚举高度
                {
                    if (pPig[i, j] != -1)    //不是猪，显示周围猪的数量
                    {
                        for(int k = 0; k < 8; k++)    //向被点击的方块周围八个方向拓展
                        {
                            if (pPig[i + dx[k], j + dy[k]] == -1)    //找到猪
                            {
                                pPig[i, j]++;    //自增一个
                            }
                        }
                    }
                }
            }
            Label1.Text = nPignum.ToString();    //显示猪的个数
            Label2.Text = "0";    //计时器清零
            Timer.Enabled = true;    //启动计时器
            bGame = false;   //游戏暂未结束
        }

        //鼠标移动事件
        private void PigStart_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 6 || e.X > 6 + nWidth * 34 || e.Y < 6 + menuStrip1.Height || e.Y >6+ menuStrip1.Height+nHeight * 34)    //不在猪的区域
            {
                MouseFocus.X = 0; MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 + 1;    //获取x位置
                int y = (e.Y - menuStrip1.Height - 6) / 34 + 1;    //获取y位置
                MouseFocus.X = x; MouseFocus.Y = y;    //设置当前高亮点
            }
            this.Refresh();    //重新绘制农场
        }

        //计时器时间显示
        private void Timer_Tick(object sender, EventArgs e)
        {
            Label2.Text = Convert.ToString(Convert.ToInt32(Label2.Text) + 1);    //增加一秒
        }

        //鼠标点击事件
        private void PigStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)    //鼠标左键被按下
            {
                bMouseLeft = true;
            }
            if (e.Button == MouseButtons.Right)    //鼠标右键被按下
            {
                bMouseRight = true;
            }
        }

        
        private bool OpenPig(int sx, int sy)
        {
            bool bCabbage = true;  //默认周围无猪
            for (int i = 0; i < 8; i++)
            {
                //获取偏移量
                int x = MouseFocus.X + dx[i];
                int y = MouseFocus.Y + dy[i];
                if (pState[x, y] == 0)//问号
                {
                    pState[x, y] = 1;//打开
                    if (pPig[x, y] == -1)//不是猪
                    {
                        DFS(x, y);
                    }
                    else//有猪
                    {
                        bCabbage = false;
                        break;
                    }
                }
            }
            return bCabbage;
        }

        
        private void PigStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseFocus.X == 0 && MouseFocus.Y == 0||bGame)  //不在有猪的区域或游戏结束
            {
                return;  //不做任何处理
            }
            if (bMouseLeft && bMouseRight)  //左右键同时被按下
            {
                if (pState[MouseFocus.X, MouseFocus.Y] == 1 && pPig[MouseFocus.X, MouseFocus.Y] > 0) //为数字区域
                {
                    int nCabbage = 0, nDoubt = 0, nSys = pPig[MouseFocus.X, MouseFocus.Y];  //记录白菜数目，问号数目，九宫格猪数
                    for(int i = 0; i < 8; i++)
                    {
                        //获取偏移量
                        int x = MouseFocus.X + dx[i];
                        int y = MouseFocus.Y + dy[i];
                        if (pState[x, y] == 2)//白菜
                        {
                            nCabbage++;
                        }
                        if (pState[x, y] == 3)//问号
                        {
                            nDoubt++;
                        }
                        if (nCabbage == nSys || nCabbage + nDoubt == nSys)
                        {
                            bool bCabbage = OpenPig(MouseFocus.X, MouseFocus.Y);//打开九宫格
                            if (!bCabbage)//周围有猪
                            {
                                //结束游戏
                                GameLost();
                            }
                        }
                    }
                }
            }
            else if (bMouseLeft)//左键被按下
            {
                if (pPig[MouseFocus.X, MouseFocus.Y] != -1&&pState[MouseFocus.X,MouseFocus.Y]==0)
                {
                    DFS(MouseFocus.X, MouseFocus.Y);
                }
                else
                {
                    GameLost();
                    //游戏结束
                }
            }
            else if(bMouseRight)//右键被按下
            {
                if (bMark)
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)//未点开
                    {
                        if (Convert.ToInt32(Label1.Text) > 0)
                        {
                            pState[MouseFocus.X, MouseFocus.Y] = 2;//白菜
                            Label1.Text = Convert.ToString(Convert.ToInt32(Label1.Text) - 1);//剩余猪数少一
                        }
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 2)//白菜
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 3;//问号
                        Label1.Text = Convert.ToString(Convert.ToInt32(Label1.Text));//剩余猪数不变
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 3)//问号
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 0;//未点开
                    }
                }
            }
            this.Refresh();
            GameWin();
            bMouseLeft = bMouseRight = false;
        }

        //游戏胜利条件
        private void GameWin()
        {
            int nCnt = 0;  // 玩家标记白菜数目、问号数目、以及无标记未点开区域总数
            for (int i = 1; i <= nWidth; i++)
            {
                for(int j = 1; j <= nHeight; j++)
                {
                    if (pState[i, j] == 0 || pState[i, j] == 2 || pState[i, j] == 3)  // 对应无标记未点开区域、白菜区域、问号区域
                    {
                        nCnt++;
                    }
                }
            }
            if (nCnt == nPignum)  //胜利条件
            {
                Timer.Enabled = false;  //关闭计时器
                MessageBox.Show(String.Format("你成功找出了所有猪呢，花了{0}秒，把它们牵回家吧", Label2.Text), "提示", MessageBoxButtons.OK);
                bGame = true;
            }
        }

        private void DFS(int sx,int sy)
        {
            pState[sx, sy] = 1;  //访问该点
            for(int i = 0; i < 4; i++)
            {
                //获得相邻点坐标
                int x = sx + px[i];
                int y = sy + py[i];
                if(x>=1&&x<=nWidth&&y>=1&&y<=nHeight&&
                    pPig[sx,sy]==0&&pPig[x,y]!=-1&&
                    (pState[x, y] == 0 || pState[x, y] == 3)) //不是猪，处于有猪的区域，未点开，或被标记为问号
                {
                    DFS(x, y);  //访问该点
                }

            }
        }
        private void GameLost()
        {
            for(int i = 1; i <= nWidth; i++)
            {
                for (int j = 1; j <= nHeight; j++)
                {
                    if (pPig[i, j] == -1 && (pState[i, j] == 0 || pState[i, j] == 3))  //未点开或标记为问号的猪
                    {
                        pState[i, j] = 1;  //点开该猪
                    }
                }
            }
            Timer.Enabled = false;  //停止计时
            bGame = true;
            MessageBox.Show("啊噢，你不小心惊到了一只猪，它喊了一声导致所有的猪都跑掉了，再来一局吧");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
