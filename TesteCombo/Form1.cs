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
            public long Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ComboboxItem> lista = new List<ComboboxItem>();
            ComboboxItem item = new ComboboxItem();
            item.Text = "Item text1";
            item.Value = 12;

            lista.Add(item);

            item = new ComboboxItem();
            item.Text = "Item Falsetti Daniel";
            item.Value = 32;

            lista.Add(item);

            item = new ComboboxItem();
            item.Text = "Item Dávi Dániel";
            item.Value = 33;

            lista.Add(item);

            item = new ComboboxItem();
            item.Text = "Golias Davi Dániel";
            item.Value = 35;

            this.cbCombo.Items.AddRange(lista.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var r = this.cbCombo.Items.Cast<ComboboxItem>().Where(w => w.Value == 33).FirstOrDefault();
            //this.cbCombo.SelectedItem = r;
            //string teste = this.cbCombo.Text;
            ComboboxItem t = (ComboboxItem)this.cbCombo.SelectedItem;
        }
    }
}
