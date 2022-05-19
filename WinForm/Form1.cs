using Data.Model;
using Repository;

namespace WinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {

            DataContext dataContext = new DataContext();
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txt_nome.Text;

            dataContext.pessoas.Add(pessoa);
            dataContext.SaveChanges();

        }

        private void btn_pesquisar_Click(object sender, EventArgs e) {

            DataContext dataContext = new DataContext();
            Pessoa pessoa = dataContext.pessoas.Where(x => x.nome == this.txt_nome.Text).FirstOrDefault();

            if (pessoa != null) {
                MessageBox.Show($"Código da pesquisa é {pessoa.codigo}");
            }

        }
    }
}