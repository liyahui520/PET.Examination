using Microsoft.AspNetCore.Antiforgery;
using PET.Examination.Controllers;

namespace PET.Examination.Web.Host.Controllers
{
    public class AntiForgeryController : ExaminationControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
