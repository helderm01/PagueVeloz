using System;
using System.Collections.Generic;

namespace Pgvz.Dominio
{
    public class Fornecedor
    {
        private Empresa empresa;
        private string nome;
        private DateTime dataHoraCadastro;
        //private CPF ou CNPJ
        private IList<Telefone> telefones;
    }
}
