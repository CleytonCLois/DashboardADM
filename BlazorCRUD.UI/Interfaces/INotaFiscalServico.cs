namespace BlazorCRUD.UI.Interfaces
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " INotaFiscalServico "

	public interface INotaFiscalServico
	{
        #region " Funções "

        Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS01();

		Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS02();

		#endregion
	}

	#endregion
}
