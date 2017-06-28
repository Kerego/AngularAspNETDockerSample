using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{

	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
					.SetBasePath(env.ContentRootPath)
					.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
					.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
					.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Add framework services.
			services.AddDbContext<StandUpContext>(x =>
				x.UseSqlServer("Server=db;Database=dockersample;User Id=sa;Password=100De100!"));
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(
			IApplicationBuilder app,
			IHostingEnvironment env,
			ILoggerFactory loggerFactory,
			StandUpContext context)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			context.Database.Migrate();

			if (context.Presentations.Count() < 3)
			{
				context.Presentations.Add(new Presentation
				{
					Title = "Embracing New Technologies",
					Speaker = "Bejenari Marian",
					Sections = new List<Section>
					{
						new Section
						{
							Name = ".Net Core"
						},
						new Section
						{
							Name = "Angular"
						}
					},
				});
				context.Presentations.Add(new Presentation
				{
					Title = "Leadership Development",
					Speaker = "Marin Efros",
					Sections = new List<Section>
					{
						new Section
						{
							Name = "Leadership"
						},
					},
				});
				context.Presentations.Add(new Presentation
				{
					Title = "Black Box",
					Speaker = "Unknown",
					Sections = new List<Section>
					{
						new Section
						{
							Name = "Unknown"
						},
					},
				});
				context.SaveChanges();
			}

			app.UseMvc();
		}
	}
}
