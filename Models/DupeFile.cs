﻿// Copyright (C) 2019-2023 Antik Mozib. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupeClear.Models
{
    public class DupeFile
    {
        public string Hash { get; set; }

        public string FullName { get; set; }

        public long Length { get; set; }
    }
}
