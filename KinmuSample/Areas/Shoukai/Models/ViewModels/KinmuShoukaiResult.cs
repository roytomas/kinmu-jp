﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KinmuSample.Areas.Shoukai.Models.ViewModels
{
    public class KinmuShoukaiResult
    {
        public IEnumerable<KinmuData> kinmuDatas;
        public String gamenString;
    }
}