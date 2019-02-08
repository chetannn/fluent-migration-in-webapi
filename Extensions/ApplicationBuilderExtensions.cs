using System;
using Microsoft.AspNetCore.Builder;
using MyApp.Migration;

namespace MyApp.API.Extensions
{
  public static class ApplicationBuilderExtensions
  {
    public static IApplicationBuilder UseAppMigration(this IApplicationBuilder app)
    {
      if (app == null) throw new ArgumentNullException(nameof(app));


      MyMigration migration = new MyMigration();
      migration.InitMigration();
      return app;
    }
  }
}