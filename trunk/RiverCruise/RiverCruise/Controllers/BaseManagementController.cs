using System.Web.Mvc;

namespace RiverCruise.Controllers
{
    [Authorize(Roles = "Edit")]
    public class BaseManagementController : BaseController
    {
         
    }
}