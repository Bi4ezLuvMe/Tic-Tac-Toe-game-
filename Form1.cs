using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace tic_tac_toe
{

    public partial class TicTacToe : Form
    {
        public int Counter = 0;
        List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9};
        public TicTacToe()
        {
            InitializeComponent();
        }
        private bool isDraw()
        {
            if(button2.Text != "-"&& button3.Text != "-" && button4.Text != "-" && button5.Text != "-" && button6.Text != "-" && button7.Text != "-" && button8.Text != "-" && button9.Text != "-" && button10.Text != "-")
            {
                return true;
            }
            return false;
        }
        private bool isComputerWon()
        {
            if(button2.Text == "O"&& button3.Text == "O" && button4.Text == "O")
            {
                return true;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                return true;
            }
            if (button8.Text == "O" && button9.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button4.Text == "O" && button7.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button2.Text == "O" && button6.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button4.Text == "O" && button6.Text == "O" && button8.Text == "O")
            {
                return true;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                return true;
            }
            if (button5.Text == "O" && button6.Text == "O" && button7.Text == "O")
            {
                return true;
            }
            return false;
        }
        private bool isHumanWon()
        {
            if (button2.Text == "X" && button3.Text == "X" && button4.Text == "X")
            {
                return true;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                return true;
            }
            if (button8.Text == "X" && button9.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button4.Text == "X" && button7.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button2.Text == "X" && button6.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button4.Text == "X" && button6.Text == "X" && button8.Text == "X")
            {
                return true;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                return true;
            }
            if (button5.Text == "X" && button6.Text == "X" && button7.Text == "X")
            {
                return true;
            }
            return false;
        }
        private void Computer()
        {
            Random random = new Random();
            int index = random.Next(numbers.Count);
            switch (index)
            {
                case 0:Text(GetNumber(0)); numbers.RemoveAt(0); break;
                case 1: Text(GetNumber(1)); numbers.RemoveAt(1); break;
                case 2: Text(GetNumber(2)); numbers.RemoveAt(2); break;
                case 3: Text(GetNumber(3)); numbers.RemoveAt(3); break;
                case 4: Text(GetNumber(4)); numbers.RemoveAt(4); break;
                case 5: Text(GetNumber(5)); numbers.RemoveAt(5); break;
                case 6: Text(GetNumber(6)); numbers.RemoveAt(6); break;
                case 7: Text(GetNumber(7)); numbers.RemoveAt(7); break;
                case 8: Text(GetNumber(8)); numbers.RemoveAt(8); break;
            }
            int GetNumber(int index1)
            {
                if (numbers.ElementAt(index1) == 1)
                {
                    return 1;
                }else if(numbers.ElementAt(index1) == 2)
                {
                    return 2;
                }
                else if (numbers.ElementAt(index1) == 3)
                {
                    return 3;
                }
                else if (numbers.ElementAt(index1) == 4)
                {
                    return 4;
                }
                else if (numbers.ElementAt(index1) == 5)
                {
                    return 5;
                }
                else if (numbers.ElementAt(index1) == 6)
                {
                    return 6;
                }
                else if (numbers.ElementAt(index1) == 7)
                {
                    return 7;
                }
                else if (numbers.ElementAt(index1) == 8)
                {
                    return 8;
                }
                else if (numbers.ElementAt(index1) == 9)
                {
                    return 9;
                }
                return 0;
            }
            void Text(int index2)
            {
                switch (index2)
                {
                    case 1:button2.Text = "O"; button2.IsAccessible = false; break;
                    case 2: button3.Text = "O"; button3.IsAccessible = false; break;
                    case 3: button4.Text = "O"; button4.IsAccessible = false; break;
                    case 4: button5.Text = "O"; button5.IsAccessible = false; break;
                    case 5: button6.Text = "O"; button6.IsAccessible = false; break;
                    case 6: button7.Text = "O"; button7.IsAccessible = false; break;
                    case 7: button8.Text = "O"; button8.IsAccessible = false; break;
                    case 8: button9.Text = "O"; button9.IsAccessible = false; break;
                    case 9: button10.Text = "O"; button10.IsAccessible = false; break;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "-")
            {
                button2.Text = "X";
                numbers.Remove(1);
                button2.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "-")
            {
                button3.Text = "X";
                numbers.Remove(2);
                button3.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "-")
            {
                button4.Text = "X";
                     numbers.Remove(3); 
                button4.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "-")
            {
                button5.Text = "X";
                numbers.Remove(4);
                button5.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                   
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "-")
            {
                button6.Text = "X";
                numbers.Remove(5);
                button6.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "-")
            {
                button7.Text = "X";
                numbers.Remove(6);
                button7.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "-")
            {
                button8.Text = "X";
                numbers.Remove(7);
                button8.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "-")
            {
                button9.Text = "X";
                numbers.Remove(8);
                button9.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "-")
            {
                button10.Text = "X";
                numbers.Remove(9);
                button10.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
