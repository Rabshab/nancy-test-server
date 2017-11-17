using System;
using Nancy;
using nancy_test_server;

public class HomeModule : NancyModule
{
  public HomeModule()
  {
    Get("/", _ => this.getWebsite());
  }

  private dynamic getWebsite()
  {
    return View["index.html"];
  }
}