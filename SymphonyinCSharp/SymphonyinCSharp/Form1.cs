namespace SymphonyinCSharp
{
    public partial class Symphony : Form
    {
        int gravity = 8;
        int noteSpeed = 5;
        int score = 0;
        int manSpeed = 0;



        public Symphony()
        {
            InitializeComponent();
            label1.Text = "welcome to symphony \npress space to begin";
            scoreText.Visible = false;
            noteOne.Visible = false;
            noteTwo.Visible = false;
            noteThree.Visible = false;
            noteFour.Visible = false;
            noteFive.Visible = false;
            singMan.Visible = false;
            label3.Visible = false;
        }

        private void Symphony_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void timerHalt(object sender, EventArgs e)
        {
            scoreText.Text = score.ToString();
            

            singMan.Top += gravity;
            noteOne.Left -= noteSpeed;
            noteTwo.Left -= noteSpeed;
            noteThree.Left -= noteSpeed;
            noteFour.Left -= noteSpeed;
            noteFive.Left -= noteSpeed;
            singMan.Left += manSpeed;

            if (singMan.Bounds.IntersectsWith(noteOne.Bounds) ||
                    singMan.Bounds.IntersectsWith(noteTwo.Bounds) ||
                    singMan.Bounds.IntersectsWith(noteThree.Bounds) ||
                    singMan.Bounds.IntersectsWith(noteFour.Bounds) ||
                    singMan.Bounds.IntersectsWith(noteFive.Bounds) ||
                    singMan.Bounds.IntersectsWith(topEnd.Bounds) ||
                    singMan.Bounds.IntersectsWith(endBox.Bounds) ||
                    singMan.Bounds.IntersectsWith(rightBox.Bounds) ||
                    singMan.Bounds.IntersectsWith(leftBox.Bounds)
                    )
            {
                endGame();

            }

            if (score > 15)
            {
                noteSpeed = 8;
            }
            if (score >25)
            {
                noteSpeed = 11;
            }
            if (score > 40)
            { 
                noteSpeed = 14; 
            
            }
            if (score > 50)
            {
                noteSpeed = 16;
            }
            if (score > 60)
            {
                noteSpeed = 20;
            }
            if (score > 70)
            {
                noteSpeed = 25;
            }
            if (score > 80)
            {
                noteSpeed = 28;
            }
            if (score > 90)
            {
                noteSpeed = 35;
            }
            if (score > 100)
            {
                noteSpeed = 40;
            }
            if (score > 110)
            {
                noteSpeed = 45;
            }
            if (score > 120)
            {
                noteSpeed = 50;
            }
            if (score > 130)
            {
                noteSpeed = 55;
            }
            if (score > 140)
            {
                noteSpeed = 60;
            }
           // if  (score > 150)
           // {
            //    wonGame();
            //
            //}

// this is the notes
            if (noteThree.Left < -50)
            {
                noteThree.Left = 660;
                score++;
            }

            if (noteTwo.Left <-50)
            {
                noteTwo.Left = 730;
                score++;
            }
            if (noteFour.Left < -50)
            {
                noteFour.Left = 714;
                score++;
            }

            if (noteFive.Left < -50)
            {
                noteFive.Left = 680;
                score++;
            }

            if (noteOne.Left < -50)
            {
                noteOne.Left = 690;
                score++;
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -8;
            }
            if (e.KeyCode == Keys.Down)
            {
                gravity = 10;
            }
           // if (e.KeyCode == Keys.Right)
            //{
               // manSpeed = 10;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
              // manSpeed = -10;
           //}

            if (e.KeyCode == Keys.Escape)
            {
                timer1.Start();
                label1.Text = "symphony";
                score = 0;
                manSpeed = 0;
                gravity = 0;
                noteSpeed = 5;
                singMan.Left = 35;
                singMan.Top = 203;
                scoreText.Visible = true;
                noteOne.Visible = true;
                noteTwo.Visible = true;
                noteThree.Visible = true;
                noteFour.Visible = true;
                noteFive.Visible = true;
                singMan.Visible = true;
                label3.Visible = false;

            }
            if (e.KeyCode == Keys.Space)
            {
                timer1.Start();
                score = 0;
                manSpeed = 0;
                gravity = 0;
                noteSpeed = 5;
                singMan.Left = 35;
                singMan.Top = 203;
                label1.Text = "symphony";
                scoreText.Visible = true;
                noteOne.Visible = true;
                noteTwo.Visible = true;
                noteThree.Visible = true;
                noteFour.Visible = true;
                noteFive.Visible = true;
                singMan.Visible = true;
                label3.Visible = false;
                singMan.Left = 35;
                singMan.Top = 203;

            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 8;
            }
            if (e.KeyCode == Keys.Down)
            {
                gravity = 8;
            }
            //if (e.KeyCode == Keys.Right)
            //{
              //manSpeed = 0;
            //}
             //if (e.KeyCode == Keys.Left)
            //{
               //manSpeed = 0;
            //}


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void box22_Click(object sender, EventArgs e)
        {

        }

        private void box10_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            timer1.Stop();
            singMan.Left = 35;
            singMan.Top = 203;
            label1.Text = "game over! \npress space to play again";
            if (singMan.Bounds.IntersectsWith(noteOne.Bounds))
            {
                noteOne.Left = 700;
            }
            if (singMan.Bounds.IntersectsWith(noteTwo.Bounds))
            {
                noteTwo.Left = 700;
            }
            if (singMan.Bounds.IntersectsWith(noteThree.Bounds))
            {
                noteThree.Left = 700;
            }
            if (singMan.Bounds.IntersectsWith(noteFour.Bounds))
            {
                noteFour.Left = 700;
            }
            if (singMan.Bounds.IntersectsWith(noteFive.Bounds))
            {
                noteFive.Left = 700;
            }

            if (noteOne.Left < 150)
            {
                noteOne.Left = 600;
            }
            if (noteTwo.Left < 150)
            {
                noteTwo.Left = 700;
            }
            if (noteThree.Left < 150)
            {
                noteThree.Left = 550;
            }
            if (noteFour.Left < 150)
            {
                noteFour.Left = 800;
            }
            if (noteFive.Left < 150)
            {
                noteFive.Left = 620;
            }
            label3.Visible = true;
            scoreText.Visible = false;
            noteOne.Visible = false;
            noteTwo.Visible = false;
            noteThree.Visible = false;
            noteFour.Visible = false;
            noteFive.Visible = false;
            singMan.Visible = false;
            label3.Text = score.ToString();

        }

        //private void wonGame()
        //{
          //  timer1.Stop();
            //singMan.Left = 35;
            //singMan.Top = 203;
            //label3.Text = score.ToString();
            //label1.Text = "you're the master now. \npress space to play again.";
            //if (singMan.Bounds.IntersectsWith(noteOne.Bounds))
            //{
              //  noteOne.Left = 700;
            //}
            //if (singMan.Bounds.IntersectsWith(noteTwo.Bounds))
            //{
              //  noteTwo.Left = 700;
            //}
            //if (singMan.Bounds.IntersectsWith(noteThree.Bounds))
            //{
              //  noteThree.Left = 700;
            //}
            //if (singMan.Bounds.IntersectsWith(noteFour.Bounds))
            //{
              //  noteFour.Left = 700;
            //}
           // if (singMan.Bounds.IntersectsWith(noteFive.Bounds))
           // {
             //   noteFive.Left = 700;
           // }
            //label3.Visible = true;
            //scoreText.Visible = false;
           // noteOne.Visible = false;
           // noteTwo.Visible = false;
           //noteThree.Visible = false;
           // noteFour.Visible = false;
            //noteFive.Visible = false;
            //singMan.Visible = false;
           
        }



    //private void keyHalt(object sender, EventArgs e)
//}
    }
