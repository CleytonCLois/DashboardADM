namespace BlazorCRUD.UI.Data
{
    #region " SqlConfiguration "

    public class SqlConfiguration
	{
		public SqlConfiguration(string connectionString) => ConnectionString = connectionString;

		public string ConnectionString { get; set; }
	}

    #endregion
}
