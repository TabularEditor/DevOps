var dataSource = Model.DataSources["te3-sql-training"] as ProviderDataSource;
var connectionString = Environment.GetEnvironmentVariable("SQLDW_CONNECTIONSTRING");
if(string.IsNullOrEmpty(connectionString))
{
    Error("Environment variable SQLDW_CONNECTIONSTRING not set!");
    return;
}
dataSource.ConnectionString = connectionString;
dataSource.Provider = "System.Data.SqlClient";
