namespace BlazorCRUD.Model
{
    #region " Usings "

    using System;

    #endregion

    public class Empresa
    {
        #region " Atributos & Propriedades "

        public int Id { get; set; }

        public string Prefeitura { get; set; }

        public string Inscricao { get; set; }

        public DateTime DataHoraInclusao { get; set; }

        #endregion
    }
}