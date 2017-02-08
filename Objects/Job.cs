using System.Collections.Generic;

namespace Jobs.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private Contact _contact;
    private static List<Job> _jobList = new List<Job>{};

    public Job(string jobTitle, string jobDescription, Contact jobContact)
    {
      _title = jobTitle;
      _description = jobDescription;
      _contact = jobContact;
    }

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

    public Contact GetContact()
    {
      return _contact;
    }
    public void SetContact(Contact newContact)
    {
      _contact = newContact;
    }

    public static List<Job> GetAll()
    {
      return _jobList;
    }
    public void Save()
    {
      _jobList.Add(this);
    }
    public static void ClearAll()
    {
      _jobList.Clear();
    }
  }
}
