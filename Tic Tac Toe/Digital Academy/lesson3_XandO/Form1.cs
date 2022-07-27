namespace lesson3_XandO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public void Victory_Check(int count)
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label4.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button9.Text == "X" && button6.Text == "X" && button3.Text == "X")
            {

                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label5.Text);
                if (i == 4)
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label5.Text = Convert.ToString(i);
                }
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button9.Text == "O" && button6.Text == "O" && button3.Text == "O")
            {

                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button10.Enabled = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                int i = int.Parse(label6.Text);
                if (i == 4)
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
                else
                {
                    i++;
                    label6.Text = Convert.ToString(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;

            if (button1.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button1.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button2.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button2.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button3.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button3.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button4.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button4.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button5.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button5.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button6.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button6.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button8.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button7.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button7.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button9.Text == "")
                count++;


            if (button8.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button8.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (button1.Text == "")
                count++;
            if (button2.Text == "")
                count++;
            if (button3.Text == "")
                count++;
            if (button4.Text == "")
                count++;
            if (button5.Text == "")
                count++;
            if (button6.Text == "")
                count++;
            if (button7.Text == "")
                count++;
            if (button8.Text == "")
                count++;

            if (button9.Text == "")
            {
                count++;

                if (label1.Text == "Игрок 1 (X)")
                {
                    if (count % 2 != 0)
                        button9.Text = "X";
                    else
                        ((Button)sender).Text = "O";
                    Victory_Check(count);
                }
                else if (label2.Text == "Игрок 2 (O)")
                {
                    if (count % 2 != 0)
                        ((Button)sender).Text = "O";
                    else
                        ((Button)sender).Text = "X";
                    Victory_Check(count);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }
    }
}