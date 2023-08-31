using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FFImageLoading.Maui
{
	public static class HostingExtensions
	{
		public static MauiAppBuilder UseFFImageLoading(this MauiAppBuilder mauiAppBuilder)
		{

			FFImageLoading.HostingExtensions.RegisterServices(mauiAppBuilder.Services);

			mauiAppBuilder.ConfigureMauiHandlers(c =>
			{
				c.AddHandler(typeof(CachedImage), typeof(Platform.CachedImageHandler));
			});

			return mauiAppBuilder;
		}
	}
}
