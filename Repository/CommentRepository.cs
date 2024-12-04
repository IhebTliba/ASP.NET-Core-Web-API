using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using my_api.Data;
using my_api.Interfaces;
using my_api.Models;

namespace my_api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context )
        {
            _context=context;
            
        }

        public  Task<List<Comments>> GetAllAsync()
        {
           return _context.Comments.ToListAsync();
        }
    }
}