using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GioCong.Data.Commons
{
    public static class AutoMapperResolver
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
        
