using System.Collections.Generic;
using System.Threading.Tasks;
using GraphCool.API.Interfaces;
using GraphCool.API.Models;

namespace GraphCool.API.Services
{
    public class PersonService : IPersonService
    {
        public Task<IList<Person>> GetAsync(int personId)
        {
            throw new System.NotImplementedException();
        }
    }
}