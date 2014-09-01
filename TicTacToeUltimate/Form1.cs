using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeUltimate
{
    public partial class frmMain : Form
    {
        private int playerTurn = 0;
        private int win = 0;
        public bool c1, c2, c3, c4, c5, c6, c7, c8, c9;
        public void init() {
            c1=c2=c3=c4=c6=c7=c8=c9=false;
            c5 = true;

        }

        
        
        


        public int PlayerTurn{
        get{return playerTurn;}
        set{playerTurn=value;}
        }

        public int Win{
        get{return win;}
        set{win=value;}
        }
        
        
        public string w1,w2,w3,w4,w5,w6,w7,w8,w9;
        
        
        public void winCheck()
        {
            #region w1WinLogic

            if (button1.Text == " " && button2.Text == " " && button3.Text == " " && w1==null)
            {
                w1 = "P2";
                button1.Image = new Bitmap(@"win_cross.png");
                button2.Image = new Bitmap(@"win_cross.png");
                button3.Image = new Bitmap(@"win_cross.png");
            }
            else if (button4.Text == " " && button5.Text == " " && button6.Text == " " && w1==null)
            {
                w1 = "P2";
                button4.Image = new Bitmap(@"win_cross.png");
                button5.Image = new Bitmap(@"win_cross.png");
                button6.Image = new Bitmap(@"win_cross.png");
            }
            else if (button7.Text == " " && button8.Text == " " && button9.Text == " " && w1==null) 
            {
                w1 = "P2";
                button7.Image = new Bitmap(@"win_cross.png");
                button8.Image = new Bitmap(@"win_cross.png");
                button9.Image = new Bitmap(@"win_cross.png");
            }
            else if (button1.Text == " " && button4.Text == " " && button7.Text == " " && w1==null)
            {
                w1 = "P2";
                button1.Image = new Bitmap(@"win_cross_3.png");
                button4.Image = new Bitmap(@"win_cross_3.png");
                button7.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button2.Text == " " && button5.Text == " " && button8.Text == " " && w1==null)
            {
                w1 = "P2";
                button2.Image = new Bitmap(@"win_cross_3.png");
                button5.Image = new Bitmap(@"win_cross_3.png");
                button8.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button3.Text == " " && button6.Text == " " && button9.Text == " " && w1==null)
            {
                w1 = "P2";
                button3.Image = new Bitmap(@"win_cross_3.png");
                button6.Image = new Bitmap(@"win_cross_3.png");
                button9.Image = new Bitmap(@"win_cross_3.png");
            }

            else if (button1.Text == " " && button5.Text == " " && button9.Text == " " && w1 == null)
            {
                w1 = "P2";
                button1.Image = new Bitmap(@"win_cross_1.png");
                button5.Image = new Bitmap(@"win_cross_1.png");
                button9.Image = new Bitmap(@"win_cross_1.png");
            }

            else if (button3.Text == " " && button5.Text == " " && button7.Text == " " && w1 == null)
            {
                w1 = "P2";
                button3.Image = new Bitmap(@"win_cross_2.png");
                button5.Image = new Bitmap(@"win_cross_2.png");
                button7.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button1.Text == "  " && button2.Text == "  " && button3.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button1.Image = new Bitmap(@"win_zero.png");
                button2.Image = new Bitmap(@"win_zero.png");
                button3.Image = new Bitmap(@"win_zero.png");
            }
            else if (button4.Text == "  " && button5.Text == "  " && button6.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button4.Image = new Bitmap(@"win_zero.png");
                button5.Image = new Bitmap(@"win_zero.png");
                button6.Image = new Bitmap(@"win_zero.png");
            }
            else if (button7.Text == "  " && button8.Text == "  " && button9.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button7.Image = new Bitmap(@"win_zero.png");
                button8.Image = new Bitmap(@"win_zero.png");
                button9.Image = new Bitmap(@"win_zero.png");
            }
            else if (button1.Text == "  " && button4.Text == "  " && button7.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button1.Image = new Bitmap(@"win_zero_3.png");
                button4.Image = new Bitmap(@"win_zero_3.png");
                button7.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button2.Text == "  " && button5.Text == "  " && button8.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button2.Image = new Bitmap(@"win_zero_3.png");
                button5.Image = new Bitmap(@"win_zero_3.png");
                button8.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button3.Text == "  " && button6.Text == "  " && button9.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button3.Image = new Bitmap(@"win_zero_3.png");
                button6.Image = new Bitmap(@"win_zero_3.png");
                button9.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button1.Text == "  " && button5.Text == "  " && button9.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button1.Image = new Bitmap(@"win_zero_1.png");
                button5.Image = new Bitmap(@"win_zero_1.png");
                button9.Image = new Bitmap(@"win_zero_1.png");
            }
            else if (button3.Text == "  " && button5.Text == "  " && button7.Text == "  " && w1 == null)
            {
                w1 = "P1";
                button3.Image = new Bitmap(@"win_zero_2.png");
                button5.Image = new Bitmap(@"win_zero_2.png");
                button7.Image = new Bitmap(@"win_zero_2.png");
            }

            #endregion

            // Checked : No Error
            #region w2WinLogic

            if (button12.Text == " " && button11.Text == " " && button10.Text == " " && w2 == null)
            {
                w2 = "P2";
                button12.Image = new Bitmap(@"win_cross.png");
                button11.Image = new Bitmap(@"win_cross.png");
                button10.Image = new Bitmap(@"win_cross.png");
            }
            else if (button15.Text == " " && button14.Text == " " && button13.Text == " " && w2 == null)
            {
                w2 = "P2";
                button15.Image = new Bitmap(@"win_cross.png");
                button14.Image = new Bitmap(@"win_cross.png");
                button13.Image = new Bitmap(@"win_cross.png");
            }
            else if (button18.Text == " " && button17.Text == " " && button16.Text == " " && w2 == null)
            {
                w2 = "P2";
                button18.Image = new Bitmap(@"win_cross.png");
                button17.Image = new Bitmap(@"win_cross.png");
                button16.Image = new Bitmap(@"win_cross.png");
            }
            else if (button18.Text == " " && button15.Text == " " && button12.Text == " " && w2 == null)
            {
                w2 = "P2";
                button18.Image = new Bitmap(@"win_cross_3.png");
                button15.Image = new Bitmap(@"win_cross_3.png");
                button12.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button17.Text == " " && button14.Text == " " && button11.Text == " " && w2 == null)
            {
                w2 = "P2";
                button17.Image = new Bitmap(@"win_cross_3.png");
                button14.Image = new Bitmap(@"win_cross_3.png");
                button11.Image = new Bitmap(@"win_cross_3.png");
            }
            
            else if (button16.Text == " " && button13.Text == " " && button10.Text == " " && w2 == null)
            {
                w2 = "P2";
                button16.Image = new Bitmap(@"win_cross_3.png");
                button13.Image = new Bitmap(@"win_cross_3.png");
                button10.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button18.Text == " " && button14.Text == " " && button10.Text == " " && w2 == null)
            {
                w2 = "P2";
                button18.Image = new Bitmap(@"win_cross_1.png");
                button14.Image = new Bitmap(@"win_cross_1.png");
                button10.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button16.Text == " " && button14.Text == " " && button12.Text == " " && w2 == null)
            {
                w2 = "P2";
                button16.Image = new Bitmap(@"win_cross_2.png");
                button14.Image = new Bitmap(@"win_cross_2.png");
                button12.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button12.Text == "  " && button11.Text == "  " && button10.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button12.Image = new Bitmap(@"win_zero.png");
                button11.Image = new Bitmap(@"win_zero.png");
                button10.Image = new Bitmap(@"win_zero.png");
            }
            else if (button15.Text == "  " && button14.Text == "  " && button13.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button15.Image = new Bitmap(@"win_zero.png");
                button14.Image = new Bitmap(@"win_zero.png");
                button13.Image = new Bitmap(@"win_zero.png");
            }
            else if (button18.Text == "  " && button17.Text == "  " && button16.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button18.Image = new Bitmap(@"win_zero.png");
                button17.Image = new Bitmap(@"win_zero.png");
                button16.Image = new Bitmap(@"win_zero.png");
            }
            else if (button18.Text == "  " && button15.Text == "  " && button12.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button18.Image = new Bitmap(@"win_zero_3.png");
                button15.Image = new Bitmap(@"win_zero_3.png");
                button12.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button17.Text == "  " && button14.Text == "  " && button11.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button17.Image = new Bitmap(@"win_zero_3.png");
                button14.Image = new Bitmap(@"win_zero_3.png");
                button11.Image = new Bitmap(@"win_zero_3.png");
            }
            
            else if (button16.Text == "  " && button13.Text == "  " && button10.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button16.Image = new Bitmap(@"win_zero_3.png");
                button13.Image = new Bitmap(@"win_zero_3.png");
                button10.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button18.Text == "  " && button14.Text == "  " && button10.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button18.Image = new Bitmap(@"win_zero_1.png");
                button14.Image = new Bitmap(@"win_zero_1.png");
                button10.Image = new Bitmap(@"win_zero_1.png");
            }
            else if (button16.Text == "  " && button14.Text == "  " && button12.Text == "  " && w2 == null)
            {
                w2 = "P1";
                button16.Image = new Bitmap(@"win_zero_2.png");
                button14.Image = new Bitmap(@"win_zero_2.png");
                button12.Image = new Bitmap(@"win_zero_2.png");
            }


            #endregion

            // Checked : No Error
            #region w3WinLogic
            if (button27.Text == " " && button26.Text == " " && button25.Text == " " && w3 == null)
            {
                w3 = "P2";
                button27.Image = new Bitmap(@"win_cross.png");
                button26.Image = new Bitmap(@"win_cross.png");
                button25.Image = new Bitmap(@"win_cross.png");
            }
            else if (button24.Text == " " && button23.Text == " " && button22.Text == " " && w3 == null)
            {
                w3 = "P2";
                button24.Image = new Bitmap(@"win_cross.png");
                button23.Image = new Bitmap(@"win_cross.png");
                button22.Image = new Bitmap(@"win_cross.png");
            }
            else if (button21.Text == " " && button20.Text == " " && button19.Text == " " && w3 == null)
            {
                w3 = "P2";
                button21.Image = new Bitmap(@"win_cross.png");
                button20.Image = new Bitmap(@"win_cross.png");
                button19.Image = new Bitmap(@"win_cross.png");
            }
            else if (button27.Text == " " && button24.Text == " " && button21.Text == " " && w3 == null)
            {
                w3 = "P2";
                button27.Image = new Bitmap(@"win_cross_3.png");
                button24.Image = new Bitmap(@"win_cross_3.png");
                button21.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button26.Text == " " && button23.Text == " " && button20.Text == " " && w3 == null)
            {
                w3 = "P2";
                button26.Image = new Bitmap(@"win_cross_3.png");
                button23.Image = new Bitmap(@"win_cross_3.png");
                button20.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button25.Text == " " && button22.Text == " " && button19.Text == " " && w3 == null)
            {
                w3 = "P2";
                button25.Image = new Bitmap(@"win_cross_3.png");
                button22.Image = new Bitmap(@"win_cross_3.png");
                button19.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button27.Text == " " && button23.Text == " " && button19.Text == " " && w3 == null)
            {
                w3 = "P2";
                button27.Image = new Bitmap(@"win_cross_1.png");
                button23.Image = new Bitmap(@"win_cross_1.png");
                button19.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button25.Text == " " && button23.Text == " " && button21.Text == " " && w3 == null)
            {
                w3 = "P2";
                button25.Image = new Bitmap(@"win_cross_2.png");
                button23.Image = new Bitmap(@"win_cross_2.png");
                button21.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button27.Text == "  " && button26.Text == "  " && button25.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button27.Image = new Bitmap(@"win_zero.png");
                button26.Image = new Bitmap(@"win_zero.png");
                button25.Image = new Bitmap(@"win_zero.png");
            }
            else if (button24.Text == "  " && button23.Text == "  " && button22.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button24.Image = new Bitmap(@"win_zero.png");
                button23.Image = new Bitmap(@"win_zero.png");
                button22.Image = new Bitmap(@"win_zero.png");
            }
            else if (button21.Text == "  " && button20.Text == "  " && button19.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button21.Image = new Bitmap(@"win_zero.png");
                button20.Image = new Bitmap(@"win_zero.png");
                button19.Image = new Bitmap(@"win_zero.png");
            }
            else if (button27.Text == "  " && button24.Text == "  " && button21.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button27.Image = new Bitmap(@"win_zero_3.png");
                button24.Image = new Bitmap(@"win_zero_3.png");
                button21.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button26.Text == "  " && button23.Text == "  " && button20.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button26.Image = new Bitmap(@"win_zero_3.png");
                button23.Image = new Bitmap(@"win_zero_3.png");
                button20.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button25.Text == "  " && button22.Text == "  " && button19.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button25.Image = new Bitmap(@"win_zero_3.png");
                button22.Image = new Bitmap(@"win_zero_3.png");
                button19.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button27.Text == "  " && button23.Text == "  " && button19.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button27.Image = new Bitmap(@"win_zero_1.png");
                button23.Image = new Bitmap(@"win_zero_1.png");
                button19.Image = new Bitmap(@"win_zero_1.png");
            }
            else if (button25.Text == "  " && button23.Text == "  " && button21.Text == "  " && w3 == null)
            {
                w3 = "P1";
                button25.Image = new Bitmap(@"win_zero_2.png");
                button23.Image = new Bitmap(@"win_zero_2.png");
                button21.Image = new Bitmap(@"win_zero_2.png");
            }



#endregion

            #region w4WinLogic
            if (button36.Text == " " && button35.Text == " " && button34.Text == " " && w4 == null)
            {
                w4 = "P2";
                button36.Image = new Bitmap(@"win_cross.png");
                button35.Image = new Bitmap(@"win_cross.png");
                button34.Image = new Bitmap(@"win_cross.png");
            }
            else if (button33.Text == " " && button32.Text == " " && button31.Text == " " && w4 == null)
            {
                w4 = "P2";
                button33.Image = new Bitmap(@"win_cross.png");
                button32.Image = new Bitmap(@"win_cross.png");
                button31.Image = new Bitmap(@"win_cross.png");
            }
            else if (button30.Text == " " && button29.Text == " " && button28.Text == " " && w4 == null)
            {
                w4 = "P2";
                button30.Image = new Bitmap(@"win_cross.png");
                button29.Image = new Bitmap(@"win_cross.png");
                button28.Image = new Bitmap(@"win_cross.png");
            }

            else if (button36.Text == " " && button33.Text == " " && button30.Text == " " && w4 == null)
            {
                w4 = "P2";
                button36.Image = new Bitmap(@"win_cross_3.png");
                button33.Image = new Bitmap(@"win_cross_3.png");
                button30.Image = new Bitmap(@"win_cross_3.png");
            }

            else if (button35.Text == " " && button32.Text == " " && button29.Text == " " && w4 == null)
            {
                w4 = "P2";
                button35.Image = new Bitmap(@"win_cross_3.png");
                button32.Image = new Bitmap(@"win_cross_3.png");
                button29.Image = new Bitmap(@"win_cross_3.png");
            }

            else if (button34.Text == " " && button31.Text == " " && button28.Text == " " && w4 == null)
            {
                w4 = "P2";
                button36.Image = new Bitmap(@"win_cross_3.png");
                button33.Image = new Bitmap(@"win_cross_3.png");
                button30.Image = new Bitmap(@"win_cross_3.png");
            }

            else if (button36.Text == " " && button32.Text == " " && button28.Text == " " && w4 == null)
            {
                w4 = "P2";
                button36.Image = new Bitmap(@"win_cross_1.png");
                button32.Image = new Bitmap(@"win_cross_1.png");
                button28.Image = new Bitmap(@"win_cross_1.png");

            }

            else if (button34.Text == " " && button32.Text == " " && button30.Text == " " && w4 == null)
            {
                w4 = "P2";
                button34.Image = new Bitmap(@"win_cross_2.png");
                button32.Image = new Bitmap(@"win_cross_2.png");
                button30.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button36.Text == "  " && button35.Text == "  " && button34.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button36.Image = new Bitmap(@"win_zero.png");
                button35.Image = new Bitmap(@"win_zero.png");
                button34.Image = new Bitmap(@"win_zero.png");
            }
            else if (button33.Text == "  " && button32.Text == "  " && button31.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button33.Image = new Bitmap(@"win_zero.png");
                button32.Image = new Bitmap(@"win_zero.png");
                button31.Image = new Bitmap(@"win_zero.png");
            }
            else if (button30.Text == "  " && button29.Text == "  " && button28.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button30.Image = new Bitmap(@"win_zero.png");
                button29.Image = new Bitmap(@"win_zero.png");
                button28.Image = new Bitmap(@"win_zero.png");
            }

            else if (button36.Text == "  " && button33.Text == "  " && button30.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button36.Image = new Bitmap(@"win_zero_3.png");
                button33.Image = new Bitmap(@"win_zero_3.png");
                button30.Image = new Bitmap(@"win_zero_3.png");
            }

            else if (button35.Text == "  " && button32.Text == "  " && button29.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button35.Image = new Bitmap(@"win_zero_3.png");
                button32.Image = new Bitmap(@"win_zero_3.png");
                button29.Image = new Bitmap(@"win_zero_3.png");
            }

            else if (button34.Text == "  " && button31.Text == "  " && button28.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button36.Image = new Bitmap(@"win_zero_3.png");
                button33.Image = new Bitmap(@"win_zero_3.png");
                button30.Image = new Bitmap(@"win_zero_3.png");
            }

            else if (button36.Text == "  " && button32.Text == "  " && button28.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button36.Image = new Bitmap(@"win_zero_1.png");
                button32.Image = new Bitmap(@"win_zero_1.png");
                button28.Image = new Bitmap(@"win_zero_1.png");

            }

            else if (button34.Text == "  " && button32.Text == "  " && button30.Text == "  " && w4 == null)
            {
                w4 = "P1";
                button34.Image = new Bitmap(@"win_zero_2.png");
                button32.Image = new Bitmap(@"win_zero_2.png");
                button30.Image = new Bitmap(@"win_zero_2.png");
            }



            #endregion

            #region w5WinLogic
            if (button45.Text == " " && button44.Text == " " && button43.Text == " " && w5 == null)
            {
                w5 = "P2";
                button45.Image = new Bitmap(@"win_cross.png");
                button44.Image = new Bitmap(@"win_cross.png");
                button43.Image = new Bitmap(@"win_cross.png");
            }
            else if (button42.Text == " " && button41.Text == " " && button40.Text == " " && w5 == null)
            {
                w5 = "P2";
                button42.Image = new Bitmap(@"win_cross.png");
                button41.Image = new Bitmap(@"win_cross.png");
                button40.Image = new Bitmap(@"win_cross.png");
            }
            else if (button39.Text == " " && button38.Text == " " && button37.Text == " " && w5 == null)
            {
                w5 = "P2";
                button39.Image = new Bitmap(@"win_cross.png");
                button38.Image = new Bitmap(@"win_cross.png");
                button37.Image = new Bitmap(@"win_cross.png");
            }
            else if (button45.Text == " " && button42.Text == " " && button39.Text == " " && w5 == null)
            {
                w5 = "P2";
                button45.Image = new Bitmap(@"win_cross_3.png");
                button42.Image = new Bitmap(@"win_cross_3.png");
                button39.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button44.Text == " " && button41.Text == " " && button38.Text == " " && w5 == null)
            {
                w5 = "P2";
                button44.Image = new Bitmap(@"win_cross_3.png");
                button41.Image = new Bitmap(@"win_cross_3.png");
                button38.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button43.Text == " " && button40.Text == " " && button37.Text == " " && w5 == null)
            {
                w5 = "P2";
                button43.Image = new Bitmap(@"win_cross_3.png");
                button40.Image = new Bitmap(@"win_cross_3.png");
                button37.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button45.Text == " " && button41.Text == " " && button37.Text == " " && w5 == null)
            {
                w5 = "P2";
                button45.Image = new Bitmap(@"win_cross_1.png");
                button41.Image = new Bitmap(@"win_cross_1.png");
                button37.Image = new Bitmap(@"win_cross_1.png");
            }

            else if (button43.Text == " " && button41.Text == " " && button39.Text == " " && w5 == null)
            {
                w5 = "P2";
                button43.Image = new Bitmap(@"win_cross_2.png");
                button41.Image = new Bitmap(@"win_cross_2.png");
                button39.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button45.Text == "  " && button44.Text == "  " && button43.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button45.Image = new Bitmap(@"win_zero.png");
                button44.Image = new Bitmap(@"win_zero.png");
                button43.Image = new Bitmap(@"win_zero.png");
            }
            else if (button42.Text == "  " && button41.Text == "  " && button40.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button42.Image = new Bitmap(@"win_zero.png");
                button41.Image = new Bitmap(@"win_zero.png");
                button40.Image = new Bitmap(@"win_zero.png");
            }
            else if (button39.Text == "  " && button38.Text == "  " && button37.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button39.Image = new Bitmap(@"win_zero.png");
                button38.Image = new Bitmap(@"win_zero.png");
                button37.Image = new Bitmap(@"win_zero.png");
            }
            else if (button45.Text == "  " && button42.Text == "  " && button39.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button45.Image = new Bitmap(@"win_zero_3.png");
                button42.Image = new Bitmap(@"win_zero_3.png");
                button39.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button44.Text == "  " && button41.Text == "  " && button38.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button44.Image = new Bitmap(@"win_zero_3.png");
                button41.Image = new Bitmap(@"win_zero_3.png");
                button38.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button43.Text == "  " && button40.Text == "  " && button37.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button43.Image = new Bitmap(@"win_zero_3.png");
                button40.Image = new Bitmap(@"win_zero_3.png");
                button37.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button45.Text == "  " && button41.Text == "  " && button37.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button45.Image = new Bitmap(@"win_zero_1.png");
                button41.Image = new Bitmap(@"win_zero_1.png");
                button37.Image = new Bitmap(@"win_zero_1.png");
            }

            else if (button43.Text == "  " && button41.Text == "  " && button39.Text == "  " && w5 == null)
            {
                w5 = "P1";
                button43.Image = new Bitmap(@"win_zero_2.png");
                button41.Image = new Bitmap(@"win_zero_2.png");
                button39.Image = new Bitmap(@"win_zero_2.png");
            }

#endregion

            #region w6WinLogic
            if (button54.Text == " " && button53.Text == " " && button52.Text == " " && w6 == null)
            {
                w6 = "P2";
                button54.Image = new Bitmap(@"win_cross.png");
                button53.Image = new Bitmap(@"win_cross.png");
                button52.Image = new Bitmap(@"win_cross.png");
            }
            else if (button51.Text == " " && button50.Text == " " && button49.Text == " " && w6 == null)
            {
                w6 = "P2";
                button51.Image = new Bitmap(@"win_cross.png");
                button50.Image = new Bitmap(@"win_cross.png");
                button49.Image = new Bitmap(@"win_cross.png");
            }
            else if (button48.Text == " " && button47.Text == " " && button46.Text == " " && w6 == null)
            {
                w6 = "P2";
                button48.Image = new Bitmap(@"win_cross.png");
                button47.Image = new Bitmap(@"win_cross.png");
                button46.Image = new Bitmap(@"win_cross.png");
            }
            else if (button54.Text == " " && button51.Text == " " && button48.Text == " " && w6 == null)
            {
                w6 = "P2";
                button54.Image = new Bitmap(@"win_cross_3.png");
                button51.Image = new Bitmap(@"win_cross_3.png");
                button48.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button53.Text == " " && button50.Text == " " && button47.Text == " " && w6 == null)
            {
                w6 = "P2";
                button53.Image = new Bitmap(@"win_cross_3.png");
                button50.Image = new Bitmap(@"win_cross_3.png");
                button47.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button52.Text == " " && button49.Text == " " && button46.Text == " " && w6 == null)
            {
                w6 = "P2";
                button52.Image = new Bitmap(@"win_cross_3.png");
                button49.Image = new Bitmap(@"win_cross_3.png");
                button46.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button54.Text == " " && button50.Text == " " && button46.Text == " " && w6 == null)
            {
                w6 = "P2";
                button54.Image = new Bitmap(@"win_cross_1.png");
                button50.Image = new Bitmap(@"win_cross_1.png");
                button46.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button52.Text == " " && button50.Text == " " && button48.Text == " " && w6 == null)
            {
                w6 = "P2";
                button52.Image = new Bitmap(@"win_cross_2.png");
                button50.Image = new Bitmap(@"win_cross_2.png");
                button48.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button54.Text == "  " && button53.Text == "  " && button52.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button54.Image = new Bitmap(@"win_zero.png");
                button53.Image = new Bitmap(@"win_zero.png");
                button52.Image = new Bitmap(@"win_zero.png");
            }
            else if (button51.Text == "  " && button50.Text == "  " && button49.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button51.Image = new Bitmap(@"win_zero.png");
                button50.Image = new Bitmap(@"win_zero.png");
                button49.Image = new Bitmap(@"win_zero.png");
            }
            else if (button48.Text == "  " && button47.Text == "  " && button46.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button48.Image = new Bitmap(@"win_zero.png");
                button47.Image = new Bitmap(@"win_zero.png");
                button46.Image = new Bitmap(@"win_zero.png");
            }
            else if (button54.Text == "  " && button51.Text == "  " && button48.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button54.Image = new Bitmap(@"win_zero_3.png");
                button51.Image = new Bitmap(@"win_zero_3.png");
                button48.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button53.Text == "  " && button50.Text == "  " && button47.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button53.Image = new Bitmap(@"win_zero_3.png");
                button50.Image = new Bitmap(@"win_zero_3.png");
                button47.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button52.Text == "  " && button49.Text == "  " && button46.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button52.Image = new Bitmap(@"win_zero_3.png");
                button49.Image = new Bitmap(@"win_zero_3.png");
                button46.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button54.Text == "  " && button50.Text == "  " && button46.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button54.Image = new Bitmap(@"win_zero_1.png");
                button50.Image = new Bitmap(@"win_zero_1.png");
                button46.Image = new Bitmap(@"win_zero_1.png");
            }
            else if (button52.Text == "  " && button50.Text == "  " && button48.Text == "  " && w6 == null)
            {
                w6 = "P1";
                button52.Image = new Bitmap(@"win_zero_2.png");
                button50.Image = new Bitmap(@"win_zero_2.png");
                button48.Image = new Bitmap(@"win_zero_2.png");
            }
            #endregion

            #region w7WinLogic
            if (button63.Text == " " && button62.Text == " " && button61.Text == " " && w7 == null)
            {
                w7 = "P2";
                button63.Image = new Bitmap(@"win_cross.png");
                button62.Image = new Bitmap(@"win_cross.png");
                button61.Image = new Bitmap(@"win_cross.png");
            }
            else if (button60.Text == " " && button59.Text == " " && button58.Text == " " && w7 == null)
            {
                w7 = "P2";
                button60.Image = new Bitmap(@"win_cross.png");
                button59.Image = new Bitmap(@"win_cross.png");
                button58.Image = new Bitmap(@"win_cross.png");
            }
            else if (button57.Text == " " && button56.Text == " " && button55.Text == " " && w7 == null)
            {
                w7 = "P2";
                button57.Image = new Bitmap(@"win_cross.png");
                button56.Image = new Bitmap(@"win_cross.png");
                button55.Image = new Bitmap(@"win_cross.png");
            }
            else if (button63.Text == " " && button60.Text == " " && button57.Text == " " && w7 == null)
            {
                w7 = "P2";
                button63.Image = new Bitmap(@"win_cross_3.png");
                button60.Image = new Bitmap(@"win_cross_3.png");
                button57.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button62.Text == " " && button59.Text == " " && button56.Text == " " && w7 == null)
            {
                w7 = "P2";
                button62.Image = new Bitmap(@"win_cross_3.png");
                button59.Image = new Bitmap(@"win_cross_3.png");
                button56.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button61.Text == " " && button58.Text == " " && button55.Text == " " && w7 == null)
            {
                w7 = "P2";
                button61.Image = new Bitmap(@"win_cross_3.png");
                button58.Image = new Bitmap(@"win_cross_3.png");
                button55.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button61.Text == " " && button59.Text == " " && button57.Text == " " && w7 == null)
            {
                w7 = "P2";
                button61.Image = new Bitmap(@"win_cross_2.png");
                button58.Image = new Bitmap(@"win_cross_2.png");
                button55.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button63.Text == " " && button59.Text == " " && button55.Text == " " && w7 == null)
            {
                w7 = "P2";
                button63.Image = new Bitmap(@"win_cross_1.png");
                button59.Image = new Bitmap(@"win_cross_1.png");
                button55.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button63.Text == "  " && button62.Text == "  " && button61.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button63.Image = new Bitmap(@"win_zero.png");
                button62.Image = new Bitmap(@"win_zero.png");
                button61.Image = new Bitmap(@"win_zero.png");
            }
            else if (button60.Text == "  " && button59.Text == "  " && button58.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button60.Image = new Bitmap(@"win_zero.png");
                button59.Image = new Bitmap(@"win_zero.png");
                button58.Image = new Bitmap(@"win_zero.png");
            }
            else if (button57.Text == "  " && button56.Text == "  " && button55.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button57.Image = new Bitmap(@"win_zero.png");
                button56.Image = new Bitmap(@"win_zero.png");
                button55.Image = new Bitmap(@"win_zero.png");
            }
            else if (button63.Text == "  " && button60.Text == "  " && button57.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button63.Image = new Bitmap(@"win_zero_3.png");
                button60.Image = new Bitmap(@"win_zero_3.png");
                button57.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button62.Text == "  " && button59.Text == "  " && button56.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button62.Image = new Bitmap(@"win_zero_3.png");
                button59.Image = new Bitmap(@"win_zero_3.png");
                button56.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button61.Text == "  " && button58.Text == "  " && button55.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button61.Image = new Bitmap(@"win_zero_3.png");
                button58.Image = new Bitmap(@"win_zero_3.png");
                button55.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button61.Text == "  " && button59.Text == "  " && button57.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button61.Image = new Bitmap(@"win_zero_2.png");
                button58.Image = new Bitmap(@"win_zero_2.png");
                button55.Image = new Bitmap(@"win_zero_2.png");
            }
            else if (button63.Text == "  " && button59.Text == "  " && button55.Text == "  " && w7 == null)
            {
                w7 = "P1";
                button63.Image = new Bitmap(@"win_zero_1.png");
                button59.Image = new Bitmap(@"win_zero_1.png");
                button55.Image = new Bitmap(@"win_zero_1.png");
            }
            #endregion

            #region w8WinLogic
            if (button72.Text == " " && button71.Text == " " && button70.Text == " " && w8 == null)
            {
                w8 = "P2";
                button72.Image = new Bitmap(@"win_cross.png");
                button71.Image = new Bitmap(@"win_cross.png");
                button70.Image = new Bitmap(@"win_cross.png");
            }
            else if (button69.Text == " " && button68.Text == " " && button67.Text == " " && w8 == null)
            {
                w8 = "P2";
                button69.Image = new Bitmap(@"win_cross.png");
                button68.Image = new Bitmap(@"win_cross.png");
                button67.Image = new Bitmap(@"win_cross.png");
            }
            else if (button66.Text == " " && button65.Text == " " && button64.Text == " " && w8 == null)
            {
                w8 = "P2";
                button66.Image = new Bitmap(@"win_cross.png");
                button65.Image = new Bitmap(@"win_cross.png");
                button64.Image = new Bitmap(@"win_cross.png");
            }
            else if (button72.Text == " " && button69.Text == " " && button66.Text == " " && w8 == null)
            {
                w8 = "P2";
                button72.Image = new Bitmap(@"win_cross_3.png");
                button69.Image = new Bitmap(@"win_cross_3.png");
                button66.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button71.Text == " " && button68.Text == " " && button65.Text == " " && w8 == null)
            {
                w8 = "P2";
                button71.Image = new Bitmap(@"win_cross_3.png");
                button68.Image = new Bitmap(@"win_cross_3.png");
                button65.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button70.Text == " " && button67.Text == " " && button64.Text == " " && w8 == null)
            {
                w8 = "P2";
                button70.Image = new Bitmap(@"win_cross_3.png");
                button67.Image = new Bitmap(@"win_cross_3.png");
                button64.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button70.Text == " " && button68.Text == " " && button66.Text == " " && w8 == null)
            {
                w8 = "P2";
                button70.Image = new Bitmap(@"win_cross_2.png");
                button68.Image = new Bitmap(@"win_cross_2.png");
                button66.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button72.Text == " " && button68.Text == " " && button64.Text == " " && w8 == null)
            {
                w8 = "P2";
                button72.Image = new Bitmap(@"win_cross_1.png");
                button68.Image = new Bitmap(@"win_cross_1.png");
                button64.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button72.Text == "  " && button71.Text == "  " && button70.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button72.Image = new Bitmap(@"win_zero.png");
                button71.Image = new Bitmap(@"win_zero.png");
                button70.Image = new Bitmap(@"win_zero.png");
            }
            else if (button69.Text == "  " && button68.Text == "  " && button67.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button69.Image = new Bitmap(@"win_zero.png");
                button68.Image = new Bitmap(@"win_zero.png");
                button67.Image = new Bitmap(@"win_zero.png");
            }
            else if (button66.Text == "  " && button65.Text == "  " && button64.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button66.Image = new Bitmap(@"win_zero.png");
                button65.Image = new Bitmap(@"win_zero.png");
                button64.Image = new Bitmap(@"win_zero.png");
            }
            else if (button72.Text == "  " && button69.Text == "  " && button66.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button72.Image = new Bitmap(@"win_zero_3.png");
                button69.Image = new Bitmap(@"win_zero_3.png");
                button66.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button71.Text == "  " && button68.Text == "  " && button65.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button71.Image = new Bitmap(@"win_zero_3.png");
                button68.Image = new Bitmap(@"win_zero_3.png");
                button65.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button70.Text == "  " && button67.Text == "  " && button64.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button70.Image = new Bitmap(@"win_zero_3.png");
                button67.Image = new Bitmap(@"win_zero_3.png");
                button64.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button70.Text == "  " && button68.Text == "  " && button66.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button70.Image = new Bitmap(@"win_zero_2.png");
                button68.Image = new Bitmap(@"win_zero_2.png");
                button66.Image = new Bitmap(@"win_zero_2.png");
            }
            else if (button72.Text == "  " && button68.Text == "  " && button64.Text == "  " && w8 == null)
            {
                w8 = "P1";
                button72.Image = new Bitmap(@"win_zero_1.png");
                button68.Image = new Bitmap(@"win_zero_1.png");
                button64.Image = new Bitmap(@"win_zero_1.png");
            }
#endregion

            #region w9WinLogic
            if (button81.Text == " " && button80.Text == " " && button79.Text == " " && w9 == null)
            {
                w9 = "P2";
                button81.Image = new Bitmap(@"win_cross.png");
                button80.Image = new Bitmap(@"win_cross.png");
                button79.Image = new Bitmap(@"win_cross.png");
            }
            else if (button78.Text == " " && button77.Text == " " && button76.Text == " " && w9 == null)
            {
                w9 = "P2";
                button78.Image = new Bitmap(@"win_cross.png");
                button77.Image = new Bitmap(@"win_cross.png");
                button76.Image = new Bitmap(@"win_cross.png");
            }
            else if (button75.Text == " " && button74.Text == " " && button73.Text == " " && w9 == null)
            {
                w9 = "P2";
                button75.Image = new Bitmap(@"win_cross.png");
                button74.Image = new Bitmap(@"win_cross.png");
                button73.Image = new Bitmap(@"win_cross.png");
            }
            else if (button81.Text == " " && button78.Text == " " && button75.Text == " " && w9 == null)
            {
                w9 = "P2";
                button81.Image = new Bitmap(@"win_cross_3.png");
                button78.Image = new Bitmap(@"win_cross_3.png");
                button75.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button80.Text == " " && button77.Text == " " && button74.Text == " " && w9 == null)
            {
                w9 = "P2";
                button80.Image = new Bitmap(@"win_cross_3.png");
                button77.Image = new Bitmap(@"win_cross_3.png");
                button74.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button79.Text == " " && button76.Text == " " && button73.Text == " " && w9 == null)
            {
                w9 = "P2";
                button79.Image = new Bitmap(@"win_cross_3.png");
                button76.Image = new Bitmap(@"win_cross_3.png");
                button73.Image = new Bitmap(@"win_cross_3.png");
            }
            else if (button79.Text == " " && button77.Text == " " && button75.Text == " " && w9 == null)
            {
                w9 = "P2";
                button79.Image = new Bitmap(@"win_cross_2.png");
                button77.Image = new Bitmap(@"win_cross_2.png");
                button75.Image = new Bitmap(@"win_cross_2.png");
            }
            else if (button81.Text == " " && button77.Text == " " && button73.Text == " " && w9 == null)
            {
                w9 = "P2";
                button81.Image = new Bitmap(@"win_cross_1.png");
                button77.Image = new Bitmap(@"win_cross_1.png");
                button73.Image = new Bitmap(@"win_cross_1.png");
            }
            else if (button81.Text == "  " && button80.Text == "  " && button79.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button81.Image = new Bitmap(@"win_zero.png");
                button80.Image = new Bitmap(@"win_zero.png");
                button79.Image = new Bitmap(@"win_zero.png");
            }
            else if (button78.Text == "  " && button77.Text == "  " && button76.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button78.Image = new Bitmap(@"win_zero.png");
                button77.Image = new Bitmap(@"win_zero.png");
                button76.Image = new Bitmap(@"win_zero.png");
            }
            else if (button75.Text == "  " && button74.Text == "  " && button73.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button75.Image = new Bitmap(@"win_zero.png");
                button74.Image = new Bitmap(@"win_zero.png");
                button73.Image = new Bitmap(@"win_zero.png");
            }
            else if (button81.Text == "  " && button78.Text == "  " && button75.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button81.Image = new Bitmap(@"win_zero_3.png");
                button78.Image = new Bitmap(@"win_zero_3.png");
                button75.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button80.Text == "  " && button77.Text == "  " && button74.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button80.Image = new Bitmap(@"win_zero_3.png");
                button77.Image = new Bitmap(@"win_zero_3.png");
                button74.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button79.Text == "  " && button76.Text == "  " && button73.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button79.Image = new Bitmap(@"win_zero_3.png");
                button76.Image = new Bitmap(@"win_zero_3.png");
                button73.Image = new Bitmap(@"win_zero_3.png");
            }
            else if (button79.Text == "  " && button77.Text == "  " && button75.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button79.Image = new Bitmap(@"win_zero_2.png");
                button77.Image = new Bitmap(@"win_zero_2.png");
                button75.Image = new Bitmap(@"win_zero_2.png");
            }
            else if (button81.Text == "  " && button77.Text == "  " && button73.Text == "  " && w9 == null)
            {
                w9 = "P1";
                button81.Image = new Bitmap(@"win_zero_1.png");
                button77.Image = new Bitmap(@"win_zero_1.png");
                button73.Image = new Bitmap(@"win_zero_1.png");
            }
            #endregion

            fullWInCheck();
        }

        public void fullWInCheck() {
            if (w1 == "P1" && w2 == "P1" && w3 == "P1" || w4 == "P1" && w5 == "P1" && w6 == "P1" || w7 == "P1" && w8 == "P1" && w9 == "P1" || w1 == "P1" && w4 == "P1" && w7 == "P1" || w2 == "P1" && w5 == "P1" && w8 == "P1" || w3 == "P1" && w6 == "P1" && w9 == "P1" || w1 == "P1" && w5 == "P1" && w3 == "P9" || w3 == "P1" && w5 == "P1" && w7 == "P1")
            {
                MessageBox.Show("Player 1 Wins");
                Process.Start("http://www.socialblood.org");
                Application.Exit();
            }
            else if (w1 == "P2" && w2 == "P2" && w3 == "P2" || w4 == "P2" && w5 == "P2" && w6 == "P2" || w7 == "P2" && w8 == "P2" && w9 == "P2" || w1 == "P2" && w4 == "P2" && w7 == "P2" || w2 == "P2" && w5 == "P2" && w8 == "P2" || w3 == "P2" && w6 == "P2" && w9 == "P2" || w1 == "P2" && w5 == "P2" && w3 == "P9" || w3 == "P2" && w5 == "P2" && w7 == "P2")
            {
                MessageBox.Show("Player 2 Wins");
                Process.Start("http://www.socialblood.org");
                Application.Exit();
            }
        }

        public void highlightCheck() {
            if (c1 == true)
            {
                tableLayoutPanel2.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c2 == true)
            {
                tableLayoutPanel3.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c3 == true)
            {
                tableLayoutPanel4.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c4 == true)
            {
                tableLayoutPanel5.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c5 == true)
            {
                tableLayoutPanel6.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c6 == true)
            {
                tableLayoutPanel7.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c7 == true)
            {
                tableLayoutPanel8.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c8 == true)
            {
                tableLayoutPanel9.BackgroundImage = new Bitmap(@"highlight.png");
            }
            if (c9 == true)
            {
                tableLayoutPanel10.BackgroundImage = new Bitmap(@"highlight.png");
            }

        }   

        public void playTurn(Button buttonTest) 
        {
            
            if (buttonTest.Enabled == true)
            {
                if (PlayerTurn == 0)
                {
                    buttonTest.Image = new Bitmap(@"zero.png");
                    buttonTest.Text = "  ";
                                      
                }
                else if (PlayerTurn == 1)
                {
                    buttonTest.Image = new Bitmap(@"cross2.png");
                    buttonTest.Text = " ";
                }
                buttonTest.Enabled = false;
                
                changeTurn();
            }
            winCheck();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            lblTurn.Text = "Player 1 Turn";
            
            //tableLayoutPanel6.BackgroundImage=new Bitmap(@"highlight.png");
            Application.Idle += highlightCheck;
            pictureBox1.Image = new Bitmap(@"zero.png");
            pictureBox2.Image = new Bitmap(@"cross2.png");
            pictureBox3.Image = new Bitmap(@"banner.png");

            
        }

        private void highlightCheck(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                tableLayoutPanel2.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c2 == true)
            {
                tableLayoutPanel3.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c3 == true)
            {
                tableLayoutPanel4.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            

            }
            if (c4 == true)
            {
                tableLayoutPanel5.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            
            }
            if (c5 == true)
            {
                tableLayoutPanel6.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c6 == true)
            {
                tableLayoutPanel7.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c7 == true)
            {
                tableLayoutPanel8.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c8 == true)
            {
                tableLayoutPanel9.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
                tableLayoutPanel10.BackgroundImage = null;
            }
            if (c9 == true)
            {
                tableLayoutPanel10.BackgroundImage = new Bitmap(@"highlight.png");
                tableLayoutPanel2.BackgroundImage = null;
                tableLayoutPanel4.BackgroundImage = null;
                tableLayoutPanel3.BackgroundImage = null;
                tableLayoutPanel6.BackgroundImage = null;
                tableLayoutPanel7.BackgroundImage = null;
                tableLayoutPanel8.BackgroundImage = null;
                tableLayoutPanel9.BackgroundImage = null;
                tableLayoutPanel5.BackgroundImage = null;
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void changeTurn() {
            
            
            if (PlayerTurn == 0)
            {
                PlayerTurn = 1;
                lblTurn.Text = "Player 2 Turn";
                
            }
            else if (PlayerTurn == 1)
            {
                PlayerTurn = 0;
                lblTurn.Text = "Player 1 Turn";
            }
            
        
        }

       

        private void btReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        #region btEvents
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if (c1 == true)
            {
                playTurn(button1);
                button1.Enabled = false;
                c1 = true;
                
                
                lblFact.Text = "We should donate blood atleast twice a year,it does not affect our health.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(c1==true){
            playTurn(button2);
            button2.Enabled = false;
            c1 = false;
            c2 = true;
            lblFact.Text = "Save Tigers-Our Nations' Pride";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button3);
                button3.Enabled = false;
                c3 = true;
                c1 = false;
                lblFact.Text = "Save Electricity";
            } 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button4);
                button4.Enabled = false;
                c4 = true;
                c1 = false;
                lblFact.Text = "every part of the world is green if every heart of the human is green";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button5);
                button5.Enabled = false;
                c5 = true;
                c1 = false;
                lblFact.Text = "drugs doesnt pay, it costs your life";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button6);
                button6.Enabled = false;
                c6 = true;
                c1 = false;
                lblFact.Text = "One in five teens are in abusive relationships,Stop abusive ,Speak up";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button7);
                button7.Enabled = false;
                c7 = true;
                c1 = false;
                lblFact.Text = " Don't drink and drive .Dont be the devil spare the innocent";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button8);
                button8.Enabled = false;
                c8 = true;
                c1 = false;
                lblFact.Text = "Every child has dreams, Don't create it.Stand against child labour";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c1 == true)
            {
                playTurn(button9);
                button9.Enabled = false;
                c9 = true;
                c1 = false;
                lblFact.Text = "Between 25,000 and 50,000,species become extict every year";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button18);
                button18.Enabled = false;
                c1 = true;
                c2 = false;
                lblFact.Text = "Every five second a child dies,from hunger related disease";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(c2==true)
            playTurn(button17);
            button17.Enabled = false;
            c2 = true;
            lblFact.Text = "Spread facts not fear!! Remember people with AIDS need our care";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button10);
                button10.Enabled = false;
                c9 = true;
                c2 = false;
                lblFact.Text = "Is childbirth a disease? 4 out of 5 such moms can be saved by education and access to skilled care";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button11);
                button11.Enabled = false;
                c8 = true;
                c2 = false;
                lblFact.Text = "Only you can prevent the spread of malware";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button12);
                button12.Enabled = false;
                c7 = true;
                c2 = false;
                lblFact.Text = "2 million children die yearly from water and sanitation dieases. Whats your perspective?";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button13);
                button13.Enabled = false;
                c6 = true;
                c2 = false;
                lblFact.Text = "Don't let them loose hope. Children in Africa have to wlk over 5 miles to retrieve unsafe drinking water";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button14);
                button14.Enabled = false;
                c5 = true;
                c2 = false;
                lblFact.Text = "Defuse the situation before it explodes. Refrain from roadrage";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button15);
                button15.Enabled = false;
                c4 = true;
                c2 = false;
                lblFact.Text = "Don't waste food";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (c2 == true)
            {
                playTurn(button16);
                button16.Enabled = false;
                c3 = true;
                c2 = false;
                lblFact.Text = "ADHD is not a read disorder, it's a myth";

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button19);
                button19.Enabled = false;
                c9 = true;
                c3 = false;
                lblFact.Text = "One in six kids are sexually abused ,75% don't tell, speak up! Save a child save a life";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button20);
                button20.Enabled = false;
                c8 = true;
                c3 = false;
                lblFact.Text = "Poverty is what happens when people give up caring for one another";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button21);
                button21.Enabled = false;
                c7=true;
                c3=false;
                lblFact.Text = "27 million modern day slaves worldwide for sale. Will you be their voice";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button22);
                button22.Enabled = false;
                c6 = true;
                c3 = false;
                lblFact.Text = "Autism awareness is nothing without action. Pledge to act";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button23);
                button23.Enabled = false;
                c5 = true;
                lblFact.Text = "Doing good does your good";
                c3 = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button24);
                button24.Enabled = false;
                c4 = true;
                c3 = false;
                lblFact.Text = "Life's most persistent and urgent question is 'What are you doing for others";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button25);
                button25.Enabled = false;
                c3 = true;
                lblFact.Text = "Racism ruins life. Everyone is equal ,so why is it  still an issue";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button26);
                button26.Enabled = false;
                c2 = true;
                c3 = false;
                lblFact.Text = "Help shatter the myths of parkinsons";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (c3 == true)
            {
                playTurn(button27);
                button27.Enabled = false;
                c1 = true;
                c3 = false;
                lblFact.Text = "Ensure a brighter future, Save electricity everyday";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button28);
                button28.Enabled = false;
                c9 = true;
                c4 = false;
                lblFact.Text = "Don't be a pirate. Stolen software may steal your identity";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button29);
                button29.Enabled = false;
                c8 = true;
                c4 = false;
                lblFact.Text = "Speak up and reach out.Prevent suicide";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button30);
                button30.Enabled = false;
                c7 = true;
                c4 = false;
                lblFact.Text = "No girl means no future.Understand their value and bear the consequences";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button31);
                button31.Enabled = false;
                c6 = true;
                c4 = false;
                lblFact.Text = "Say no to fastfood , Obesity can led to coronery heart disease,type 2 diabetes and liver disease";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button32);
                button32.Enabled = false;
                c5 = true;
                c4 = false;
                lblFact.Text = "Do for 1 ,what you wish you could do for 100";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button33);
                button33.Enabled = false;
                c4 = true;
                lblFact.Text = "Do justly love mercy walk hungry";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button34);
                button34.Enabled = false;
                c3 = true;
                c4 = false;
                lblFact.Text = "Change happens when enough people speak up in the same voice";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button35);
                button35.Enabled = false;
                c2 = true;
                c4 = false;
                lblFact.Text = "Our lifes begin to end the day we become silent about things that matter";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (c4 == true)
            {
                playTurn(button36);
                button36.Enabled = false;
                c1 = true;
                c4 = false;
                lblFact.Text = "You may choose to look the other way but you can never say again that you didn't know";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button37);
                button37.Enabled = false;
                c9 = true;
                c5 = false;
                lblFact.Text = "What breaks you heart above the world? act on that!";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button38);
                button38.Enabled = false;
                c8 = true;
                c5 = false;
                lblFact.Text = "Charity goves but justice changes";
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button39);
                button39.Enabled = false;
                c7 = true;
                c5 = false;
                lblFact.Text = "";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button40);
                button40.Enabled = false;
                c6 = true;
                c5 = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button41);
                button41.Enabled = false;
                c5 = true;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button42);
                button42.Enabled = false;
                c4 = true;
                c5 = false;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button43);
                button43.Enabled = false;
                c3 = true;
                c5 = false;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button44);
                button44.Enabled = false;
                c2 = true;
                c5 = false;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (c5 == true)
            {
                playTurn(button45);
                button45.Enabled = false;
                c1 = true;
                c5 = false;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button46);
                button46.Enabled = false;
                c9 = true;
                c6 = false;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button47);
                button47.Enabled = false;
                c8 = true;
                c6 = false;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button48);
                button48.Enabled = false;
                c7 = true;
                c6 = false;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button49);
                button49.Enabled = false;
                c6 = true;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button50);
                button50.Enabled = false;
                c5 = true;
                c6 = false;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button51);
                button51.Enabled = false;
                c4 = true;
                c6 = false;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button52);
                button52.Enabled = false;
                c3 = true;
                c6 = false;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button53);
                button53.Enabled = false;
                c2 = true;
                c6 = false;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (c6 == true)
            {
                playTurn(button54);
                button54.Enabled = false;
                c1 = true;
                c6 = false;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button55);
                button55.Enabled = false;
                c9 = true;
                c7 = false;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button56);
                button56.Enabled = false;
                c8 = true;
                c7 = false;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button57);
                button57.Enabled = false;
                c7 = true;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button58);
                button58.Enabled = false;
                c6 = true;
                c7 = false;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button59);
                button59.Enabled = false;
                c5 = true;
                c7 = false;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button60);
                button60.Enabled = false;
                c4 = true;
                c7 = false;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button61);
                button61.Enabled = false;
                c3 = true;
                c7 = false;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button62);
                button62.Enabled = false;
                c2 = true;
                c7 = false;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (c7 == true)
            {
                playTurn(button63);
                button63.Enabled = false;
                c1 = true;
                c7 = false;
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button64);
                button64.Enabled = false;
                c9 = true;
                c8 = false;
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {

                playTurn(button65);
                button65.Enabled = false;
                c8 = true;

            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button66);
                button66.Enabled = false;
                c7 = true;
                c8 = false;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {

                playTurn(button67);
                button67.Enabled = false;
                c6 = true;
                c8 = false;
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {

                playTurn(button68);
                button68.Enabled = false;
                c5 = true;
                c8 = false;
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button69);
                button69.Enabled = false;
                c4 = true;
                c8 = false;
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button70);
                button70.Enabled = false;
                c3 = true;
                c8 = false;
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button71);
                button71.Enabled = false;
                c2 = true;
                c8 = false;
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (c8 == true)
            {
                playTurn(button72);
                button72.Enabled = false;
                c1 = true;
                c8 = false;
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if(c9==true)
            {
            playTurn(button73);
            button73.Enabled = false;
                c9=true;
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button74);
                button74.Enabled = false;
                c8 = true;
                c9 = false;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {

                playTurn(button75);
                button75.Enabled = false;
                c7 = true;
                c9 = false;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button76);
                button76.Enabled = false;
                c6 = true;
                c9 = false;
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button77);
                button77.Enabled = false;
                c5 = true;
                c9 = false;
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button78);
                button78.Enabled = false;
                c4 = true;
                c9 = false;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button79);
                button79.Enabled = false;
                c3 = true;
                c9 = false;
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button80);
                button80.Enabled = false;
                c2 = true;
                c9 = false;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (c9 == true)
            {
                playTurn(button81);
                button81.Enabled = false;
                c1 = true;
                c9 = false;
            }
        }
        #endregion

    }
}
