# DevOps
This repository is used to demonstrate Tabular Editor integration with GitHub Actions for Power BI or Analysis Services CI/CD

# Actions
The repository contains a single [workflow](https://github.com/TabularEditor/DevOps/blob/main/.github/workflows/BuildAndValidateTabularModel.yml) which performs the following actions against the AdventureWorks model source code in the repo:

1. Uses a [PowerShell script](https://github.com/TabularEditor/DevOps/blob/main/Scripts/DownloadTE2.ps1) to Download Tabular Editor 2.x
2. Run a Best Practice Analysis
3. Run a Schema Check (i.e. checking that columns in the source SQL partitions are correctly mapped to imported column). Uses a [C# script](https://github.com/TabularEditor/DevOps/blob/main/Scripts/ReplaceDataSourceConnectionString.csx) to update the data source credentials before performing the Schema Check.
4. Deploy the model to an instance of Analysis Services (that could be SSAS, Azure AS or Power BI XMLA).

# Instructions

To replicate this in your own fork, you have to set up the following environment and environment variables under the GitHub repository settings:

1. An environment named "Dev"
2. One environment variable named "SQLDW_CONNECTIONSTRING". This should hold the SQLNCLI connection string to access a SQL database that holds [AdventureWorksDW2019](https://github.com/Microsoft/sql-server-samples/releases/download/adventureworks/AdventureWorksDW2019.bak):

  ```connectionstring
  data source=<SQL SERVER NAME>;initial catalog=<SQL DATABASE NAME>;persist security info=True;user id=<SQL USERNAME>;password=<SQL PASSWORD>
  ```
3. One environment variable named "AS_CONNECTIONSTRING" which points to the Analysis Services or Power BI workspace where you want the workflow to deploy the model.
  ```connectionstring
  Provider=MSOLAP;Data Source=<AS SERVER NAME>;User ID=<USERNAME>;Password=<PASSWORD>
  ```
  To use a Service Principal, specify the following:
  ```connectionstring
  Provider=MSOLAP;Data Source=<AS SERVER NAME>;User ID=app:<APPLICATION ID>@<TENANT ID>;Password=>APPLICATION SECRET>
  ```
