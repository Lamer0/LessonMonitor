﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonitor.Core.Entities
{
    public class TimeCode
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        public TimeSpan Time { get; set; }

    }
}
