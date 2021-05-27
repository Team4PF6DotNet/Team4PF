using PsAspNETCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Interface.cs
{
    public interface IProjectCreatorService
    {
        Task<List<ProjectCreator>> GetAll();
    }
}
