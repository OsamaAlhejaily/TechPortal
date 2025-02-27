
using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;
using System.Collections.Generic;
using System.Linq;


namespace TechJobPortal.Controllers
{
   public class JobController : Controller
   {
       private static List<Job> _jobs = new List<Job>
       {
           new Job { id = 1, title = "Software Engineer", companyName = "Al-rajhi",location = "Riyadh", Jt = JobType.Full_Time,PostedDate = new DateTime(2025,02,02)},
           new Job { id = 2, title = "Sales", companyName = "Apple",location = "Dubai", Jt = JobType.Part_Time,PostedDate = new DateTime(2025,02,05)},
           new Job { id = 3, title = "Web Developer", companyName = "Elm",location = "Medina", Jt = JobType.Contract,PostedDate = new DateTime(2025,02,15)},
           new Job { id = 4, title = "Network Administrator", companyName = "STC", location = "Jeddah", Jt = JobType.Full_Time, PostedDate = new DateTime(2025,02,18)},
           new Job { id = 5, title = "UX Designer", companyName = "Microsoft", location = "Abu Dhabi", Jt = JobType.Remote, PostedDate = new DateTime(2025,02,20)}

       
       };


       public IActionResult Index()
       {
           return View(_jobs);
       }
       public IActionResult Details(int Id)
{
    var job = _jobs.FirstOrDefault(j => j.id == Id);
    if (job == null)
        return NotFound();

    ViewBag.JobTypes = Enum.GetValues(typeof(JobType));
    return View(job);
}

   }
}