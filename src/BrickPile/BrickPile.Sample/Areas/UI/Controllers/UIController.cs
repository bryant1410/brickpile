﻿using System.Web.Mvc;

namespace BrickPile.UI.Controllers {
    [Authorize]
    public class UIController : Controller {
        public ActionResult Index() {
            if(Request.IsAjaxRequest()) {
                return PartialView("Index");
            }
            return View("Index");
        }
    }
}
