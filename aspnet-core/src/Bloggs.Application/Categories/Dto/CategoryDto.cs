﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Bloggs.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bloggs.Categories.Dto
{
   
    public class CategoryDto:FullAuditedEntityDto<long>
    {
     
        public string Name { get; set; }
    }
}