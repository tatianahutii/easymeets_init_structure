﻿using EasySpeak.Core.Common.DTO;
using FluentValidation;

namespace EasySpeak.Core.WebAPI.Validators
{
    public class NewSampleDtoValidator : AbstractValidator<SampleDto>
    {
        public NewSampleDtoValidator()
        {
            RuleFor(u => u.Title).NotNull().MaximumLength(50);
            RuleFor(u => u.CreatedBy).NotEmpty();
        }
    }
}
