using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteDeFolhaDePagamento
{

    public partial class ReajusteSalarial : Form
    {
        private RepositorioFuncionario  repositorio =new RepositorioFuncionario();
        private BindingSource leituraSource =
        new BindingSource();
        public ReajusteSalarial()
        {
            InitializeComponent();
            leituraSource.DataSource = repositorio.ObterTodos();
            dgvLeitura.DataSource = leituraSource;
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(txtArquivo.Text);
                if (repositorio.ObterTodos().Count > 0)
                {
                    TotalizarValores(repositorio.ObterTodos());
                }
            }
        } 
        private void ProcessarArquivo(string nomeArquivo)
        {
            repositorio.ObterTodos().Clear();
            string linhaLida;
            var arquivo = new System.IO.StreamReader(@nomeArquivo);
            while ((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dadosLidos[0]),
                    Salario = Convert.ToDouble(dadosLidos[1])
                };
                repositorio.Inserir(funcionario);
            }
            arquivo.Close();
        }

        private void TotalizarValores(IList<Funcionario> dadosLidos)
        {
            double totalSemReajuste = 0, totalComReajuste = 0;
            foreach (var funcionario in dadosLidos)
            {
                totalSemReajuste += funcionario.Salario;
                totalComReajuste += funcionario.
                NovoSalario;
            }
            double percentualReajuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;
            lblTotalSReajuste.Text = string.Format("{0:c}", totalSemReajuste);
            lblTotalCReajuste.Text = string.Format("{0:c}", totalComReajuste);
            lblPercentualR.Text = string.Format("{0:n}%", percentualReajuste);
        }

      
    }
    class Funcionario
    {
        public int Codigo { get; set; }

        public double Salario { get; set; }

        public double Percentual
        {
            get
            {
                if (this.Salario < 1000) return 15;
                else if (this.Salario < 1500) return 10;
                else
                    return 5;
            }
        }

        public double NovoSalario
        {
            get
            {
                return (this.Salario * this.Percentual /
                100) + this.Salario;
            }
        }
    }
    class RepositorioFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList<Funcionario>();

        public void Inserir(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public IList<Funcionario> ObterTodos()
        {
            return this.funcionarios;
        }
    }
}