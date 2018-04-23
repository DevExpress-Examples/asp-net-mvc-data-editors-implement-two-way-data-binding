using System.Web.Mvc;

namespace EditorsModelBinding.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Editors() {
            return View(ListsDataHelper.GetSampleCustomer());
        }

        [HttpPost]
        public ActionResult Editors(CustomerInfo model) {
            return View("Details", model);
        }

        public ActionResult FormLayout() {
            return View(ListsDataHelper.GetSampleCustomer());
        }

        [HttpPost]
        public ActionResult FormLayout(CustomerInfo model) {
            return View("Details", model);
        }
    }
}