namespace ProjectName.Models
{
  public class ClassOneClassTwo
  {
    public int ClassOneClassTwoId { get; set; }
    public int ClassOneId { get; set; }
    public int ClassTwoId { get; set; }
    public virtual ClassOne ClassOne { get; set; }
    public virtual ClassTwo ClassTwo { get; set; }
  }
}