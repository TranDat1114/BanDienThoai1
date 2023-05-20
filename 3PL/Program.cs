using _1DAL.ConText;
using _1DAL.IRepository;
using _1DAL.Repositorys;

using _2BUS.IService;
using _2BUS.Service;

using _3PL.View;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace _3PL
{
    public static class Program
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ của ứng dụng
            services.AddDbContext<DBContextDienThoai>(options => options.UseSqlServer("server=tranhoang\\moonserver; database=DuAnDT;Integrated Security=True"));

            // Đăng ký các form và các thành phần liên quan
            services.AddTransient<IKhachHangRepos, KhachHangRepos>();
            services.AddTransient<IChucVuRepos, ChucVuRepos>();
            services.AddTransient<INhanVienRepos, NhanVienRepos>();
            services.AddTransient<INhanVienService, NhanVienService>();
            services.AddTransient<IKhachHangService, KhachHangService>();
            services.AddTransient<IChucVuService, ChucVuService>();
            services.AddTransient<IHoaDonRepos, HoaDonRepos>();
            services.AddTransient<IHoaDonService, HoaDonService>();
            services.AddTransient<IHoaDonCTRepos, HoaDonCTRepos>();
            services.AddTransient<IHoaDonCTService_, HoaDonCTService>();
            services.AddTransient<IDTCTRepos, DTCTRepos>();
            services.AddTransient<IDTCTService, DTCTService>();
            services.AddTransient<IDTRepos, DTRepos>();
            services.AddTransient<IMauSacRepos, MauSacRepos>();
            services.AddTransient<IMauSacService, MauSacService>();
            services.AddTransient<IImeiRepos, ImeiRepos>();
            services.AddTransient<IImeiService, IMeiService>();
            services.AddTransient<IDungLuongRepos, DungLuongRepos>();
            services.AddTransient<IDungLuongService, DungLuongService>();
            services.AddTransient<IHSXRepos, HSXRepos>();
            services.AddTransient<IHSXService, HSXService>();
            services.AddTransient<IDTService, DTService>();
            
            services.AddSingleton<FrmDangNhap>();
            services.AddSingleton<FrmMain>();
            services.AddSingleton<FrmNhanVien>();
            services.AddSingleton<FrmBanHang>();
            services.AddSingleton<FrmKhachHang>();
            services.AddSingleton<FrmDienThoai>();
            services.AddSingleton<FrmHoaDon>();
            services.AddSingleton<FrmHSX>();
            services.AddSingleton<FrmQuanLySP>();
            services.AddSingleton<FrmDienThoaiCT>();
            services.AddSingleton<FrmImei>();
            services.AddSingleton<FrmDungLuong>();
            services.AddSingleton<FrmMauSac>();
            services.AddSingleton<FrmQuenMK>();
            services.AddSingleton<FrmThongKe>();

            //services.AddTransient<SomeOtherForm>();
        }
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
            using var serviceProvider = services.BuildServiceProvider();
            // Khởi tạo và chạy ứng dụng
            var form = serviceProvider.GetRequiredService<FrmMain>();
            Application.Run(form);

        }

    }
}