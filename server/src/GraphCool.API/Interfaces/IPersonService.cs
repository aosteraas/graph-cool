using System.Collections.Generic;
using System.Threading.Tasks;
using GraphCool.API.Models;

namespace GraphCool.API.Interfaces
{
    public interface IPersonService
    {
        Task<IList<Person>> GetAsync(int personId);
    }
}