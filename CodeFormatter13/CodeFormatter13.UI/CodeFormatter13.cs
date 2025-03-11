using CodeFormatter13.Dominio.CodeFormatter;

namespace CodeFormatter13.UI
{
    public partial class CodeFormatter13 : Form
    {
        private readonly IServicoDeCodeFormatter _servicoDeCodeFormatter;
        public CodeFormatter13(IServicoDeCodeFormatter servicoDeCodeFormatter)
        {
            _servicoDeCodeFormatter = servicoDeCodeFormatter;

            InitializeComponent();
        }

        private void btnFormater_Click(object sender, EventArgs e)
        {
            var lista = rtbLista.Text;

            if (string.IsNullOrEmpty(lista))
                return;

            var formatado = _servicoDeCodeFormatter.FormatarClasseInformada(lista);


            rtbVariaveis.Text = formatado.Result.VariavesClasse;
            rtbCodigoValidacao.Text = formatado.Result.CodigoValidacaoClasse;

        }

    }
}
