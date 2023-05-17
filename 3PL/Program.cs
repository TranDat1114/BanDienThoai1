using _1DAL.ConText;
using _1DAL.IRepository;
using _1DAL.Repositorys;
using _2BUS.Service;
using _3PL.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace _3PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Trong phương thức Main của ứng dụng
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cấu hình DI Container
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Tạo ServiceProvider từ DI Container
            using (var serviceProvider = services.BuildServiceProvider())
            {
                // Khởi tạo và chạy ứng dụng
                var form = serviceProvider.GetRequiredService<FrmMain>();
                Application.Run(form);
            }

         }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ của ứng dụng
            services.AddDbContext<DBContextDienThoai>(options => options.UseSqlServer("Data Source=HẢI\\SQLEXPRESS;Initial Catalog=DuAnDT;Integrated Security=True"));
            // Đăng ký các form và các thành phần liên quan
            services.AddTransient<FrmMain>();
            services.AddTransient<IKhachHangRepos,KhachHangRepos>();
            //services.AddTransient<SomeOtherForm>();
        }
    }
}