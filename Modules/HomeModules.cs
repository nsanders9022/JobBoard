using Nancy;
using Jobs.Objects;
using System.Collections.Generic;

namespace JobBoards
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Get["/view_all_jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["view_all_jobs.cshtml", allJobs];
      };
      Post["/jobs_added"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-email"], Request.Form["new-phone-number"]);
        Job newJob = new Job(Request.Form["new-title"], Request.Form["new-description"], newContact);
        newJob.Save();
        return View["jobs_added.cshtml", newJob];
      };
      Post["/jobs_cleared"] = _ => {
        Job.ClearAll();
        return View["jobs_cleared.cshtml"];
      };
    }
  }
}
