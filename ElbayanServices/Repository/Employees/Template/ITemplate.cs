using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Template.Dtos;

namespace ElbayanServices.Repository.Employees.Template
{
    public interface ITemplate
    {
        List<TemplateResponseDto> Get();
        TemplateResponseDto Get(Guid id);
        bool Add(TemplateRequestDto model);
        bool Update(TemplateRequestDto model);
        bool DisableOrEnable(Guid id);
    }
}