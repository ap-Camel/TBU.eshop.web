using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TBU.eshop.web.Models.Validations
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter)]
    public class FileContentAttribute : ValidationAttribute
    {

        public string ContentType { get; set; }

        public FileContentAttribute(string contentType)
        {
            ContentType = contentType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            } else if(value is IFormFile formFile)
            {
                if(formFile.ContentType.ToLower().Contains(this.ContentType.ToLower()))
                {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult($"{validationContext.MemberName}: content of the file is not {ContentType}");
                }
            }

            throw new NotImplementedException($"the attribute {nameof(FileContentAttribute)} is not implemented for type: {value.GetType()}");
        }

    }
}
