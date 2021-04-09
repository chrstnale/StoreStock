using StoreStock.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StoreStock.Data
{
    internal class ProductDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoreStock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<ProductModel> FetchAll()
        {
            List<ProductModel> returnList = new List<ProductModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductModel product = new ProductModel();
                        product.Code = reader.GetString(1);
                        product.Name = reader.GetString(2);
                        product.Amount = reader.GetInt32(3);
                        product.Price = reader.GetInt32(4);

                        returnList.Add(product);
                    }
                }
            }
                return returnList;
        }
    }
}