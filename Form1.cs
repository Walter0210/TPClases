using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        private Double _PilaNumeros;
        private String _operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
                calcDisplay.Clear();
            Button b = (Button)sender;
            calcDisplay.Text = calcDisplay.Text + b.Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            calcDisplay.Clear();
            calcDisplay.Text = "0";
            _PilaNumeros = 0;
            _operador = "";
            historial.Text = "";
        }

        private void operacion(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            _operador = b.Text;
            _PilaNumeros = Double.Parse(calcDisplay.Text);
            calcDisplay.Clear();
            historial.Text = _PilaNumeros + " " + _operador;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            historial.Text = "";
            switch (_operador)
            {
                case "+":
                    calcDisplay.Text = (_PilaNumeros + Double.Parse(calcDisplay.Text)).ToString();
                    break;
                case "-":
                    calcDisplay.Text = (_PilaNumeros - Double.Parse(calcDisplay.Text)).ToString();
                    break;
                case "*":
                    calcDisplay.Text = (_PilaNumeros * Double.Parse(calcDisplay.Text)).ToString();
                    break;
                case "/":
                    calcDisplay.Text = (_PilaNumeros / Double.Parse(calcDisplay.Text)).ToString();
                    break;
            }
        }
    }
}
