using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {

        // private ConnectionState connectionState;
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade;integrated security=true");
        public DataTable GetAll()//method ürünleri döndürmek için 
        {
            //SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade;integrated security=true");//@ yazılan her şeyi string olarak kabul etmemizi sağlar
            //initial catalog=Etrade (HANGİ VERİ TABANINA BAĞLANACAĞIMIZI BELİRTİR)
            //integrated security=true (VERİ TABANINA WİNDOWS OTANTİCATİON İLE BAĞLAN) 
            //uzaktaki bir bilgisayara bağlanmak için uid=engin;password=1234
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);//verileri ekrana getirir connection a gönderir
            SqlDataReader reader = command.ExecuteReader();//sql komudunu çalıştırmak için kullanılır

            DataTable dataTable = new DataTable();//datatable oluştur
            dataTable.Load(reader);
            reader.Close();//redar i kapat
            _connection.Close();
            return dataTable;


        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();//Bağlantı açmak
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name = @name, UnitPrice=@unitPrice, StockAmount=@StockAmount where Id=@Id)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }





        /*   public List<Product> GetAll()//method ürünleri döndürmek için 
           {
               SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade;integrated security=true");//@ yazılan her şeyi string olarak kabul etmemizi sağlar
               //initial catalog=Etrade (HANGİ VERİ TABANINA BAĞLANACAĞIMIZI BELİRTİR)
               //integrated security=true (VERİ TABANINA WİNDOWS OTANTİCATİON İLE BAĞLAN) 
               //uzaktaki bir bilgisayara bağlanmak için uid=engin;password=1234
               if (_connection.State == _ConnectionState.Closed)
               {
                   _connection.Open();//Bağlantı açmak
               }
               SqlCommand command = new SqlCommand("Select * from Products", connection);//verileri ekrana getirir connection a gönderir
               SqlDataReader reader = command.ExecuteReader();//sql komudunu çalıştırmak için kullanılır


               IList<Product> products = new List<Product>();

               while (reader.Read())//kayıtları tek tek oku 
               {
                   Product product = new Product
                   {
                       Id = Convert.ToInt32(reader["Id"]),//Convert.ToInt32 Tum hepsini int yap
                       Nmae = reader["Name"].ToString(),
                       StoclAmoun = Convert.ToInt32(reader["StockAmount"]),
                       UnitPrice = Convert.ToDecimal(reader["UnitePrice"])

                   };
                   products.Add(product);
               }

               reader.Close();//redar i kapat
               connection.Close();
               return products;


           }*/


    }
}
