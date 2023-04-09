using Dapper;
using Npgsql;
using Discount.API.Entities;

namespace Discount.API.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly IConfiguration _configuration;

        public DiscountRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            using var connection = GetConnection();
            var query = "SELECT * FROM Coupon WHERE ProductName = @ProductName";
            var param = new { ProductName = productName };

            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>(query, param);

            if (coupon == null)
                return new Coupon { ProductName = "No Discount", Amount = 0, Description = "No Discount" };

            return coupon;
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            using var connection = GetConnection();
            var query = "INSERT INTO Coupon (ProductName, Description, Amount) VALUES (@ProductName, @Description, @Amount)";
            var param = new
            {
                coupon.ProductName,
                coupon.Description,
                coupon.Amount
            };

            var result = await connection.ExecuteAsync(query, param);

            return result != 0;
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            using var connection = GetConnection();
            var query = @"UPDATE Coupon
                          SET
                          (
                            ProductName = @ProductName,
                            Description = @Description,
                            Amount = @Amount
                          )
                          WHERE Id = @Id";
            var param = new
            {
                coupon.ProductName,
                coupon.Description,
                coupon.Amount,
                coupon.Id
            };

            var result = await connection.ExecuteAsync(query, param);

            return result != 0;
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            using var connection = GetConnection();
            var query = "DELETE FROM Coupon WHERE ProductName = @ProductName";
            var param = new { ProductName = productName};

            var result = await connection.ExecuteAsync(query, param);

            return result != 0;
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        }
    }
}
