using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using SvenQL.Models;

namespace SvenQL.Controllers
{
    public class SqlQuery
    {
        public string Query { get; set; }
    }

    public class QueryController : ApiController
    {
        public ResultSet Post([FromBody]SqlQuery query)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = query.Query;

                return ReadResultSet(command);
            }
        }

        private static ResultSet ReadResultSet(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var columns = CreateColumns(reader);
                var resultSet = new ResultSet(columns);

                var rowValues = new object[reader.FieldCount];

                while (reader.Read())
                {
                    reader.GetValues(rowValues);

                    resultSet.AddRow(rowValues);
                }

                return resultSet;
            }
        }

        private static IEnumerable<Column> CreateColumns(SqlDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var columnName = reader.GetName(i);
                yield return new Column(columnName);
            }
        }
    }
}