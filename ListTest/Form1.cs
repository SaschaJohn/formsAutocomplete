using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{

    

    public partial class Form1 : Form
    {
        static Person p = new Person("Tim", "Taler");
        static Person p2 = new Person("Jim", "Knopf");

        static Person[] x = {p,p2 };

        ArrayList flist = new ArrayList(x);
        public Form1()
        {
            InitializeComponent();


            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

            this.comboBox1.Items.AddRange(x);

            this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var person = this.comboBox1.SelectedItem as Person;
            MessageBox.Show(p.ToString());
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var person = this.comboBox1.SelectedValue as Person;
            MessageBox.Show(p.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedIndex.ToString());
        }
    }

    public class Person
    {
        public string firstName { get; set; } 
        public string lastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        public override bool Equals(System.Object p)
        {
            // If parameter is null return false:
            if ((object)p == null)
            {
                return false;
            }

            var person = p as Person;

            if (person == null)
            {
                return false;
            }

            

            // Return true if the fields match:
            return (firstName == person.firstName) && (lastName == person.lastName);
        }

        public bool Equals(Person p)
        {
            // If parameter is null return false:
            if (p == null)
            {
                return false;
            }

            

            // Return true if the fields match:
            return (firstName == p.firstName) && (lastName == p.lastName);
        }
    }
}
