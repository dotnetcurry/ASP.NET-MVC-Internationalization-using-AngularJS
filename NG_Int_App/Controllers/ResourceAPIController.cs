using NG_Int_App.App_LocalResources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Web.Http;

namespace NG_Int_App.Controllers
{
    public class ResourceAPIController : ApiController
    {
        [HttpGet]
        [Route("api/accessresources")]
        public IHttpActionResult GetResourceStringsFromResources()
        {
            //1.   
            ResourceSet resources = MVCInternattional.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            Dictionary<string, string> resDictionary = new Dictionary<string, string>();
            //2.
            foreach (DictionaryEntry resource in resources)
            {
                resDictionary.Add(resource.Key.ToString(), resource.Value.ToString());
            }
            //3.
            return Ok(resDictionary);
        }
    }
}
