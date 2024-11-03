using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SQL tarafında yazdığımız Select*From ifadesini çağıralım.
            //Kullanacağımız yapının ismi Ado.net olarak geçer.
            //Ado.net-->C# programlama dilinde SQL kullanabilmemize olanak sağlayan bir çerçeve.

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            //Burada bir SQL bağlantısına ihtiyacımız var.

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-TM7A10AB\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //SqlDataAdapter C# tarafındaki kodlarla sql sunucusu arasında bir köprü görevi görür.

            DataTable dataTable = new DataTable();
            //DataTable verileri geçici belleğe (ram bellek) almamızı sağlar.

            adapter.Fill(dataTable);
            connection.Close();

            //var değişkeni bütün değişken türlerini üzerine alan bir değişken. Kategori tablosunda hem sayısal hem string tür var.
            
            //Datatable satırları içinden gelen verileri item'e atadık.

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
