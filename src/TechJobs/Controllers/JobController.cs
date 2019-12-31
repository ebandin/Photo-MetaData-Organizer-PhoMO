using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.ViewModels;
using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

        // Our reference to the data store
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        public List<Job> Jobs { get; private set; }
// TODO # 1
        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            
            Jobs = jobData.FindByValue(id);

            return View();
        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

        [HttpPost]
        public IActionResult New(NewJobViewModel newJobViewModel)
        {

            if (ModelState.IsValid)
            {
                Job newJob = new Job
                {
                    Name = newJobViewModel.Name,
                    //Employer = JobData.Find(newJobViewModel.EmployerID),
                    Employer = newJobViewModel.EmployerID,
                    Location = newJobViewModel.Location,
                    CoreCompetency =
                    PositionType =

                    //newJobViewModel.
                };
                // th jobcontroller connects to the JobData function of Find
                //  change how the DataImporter works with the Job fields
                // 
                return View("Index", newJobViewModel);

            }
            else
            {
                newJobViewModel.Jobs = jobData.FindByColumnAndValue(newJobViewModel.Column, newJobViewModel.Value);
            }

            newJobViewModel.Title = "Search";

            ;

            //TODO #6 - Validate the ViewModel and if valid, create a 
            //new Job and add it to the JobData data store.Then
            //redirect to the Job detail(Index) action/view for the new Job.

            //return View("Index");
            return View(newJobViewModel);
        }
    }
}
