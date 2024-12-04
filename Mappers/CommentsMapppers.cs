using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_api.Dtos;
using my_api.Models;

namespace my_api.Mappers
{
    public static class CommentsMapppers
    {
        public static CommentsDto ToCommentsDto (this Comments commentModel)
        {
            return new CommentsDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId


            };
        }
        
    }
}