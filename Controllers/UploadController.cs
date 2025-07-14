using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using SwgohParticipation.Data;
using SwgohParticipation.Mappings;
using SwgohParticipation.Models;
using SwgohParticipation.ViewModels;

namespace SwgohParticipation.Controllers
{
    public class UploadController : Controller
    {
        private readonly AppDbContext _context;

        public UploadController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new UploadViewModel { ReferenceDate = DateTime.Now });
        }

        [HttpPost]
        public async Task<IActionResult> Index(UploadViewModel model)
        {
            if (model.CsvFile != null && model.CsvFile.Length > 0)
            {
                using var reader = new StreamReader(model.CsvFile.OpenReadStream());
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                try
                {
                    if (model.TargetTable == "RoteParticipation")
                    {
                        csv.Context.RegisterClassMap<RoteParticipationMap>();
                        var records = csv.GetRecords<RoteParticipation>().ToList();
                        records.ForEach(r => r.StartDate = model.ReferenceDate);

                        _context.RoteParticipations.AddRange(records);
                    }
                    else if (model.TargetTable == "TwParticipation")
                    {
                        csv.Context.RegisterClassMap<TwParticipationMap>();
                        var records = csv.GetRecords<TwParticipation>().ToList();
                        records.ForEach(r => r.StartDate = model.ReferenceDate);

                        _context.TwParticipations.AddRange(records);
                    }
                    else if (model.TargetTable == "Order66Participation")
                    {
                        csv.Context.RegisterClassMap<Order66ParticipationMap>();
                        var records = csv.GetRecords<Order66Participation>().ToList();
                        records.ForEach(r => r.StartDate = model.ReferenceDate);

                        _context.Order66Participations.AddRange(records);
                    }
                    else if (model.TargetTable == "TicketParticipation")
                    {
                        csv.Context.RegisterClassMap<TicketParticipationMap>();
                        var records = csv.GetRecords<TicketParticipation>().ToList();
                        records.ForEach(r => r.WeekEndDate = model.ReferenceDate);

                        _context.TicketParticipations.AddRange(records);
                    } 
                    else if (model.TargetTable == "PlayerOverview")
                    {
                        csv.Context.RegisterClassMap<PlayerOverviewMap>();
                        var records = csv.GetRecords<PlayerOverview>().ToList();
                        records.ForEach(r => r.ReportDate = model.ReferenceDate);

                        _context.PlayerOverviews.AddRange(records);
                    }                

                    await _context.SaveChangesAsync();
                    ViewBag.Message = "Data uploaded successfully.";
                }
                catch (Exception ex)
                {
                    if (ex is HeaderValidationException)
                    {
                        ViewBag.Message = "Error parsing CSV file. Please ensure the file format is correct.";
                    }
                    else
                    {
                        ViewBag.Message = $"An error occurred while uploading data: {ex.Message}";
                    }
                }
            }
            else
            {
                ViewBag.Message = "Please upload a valid CSV file.";
            }

            return View(model);
        }
    }
}