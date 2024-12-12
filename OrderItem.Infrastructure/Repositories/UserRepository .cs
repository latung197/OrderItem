using Dapper;
using Npgsql;
using OrderItem.Domain.Entities;
using OrderItem.Domain.Interfaces;

namespace OrderItem.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<int> CreateUserAsync(User user)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            const string sql = "SELECT create_user(@Username, @PasswordHash, @Role);";
            return await connection.ExecuteAsync(sql, new { user.Username, user.PasswordHash, user.Role });
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            const string sql = "SELECT * FROM get_user_by_username(@Username);";
            return await connection.QuerySingleOrDefaultAsync<User>(sql, new { Username = username });
        }
    }
}
