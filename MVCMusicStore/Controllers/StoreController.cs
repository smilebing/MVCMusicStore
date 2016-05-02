﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public String Index()
        {
            return "hello from Store.index()";
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse,Genre=" + genre);
            return message;
        }

        public string Details(int id)
        {
            string message = "Store.Details,ID=" + id;
            return message;
        }

        public ActionResult List()
        {
           
        }
	}
}