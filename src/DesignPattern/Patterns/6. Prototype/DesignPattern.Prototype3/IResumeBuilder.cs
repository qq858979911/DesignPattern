﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype3
{
    public interface IResumeBuilder
    {
        IResumeBuilder BuildBasicInfo(Action<BasicInfo> buildBasicInfoDelegate);
        IResumeBuilder BuildWorkExperence(Action<WorkExperence> buildWorkExperenceDelegate);
        ResumeBase Build();
    }
}
