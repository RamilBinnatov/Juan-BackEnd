﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Services.Interface
{
    interface IFileService
    {
        string ReadFile(string path, string template);
    }
}
