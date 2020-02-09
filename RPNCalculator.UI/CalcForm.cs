using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPNCalculator.UI
{
    public partial class CalcForm : Form
    {
        private readonly IOperationStack stack;
        public CalcForm(IOperationStack stack, IOperationFactory factory)
        {
            this.stack = stack;
            InitializeComponent();
            txtInput.Focus();
            foreach (var symbol in factory.AvailableOperations)
            {
                listViewSymbols.Items.Add(new ListViewItem(new[] { symbol.Symbol, symbol.Description }));
            }

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Escape)
                {
                    e.Handled = true;
                    stack.Clear();
                    RefreshCalc();
                }
                if (stack.Operate(txtInput.Text + e.KeyChar.ToString()))
                {
                    e.Handled = true;
                    RefreshCalc();
                }
                else if (e.KeyChar == (char)Keys.Enter && !stack.AddOperand(txtInput.Text))
                {
                    MessageBox.Show($"Invalid input: {txtInput.Text}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    RefreshCalc();
                }
            }
            catch (Exception ex)
            {
                e.Handled = true;
                txtInput.Clear();
                MessageBox.Show(ex. Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCalc()
        {
            int i = 1;
            StringBuilder builder = new StringBuilder();
            foreach (var value in stack.Values)
            {
                string line = $"{i++}:\t{value}";
                if (builder.Length + line.Length > txtInput.MaxLength)
                {
                    builder.Remove(0, line.Length);
                }
                builder.AppendLine(line);
            }
            txtInput.Clear();
            txtOuput.Text = builder.ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator that works with the Reverse Polish Notation.\r\n" +
                "Topmost operand corresponds to the rightmost operand in the common notation.\r\n" +
                "Press enter to push a number onto the stack, or type a symbol to perform an operation.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RPN Calculator .NET Core\r\nAuthor: Carlo Sganzerla\r\n\r\n" +
                "MIT License\r\n\r\n" +
                $"Copyright (c) {DateTime.Now.Year} Carlo Sganzerla", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
