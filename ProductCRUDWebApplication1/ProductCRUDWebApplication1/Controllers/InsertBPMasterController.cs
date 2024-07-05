using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProductCRUDWebApplication1.Controllers
{
    public class InsertBPMasterController : Controller
    {
        // GET: InsertBPMaster
        public async Task<ActionResult> Index1()
        {
            var httpClient = new HttpClient();

            // httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("B1SESSION", "61ca65a0-3773-11ef-8000-000c299aeb53");
            // var insertRequestBody = "{\"CardCode\":\"V0150\",\"CardName\":\"ICICILOMBARDGENERALINSURANCECOLTDtested123\",\"CardType\":\"cSupplier\",\"GroupCode\":105,\"PayTermsGrpCode\":1,\"SalesPersonCode\":-1,\"DefaultAccount\":\"20091867546\",\"DefaultBranch\":\"FARIDABAD\",\"DefaultBankCode\":\"HDFC\",\"CompanyPrivate\":\"cPrivate\",\"Industry\":3,\"U_Controling_Branch\":\"Faridabaad\",\"BPAddresses\":[{\"AddressName\":\"Delhi-1\",\"ZipCode\":\"121001\",\"City\":\"DELHI\",\"Country\":\"IN\",\"State\":\"DL\",\"AddressType\":\"bo_BillTo\",\"AddressName2\":\"PARSAVNATHCAPITALTOWER\",\"AddressName3\":\"FOURTH,BHAIVEERSINGH\",\"BPCode\":\"V0138\",\"RowNum\":0,\"GSTIN\":\"07AAACI7904G1ZP\",\"GstType\":\"gstRegularTDSISD\",\"U_PANNo\":\"AAACI7904G\"},{\"AddressName\":\"Delhi-2\",\"ZipCode\":\"110001\",\"City\":\"Delhi\",\"County\":\"india\",\"Country\":\"IN\",\"State\":\"DL\",\"AddressType\":\"bo_BillTo\",\"AddressName2\":\"TOWERD,,GLOBALBUSINESSPARK,TWELTH,\",\"AddressName3\":\"MEHRAULIGURGAONROAD,\",\"BPCode\":\"V0138\",\"RowNum\":1,\"GSTIN\":\"07AAACI7904G1ZP\",\"GstType\":\"gstRegularTDSISD\",\"U_PANNo\":\"AAACI7904G\"},{\"AddressName\":\"Delhi-1\",\"ZipCode\":\"121001\",\"City\":\"DELHI\",\"Country\":\"IN\",\"State\":\"DL\",\"AddressType\":\"bo_ShipTo\",\"AddressName2\":\"PARSAVNATHCAPITALTOWER\",\"AddressName3\":\"FOURTH,BHAIVEERSINGH\",\"BPCode\":\"V0138\",\"RowNum\":2,\"GSTIN\":\"07AAACI7904G1ZP\",\"GstType\":\"gstRegularTDSISD\",\"CreateDate\":\"2024-06-24\",\"CreateTime\":\"16:49:15\",\"U_PANNo\":\"AAACI7904G\"},{\"AddressName\":\"Delhi-2\",\"ZipCode\":\"110001\",\"City\":\"Delhi\",\"County\":\"india\",\"Country\":\"IN\",\"State\":\"DL\",\"AddressType\":\"bo_ShipTo\",\"AddressName2\":\"TOWERD,,GLOBALBUSINESSPARK,TWELTH,\",\"AddressName3\":\"MEHRAULIGURGAONROAD,\",\"BPCode\":\"V0138\",\"RowNum\":3,\"GSTIN\":\"07AAACI7904G1ZP\",\"GstType\":\"gstRegularTDSISD\",\"U_PANNo\":\"AAACI7904G\"}],\"ContactEmployees\":[{\"CardCode\":\"V0138\",\"Name\":\"JitendraSingh\",\"Position\":\"FleetDepartment\",\"Address\":\"5303Newindustrialarea\",\"MobilePhone\":\"7878787878\",\"E_Mail\":\"fleet@mlpl24x7.com\",\"Title\":\"Mr\",\"Active\":\"tYES\",\"FirstName\":\"Jitendra\",\"LastName\":\"Singh\"},{\"CardCode\":\"V0138\",\"Name\":\"Rahul\",\"Position\":\"FleetIncharge\",\"Address\":\"5303Newindustrial\",\"MobilePhone\":\"7879838798\",\"E_Mail\":\"fleet@mlpl24x7.com\",\"Title\":\"Mr\",\"Active\":\"tYES\",\"FirstName\":\"Rahul\",\"LastName\":\"Pandey\"}],\"BPBankAccounts\":[{\"BPCode\":\"V0138\",\"Branch\":\"FARIDABAD\",\"Country\":\"IN\",\"BankCode\":\"HDFC\",\"AccountNo\":\"20091867546\",\"AccountName\":\"HDFCBANK\",\"BICSwiftCode\":\"HDFC0000093\"}]}";

            var loginRequestBody = new
            {
                CompanyDB = "MLPLTEST1312",
                Password = "9811",
                UserName = "manager"
            };

            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(loginRequestBody);
            // var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var content = new StringContent(jsonString);

            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            string url = "https://103.194.8.71:50000/b1s/v1/BusinessPartners";
            string loginUrl = "https://103.194.8.71:50000/b1s/v1/Login";

            var response = await httpClient.PostAsync(loginUrl, content);

            ViewBag.statusCode = response;

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                dynamic parsedResponse = JsonConvert.DeserializeObject(responseData);

                return Json(parsedResponse);
            }
            else
            {
                string responseData = null;
                return View(responseData);
            }

            // return View();
        }

        public class B1Session
        {
            public string SessionId { get; set; }
        }
        public async Task<ActionResult> Index()
        {
            var loginRequestBody = new
            {
                CompanyDB = "MLPLTEST1312",
                Password = "9811",
                UserName = "manager"
            };
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("B1S-WCFCompatible", "true");
                client.DefaultRequestHeaders.Add("B1S-MetadataWithoutSession", "true");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("*/*"));
                client.DefaultRequestHeaders.ExpectContinue = false;

                // decompression
                client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));
                client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("deflate"));
                client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("br"));

                var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(loginRequestBody);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://103.194.8.71:50000/b1s/v1/Login", content);
                var statusCode = response.StatusCode;
                ViewBag.Response = response;
                if (response.IsSuccessStatusCode)
                {
                    if (response.Content.Headers.ContentEncoding.Contains("gzip"))
                    {
                        using (var gzipStream = new GZipStream(await response.Content.ReadAsStreamAsync(), CompressionMode.Decompress))
                        using (var streamReader = new StreamReader(gzipStream))
                        {
                            string responseBody = streamReader.ReadToEnd();
                            // B1Session obj = JsonConvert.DeserializeObject<B1Session>(responseBody);

                            dynamic responseData = JsonConvert.DeserializeObject(responseBody);

                            string sessionId = responseData.SessionId;
                            ViewBag.Response = responseData;
                            return Json(sessionId, JsonRequestBehavior.AllowGet);

                            // return Json(responseData, JsonRequestBehavior.AllowGet);
                        }
                    }

                    else
                    {
                        // Handle unsuccessful request (e.g., log, throw exception, return error response)
                        // Example: return BadRequest();
                    }
                }
                else 
                { 
                    return Json("Data not get From SAP");
                }
            }

            return View();
        }
    }
}