using System;
using System.Windows.Forms;

namespace COVIDPROJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            BackgroundImageLayout = ImageLayout.Stretch;
            
            label1.Text = "COVID-Net: Are You Smarter Than A Machine?";
           

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }
    }
}
