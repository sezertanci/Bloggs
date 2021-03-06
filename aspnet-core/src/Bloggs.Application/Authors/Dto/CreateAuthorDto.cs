﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Bloggs.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bloggs.Authors.Dto
{
 
    public class CreateAuthorDto: EntityDto<long>
    {
        [Required]        
        public long UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
