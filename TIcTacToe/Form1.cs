using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIcTacToe
{
    public partial class Form1 : Form
    {
        private string Turn = "X";//to change turns
        private int etat = 0;//to count current state
        private int Xscore = 0;//to count X score
        private int Oscore = 0;//to count O score
        private bool winner=false;
        public Form1()
        {
            InitializeComponent();
        }
//-----------------------------Design Changes--------------------------------
        private void changeTurn() //to frequently change Turns
        {
            if (Turn == "X") Turn = "O";
            else Turn = "X";
        }
        private void changeButton(Button b) //change buttons text and design
        {
            if (b.Text == "")
            {
                if (Turn == "O")
                {
                    b.ForeColor = Color.FromArgb(242, 235, 211);
                }
                b.Text = Turn;
                changeTurn();
                Borderchange();
                etat++;
            }
            state.Text=Turn+" Turn";
        }
        private void ButtonReset(Button b)//Reset button to its normal state
        {
            b.Text = "";
            b.ForeColor = Color.FromArgb(84, 84, 84);
        }
        private void Borderchange()
        {
            if (Turn == "X")
            {
                //change bordersize
                X.FlatAppearance.BorderSize = 3;
                O.FlatAppearance.BorderSize = 1;
                //change colorsize
                X.FlatAppearance.BorderColor = Color.FromArgb(13, 161, 146);
                O.FlatAppearance.BorderColor = default(Color);
            }
            else
            {
                //change bordersize
                O.FlatAppearance.BorderSize = 3;
                X.FlatAppearance.BorderSize = 1;
                //change colorsize
                O.FlatAppearance.BorderColor = Color.FromArgb(13, 161, 146);
                X.FlatAppearance.BorderColor = default(Color);
            }
        }
        private void Message(string m) //do the work of MessageBox
        {
            MessageBox.Enabled = true;
            MessageBox.Visible = true;
            MessageBox.Width = 394; MessageBox.Height = 252;
            MessageBox.Location = new Point(203, 128);
            MessageBox.Text = m;
        }

//____________________________________________________________________________

//-------------------------------------test winner-------------------------------------
        private bool checkwinner()
        {
            //test lignes
            if ((b00.Text == b01.Text) && (b01.Text == b02.Text) && b02.Text != "")  return true;
            else if ((b10.Text == b11.Text) && (b11.Text == b12.Text) && b12.Text != "") return true;
            else if ((b20.Text == b21.Text) && (b21.Text == b22.Text) && b22.Text != "") return true;

            //test colones
            else if ((b00.Text == b10.Text) && (b10.Text == b20.Text) && b20.Text != "") return true;
            else if ((b01.Text == b11.Text) && (b11.Text == b21.Text) && b21.Text != "") return true;
            else if ((b02.Text == b12.Text) && (b12.Text == b22.Text) && b22.Text != "") return true;

            //test diagonale
            else if ((b00.Text == b11.Text) && (b11.Text == b22.Text) && b22.Text != "") return true;
            else if ((b20.Text == b11.Text) && (b11.Text == b02.Text) && b02.Text != "") return true;
            return false;
        }
        private void Winner()
        {
            if (etat >= 5) //to avoid testing the winner from the start of the game
            {
                if (checkwinner()==true)
                {
                    winner = true;
                    changeTurn();
                    if (winner)
                    {
                        if (Turn == "X") X.Text = Convert.ToString(++Xscore);
                        else O.Text = Convert.ToString(++Oscore);
                    }
                    state.Text = "Game Over";
                    Message(Turn + "\nWon!");
                }
            }
            if (etat == 9 && winner == false)  //that means that all the colones are taken
            {
                state.Text = "Game Over";
                Message("Draw!");            
            }
        }
//_______________________________________________________________________________________

//----------------------------------Buttons-------------------------------------

    //------------------------Restart button------------------------
        private void Restart_Click(object sender, EventArgs e)
        {
            if (winner==false)
            {
                Xscore = 0;
                Oscore = 0;
                X.Text = "- ";
                O.Text = "- ";
                Turn = "X";
            }
            else
            {
                changeTurn();
            }
            ButtonReset(b00); ButtonReset(b01); ButtonReset(b02);
            ButtonReset(b10); ButtonReset(b11); ButtonReset(b12);
            ButtonReset(b20); ButtonReset(b21); ButtonReset(b22);
            etat = 0;
            winner = false;
            state.Text = "Click to start";
            Borderchange();
        }
        //_______________________________________________________________

        //-------------------------Colone buttons-------------------------
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            changeButton(btn);

            Winner();
        }
        
    //_______________________________________________________________

    //-------------------------Score buttons-------------------------
        private void X_Click(object sender, EventArgs e)
        {
            if (etat == 0)
            {
                Turn = "X";
                X.FlatAppearance.BorderColor = Color.FromArgb(13, 161, 146);
                X.FlatAppearance.BorderSize = 2;
                
            }
        }
        private void O_Click(object sender, EventArgs e)
        {
            if (etat == 0)
            {
                Turn = "O";
                O.FlatAppearance.BorderColor = Color.FromArgb(13, 161, 146);
                O.FlatAppearance.BorderSize = 2;
            }
        }
        //_______________________________________________________________

        //______________________________________________________________________________
        private void Form1_Load(object sender, EventArgs e)
        {
            X.FlatStyle = FlatStyle.Flat;
            O.FlatStyle = FlatStyle.Flat;
            MessageBox.FlatStyle = FlatStyle.Flat;
            //remobe MessageBox Border
            MessageBox.FlatAppearance.BorderSize = 0;
            //remove hover from buttons X O MessageBox
            X.FlatAppearance.MouseOverBackColor = X.BackColor;
            O.FlatAppearance.MouseOverBackColor = O.BackColor;
            MessageBox.FlatAppearance.MouseOverBackColor = MessageBox.BackColor;
        }

        private void MessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Enabled = false;
            MessageBox.Visible = false;
            Restart_Click(Restart, EventArgs.Empty);
        }
        private void MessageBox_MouseHover(object sender, EventArgs e)
        {
            MessageBox.BackColor= Color.FromArgb(20, 189, 172);
        }

        
    }
}
