// Copyright (c) Yhd Tech. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using Yhd.TencentSCF.Configuration;

namespace Yhd.TencentSCF.Runtime
{
    /// <summary>
    /// Extension methods for setting up SCF services in a <see cref="IServiceCollection" />.
    /// </summary>
    internal static class SCFServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the SCF services to the provided <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static ISCFBuilder AddSCF(this IServiceCollection services, Action<SCFHostOptions> configure,IConfigurationRoot configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.Configure(configure);

            // Core host services
            services.TryAddSingleton<ISCFHost, SCFHost>();
            services.TryAddTransient<IFunctionInvoker, FunctionInvoker>();
            var builder = new SCFBuilder(services, configuration);
            builder.AddBuiltInBindings();

            return builder;
        }
    }
}

