using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        Cliente cliente;

        public Form1()
        {
            InitializeComponent();
            
            this.cliente = new Cliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
         
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(textBoxDeposito.Text);

                cliente.Creditar(valor);

                textBoxDeposito.Clear();

                labelSaldoValor.Text = cliente.saldo.ToString("0.00");

                MessageBox.Show("Depósito realizado com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
   

        private void labelCifrao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(textBoxSacar.Text);

                cliente.Debitar(valor);

                labelSaldoValor.Text = cliente.saldo.ToString("0.00");

                textBoxSacar.Clear();

                MessageBox.Show("Saque realizado com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
