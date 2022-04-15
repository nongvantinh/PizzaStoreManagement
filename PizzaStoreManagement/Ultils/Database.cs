using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PizzaStoreManagement.Ultils
{
    public class Database
    {
        private Database() { }

        private static readonly Lazy<Database> _lazy = new Lazy<Database>(() => new Database());
        public static Database Instance => _lazy.Value;
        string connectionString = "Server=DESKTOP-5LU9UG3;Database=pizza_store;uid=sa;pwd=nongvantinh";

        public static T ExecuteScalar<T>(string query, List<Tuple<SqlDbType, object>> parameters)
        {
            using (SqlConnection connection = new SqlConnection(Instance.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = query;

                    MatchCollection matches = Regex.Matches(query, @"@\b\w*\b", RegexOptions.IgnoreCase);
                    if (matches.Count != parameters.Count)
                        throw new Exception($"parameters mismatch: {matches.Count} and {parameters.Count}");
                    for (int i = 0; i != matches.Count; ++i)
                        cmd.Parameters.Add(matches[i].Value, parameters[i].Item1).Value = parameters[i].Item2;

                    return (T)cmd.ExecuteScalar();
                }
            }
        }

        public static int ExecuteNonQuery(string query, List<Tuple<SqlDbType, object>> parameters)
        {
            using (SqlConnection connection = new SqlConnection(Instance.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = query;

                    MatchCollection matches = Regex.Matches(query, @"@\b\w*\b", RegexOptions.IgnoreCase);
                    if (matches.Count != parameters.Count)
                        throw new Exception($"parameters mismatch: {matches.Count} and {parameters.Count}");
                    for (int i = 0; i != matches.Count; ++i)
                        cmd.Parameters.Add(matches[i].Value, parameters[i].Item1).Value = parameters[i].Item2;

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ExecuteReader(string query, List<Tuple<SqlDbType, object>> parameters, Action<SqlDataReader> reader)
        {
            using (SqlConnection connection = new SqlConnection(Instance.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = query;
                    MatchCollection matches = Regex.Matches(query, @"@\b\w*\b", RegexOptions.IgnoreCase);
                    if (matches.Count != parameters.Count)
                        throw new Exception($"parameters mismatch: {matches.Count} and {parameters.Count}");

                    for (int i = 0; i != matches.Count; ++i)
                        cmd.Parameters.Add(matches[i].Value, parameters[i].Item1).Value = parameters[i].Item2;

                    reader(cmd.ExecuteReader());
                }
            }
        }
    }
}
