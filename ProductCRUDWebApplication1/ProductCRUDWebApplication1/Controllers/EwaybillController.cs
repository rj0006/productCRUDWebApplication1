using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ProductCRUDWebApplication1.Models;
using ProductCRUDWebApplication1.Helper;
using static System.Net.Mime.MediaTypeNames;
using System.EnterpriseServices;
using System.Security.Policy;

namespace ProductCRUDWebApplication1.Controllers
{
    public class EwaybillController : Controller
    {
        public class StateModel
        {
            public int StateId { get; set; }
            public string StateName { get; set; }
            public string API_USER { get; set; }
            public string API_PASSWORD { get; set; }
            public int? CityId { get; set; } // Nullable if CityId can be null
            public string GstTinNo { get; set; }
        }
        public class StateMasterRepository
        {
            public IEnumerable<StateModel> GetAll()
            {
                return DataBaseFactory.QuerySP<StateModel>("Ewaybill_Detail", (object)null, "State Master - GetAll");
            }
        }
        public class StateService
        {
            private StateMasterRepository _repository;
            public StateService()
            {
                _repository = new StateMasterRepository();
            }
            public IEnumerable<StateModel> GetAllMasterCustomers()
            {
                return _repository.GetAll();
            }
        }


        // [Authorize]
        public ActionResult Index()
        {
            StateService stateService = new StateService();
            IEnumerable<StateModel> allCustomers = stateService.GetAllMasterCustomers();
            return View(allCustomers);
        }

        public class EwayBillModel
        {
            public int StateId { get; set; } // Adjust data type as needed
            public string EwbNo { get; set; }
        }
        [HttpPost]
        public async Task<ActionResult> GetData(EwayBillModel model)
        {
            if (ModelState.IsValid)
            {
                StateService stateService = new StateService();
                IEnumerable<StateModel> allState = stateService.GetAllMasterCustomers();

                var dbStateId = allState.Select(s => s.StateId);
                var ajaxStateId = model.StateId;

                StateModel stateData = allState.FirstOrDefault(s => s.StateId == model.StateId);
                
                string ewbNo = model.EwbNo;
                if (stateData != null)
                {
                    var httpClient = new HttpClient();

                    var authHeaderValue = new System.Net.Http.Headers.AuthenticationHeaderValue("Authorization", "IalkRmh3z4=:::ZH4TUvIeJ3A=");

                    // Set the Authorization header using DefaultRequestHeaders
                    httpClient.DefaultRequestHeaders.Authorization = authHeaderValue;

                    dynamic requestBody = new System.Dynamic.ExpandoObject();
                    requestBody.ewbNo = ewbNo;
                    requestBody.EWBUserName = stateData.API_USER;
                    requestBody.EWBPassword = stateData.API_PASSWORD;
                    requestBody.GSTIN = stateData.GstTinNo;
                    if (stateData.StateId == 4) // for use testing scenario
                    {
                        requestBody.Year = 2017;
                        requestBody.Month = 1;
                        requestBody.EFUserName = "29AAACW3775F000";
                        requestBody.EFPassword = "Admin!23..";
                        requestBody.CDKey = 1000687;
                    }
                    else // it live scenrio
                    {
                        requestBody.Year = 2024;
                        requestBody.Month = 6;
                        requestBody.EFUserName = "039C10BA-5F49-4C9C-98B7-2B14AAFA38E8";
                        requestBody.EFPassword = "1D4331EF-1DFB-43D3-A065-4F24DBBEB1CD";
                        requestBody.CDKey = 1550859;
                    }

                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    string url = stateData.StateId == 4
                        ? "http://ewaysandbox.webtel.in/Sandbox/EWayBill/v1.3/GetEWB"
                        : "http://ewayasp.webtel.in/EWayBill/v1.3/GetEWB";
                    
                    var response = await httpClient.PostAsync(url, content);

                    ViewBag.statusCode = response;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        dynamic parsedResponse = JsonConvert.DeserializeObject(responseData);
                            
                        return Json(parsedResponse);
                    }
                    else { 
                        string responseData = null;
                        return View(responseData);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "No data found for the provided ID.");
                }
            }
            // If model state is not valid or no data found, return to the same view with the entered ID.
            return View(model);
        }

        public class ExtendValidityModel
        {
            public int StateId { get; set; }
            public string EwbNo { get; set; }
            public string currentPlace { get; set; }
            public string currentPincode { get; set; }
            public string currentState { get; set; }
            public string totalKm { get; set; }
            public string mode { get; set; }
            public string vehicleNo { get; set; }
            public string transporterDoc { get; set; }
            public string transporterDate { get; set; }
        }

        [HttpPost]
        public ActionResult ExtendEwbValidity(ExtendValidityModel validityModel)
        {
            StateService stateService = new StateService();
            IEnumerable<StateModel> allState = stateService.GetAllMasterCustomers();
            var dbStateId = allState.Select(s => s.StateId);
            var ajaxStateId = validityModel.StateId;
            StateModel stateData = allState.FirstOrDefault(s => s.StateId == validityModel.StateId);

            var requestBody = new
            {
                Push_Data_List = new[]
                {
                    new
                    {
                        EWBNumber = validityModel.EwbNo,
                        TransMode = validityModel.mode,
                        VehicleNumber = validityModel.vehicleNo
                    }
                },
                EFUserName = stateData.StateId == 4 ? "29AAACW3775F000" : "039C10BA-5F49-4C9C-98B7-2B14AAFA38E8",
                EFPassword = stateData.StateId == 4 ? "Admin!23.." : "1D4331EF-1DFB-43D3-A065-4F24DBBEB1CD",
                CDKey = stateData.StateId == 4 ? 1000687 : 1550859,
            };

            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            if (content != null)
            {
                var responseData = content.ReadAsStringAsync().Result;
                dynamic parsedResponse = JsonConvert.DeserializeObject(responseData);

                return Json(parsedResponse);
            }
            else { }

            return View(validityModel);
        }
    }
}
