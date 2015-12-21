﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using Chapter4.Models;

namespace Chapter4.Services
{
    public class ConfigService
    {
        public Model LoadJSON()
        {
            string modelContent = File.ReadAllText(@"C:\ArcGISRuntimeBook\JSON\config_scene.json");
            return JsonConvert.DeserializeObject<Model>(modelContent);
        }
    }
}
