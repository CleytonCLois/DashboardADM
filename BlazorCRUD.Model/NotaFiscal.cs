namespace BlazorCRUD.Model
{
    #region " Usings "

    using System;

    #endregion

    public class NotaFiscal
    {
        #region " Atributos & Propriedades "

        public int Id { get; set; }

        public string Prefeitura { get; set; }

        public string Numero { get; set; }

        public DateTime DataHoraCadastro { get; set; }

        #endregion
    }
}