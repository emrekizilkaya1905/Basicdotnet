namespace basics.Models {
  public class Repository{
    private static readonly List<Course> _courses=new();
    static Repository() {
      _courses=new List<Course>() {
      new Course (){Id = 1, Title ="ASP.NET COURSE",Description="Nice Course", Image="1.jpeg",
      Tags = new string [] {"asp.net","web developing"},IsActive=true, IsHome=true
       },
      new Course (){Id = 2, Title ="PHP COURSE",Description="Nice Course", Image="2.jpeg",Tags = new string [] {"php","web developing"},IsActive=true, IsHome=true },
      new Course() {Id = 3, Title ="DJANGO COURSE",Description="Nice Course",Image="3.jpeg",Tags = new string [] {"django","web developing"},IsActive=true, IsHome=true }
      };
      
    }
    public static List<Course> Courses {
      get {
        return _courses;
      }
    }
    public static Course? GetById(int? id) {
      return _courses.FirstOrDefault(c=> c.Id==id);
    }
  }
}