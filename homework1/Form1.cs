using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        private CalculatorModel _calculatorModel;

        public Form1()
        {
            InitializeComponent();
            _calculatorModel = new CalculatorModel();
        }

        // when the form is loaded, the following code will be executed
        private void Form1Load(object sender, EventArgs e)
        {

        }

        // when the number button is clicked, the following code will be executed
        private void ClickNumberButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _textBox.Text = this._calculatorModel.InsertStringToCurrentNumberLast(button.Text);
        }

        // when the calculation operator button is clicked, the following code will be executed
        private void ClickCalculateOperatorButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _textBox.Text = this._calculatorModel.UseCalculationOperation(button.Text);
        }

        // when the equal operator button is clicked, the following code will be executed
        private void ClickEqualOperatorButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _textBox.Text = this._calculatorModel.UseEqualOperation();
        }

        // when the clear button is clicked, the following code will be executed
        private void ClickClearButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _textBox.Text = this._calculatorModel.Clear();
        }

        // when the clear entry button is clicked, the following code will be executed
        private void ClickClearEntryButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _textBox.Text = this._calculatorModel.ClearEntry();
        }
    }
}
