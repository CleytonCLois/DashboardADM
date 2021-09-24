namespace BlazorCRUD.UI.Interfaces
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " IEmpresaServico "

	public interface IEmpresaServico
	{
        #region " Funções "

        Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS01();

		Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS02();

		#endregion
	}

	#endregion
}
