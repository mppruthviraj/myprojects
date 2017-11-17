using ABB_Portal.Models.ABBEntityModels.ABBModels;
using ABB_Portal.Models.ABBEntityModels.Initializers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABB_Portal.Controllers
{
    [HandleError]
    public class ABBTestimonialsController : Controller
    {
        
        // GET: ABBAddTestimonials
        public ActionResult Index()
        {
            return View("~/Views/ABBViews/ABB_Home.cshtml");
        }

        [Authorize]
        // GET: ABBAddTestimonials
        public ActionResult NavigateToAddTestimonials()
        {
            return View("~/Views/ABBViews/ABBTestimonials/ABB_AddTestimonials.cshtml");
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddTestimonials(ABBTestimonials postedModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    for (int i = 0; i < Request.Files.Count; i++)
                    {
                        HttpPostedFileBase file = Request.Files[i];
                        bool isDirectoryExists = Directory.Exists(Server.MapPath(@"~/AllImages"));
                        if(!isDirectoryExists)
                        {
                            Directory.CreateDirectory(Server.MapPath(@"~/AllImages"));
                        }

                        var targetPath = Path.Combine(Server.MapPath(@"~/AllImages"), string.Format("File{0}~{1}", GenerateRanomNumber(), file.FileName));
                        string filename = Path.GetFileName(file.FileName);
                        file.SaveAs(targetPath);
                        if (string.IsNullOrEmpty(postedModel.ImageName))
                        {
                            postedModel.ImageName = targetPath;
                        }
                        else
                        {
                            postedModel.ImageName = string.Join(",", postedModel.ImageName, targetPath);
                        }

                    }

                    ABBPortalContext dbCtx = new ABBPortalContext();
                    dbCtx.ABBTestimonials.Add(postedModel);
                    dbCtx.SaveChanges();
                    dbCtx.Dispose();
                    ModelState.Clear();
                    return RedirectToAction("ViewTestimonials");
                }
                return View("~/Views/ABBViews/ABBTestimonials/ABB_AddTestimonials.cshtml");

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("~/Views/ABBViews/ABBTestimonials/ABB_AddTestimonials.cshtml");
            }
        }

        private long GenerateRanomNumber()
        {
            Random random = new Random();
            return random.Next(1, 100000);
        }

        [Authorize]
        [HttpGet]
        public ActionResult ViewTestimonials()
        {
            List<ABBTestimonials> modifiedRecords = new List<ABBTestimonials>();
            try
            {
                ABBPortalContext dbCtx = new ABBPortalContext();
                List<ABBTestimonials> allRecords = dbCtx.ABBTestimonials.ToList();

                foreach (ABBTestimonials eachRecord in allRecords)
                {
                    string[] imageNameArray = eachRecord.ImageName.Split(',');
                    eachRecord.ImageName = "";
                    for (int i = 0; i < imageNameArray.Length; i++)
                    {
                        int startIndex = imageNameArray[i].LastIndexOf('~') + 1;
                        int endIndex = imageNameArray[i].Length - startIndex;
                        string onlyFileName = imageNameArray[i].Substring(startIndex, endIndex);
                        if(string.IsNullOrEmpty(eachRecord.ImageName))
                        {
                            eachRecord.ImageName = onlyFileName;
                        }
                        else
                        {
                            eachRecord.ImageName = string.Join(",", eachRecord.ImageName, onlyFileName);
                        }                       
                        
                    }
                    modifiedRecords.Add(eachRecord);
                }
                return View("~/Views/ABBViews/ABBTestimonials/ABB_ViewTestimonials.cshtml", modifiedRecords);
            }

            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("~/Views/ABBViews/ABBTestimonials/ABB_ViewTestimonials.cshtml", modifiedRecords);
            }


        }

    }
}

