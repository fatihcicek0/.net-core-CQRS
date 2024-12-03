using CQRS_.net_core.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_.net_core.Mapper
{
    public static  class Registration
    {
        public static void  AddCustomMapper(this IServiceCollection services) {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
