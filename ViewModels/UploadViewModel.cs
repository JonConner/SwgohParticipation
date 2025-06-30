using Microsoft.AspNetCore.Http;
using System;

namespace SwgohParticipation.ViewModels
{
    public class UploadViewModel
    {
        public IFormFile? CsvFile { get; set; }
        public string? TargetTable { get; set; }
        public DateTime ReferenceDate { get; set; }
    }
}