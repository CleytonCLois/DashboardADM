using System.Collections.Generic;

namespace BlazorCRUD.Model
{
    #region " Grafico "

    public class Grafico
    {
        public IList<string> texto { get; set; } // texto (Desatualizadas a mais de uma semana e Desatualizadas)
        
        public double valores { get; set; } // Valores
    }

    #endregion
}
