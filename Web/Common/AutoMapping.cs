using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Web.ViewModels;

namespace Web.Common
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PublishingCompany, PublishingComapnyViewModel>();
        }
    }
}
