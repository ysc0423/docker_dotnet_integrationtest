using Dapper;
using jenkin_test.Domain;
using Npgsql;
using System;
using System.Collections.Generic;

namespace jenkin_test.Repository
{
	public class ValueRepository : IValueRepository
	{
		public readonly string _connectionString;

		public ValueRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IEnumerable<User> Get()
		{
			using(var dbConnection = new NpgsqlConnection(_connectionString))
			{
				dbConnection.Open();

				var query = "SELECT * FROM public.users";

				try
				{
					var users = dbConnection.Query<User>(query);

					return users;

				}
				catch (Exception)
				{
					throw;
				}				
			}
		}
	}
}
