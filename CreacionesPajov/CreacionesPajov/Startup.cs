using CreacionesPajov.WEB.Models.Abstract;
using CreacionesPajov.WEB.Models.Abstract.IColorHilo;
using CreacionesPajov.WEB.Models.Abstract.IColorTela;
using CreacionesPajov.WEB.Models.Abstract.IHilos;
using CreacionesPajov.WEB.Models.Abstract.ILoteHilo;
using CreacionesPajov.WEB.Models.Abstract.ILoteTela;
using CreacionesPajov.WEB.Models.Abstract.IOperacion;
using CreacionesPajov.WEB.Models.Abstract.IProduccion;
using CreacionesPajov.WEB.Models.Abstract.IProveedorHilo;
using CreacionesPajov.WEB.Models.Abstract.IProveedorTela;
using CreacionesPajov.WEB.Models.Abstract.IRemision;
using CreacionesPajov.WEB.Models.Abstract.ISubFase;
using CreacionesPajov.WEB.Models.Abstract.ITelas;
using CreacionesPajov.WEB.Models.Abstract.ITipoNovedadEmpleado;
using CreacionesPajov.WEB.Models.Abstract.ITipoPrendas;
using CreacionesPajov.WEB.Models.Abstract.IUsuario;
using CreacionesPajov.WEB.Models.Bussines;
using CreacionesPajov.WEB.Models.Bussines.ServiceColorHilos;
using CreacionesPajov.WEB.Models.Bussines.ServiceColorTela;
using CreacionesPajov.WEB.Models.Bussines.ServiceHilos;
using CreacionesPajov.WEB.Models.Bussines.ServiceLoteHilo;
using CreacionesPajov.WEB.Models.Bussines.ServiceProduccion;
using CreacionesPajov.WEB.Models.Bussines.ServiceProveedorHilo;
using CreacionesPajov.WEB.Models.Bussines.ServiceProveedorTela;
using CreacionesPajov.WEB.Models.Bussines.ServiceRemision;
using CreacionesPajov.WEB.Models.Bussines.ServicesOperacion;
using CreacionesPajov.WEB.Models.Bussines.ServicesSubFase;
using CreacionesPajov.WEB.Models.Bussines.ServicesTelas;
using CreacionesPajov.WEB.Models.Bussines.ServiceTipoNovedadEmpleados;
using CreacionesPajov.WEB.Models.Bussines.ServiceTipoPrendas;
using CreacionesPajov.WEB.Models.Bussines.ServiceUsuario;
using CreacionesPajov.WEB.Models.DAL;
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreacionesPajov
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
            services.AddControllersWithViews();

            var conexion = Configuration["ConnectionStrings:MySql"];//Obtenemos la cadena de conexion
            // Convertimos nuestra conexion en un servicio para utilizarla en todas partes
            services.AddDbContext<AppDbContext>(option =>
            option.UseMySql(conexion, ServerVersion.AutoDetect(conexion))
            );

            services.AddScoped<IEmpleadoService, EmpleadoService>();
            services.AddScoped<ITipoDocumentoService, TipoDocumentoService>();
            services.AddScoped<ITipoOperacionService, TipoOperacionService>();
            services.AddScoped<IOperacionService, OperacionServices>();
            services.AddScoped<IFaseService, FaseService>();
            services.AddScoped<ISubFaseService, SubFaseServices>();
            services.AddScoped<IRemisionService, RemisionService>();
            services.AddScoped<IColorHiloService, ColorHiloService>();
            services.AddScoped<IHilosService, HilosService>();
            services.AddScoped<ITelasService, TelasService>();
            services.AddScoped<IColorTelaService, ColorTelaService>();
            services.AddScoped<IProveedorTelaService, ProveedorTelaService>();
            services.AddScoped<ITipoPrendaService, TipoPrendaService>();
            services.AddScoped<IProveedorHiloService, ProveedorHiloService>();
            services.AddScoped<ITipoNovedadEmpleadoService, TipoNovedadEmpleadoService>();
            services.AddScoped<IProduccionService, ProduccionService>();
            //services.AddScoped<IAdministradorService, AdministradorService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ILoteHiloService,  LoteHiloService>();
            services.AddScoped<ILoteTelaService, LoteTelaService>();
       

            //Indentity

            services.AddIdentity<Usuario, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
              //.AddDefaultUI()
              .AddDefaultTokenProviders() //para trabajar con la confirmación de email
              .AddEntityFrameworkStores<AppDbContext>();
            //.AddClaimsPrincipalFactory<UsuarioClaimsPrincipalFactory>();

            //configuración del password
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 9;
                options.User.RequireUniqueEmail = true;
            });


            //Creamos las cookies para el inicio de sesión y el tiempo de lo que va a durar abierta si el usuario no la cierra.
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Admin/NoAutorizado");
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath = new PathString("/Usuarios/Login");
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });



        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Shared/Error");
                //  The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Usuarios}/{action=Landing}/{id?}");
            });
            Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa");
        }
    }
}
