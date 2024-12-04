using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using my_api.Data;
using my_api.Interfaces;
using my_api.Mappers;
using Route = Microsoft.AspNetCore.Mvc.RouteAttribute;
namespace my_api.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
         private readonly ApplicationDBContext _context;
         private readonly ICommentRepository _commentRepo;
        public CommentsController(ApplicationDBContext  context, ICommentRepository commentRepo)
        {
          _context= context;   
          _commentRepo= commentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comment=await _commentRepo.GetAllAsync();
            var commentDto= comment.Select(s=>s.ToCommentsDto());
            return Ok(commentDto);
        }
        
    }
}