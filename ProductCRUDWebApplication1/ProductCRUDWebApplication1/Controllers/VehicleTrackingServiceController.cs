using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProductCRUDWebApplication1.Controllers
{
    public class VehicleTrackingServiceController : Controller
    {
        // GET: VehicleTrackingService
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string chassisNo)
        {
            HttpClient httpClient = new HttpClient();

            // httpClient.BaseAddress = new Uri("https://partnerapi.vecv.net/tracking/vehicletracking");
            httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Id", "e035ba14-36d3-4ded-81e2-34168ed23a70");
            httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Secret", "vC3uD0wD1mT6uH5tO5tQ1uO1lB6dN4vB7wH3kB2tK1eS4eC8eL");
            try
            {
                // Get Current date
                DateTime currentDate = DateTime.Today;

                // Set startDateTime to the first second of the current day in the format "YYYYMMDD000001"
                var startDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 0, 0, 1).ToString("yyyyMMddHHmmss");

                // Set endDateTime to the last second of the current day in the format "YYYYMMDD235959"
                var endDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 23, 59, 59).ToString("yyyyMMddHHmmss");

                // Now you can use startDateTime and endDateTime with the required format

                // Construct the request body
                var requestBody = new
                {
                    startDateTime,
                    chassisno = new[] { chassisNo }, // "MC2CASRF0NB076134"
                    endDateTime,
                    latestOnly = true
                };

                // Convert the request body to JSON
                var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                // Make the POST request
                var response = await httpClient.PostAsync("https://partnerapi.vecv.net/tracking/vehicletracking", content);

                ViewBag.CheckResponse = response;
                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and return the response content
                    var responseData = await response.Content.ReadAsStringAsync();
                    ViewBag.responseData = responseData;

                    dynamic parsedResponse = JsonConvert.DeserializeObject(responseData);
                    ViewBag.parsedResponse = parsedResponse;
                }
                else
                {
                    // Handle unsuccessful response
                    // throw new Exception($"Failed to retrieve data from API. Error: {response.StatusCode}");
                    ViewBag.response = $"Failed to retrieve data from API. Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
            }
            return View();
        }
    }
}