using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Hladir.CSharp.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioProjectFileNameConventions"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileNameConventions(this IServiceCollection services)
        {
            services.AddVisualStudioProjectFileNameConventions(
                services.AddCSharpVisualStudioProjectFileNameConventionsAction(
                    new ServiceAction<IFileNameOperator>(() => services.AddSingleton<IFileNameOperator, FileNameOperator>())));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioProjectFileNameConventions"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioProjectFileNameConventions> AddVisualStudioProjectFileNameConventionsAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioProjectFileNameConventions>(() = services.AddVisualStudioProjectFileNameConventions());
            return serviceAction;
        }
    }
}
