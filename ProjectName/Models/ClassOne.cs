using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ClassOne
  {
    public ClassOne()
    {
      this.JoinEntities = new HashSet<ClassOneClassTwo>();
    }

    public int ClassOneId { get; set; }
    public string ClassOneName { get; set; }
    public virtual ICollection<ClassOneClassTwo> JoinEntities { get; }
  }
}