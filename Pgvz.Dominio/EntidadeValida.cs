namespace Pgvz.Dominio
{
    public struct EntidadeValida
    {
        public bool Valida { get; }
        public string Mensagem { get; }

        public EntidadeValida(bool valida, string mensagem)
        {
            Valida = valida;
            Mensagem = mensagem;
        }
    }
}
