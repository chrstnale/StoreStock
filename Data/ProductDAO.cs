using StoreStock.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StoreStock.Data
{
    internal class ProductDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoreStock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Show all data
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
                        product.ID = reader.GetInt32(0);
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

        internal int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.Products WHERE ID = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;

                connection.Open();

                int deletedId = command.ExecuteNonQuery();

                return deletedId;

            }

        }
        //Fetch one data
        public ProductModel FetchOne(int Id)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from dbo.Products WHERE ID = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ProductModel product = new ProductModel();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        product.ID = reader.GetInt32(0);
                        product.Code = reader.GetString(1);
                        product.Name = reader.GetString(2);
                        product.Amount = reader.GetInt32(3);
                        product.Price = reader.GetInt32(4);

                    }
                }
                return product;
            }

        }

        //Create new data
        public int Create(ProductModel productModel)
        {
            string sqlQuery = "";
            if(productModel.ID <= 0)
            {
                sqlQuery = "INSERT INTO dbo.Products VALUES(@Code, @Name, @Amount, @Price)";

            }
            else
            {
                sqlQuery = "UPDATE dbo.Products SET Code = @Code, Name = @Name, Amount = @Amount, Price = @Price WHERE ID= @ID";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = productModel.ID;
                command.Parameters.Add("@Code", System.Data.SqlDbType.VarChar, 1000).Value = productModel.Code;
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 1000).Value = productModel.Name;
                command.Parameters.Add("@Amount", System.Data.SqlDbType.Int).Value = productModel.Amount;
                command.Parameters.Add("@Price", System.Data.SqlDbType.Int).Value = productModel.Price;

                connection.Open();

                int newId = command.ExecuteNonQuery();

                return newId;
            }

        }
    }
}