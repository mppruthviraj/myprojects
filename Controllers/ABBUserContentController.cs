using ABB_Portal.Models.ABBEntityModels.ABBModels;
using ABB_Portal.Models.ABBEntityModels.Initializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABB_Portal.Controllers
{
    public class ABBUserContentController : Controller
    {
        // GET: ABBUserContent
        public ActionResult Index()
        {
            return View("~/Views/ABBViews/ABBUserPages/ABB_Front_Home.cshtml");
        }

        public ActionResult DisplaySubCategories(string categoryId)
        {
            switch (categoryId)
            {
                case "1":
                    ViewBag.GeneraionLink = "11";
                    ViewBag.TransmissionLink = "12";
                    ViewBag.DistributionLink = "13";
                    ViewBag.Title = "Utilities";
                    break;

                case "2":
                    ViewBag.GeneraionLink = "21";
                    ViewBag.TransmissionLink = "22";
                    ViewBag.DistributionLink = "23";
                    ViewBag.Title = "Industries";
                    break;
                case "3":
                    ViewBag.GeneraionLink = "31";
                    ViewBag.TransmissionLink = "32";
                    ViewBag.DistributionLink = "33";
                    ViewBag.Title = "Transportation and infrastructure";
                    break;
                default:
                    ViewBag.GeneraionLink = "#";
                    ViewBag.TransmissionLink = "#";
                    ViewBag.DistributionLink = "#";
                    break;


            }
            return View("~/Views/ABBViews/ABBUserPages/ABB_SubCategory.cshtml");
        }

        public ActionResult DisplayLineOfBusiness(string categoryId)
        {
            ABBPortalContext dbCtx = new ABBPortalContext();
            List<ABBTestimonials> filteredConventionalRecords = new List<ABBTestimonials>();
            List<ABBTestimonials> filteredRenewaleRecords = new List<ABBTestimonials>();

            List<ABBTestimonialDisplay> collectionOfDisplayItemsCon = new List<ABBTestimonialDisplay>();
            List<ABBTestimonialDisplay> collectionOfDisplayItemsRen = new List<ABBTestimonialDisplay>();

            switch (categoryId)
            {
                case "11":

                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Generation";

                    break;
                case "12":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Transmission";

                    break;
                case "13":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Utilities && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Distribution";

                    break;

                case "21":

                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Generation";

                    break;
                case "22":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Transmission";
                    break;
                case "23":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.Industries && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Distribution";
                    break;

                case "31":

                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Generation && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Generation";
                    break;
                case "32":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Transmission && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Transmission";
                    break;
                case "33":
                    filteredConventionalRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Conventional).ToList();
                    filteredRenewaleRecords = dbCtx.ABBTestimonials.Where(mo => mo.Category == Models.ABBEntityModels.ABBModels.Enums.ABB_Category.TransactionAndInfrastructure && mo.SubCategory == Models.ABBEntityModels.ABBModels.Enums.ABB_SubCategory.Distribution && mo.LineOfBusiness == Models.ABBEntityModels.ABBModels.Enums.ABB_LineOfBusiness.Renewable).ToList();


                    foreach (ABBTestimonials eachTestimonialCon in filteredConventionalRecords)
                    {
                        ABBTestimonialDisplay displayItemCon = new ABBTestimonialDisplay();
                        displayItemCon.RecordId = eachTestimonialCon.Id;
                        displayItemCon.RecordTitle = eachTestimonialCon.Title;
                        collectionOfDisplayItemsCon.Add(displayItemCon);
                    }

                    foreach (ABBTestimonials eachTestimonialRen in filteredRenewaleRecords)
                    {
                        ABBTestimonialDisplay displayItemRen = new ABBTestimonialDisplay();
                        displayItemRen.RecordId = eachTestimonialRen.Id;
                        displayItemRen.RecordTitle = eachTestimonialRen.Title;
                        collectionOfDisplayItemsRen.Add(displayItemRen);
                    }
                    ViewBag.ConventionalItems = collectionOfDisplayItemsCon;
                    ViewBag.RenewableItems = collectionOfDisplayItemsRen;
                    ViewBag.Title = "Distribution";
                    break;

                default: break;


            }
            return View("~/Views/ABBViews/ABBUserPages/ABB_LOB.cshtml");
        }

        
        
        public ActionResult DisplayTestimonials(string recordId)
        {
            ABBTestimonials displayRecord = new ABBTestimonials();
            try
            {
                ABBPortalContext dbCtx = new ABBPortalContext();
                Int32 itemId = Convert.ToInt32(recordId);
                displayRecord = dbCtx.ABBTestimonials.Where(re => re.Id == itemId).FirstOrDefault();
                return View("~/Views/ABBViews/ABBUserPages/ABB_TestimonialContent.cshtml", displayRecord);
            }
            catch (Exception ex)
            {
                return View("~/Views/ABBViews/ABBUserPages/ABB_TestimonialContent.cshtml", displayRecord);
            }
        }

        public ActionResult ReadMoreTestimonial(string recordId)
        {
            ABBTestimonials displayRecord = new ABBTestimonials();
            try
            {
                ABBPortalContext dbCtx = new ABBPortalContext();
                Int32 itemId = Convert.ToInt32(recordId);
                displayRecord = dbCtx.ABBTestimonials.Where(re => re.Id == itemId).FirstOrDefault();
                return View("~/Views/ABBViews/ABBUserPages/ABB_CompleteContent.cshtml", displayRecord);
            }
            catch (Exception ex)
            {
                return View("~/Views/ABBViews/ABBUserPages/ABB_CompleteContent.cshtml", displayRecord);
            }
        }

        public ActionResult PictureGallery(string recordId)
        {
            ABBTestimonials displayRecord = new ABBTestimonials();
            try
            {
                ABBPortalContext dbCtx = new ABBPortalContext();
                Int32 itemId = Convert.ToInt32(recordId);
                displayRecord = dbCtx.ABBTestimonials.Where(re => re.Id == itemId).FirstOrDefault();
                return View("~/Views/ABBViews/ABBUserPages/ABB_PictureGallery.cshtml", displayRecord); 
            }
            catch(Exception ex)
            {
                return View("~/Views/ABBViews/ABBUserPages/ABB_PictureGallery.cshtml", displayRecord);
            }
        }
    }
}