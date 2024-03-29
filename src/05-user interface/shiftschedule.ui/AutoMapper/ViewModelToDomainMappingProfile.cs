﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.UI.ViewModels;

namespace ShiftSchedule.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeViewModel>();
        }
    }
}