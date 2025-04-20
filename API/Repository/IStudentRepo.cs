using API.Models;

namespace API.Repository
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task Create(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}
