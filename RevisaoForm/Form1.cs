using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tx_salvar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.nome = tx_nome.Text;
            f.cpf = tx_cpf.Text;
            f.email = tx_email.Text;
            f.salario = Convert.ToDouble(tx_salario.Text);
            f.funcao = tx_funcao.Text;

            double resultado = f.CalcularSalario();
            lb_confirm.Text = "O salário final é " + resultado.ToString();
        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void lb_confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
