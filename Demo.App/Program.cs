using Demo.App.Controllers;
using SIS.HTTP.Enums;
using SIS.WebServer;
using SIS.WebServer.Result;
using SIS.WebServer.Routing;
using SIS.WebServer.Routing.Contracts;

namespace Demo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            //[GET] MAPPING
            serverRoutingTable.Add(HttpRequestMethod.Get, "/", httpRequest 
                => new HomeController().Home(httpRequest));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Login", httpRequest
                => new HomeController().Login(httpRequest));
            serverRoutingTable.Add(HttpRequestMethod.Get, "/Logout", httpRequest
                => new HomeController().Logout(httpRequest));
            //[POST] MAPPING
            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}
