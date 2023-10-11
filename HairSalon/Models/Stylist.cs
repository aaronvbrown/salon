using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Client> Clients { get; set; }
  }
}