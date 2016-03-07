using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUnitTesting
{
    public partial class Form1 : Form
    {
        ArrayStack fStack;

        public Form1()
        {
            InitializeComponent();

            fStack = new ArrayStack();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fStack.Push("Ayy");
            listPrintAll.Items.Add("Item added. Number of free array slots left: " + fStack.Count() + "/" + fStack.StackString.Length);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            fStack.Pop();
            listPrintAll.Items.Add("Item removed. Number of free array slots left: " + fStack.Count() + "/" + fStack.StackString.Length);
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            fStack.Peek();
            listPrintAll.Items.Add("Currently on most recent slot number: " + fStack.Count() + "/" + fStack.StackString.Length);
        }
    }
}
