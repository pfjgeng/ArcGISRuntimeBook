﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using Chapter2b.Models;

namespace Chapter2b.Services
{
    public class ConfigService
    {
        public Model LoadJSON()
        {
            string modelContent = File.ReadAllText(@"C:\ArcGISRuntimeBook\JSON\config.json");
            return JsonConvert.DeserializeObject<Model>(modelContent);
        }
    }
}
