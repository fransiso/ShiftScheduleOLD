﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ShiftSchedule.UI.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}