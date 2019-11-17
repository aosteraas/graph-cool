using System.Collections.Generic;
using System.Threading.Tasks;
using GraphCool.API.Models;

namespace GraphCool.API.Interfaces
{
    public interface IPersonService
    {
        Task<Person> GetAsync(int personId);
    }
}