using System.Web.Mvc;

namespace EShop.Areas.FrontEnd
{
    public class FrontEndAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "FrontEnd";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "FrontEnd_default",
                "FrontEnd/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
