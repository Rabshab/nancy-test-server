using Nancy;
using Nancy.Configuration;

public class Bootstrapper : DefaultNancyBootstrapper
{
  public override void Configure(INancyEnvironment environment)
  {
    environment.Tracing(
        enabled: true,
        displayErrorTraces: true);
  }
}