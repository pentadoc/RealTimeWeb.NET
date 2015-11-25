﻿using System;
using System.Web.Http;

namespace Soloco.RealTimeWeb.Common.Infrastructure.DryIoc
{
    public static class HttpDependencyExtensions
    {
        public static HttpConfiguration RegisterDependencyResolver(this HttpConfiguration config, Action<IContainer> initializer)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));

            config.DependencyResolver = new HttpDependencyResolver(initializer);

            return config;
        }
    }
}