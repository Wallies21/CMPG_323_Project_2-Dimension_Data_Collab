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


            #region Chart 3
            var HR = _context.Cmpg323Project2Dataset.Where(HR => HR.EducationField == "Human Resources").Count();
            var lsci = _context.Cmpg323Project2Dataset.Where(lsci => lsci.EducationField == "Life Sciences").Count();
            var mark = _context.Cmpg323Project2Dataset.Where(mark => mark.EducationField == "Marketing").Count();
            var med = _context.Cmpg323Project2Dataset.Where(med => med.EducationField == "Medical").Count();
            var other = _context.Cmpg323Project2Dataset.Where(other => other.EducationField == "Other").Count();
            var techd = _context.Cmpg323Project2Dataset.Where(techd => techd.EducationField == "Technical Degree").Count();


            ViewBag.HumanR = JsonConvert.SerializeObject(HR);
            ViewBag.LifeSci = JsonConvert.SerializeObject(lsci);
            ViewBag.Marketing = JsonConvert.SerializeObject(mark);
            ViewBag.Medical = JsonConvert.SerializeObject(med);
            ViewBag.Other = JsonConvert.SerializeObject(other);
            ViewBag.TechDegree = JsonConvert.SerializeObject(techd);

            #endregion

            #region Chart 4
            var Hr = _context.Cmpg323Project2Dataset.Where(Hr => Hr.Department == "Human Resources").Count();
            var rd = _context.Cmpg323Project2Dataset.Where(rd => rd.Department == "Research & Development").Count();
            var sales = _context.Cmpg323Project2Dataset.Where(sales => sales.Department == "Sales").Count();


            ViewBag.HResources = JsonConvert.SerializeObject(Hr);
            ViewBag.ResearchDevel = JsonConvert.SerializeObject(rd);
            ViewBag.Sales = JsonConvert.SerializeObject(sales);

            #endregion


            return View();
        }
    }
}
