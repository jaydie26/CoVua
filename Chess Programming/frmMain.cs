using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chess_Usercontrol;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Collections;
using System.Media;
using DigitalClock;
namespace Chess_Programming
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {

        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
      
       
        UcCapturedPieces ucCapturedPieces1, ucCapturedPieces2;
        
        UcCountDownTimer UcCountDownTimer1, UcCountDownTimer2;

        short TimeBonus = 0;
        short TimeLimit = 1;
        //10 phút + 15s mỗi lượt

        UcChessBoard Board;

        ChessSide _OwnSide;
        GameMode _GameMode;

        Label[] lblNotation = new Label[36];
        int intNotationSize;

        public frmMain()
        {
            InitializeComponent();
        }

        //Chơi với Người
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();



                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
               
                UcCountDownTimer1 = new UcCountDownTimer();
                UcCountDownTimer2 = new UcCountDownTimer();


                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 1;
                UcCountDownTimer2.Second = 1;

                UcCountDownTimer1.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer1_TimeOut);
                UcCountDownTimer2.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer2_TimeOut);
            }

          
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
            

            pnlTimer1.Controls.Clear();
            pnlTimer2.Controls.Clear();


            pnlTimer1.Visible = true;
            pnlTimer2.Visible = true;

            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;
           
            panel1.Visible = true;
            panel1.Controls.Clear();
           
            Board = new UcChessBoard(ChessBoardStyle.Wooden, ChessPieceStyle.Wooden3D, eOwnSide, eGameMode, 75, 66, true, strFEN);
            ucCapturedPieces1.PieceColor = Board.OwnSide;
           


            pnlTimer1.Controls.Add(UcCountDownTimer1);
            pnlTimer2.Controls.Add(UcCountDownTimer2);

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);
           

            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);


            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((75 * 38) / 100);

            AddNotation(75, eOwnSide);
            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(75 * 8 + intNotationSize * 2, 75 * 8 + intNotationSize * 2);
            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;


            UcCountDownTimer1.Size = new Size(110, 35);
            UcCountDownTimer2.Size = new Size(110, 35);
            UcCountDownTimer1.Location = new Point(8, 8);
            UcCountDownTimer2.Location = new Point(8, 8);
            pnlTimer1.Size = new Size(UcCountDownTimer1.Width + 16, UcCountDownTimer1.Height + 16);
            pnlTimer2.Size = pnlTimer1.Size;

            pnlPlayer1.Visible = true;
            pnlPlayer2.Visible = true;

            pnlPlayer1.Location = new Point(105, 13);
            int w = this.ribbonClientPanel1.Height - pnlPlayer2.Height - 10;
            pnlPlayer2.Location = new Point(pnlPlayer1.Location.X, w-30);

            panel1.Location = new Point(pnlPlayer1.Location.X + pnlPlayer1.Width + 355, pnlPlayer1.Location.Y);
            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 323, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 323, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);

            if (Board.OwnSide == ChessSide.White)
                UcCountDownTimer2.StartTimer();
            else
                UcCountDownTimer1.StartTimer();
        }
        //Chơi với máy
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, GameDifficulty eDifficulty, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
              
                UcCountDownTimer1 = new UcCountDownTimer();
                UcCountDownTimer2 = new UcCountDownTimer();


                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 1;
                UcCountDownTimer2.Second = 1;

                UcCountDownTimer1.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer1_TimeOut);
                UcCountDownTimer2.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer2_TimeOut);
            }

          

           
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;

            pnlTimer1.Controls.Clear();
            pnlTimer2.Controls.Clear();
            pnlTimer1.Visible = true;
            pnlTimer2.Visible = true;

            panel1.Visible = true;
            panel1.Controls.Clear();
          
            Board = new UcChessBoard(ChessBoardStyle.Wooden, ChessPieceStyle.Wooden3D, eOwnSide, eGameMode, eDifficulty, 75,66, true, strFEN);

            pnlTimer1.Controls.Add(UcCountDownTimer1);
            pnlTimer2.Controls.Add(UcCountDownTimer2);

            ucCapturedPieces1.PieceColor = Board.OwnSide;

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);
      

            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
        
     

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((75 * 38) / 100);
            this._GameMode = GameMode.VsComputer;
            this._OwnSide = ChessSide.White;
            AddNotation(75, eOwnSide);

            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(75 * 8 + intNotationSize * 2, 75 * 8 + intNotationSize * 2);

            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;


          
           

            UcCountDownTimer1.Size = new Size(110, 35);
            UcCountDownTimer2.Size = new Size(110, 35);
            UcCountDownTimer1.Location = new Point(8, 8);
            UcCountDownTimer2.Location = new Point(8, 8);
            pnlTimer1.Size = new Size(UcCountDownTimer1.Width + 16, UcCountDownTimer1.Height + 16);
            pnlTimer2.Size = pnlTimer1.Size;

            pnlPlayer1.Visible = true;
            pnlPlayer2.Visible = true;

            pnlPlayer1.Location = new Point(105, 13);
            int w = this.ribbonClientPanel1.Height - pnlPlayer2.Height - 10;
            pnlPlayer2.Location = new Point(pnlPlayer1.Location.X, w-30);

            //Board
            panel1.Location = new Point(pnlPlayer1.Location.X + pnlPlayer1.Width + 355, pnlPlayer1.Location.Y);
            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 323, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 323, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);

            if (Board.OwnSide == ChessSide.White)
                UcCountDownTimer2.StartTimer();
            else
                UcCountDownTimer1.StartTimer();
        }

        void UcCountDownTimer2_TimeOut(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            Board.Enabled = false;
            MessageBox.Show("Bạn Đã Thua Do Hết Thời Gian !!!");
        }

        void UcCountDownTimer1_TimeOut(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            Board.Enabled = false;
            MessageBox.Show("Đối Thủ Đã Hết Thời Gian !!!");
        }
        void MoveMaked(object sender, EventArgs e)
        {
            if (Board == null)
                return;



            if (Board.GameMode == GameMode.VsComputer)
            {
               
              
            }
            else
            {
                Board.Enabled = true;
                
            }

          
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.Black) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.White))
            {
                UcCountDownTimer2.StopTimer();
                UcCountDownTimer1.StartTimer();
                UcCountDownTimer2.TimeBonus(TimeBonus);
            }
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
            {
                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StartTimer();
                UcCountDownTimer1.TimeBonus(TimeBonus);
            }
            if (Board.GameStatus != GameStatus.NowPlaying)
            {
                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();
                Board.Enabled = false;
            }
        }


        void Board_PieceCaptured(object sender, EventArgs e)
        {
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
        }



        void AddNotation(int intCellSize, ChessSide eOwnSide)
        {

            for (int i = 0; i < 36; i++)
            {
                lblNotation[i] = new Label();
                lblNotation[i].Height = intCellSize;
                lblNotation[i].Width = intCellSize;
                lblNotation[i].Image = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, ChessBoardStyle.BoardEdge);

                lblNotation[i].TextAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].Font = new Font(FontFamily.GenericSansSerif, 14.0f);
                lblNotation[i].ImageAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].ForeColor = Color.White;
            }

            lblNotation[0].Height = intNotationSize;
            lblNotation[0].Width = intNotationSize;
            lblNotation[0].Location = new Point();
            lblNotation[0].BackColor = Color.Blue;
            panel1.Controls.Add(lblNotation[0]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[i].Location = new Point(intCellSize * (i - 1) + intNotationSize, 0);
                panel1.Controls.Add(lblNotation[i]);
            }
            lblNotation[9].Height = intNotationSize;
            lblNotation[9].Width = intNotationSize;
            lblNotation[9].BackColor = Color.Blue;
            lblNotation[9].Location = new Point(0, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[9]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[9 + i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[9 + i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[9 + i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[9 + i].Location = new Point(intCellSize * (i - 1) + intNotationSize, intNotationSize + intCellSize * 8);
                panel1.Controls.Add(lblNotation[9 + i]);
            }
            lblNotation[18].Height = intNotationSize;
            lblNotation[18].Width = intNotationSize;
            lblNotation[18].BackColor = Color.Blue;
            lblNotation[18].Location = new Point(intNotationSize + intCellSize * 8, 0);
            panel1.Controls.Add(lblNotation[18]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[18 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[18 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[18 + i].Text = Convert.ToString(i);
                }
                lblNotation[18 + i].Location = new Point(0, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[18 + i]);
            }

            lblNotation[27].Height = intNotationSize;
            lblNotation[27].Width = intNotationSize;
            lblNotation[27].BackColor = Color.Blue;
            lblNotation[27].Location = new Point(intNotationSize + intCellSize * 8, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[27]);
            for (int i = 1; i <= 8; i++)
            {
                lblNotation[27 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[27 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[27 + i].Text = Convert.ToString(i);
                }
                lblNotation[27 + i].Location = new Point(intNotationSize + intCellSize * 8, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[27 + i]);
            }

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        string GetMoveList(Stack stkWhite, Stack stkBlack)
        {
            StringBuilder str = new StringBuilder();

            Stack MoveList = new Stack();
            if (stkWhite.Count > stkBlack.Count)
            {
                MoveList.Push(stkBlack.Pop());
            }
            //Lúc này 2 Stack bằng nhau
            while (stkWhite.Count > 0)
            {
                MoveList.Push(stkBlack.Pop());
                MoveList.Push(stkWhite.Pop());
            }

            foreach (string s in MoveList)
            {
                str.Append(s);
                str.Append(' ');
            }
            return str.ToString().Trim();
        }



        SoundPlayer soundNewGame;
        private void frmMain_Load(object sender, EventArgs e)
        {
            soundNewGame = new SoundPlayer(Properties.Resources.NewGame);
            soundNewGame.LoadAsync();

       
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            frmSelectGame frm = new frmSelectGame();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChessSide eOwnSide = frm.eOwnSide;
                GameMode eGameMode = frm.eGameMode;
                GameDifficulty eDifficulty = frm.eDifficulty;
                string strFen = clsFEN.DefaultFENstring;

                this.TimeLimit = frm.TimeLimit;
                this.TimeBonus = frm.TimeBonus;

                if (eGameMode == GameMode.VsComputer)
                    CreateChessBoard(eOwnSide, eGameMode, eDifficulty, strFen);
                else
                    CreateChessBoard(eOwnSide, eGameMode, strFen);
                frmMessageBox.ShowMessage = true;

                PlayMusic(soundNewGame);
            }
            frm.Dispose();

        }
        public void PlayMusic(SoundPlayer sound)
        {
            if (Board == null)
                return;
            if (Board.PlaySound == true)
            {
                sound.Play();
            }
        }

      

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                // This is all that is needed to change the color table for all controls on the form
                ribbonControl1.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();
        }

       

       

      

     

     

      
      













    }
}