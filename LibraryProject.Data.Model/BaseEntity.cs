using System.ComponentModel.DataAnnotations;


namespace LibraryProject.Data.Model
{
  public  class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
