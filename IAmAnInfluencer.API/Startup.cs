using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using IAmAnInfluencer.Infra.Common;
using IAmAnInfluencer.Infra.Repository;
using IAmAnInfluencer.Infra.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

            services.AddAuthentication(

                 x =>
                 {
                     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                 }

                ).AddJwtBearer(

                y =>
                {
                    y.RequireHttpsMetadata = false;
                    y.SaveToken = true;
                    y.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();

            //Repository
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDeductionEmployeeRepository, DeductionEmployeeRepository>();
            services.AddScoped<IDeductionRepository, DeductionRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
            services.AddScoped<IFeedbackRepository, FeedbackRepository>();
            services.AddScoped<IIAmAnInfluncerRepository, IAmAnInfluncerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJWTRepository, JWTRepository>();

            //Service
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IDeductionEmployeeService, DeductionEmployeeService>();
            services.AddScoped<IDeductionService, DeductionService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IIAmAnInfluncerService, IAmAnInfluncerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJWTService, JWTService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                    .AllowCredentials()); // allow credentials
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
