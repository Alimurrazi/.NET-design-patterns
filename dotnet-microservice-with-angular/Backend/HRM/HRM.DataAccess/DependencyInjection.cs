using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<HRMDbContext>(options => options.UseSqlServer(connectionString ??
                        throw new ArgumentNullException(connectionString)));

            return services;
        }
    }
}
