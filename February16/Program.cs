using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace February16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region 
            //var builder = new ConfigurationBuilder(); 
            //builder.SetBasePath(@"D:\other\ProjNew\February16 [FluentApi]\February16"); //установка пути к текущему каталогу
            //builder.AddJsonFile("appsettings.json"); //получаем конфигурацию из файла
            //var config = builder.Build(); //создаём конфигурацию
            //string connectionString = config.GetConnectionString("DefaultConnection"); //получаемстроку подключения

            //var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //var options = optionsBuilder.UseSqlServer(connectionString).Options;

            //using (var db = new MyContext(options))
            //{

            //}
            //
            #endregion

            using (var db = new MyContext()) { }

            Console.WriteLine("Hello World!");
        }
    }
}