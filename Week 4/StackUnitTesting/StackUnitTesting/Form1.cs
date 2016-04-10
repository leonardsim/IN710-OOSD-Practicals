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

            fStack = new ArrayStack(5);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fStack.Push("3");
            listPrintAll.Items.Add("Item added. Stack[" + fStack.Count() + "/" + (fStack.StackString.Length - 1) + "]");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            fStack.Pop();
            listPrintAll.Items.Add("Item removed. Stack[" + fStack.Count() + "/" + (fStack.StackString.Length - 1) + "]");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            fStack.Peek();
            listPrintAll.Items.Add("Currently on most recent slot number: " + fStack.Count() + "/" + fStack.StackString.Length);
        }
    }
}
