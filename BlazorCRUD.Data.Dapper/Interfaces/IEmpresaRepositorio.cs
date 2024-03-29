﻿namespace BlazorCRUD.Data.Dapper.Repositorios
{
	#region " Usings "

	using BlazorCRUD.Model;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	#endregion

	#region " IEmpresaRepositorio "

	public interface IEmpresaRepositorio
	{
		#region " Funções "
		Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS01();

		Task<IEnumerable<Empresa>> CarregarDadosEmpresaADSIS02();

		#endregion
	}

    #endregion
}
