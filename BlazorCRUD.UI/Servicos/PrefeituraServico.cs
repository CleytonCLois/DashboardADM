﻿namespace BlazorCRUD.UI.Servicos
{
	#region " Usings "

	using BlazorCRUD.Data.Dapper.Repositorios;
	using BlazorCRUD.Model;
	using BlazorCRUD.UI.Data;
	using BlazorCRUD.UI.Interfaces;
	using System.Collections.Generic;
	using System.Threading.Tasks;

    #endregion

    #region " PrefeituraServico "

    public class PrefeituraServico : IPrefeituraServico
	{
        #region " Conexão "

        private readonly SqlConfiguration _configuration;

		private IPrefeituraRepositorio _PrefeituraRepositorio;

		public PrefeituraServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_PrefeituraRepositorio = new PrefeituraRepositorio(configuration.ConnectionString);
		}

        #endregion

        #region " Funções "

        public Task<IEnumerable<Prefeitura>> TodasPrefeituras()
		{
			return _PrefeituraRepositorio.TodasPrefeituras();
		}

		public Task<IEnumerable<Prefeitura>> ListaDePrefeituras(int situacao)
		{
			return _PrefeituraRepositorio.ListaDePrefeituras(situacao);
		}

		#endregion
	}

    #endregion
}
