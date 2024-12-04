using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using my_api.Models;

namespace my_api.Interfaces
{
    public interface ICommentRepository
    {
      Task<List<Comments>> GetAllAsync();

    }
}