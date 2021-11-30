var dataSource = Model.DataSources["te3-sql-training"] as ProviderDataSource;
dataSource.ConnectionString = Environment.GetEnvironmentVariable("SQLDW_CONNECTIONSTRING");
dataSource.Provider = "System.Data.SqlClient";