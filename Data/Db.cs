using MySqlConnector;
using System.Data;

namespace TaskLink.Data
{
    /// <summary>Low-level MySQL helper (XAMPP defaults: root user, empty password, port 3306).</summary>
    public static class Db
    {
        public const string ConnStr =
            "Server=localhost;Port=3306;Database=tasklink;Uid=root;Pwd=;AllowUserVariables=true;";

        public static MySqlConnection Open()
        {
            var c = new MySqlConnection(ConnStr);
            c.Open();
            return c;
        }

        public static void Initialize()
        {
            using var connection = Open();
        }

        public static MySqlParameter P(string name, object value) =>
            new MySqlParameter(name, value ?? DBNull.Value);

        static MySqlParameter[] Parameters((string Name, object? Value)[] ps) =>
            ps.Select(p => P(p.Name, p.Value ?? DBNull.Value)).ToArray();

        public static List<T> Query<T>(string sql, Func<MySqlDataReader, T> map, params MySqlParameter[] ps)
        {
            using var c = Open();
            using var cmd = new MySqlCommand(sql, c);
            cmd.Parameters.AddRange(ps);
            using var r = cmd.ExecuteReader();
            var list = new List<T>();
            while (r.Read()) list.Add(map(r));
            return list;
        }

        public static DataTable Query(string sql, params (string Name, object? Value)[] ps)
        {
            using var c = Open();
            using var cmd = new MySqlCommand(sql, c);
            cmd.Parameters.AddRange(Parameters(ps));
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public static int Execute(string sql, params MySqlParameter[] ps)
        {
            using var c = Open();
            using var cmd = new MySqlCommand(sql, c);
            cmd.Parameters.AddRange(ps);
            return cmd.ExecuteNonQuery();
        }

        public static int Exec(string sql, params (string Name, object? Value)[] ps) =>
            Execute(sql, Parameters(ps));

        public static int Exec(MySqlConnection c, MySqlTransaction tx, string sql, params (string Name, object? Value)[] ps)
        {
            using var cmd = new MySqlCommand(sql, c, tx);
            cmd.Parameters.AddRange(Parameters(ps));
            return cmd.ExecuteNonQuery();
        }

        public static object? Scalar(string sql, params MySqlParameter[] ps)
        {
            using var c = Open();
            using var cmd = new MySqlCommand(sql, c);
            cmd.Parameters.AddRange(ps);
            return cmd.ExecuteScalar();
        }

        public static object? Scalar(string sql) => Scalar(sql, Array.Empty<MySqlParameter>());

        public static object? Scalar(string sql, params (string Name, object? Value)[] ps)
        {
            using var c = Open();
            using var cmd = new MySqlCommand(sql, c);
            cmd.Parameters.AddRange(Parameters(ps));
            return cmd.ExecuteScalar();
        }

        public static string? S(MySqlDataReader r, int i) => r.IsDBNull(i) ? null : r.GetString(i);
    }
}
