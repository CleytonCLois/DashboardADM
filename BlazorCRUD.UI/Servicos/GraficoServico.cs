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

    #region " GraficoServico "

    public class GraficoServico : IGraficoServico
	{
        #region " Conexão "

        private readonly SqlConfiguration _configuration;

		private IGraficoRepositorio _GraficoRepositorio;

		public GraficoServico(SqlConfiguration configuration)
		{
			_configuration = configuration;
			_GraficoRepositorio = new GraficoRepositorio(configuration.ConnectionString);
		}

        #endregion

        #region " Funções "

        public Task<List<Grafico>> PreencherDados()
		{
			return _GraficoRepositorio.PreencherDados();
		}

		public Task<List<Grafico>> PrefeiturasAtualizadas()
		{
			return _GraficoRepositorio.PrefeiturasAtualizadas();
		}

		public Task<List<Grafico>> PrefeiturasAtualizadasUltimas24hrs()
		{
			return _GraficoRepositorio.PrefeiturasAtualizadasUltimas24hrs();
		}

		public Task<List<Grafico>> PrefeiturasDesatualizadas()
		{
			return _GraficoRepositorio.PrefeiturasDesatualizadas();
		}

		public Task<List<Grafico>> PrefeiturasDesatualizadasMaisDeUmaSemana()
		{
			return _GraficoRepositorio.PrefeiturasDesatualizadasMaisDeUmaSemana();
		}

        #endregion
    }

    #endregion
}
