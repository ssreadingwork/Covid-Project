using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDPROJ1
{
  

    public partial class Form3 : Form
    {
        public void imager()
        {
            label3.Visible = false;
            List<string> covid = new List<string>();
            covid.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/000001-1.jpg?raw=true");
            covid.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/000001-12.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00001.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00006.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00008.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00015a.png?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00017.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00018.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00020.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00021.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00022.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00024.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00025.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00026.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00027.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00032.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00033.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00035.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00036.jpg?raw=true");
            covid.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00037.jpg?raw=true");
            covid.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200318082923328940.1003000225002.png?raw=true");


            List<string> other = new List<string>();
            other.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00031.jpg?raw=true");
            other.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00034.jpg?raw=true");
            other.Add("https://prod-images-static.radiopaedia.org/images/24108616/209fe9dbdd49229dd9d95801f3d78f_jumbo.jpeg");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/legionella-pneumonia-1.png?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/legionella-pneumonia-2.jpg?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/pneumocystis-jiroveci-pneumonia-2.png?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/streptococcus-pneumoniae-pneumonia-1.jpg?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/chlamydia-pneumonia-PA.png?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/cavitating-pneumonia-4-day0-L.jpg?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/aspiration-pneumonia-5-day0.jpg?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/ards-secondary-to-tiger-snake-bite.png?raw=true");
            other.Add("https://github.com/ieee8023/covid-chestxray-dataset/blob/master/images/X-ray_of_cyst_in_pneumocystis_pneumonia_1.jpg?raw=true");


            List<string> normal = new List<string>();
            normal.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00023.jpg?raw=true");
            normal.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00028.jpg?raw=true");
            normal.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00040a.jpg?raw=true");
            normal.Add("https://github.com/agchung/Figure1-COVID-chestxray-dataset/blob/master/images/COVID-00034.jpg?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200317090830828260.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200319202613984410.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200323115834968210.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.202003241816485934.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200401171818781600.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200403010103781780.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.1722810170.20200418154808640220.1003000225002.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020031913094890017.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020033016123149069.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020032712415994976.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020032413222814777.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020032009520943077.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020032009002413573.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020032008575844669.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020031914434008949.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020031914133530635.1203801020003.png?raw=true");
            normal.Add("https://github.com/agchung/Actualmed-COVID-chestxray-dataset/blob/master/images/CR.1.2.840.113564.192168196.2020031913311637123.1203801020003.png?raw=true");

               


            Random randompic1 = new Random();
            pictureBox1.ImageLocation = covid[randompic1.Next(0, covid.Count - 1)];

            Random randompic2 = new Random();
            pictureBox2.ImageLocation = other[randompic2.Next(0, other.Count - 1)];

            Random randompic3 = new Random();
            pictureBox4.ImageLocation = normal[randompic3.Next(0, normal.Count - 1)];
        }
        public void location()
        {
            var random = new Random();
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };
            int index = random.Next(list.Count);
            int casenum = index;
            switch (casenum)
            {
                case 0:
                    pictureBox1.Location = new Point(56, 200);
                    pictureBox2.Location = new Point(300, 200);
                    pictureBox4.Location = new Point(544, 200);
                    break;
                case 1:
                    pictureBox1.Location = new Point(56, 200);
                    pictureBox4.Location = new Point(300, 200);
                    pictureBox2.Location = new Point(544, 200);
                    break;
                case 2:
                    pictureBox2.Location = new Point(56, 200);
                    pictureBox1.Location = new Point(300, 200);
                    pictureBox4.Location = new Point(544, 200);
                    break;
                case 3:
                    pictureBox2.Location = new Point(56, 200);
                    pictureBox4.Location = new Point(300, 200);
                    pictureBox1.Location = new Point(544, 200);
                    break;
                case 4:
                    pictureBox4.Location = new Point(56, 200);
                    pictureBox2.Location = new Point(300, 200);
                    pictureBox1.Location = new Point(544, 200);
                    break;
                case 5:
                    pictureBox4.Location = new Point(56, 200);
                    pictureBox1.Location = new Point(300, 200);
                    pictureBox2.Location = new Point(544, 200);
                    break;
            }

        }

        int counter = 1;
        int score = 0;
            
        public Form3()
        {
            InitializeComponent();
            label1.Text = $"{counter} / 10";
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //picturebox4 = normal
            //picturebox1 = covid
            //picturebox 2 = other

            imager();

            //random number to determine position of pictures
            
            location();
           
            




            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            //normal
            counter = counter + 1;
           

            label3.Text = "Incorrect!";
            label3.Visible = true;
            await Task.Delay(1500);
            label1.Text = $"Round {counter}";
            label4.Text = $"{score} / 10";
            if (counter > 10)
            {
                //endgame func
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label5.Text = $"You got {score} points!";
                if (score == 10)
                {

                    label7.Text = "You beat the AI! Well done! Want to go again?";
                }
                else if (score == 9)
                {
                    label7.Text = "You scored the same as the AI! Want to try and beat it?";
                }
                else
                {
                    label7.Text = "You scored less than the AI, want to try again?"; 
                }



            }
            else
            {

                location();
                imager();
               
            }


        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            // covid
            counter = counter + 1;
            score = score + 1;

            label3.Text = "Correct!";
            label3.Visible = true;
            await Task.Delay(1500);
            label1.Text = $"Round {counter}";
            label4.Text = $"{score} / 10";
            if (counter > 10)
            {
                //endgame func
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label5.Text = $"You got {score} points!";
                if (score == 10)
                {

                    label7.Text = "You beat the AI! Well done! Want to go again?";
                }
                else if (score == 9)
                {
                    label7.Text = "You scored the same as the AI! Want to try and beat it?";
                }
                else
                {
                    label7.Text = "You scored less than the AI, want to try again?";
                }



            }
            else
            {

                location();
                imager();
                
            }






        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            // other
            counter = counter + 1;
            

            label3.Text = "Inorrect!";
            label3.Visible = true;
            await Task.Delay(3000);
            label1.Text = $"Round {counter}";
            label4.Text = $"{score} / 10";
            if (counter > 10)
            {
                //endgame func
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label5.Text = $"You got {score} points!";
                if (score == 10)
                {

                    label7.Text = "You beat the AI! Well done! Want to go again?";
                }
                else if (score == 9)
                {
                    label7.Text = "You scored the same as the AI! Want to try and beat it?";
                }
                else
                {
                    label7.Text = "You scored less than the AI, want to try again?";
                }



            }
            else
            {


                imager();
                location();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private async void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // other
            counter = counter + 1;


            label3.Text = "Incorrect!";
            label3.Visible = true;
            await Task.Delay(1500);
            label1.Text = $"Round {counter}";
            label4.Text = $"{score} / 10";
            if (counter > 10)
            {
                //endgame func
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label5.Text = $"You got {score} points!";
                if (score == 10)
                {

                    label7.Text = "You beat the AI! Well done! Want to go again?";
                }
                else if (score == 9)
                {
                    label7.Text = "You scored the same as the AI! Want to try and beat it?";
                }
                else
                {
                    label7.Text = "You scored less than the AI, want to try again?";
                }



            }
            else
            {
                location();

                imager();
               
            }
        }
    }
}
