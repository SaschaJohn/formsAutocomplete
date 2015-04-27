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

        static Person[] x = {p };

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
            MessageBox.Show(p.firstName);
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
    }
}
