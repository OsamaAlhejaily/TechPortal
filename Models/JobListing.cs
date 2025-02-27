using System.ComponentModel.DataAnnotations;

namespace TechJobPortal.Models{ //Tell it we are in the models folder
public class Job{
    public int id{get;set;}
    [Required]
    public string title{get; set;}
    [Required]
    public string companyName{get; set;}
    public string location{get; set;}
    
    public JobType Jt{get; set;}

    public DateTime PostedDate{get; set;}




}
public enum JobType
{
  Full_Time,
  Part_Time,
  Remote,
  Contract,
}
}