﻿using System.Collections.Generic;

namespace BlazorCRUD.Model
{
    #region " Grafico "

    public class Grafico
    {
        public string texto { get; set; } // Texto (Desatualizadas a mais de uma semana e Desatualizadas)
        
        public double valores { get; set; } // Valores

        public byte[] logo { get; set; } // Logo

        public string Hora { get; set; } // Logo

        public int Quantidade { get; set; } // Logo

        public string Situacao { get; set; } // Logo
    }

    #endregion
}
