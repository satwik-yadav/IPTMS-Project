using IPTreatmentManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace IPTreatmentManagementPortal.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static string token= null;
        private IConfiguration configuration;
        TreatmentPlan plan;
        static int pId =1;
        FinalAmount finalAmount;
     
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));
        public HomeController(ILogger<HomeController> logger, IConfiguration _configuration)
        {
            _logger = logger;
            configuration = _configuration;
        }

       
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public ActionResult Login()
        {
            _log4net.Info("Admin is logging in");
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> PostLogin([FromForm] User cred)
        {
            if (ModelState.IsValid)
            {
                _log4net.Info("Post Login is called");
                User loginCred = new User();
                

                string userName;

                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(cred), Encoding.UTF8, "application/json");
                    string authUri = configuration.GetValue<string>("MyLinkValue:authUri");
                    httpClient.BaseAddress = new Uri(authUri);

                    try
                    {
                        using (var response = await httpClient.PostAsync("api/Auth", content))
                        {

                            if (!response.IsSuccessStatusCode)
                            {
                                _log4net.Info("Login failed");
                                ViewBag.Message = "Please Enter valid credentials";
                                return View("Login");
                            }
                            _log4net.Info("Login Successful and token generated");
                            string strtoken = await response.Content.ReadAsStringAsync();


                            loginCred = JsonConvert.DeserializeObject<User>(strtoken);
                            userName = cred.Username;
                            token = strtoken;

                        }
                    }

                    catch(Exception ex)
                    {
                        _log4net.Error("Authorisation Microservice is Down!! Exception " + ex + " occured");
                        ViewBag.erroroccured = "Some Error Occured";
                        return View("~/Views/Shared/Error.cshtml");
                    }
                    
                }

                if (token == null)
                {
                    return RedirectToAction("Login");
                }

                return View("~/Views/Home/Index.cshtml");
            }

            else
            {
                ViewBag.Message = "Username or Password cannot be empty!";
               
                return RedirectToAction("Login");
            }

        }

        public ActionResult Logout()
        {
           token= null;

            return View("Login");
        }



        [HttpGet]
        public async Task<ActionResult> GetPackages()
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }

            using (var httpClient = new HttpClient())
            {
                string offeringUri = configuration.GetValue<string>("MyLinkValue:offeringUri");
                httpClient.BaseAddress = new Uri(offeringUri);
                
                try
                {
                    using (var response = await httpClient.GetAsync("api/Offering/IPTreatmentPackages"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        List<PackageDetail> res = JsonConvert.DeserializeObject<List<PackageDetail>>(apiResponse);
                        _log4net.Info("Treatman offering microservice returned response.");

                        if (res == null)
                        {
                            _log4net.Info("Null response from treatment microservice.");
                            return NoContent();
                        }
                        else
                        {
                            _log4net.Info("Displaying treatment packages.");
                            return View(res);
                        }
                    }
                }

                catch (Exception ex)
                {
                    _log4net.Error("Treatment Offering Microservice is Down!! Exception " + ex + " occured");
                    ViewBag.erroroccured = "Some Error Occured";
                    return View("~/Views/Shared/Error.cshtml");
                }


            }

        }
        
          

        [HttpGet]
        public ActionResult RegisterPatient()
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }
            _log4net.Info("Admin is registering New Patient");
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> NewPatient([FromForm] Patient patient)
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                _log4net.Info("NewPatient is called. Patient is registering");

                using (var httpClient = new HttpClient())
                {
                    string treatmentUri = configuration.GetValue<string>("MyLinkValue:treatmentUri");
                    httpClient.BaseAddress = new Uri(treatmentUri);
                   
                    try
                    {
                        using (var response = await httpClient.GetAsync("api/Treatment/FormulateTreatmentTimetable?Id=" + pId + "&Name=" + patient.Name + "&Age=" + patient.Age + "&Ailment=" + patient.Ailment + "&TreatmentPackageName=" + patient.TreatmentPackageName + "&CommencementDate=" + patient.CommencementDate))
                        {

                            if (!response.IsSuccessStatusCode)
                            {
                                _log4net.Info("Register Patient failed");
                                ViewBag.Message = "Please Enter valid details";
                                return View("RegisterPatient");
                            }
                            else
                            {
                                var jsoncontent = await response.Content.ReadAsStringAsync();
                                plan = JsonConvert.DeserializeObject<TreatmentPlan>(jsoncontent);
                                _log4net.Info("Treatment microservice returned response.");
                                _log4net.Info("Displaying treatment plan.");
                                pId++;
                                return View(plan);

                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        _log4net.Error("Treatment Microservice is Down!! Exception " + ex + " occured");
                        ViewBag.erroroccured = "Some Error Occured";
                        return View("~/Views/Shared/Error.cshtml");
                    }

                }
                
            }
            
            else{
                ViewBag.Message = "Please Enter all the details!";
                return RedirectToAction("RegisterPatient");
            }
            
        }



        
        [HttpGet]
               
        public async Task<ActionResult> GetInsurerDetail()
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }

            using (var httpClient = new HttpClient())
            {
          
                string claimsUri = configuration.GetValue<string>("MyLinkValue:claimsUri");
                httpClient.BaseAddress = new Uri(claimsUri);
 
                _log4net.Info("GetInsurerDetail is called.");

                try
                {
                    using (var response = await httpClient.GetAsync("api/Insurance/AllInsurerDetail"))
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();
                        List<InsurerDetail> res = JsonConvert.DeserializeObject<List<InsurerDetail>>(apiResponse);
                        _log4net.Info("Insurance Claim microservice returned response.");


                        if (res == null)
                        {
                            _log4net.Info("Insurance Claim Api response is null.");
                            return NoContent();
                        }
                        else
                        {
                            _log4net.Info("Insurer details is displayed.");
                            return View(res);
                        }
                    }
                }

                catch (Exception ex)
                {
                    _log4net.Error("Insuranc Claims Microservice is Down!! Exception " + ex + " occured");
                    ViewBag.erroroccured = "Some Error Occured";
                    return View("~/Views/Shared/Error.cshtml");
                }


            }

        }

        

        [HttpGet]
        public ActionResult InitiateClaim()
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }
            _log4net.Info("Admin is initiating insurance claim for Patient");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetFinalAmount([FromForm] InitiateClaim claim)
        {
            if (token == null)
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                _log4net.Info("GetFinalAmount is called");

                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(claim), Encoding.UTF8, "application/json");
                    string claimsUri = configuration.GetValue<string>("MyLinkValue:claimsUri");
                    httpClient.BaseAddress = new Uri(claimsUri);
                    try
                    {
                        using (var response = await httpClient.PostAsync("api/Insurance/GetBalance", content))
                        {

                            if (!response.IsSuccessStatusCode)
                            {
                                _log4net.Info("Initiate Claim failed");
                                ViewBag.Message = "Please Enter valid details";
                                return View("InitiateClaim");
                            }
                            else
                            {
                                finalAmount = new FinalAmount();
                                var jsoncontent = await response.Content.ReadAsStringAsync();
                                finalAmount.Amount = JsonConvert.DeserializeObject<int>(jsoncontent);
                                _log4net.Info("Insurance Claim microservice returned response.");
                                
                                _log4net.Info("Displaying Amount.");
                                return View(finalAmount);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _log4net.Error("Insurance Claims Microservice is Down!! Exception " + ex + " occured");
                        ViewBag.erroroccured = "Some Error Occured";
                        return View("~/Views/Shared/Error.cshtml");
                    }
                }             
            }

            else
            {
                ViewBag.Message = "Please Enter all the details!";
                return RedirectToAction("InitiateClaim");
            }
        }



    }
}
