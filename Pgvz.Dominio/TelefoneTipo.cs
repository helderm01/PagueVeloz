using System.ComponentModel;

namespace Pgvz.Dominio
{
    public enum TelefoneTipo
    {
        [Description("Celular")]
        Celular,
        
        [Description("Comercial")]
        Comercial,

        [Description("Residencial")]
        Residencial
    }
}
