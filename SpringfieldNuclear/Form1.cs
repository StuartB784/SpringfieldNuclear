using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();

            textBox4.Text = "Reactor Meltdown";

            // Label and Textbox Color Change

            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            textBox4.BackColor = Color.Red;
            this.Refresh();
            Thread.Sleep(1000);

            label1.BackColor = Color.CornflowerBlue;
            label2.BackColor = Color.CornflowerBlue;
            textBox4.BackColor = Color.White;
            this.Refresh();
            Thread.Sleep(1000);

            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            textBox4.BackColor = Color.Red;
            this.Refresh();
            Thread.Sleep(1000);

            label1.BackColor = Color.CornflowerBlue;
            label2.BackColor = Color.CornflowerBlue;
            textBox4.BackColor = Color.White;
            this.Refresh();
            Thread.Sleep(1000);

            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            textBox4.BackColor = Color.Red;
            this.Refresh();
            Thread.Sleep(1000);

            label1.BackColor = Color.CornflowerBlue;
            label2.BackColor = Color.CornflowerBlue;
            textBox4.BackColor = Color.White;
            this.Refresh();
            Thread.Sleep(1000);

            textBox4.Text = "Reactors are Normal";



        }
    }
}
