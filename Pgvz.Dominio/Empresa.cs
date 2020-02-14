namespace Pgvz.Dominio
{
    public class Empresa
    {
        private string nome;
        private Cnpj cnpj;
        private UnidadeFederacaoSigla uf;

        public string Nome { get => nome; }
        public Cnpj Cnpj { get => cnpj; }
        public UnidadeFederacaoSigla Uf { get => uf; }

        public Empresa(string nome, string cnpj, UnidadeFederacaoSigla uf)
        {
            AtribuirNome(nome);
            AtribuirCNPJ(cnpj);
            AtribuirUF(uf);
        }

        public EntidadeValida AtribuirNome(string nome)
        {
            nome = nome.Trim();
            if (string.IsNullOrEmpty(nome))
                return new EntidadeValida(false, "Nome é obrigatório!");

            if (nome.Length < 5)
                return new EntidadeValida(false, "Nome deve conter no mínimo 5 caracteres!");

            if (nome.Length > 24)
                return new EntidadeValida(false, "Nome deve conter no máximo 25 caracteres!");

            this.nome = nome;
            return new EntidadeValida(true, string.Empty);
        }

        public EntidadeValida AtribuirCNPJ(string cnpj)
        {
            var cnpjValido = new Cnpj(cnpj);
            
            if (!Cnpj.ValidarCNPJ(cnpjValido))
                return new EntidadeValida(false, "CNPJ inválido!");

            this.cnpj = cnpjValido;
            return new EntidadeValida(true, string.Empty);
        }

        public EntidadeValida AtribuirUF(UnidadeFederacaoSigla uf)
        {
            this.uf = uf;
            return new EntidadeValida(false, string.Empty);
        }
    }
}
