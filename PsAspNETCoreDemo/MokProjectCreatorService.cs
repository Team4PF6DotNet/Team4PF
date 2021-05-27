using PsAspNETCoreDemo.Interface.cs;
using PsAspNETCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Services.cs
{
    public class MokProjectCreatorService : IProjectCreatorService
    {
        public async Task<List<ProjectCreator>> GetAll()
        {
            List<ProjectCreator> list = new List<ProjectCreator>() {
            new ProjectCreator(){
                FirstName= "Marianna",
                LastName = "Karapanou",
                Address = "California",
                Email = "hello@mar.gr",
                Phone= "923224"
                }
            };
            return list;
        }
    }
}
