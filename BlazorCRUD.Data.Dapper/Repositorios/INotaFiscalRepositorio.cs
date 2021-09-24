namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " INotaFiscalRepositorio "

	public interface INotaFiscalRepositorio
	{
		#region " Funções "
		Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS01();

		Task<IEnumerable<NotaFiscal>> CarregarDadosNotaFiscalADSIS02();

		#endregion
	}

    #endregion
}
