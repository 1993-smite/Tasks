using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVueTest.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Components()
        {
            return View();
        }

        public async Task<IActionResult> GetFile(string imageUrl, string fileName)
        {
            // check if image URL exists by reading response header
            bool fileExist;
            HttpWebResponse response = null;
            var request = (HttpWebRequest)WebRequest.Create(imageUrl);
            request.Timeout = 10000; // in milliseconds, e.g. 10 sec
            request.Method = "HEAD";
            try
            {
                response = (HttpWebResponse)request.GetResponse(); // get validity response
                fileExist = response.StatusCode == HttpStatusCode.OK;

                if (fileExist)
                {
                    HttpClient client = new HttpClient();
                    byte[] data = await client.GetByteArrayAsync(imageUrl);
                    return File(data, "application/png", fileName);
                }
                else
                {
                    throw new Exception("Image not found");
                }
            }
            catch (Exception err)
            {
                throw new Exception("Bad request" + err.Message);
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }

        public IActionResult Tree()
        {
            return View();
        }
    }
}