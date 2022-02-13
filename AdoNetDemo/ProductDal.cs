using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
   public class ProductDal
    {   
        SqlConnection _con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; Initial Catalog = ETrade; Integrated Security = True");
        
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"])
                };
                products.Add(product);
            }
            sqlDataReader.Close();
            _con.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        public DataTable GetAll2()
        {   ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            _con.Close();
            return dataTable;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products VALUES(@name,@unitPrice,@stockAmount)", _con);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();
            _con.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount WHERE Id=@id", _con);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();
            _con.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE Id=@id", _con);
            sqlCommand.Parameters.AddWithValue("@id",id);
            sqlCommand.ExecuteNonQuery();
            _con.Close();
        }
    }
}
