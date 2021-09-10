namespace BlazorCRUD.UI.Data
{
    #region " Usings "

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    #endregion

    #region " SqlConfiguration "

    public class SqlConfiguration
	{
		public SqlConfiguration(string connectionString) => ConnectionString = connectionString;

		public string ConnectionString { get; set; }
	}

    #endregion
}
