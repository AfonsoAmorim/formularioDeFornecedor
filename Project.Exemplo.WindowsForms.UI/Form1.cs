using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Exemplo.WindowsForms.UI
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedores();

          


            List<Fornecedores> listaFornecedores = new List<Fornecedores>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource = listaFornecedores;
        
        }

        private Fornecedores RetornarFornecedor(Fornecedores fornecedor)
        {

            if (txtNomeDoFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeDoFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor");
               
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o endereço");
               
            }

            if (txtNomeDoContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = txtNomeDoContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome de contato");
                
            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o telefone");
               
        }
        return Fornecedores;
    }
}
