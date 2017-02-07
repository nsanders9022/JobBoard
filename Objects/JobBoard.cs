using System.Collections.Generic;

namespace Jobs.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _contactInfo;
    private static List<Job> _instances = new List<Job>{};

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetContactInfo()
    {
      return _contactInfo;
    }
    public void SetContactInfo(string newContactInfo)
    {
      _contactInfo = newContactInfo;
    }
  }
}
