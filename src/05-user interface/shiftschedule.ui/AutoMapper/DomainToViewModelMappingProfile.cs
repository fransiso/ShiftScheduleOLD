using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using AutoMapper;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.UI.ViewModels;

namespace ShiftSchedule.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeViewModel, Employee>();
           
        }
    }
    
}