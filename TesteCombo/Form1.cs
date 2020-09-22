using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TesteCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "Item text1";
            item.Value = 12;

            this.cbCombo.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Item Falsetti Dániel";
            item.Value = 32;

            this.cbCombo.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Item Dávi Dániel";
            item.Value = 33;

            this.cbCombo.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Golias Davi Dániel";
            item.Value = 35;

            this.cbCombo.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teste = this.cbCombo.Text;
            ComboboxItem t = (ComboboxItem)this.cbCombo.SelectedItem;
        }
    }
}
