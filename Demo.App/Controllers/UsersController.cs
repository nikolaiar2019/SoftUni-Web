using SIS.HTTP.Requests.Contracts;
using SIS.HTTP.Responses.Contracts;

namespace Demo.App.Controllers
{
    public class UsersController : BaseController
    {
        public IHttpResponse Login(IHttpRequest httpRequest)
        {
            httpRequest.Session.AddParameter("username", "Pesho");
            return this.Redirect("/");
        }

        public IHttpResponse LoginConfirm(IHttpRequest httpRequest)
        {

        }
        public IHttpResponse Register(IHttpRequest httpRequest)
        {

        }

        public IHttpResponse RegisterConfirm(IHttpRequest httpRequest)
        {

        }

        public IHttpResponse Logout(IHttpRequest httpRequest)
        {
            if (this.IsLoggedIn())
            {
                httpRequest.Session.ClearParameters();
                return this.Redirect("/");
            }
            return this.Redirect("/");
        }
    }
}
