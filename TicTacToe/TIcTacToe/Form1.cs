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
        private string Turn = "X";
        private int etat = 0;
        private int Xscore = 0;
        private int Oscore = 0;
        private bool winner=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void changeTurn()
        {
            if (Turn == "X") Turn = "O";
            else Turn = "X";
        }
        private void changeButton(Button b)
        {
            if (b.Text == "")
            {
                if (Turn == "O")
                {
                    b.ForeColor = Color.FromArgb(242, 235, 211);
                }
                b.Text = Turn;
                changeTurn();
                etat++;
            }
            state.Text=Turn+" Turn";
        }
        private void ButtonReset(Button b)
        {
            b.Text = "";
            b.ForeColor = Color.FromArgb(84, 84, 84);
        }
        private bool checkwinner()
        {
            //test lignes
            if ((b00.Text == b01.Text) && (b01.Text == b02.Text) && b02.Text != "") return true;
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
            if (etat >= 5)
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
                    MessageBox.Show(Turn + " Winner!");
                    Restart_Click(Restart, EventArgs.Empty);
                }
            }
            if(etat == 9)
            {
                state.Text = "Game Over";
                MessageBox.Show("Draw!");
                Restart_Click(Restart, EventArgs.Empty);
            }
        }
        
        private void Restart_Click(object sender, EventArgs e)
        {
            if (winner == false)
            {
                X.Text = "- ";
                O.Text = "- ";
                Turn = "X";
                state.Text = "Click to start";
            }
            else
            {
                changeTurn();
                state.Text = Turn + " Turn";
            }
            ButtonReset(b00); ButtonReset(b01); ButtonReset(b02);
            ButtonReset(b10); ButtonReset(b11); ButtonReset(b12);
            ButtonReset(b20); ButtonReset(b21); ButtonReset(b22);
            etat = 0;
            winner = false;
            
        }

        private void b00_Click(object sender, EventArgs e)
        {
            changeButton(b00);
            Winner();
        }
        private void b01_Click(object sender, EventArgs e)
        {
            changeButton(b01);
            Winner();
        }
        private void b02_Click(object sender, EventArgs e)
        {
            changeButton(b02);
            Winner();
        }
        private void b10_Click(object sender, EventArgs e)
        {
            changeButton(b10);
            Winner();
        }
        private void b11_Click(object sender, EventArgs e)
        {
            changeButton(b11);
            Winner();
        }
        private void b12_Click(object sender, EventArgs e)
        {
            changeButton(b12);
            Winner();
        }
        private void b20_Click(object sender, EventArgs e)
        {
            changeButton(b20);
            Winner();
        }
        private void b21_Click(object sender, EventArgs e)
        {
            changeButton(b21);
            Winner();
        }
        private void b22_Click(object sender, EventArgs e)
        {
            changeButton(b22);
            Winner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (etat == 0)
            {
                Turn = "X";
            }
        }

        private void O_Click(object sender, EventArgs e)
        {
            if (etat == 0)
            {
                Turn = "O";
            }
        }
    }
}
