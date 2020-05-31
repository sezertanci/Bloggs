﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Bloggs.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bloggs.Tags.Dto
{
    [AutoMap(typeof(Tag))]
    public class TagCreateDto : EntityDto<long>
    {
        [Required]
        public string Name { get; set; }
    }
}
