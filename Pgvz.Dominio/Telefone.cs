namespace Pgvz.Dominio
{
    public class Telefone
    {
        private int ddd;
        private string numero;
        private TelefoneTipo tipo;

        public Telefone(string ddd, TelefoneTipo tipo, string numero)
        {
            AtribuirDDD(ddd);
            AtribuirTipo(tipo);
            AtribuirNumero(numero);
        }

        public int Ddd { get => ddd; }
        public string Numero { get => numero; }
        public TelefoneTipo Tipo { get => tipo; }

        public EntidadeValida AtribuirDDD(string ddd)
        {
            if (ddd.Length != 2)
                return new EntidadeValida(false, "DDD deve ter apenas 2 caracteres.");

            if (!int.TryParse(ddd, out this.ddd))
                return new EntidadeValida(false, "DDD inválido.");

            return new EntidadeValida(true, string.Empty);
        }
        public void AtribuirTipo(TelefoneTipo tipo)
        {
            this.tipo = tipo;
        }
        public EntidadeValida AtribuirNumero(string numero)
        {
            if (numero.Contains("-"))
                return new EntidadeValida(false, "Telefone deve conter apenas números.");

            if (tipo == TelefoneTipo.Celular)
            {
                if (numero.Length != 9)
                    return new EntidadeValida(false, "Telefone celular deve conter 9 caracteres.");

                if (!numero.StartsWith("9"))
                    return new EntidadeValida(false, "Telefone celular deve iniciar com o número 9.");

                this.numero = numero;
                return new EntidadeValida(true, string.Empty);
            }

            if (numero.Length != 8)
                return new EntidadeValida(false, "Telefone deve conter 8 caracteres.");

            this.numero = numero;
            return new EntidadeValida(true, string.Empty);
        }
    }
}
