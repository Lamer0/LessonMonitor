﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonMonitor.Core.Entities;

namespace LessonMonitor.Core.Services
{
    public interface ITopicService
    {
        Task<Topic[]> Get();

        Task<Topic> Get(Lesson lesson);
    }
}
