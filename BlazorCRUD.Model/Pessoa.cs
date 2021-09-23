namespace BlazorCRUD.Model
{
    #region " Usings "

    using System;

    #endregion

    public class Pessoa
    {
		#region " Atributos & Propriedades "

		public int Id { get; set; }

		public string Prefeitura { get; set; }

		public string PES_CpfCnpj { get; set; }

		public string RazaoSocial { get; set; }

		public DateTime DataHoraInclusao { get; set; }

		#endregion
	}
}