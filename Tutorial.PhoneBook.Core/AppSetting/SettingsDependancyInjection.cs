﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Core.AppSetting
{
    public static class SettingsDependancyInjection
    {
        public static SqlAppSetting SqlSettings { get; } = new();
        public static void Init(IConfiguration configuration)
        {
            var sqlSection = configuration.GetSection(SqlAppSetting.SectionName);
            sqlSection.Bind(SqlSettings);
        }
        public static void AddSettingsDependancyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SqlAppSetting>(configuration.GetSection(SqlAppSetting.SectionName));
            Init(configuration);
        }

     }
}
