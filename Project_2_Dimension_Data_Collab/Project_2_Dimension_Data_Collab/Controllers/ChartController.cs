using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_2_Dimension_Data_Collab.Data;

namespace Project_2_Dimension_Data_Collab.Controllers
{
    //[Authorize]

    public class ChartController : Controller
    {
        private readonly Dimension_Data_CollabContext _context;
        public ChartController(Dimension_Data_CollabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            #region Chart 1
            var x = _context.Cmpg323Project2Dataset.Where(x => x.Gender == "Male").Count();
            var y = _context.Cmpg323Project2Dataset.Where(y => y.Gender == "Female").Count();
            
            ViewBag.male = JsonConvert.SerializeObject(x);
            ViewBag.female = JsonConvert.SerializeObject(y);

            #endregion

            #region Chart 2
            var hrep = _context.Cmpg323Project2Dataset.Where(hrep => hrep.JobRole == "Healthcare Representative").Count();
            var hr = _context.Cmpg323Project2Dataset.Where(hr => hr.JobRole == "Human Resources").Count();
            var labtech = _context.Cmpg323Project2Dataset.Where(labtech => labtech.JobRole == "Laboratory Technician").Count();
            var man = _context.Cmpg323Project2Dataset.Where(man => man.JobRole == "Manager").Count();
            var mandir = _context.Cmpg323Project2Dataset.Where(mandir => mandir.JobRole == "Manufacturing Director").Count();
            var rdir = _context.Cmpg323Project2Dataset.Where(rdir => rdir.JobRole == "Research Director").Count();
            var rsci = _context.Cmpg323Project2Dataset.Where(rsci => rsci.JobRole == "Research Scientist").Count();
            var sexec = _context.Cmpg323Project2Dataset.Where(sexec => sexec.JobRole == "Sales Executive").Count();
            var salerep = _context.Cmpg323Project2Dataset.Where(salerep => salerep.JobRole == "Sales Representative").Count();


            ViewBag.HealthRep = JsonConvert.SerializeObject(hrep);
            ViewBag.HR = JsonConvert.SerializeObject(hr);
            ViewBag.LabTech = JsonConvert.SerializeObject(labtech);
            ViewBag.Manager = JsonConvert.SerializeObject(man);
            ViewBag.ManufDir = JsonConvert.SerializeObject(mandir);
            ViewBag.ResearchDir = JsonConvert.SerializeObject(rdir);
            ViewBag.ResearchSci = JsonConvert.SerializeObject(rsci);
            ViewBag.SalesExec = JsonConvert.SerializeObject(sexec);
            ViewBag.SalesRep = JsonConvert.SerializeObject(salerep);

            #endregion


            return View();
        }
    }
}
