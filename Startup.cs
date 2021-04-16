using API_VNG.Repository;
using API_VNG.Repository.BanHang;
using API_VNG.Repository.CuaHang;
using API_VNG.Repository.DanhMuc;
using API_VNG.Repository.KhoTong;
using API_VNG.Repository.KhoVungMien;
using API_VNG.Repository.QuanTri;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Threading.Tasks;
using VNG.Business.Models.System;

namespace API_VNG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            //Cấu hình Database
            services.AddDbContext<AppContext>(options =>
                     options.UseSqlServer(
                         Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_VNG", Version = "v1" });
            });
            services.AddScoped<IDapper, Dapper>();
            services.AddTransient<IHeThongRepository, HeThongRepository>();
            services.AddTransient<IDanhMucRepository, DanhMucRepository>();
            services.AddTransient<IBanHangRepository, BanHangRepository>();
            services.AddTransient<ICuaHangRepository, CuaHangRepository>();
            services.AddTransient<IKhoVungMienRepository, KhoVungMienRepository>();
            services.AddTransient<IKhoTongRepository, KhoTongRepository>();
            services.AddTransient<IQuanTriRepository, QuanTriRepository>();
            //Chứng thực token
            var key = Encoding.ASCII.GetBytes("CAITRIMINH");
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        //SYS_User_ViewModel P = new SYS_User_ViewModel();
                        //P.option = 3;
                        //P.TenDangNhap = "admin";
                        //P.MatKhau = "1";
                        //var userService = context.HttpContext.RequestServices.GetRequiredService<IHeThongRepository>();
                        //var userId = context.Principal.Identity.Name;
                        //var user = userService.NguoiDung(P);
                        //if (user == null)
                        //{
                        //    // return unauthorized if user no longer exists
                        //    context.Fail("Unauthorized");
                        //}
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            //Hide Model Schemas default
            // services.AddSwaggerGen(options => options.DocumentFilter<RemoveSchemasFilter>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_VNG v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
