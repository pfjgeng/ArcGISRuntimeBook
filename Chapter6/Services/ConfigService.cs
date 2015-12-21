﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using Chapter6.Models;

namespace Chapter6.Services
{
    public class ConfigService
    {
        public Model LoadJSON()
        {
            string modelContent = File.ReadAllText(@"C:\ArcGISRuntimeBook\JSON\config_sf.json");
            return JsonConvert.DeserializeObject<Model>(modelContent);
        }
    }
}
