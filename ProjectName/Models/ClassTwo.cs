using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ClassTwo
  {
    public ClassTwo()
    {
      this.JoinEntities = new HashSet<ClassOneClassTwo>();
    }

    public int ClassTwoId { get; set; }
    public string ClassTwoName { get; set; }
    public virtual ICollection<ClassOneClassTwo> JoinEntities { get; set; }
  }
}