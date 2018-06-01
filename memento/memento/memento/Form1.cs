using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memento
{
        public partial class Form1 : Form
        {
            Person person;
            Caretaker[] caretaker;
            int counter = 0;
            public Form1()
            {
                InitializeComponent();
                person = new Person();
                caretaker = new Caretaker[10];
            }

            private void DisplayPersonInformation()
            {
                textBox1.Text = person.FirstName;
                textBox2.Text = person.LastName;
                textBox3.Text = person.Age.ToString();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (counter < 10)
                {
                    caretaker[counter] = new Caretaker();
                    caretaker[counter].Memento = person.CreateMemento();
                    counter++;
                    person.FirstName = textBox1.Text;
                    person.LastName = textBox2.Text;
                    person.Age = int.Parse(textBox3.Text);
                }

            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (counter > 1)
                {
                    counter--;
                    person.SetMemento(caretaker[counter].Memento);
                    DisplayPersonInformation();
                }
            }
        }
}