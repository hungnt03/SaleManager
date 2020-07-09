﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Settings
{
    public class ClientAppSettings
    {
        public string Url { get; set; }
        public string EmailConfirmationPath { get; set; }
        public string ResetPasswordPath { get; set; }
    }
}
