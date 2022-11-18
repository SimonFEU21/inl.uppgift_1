using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApi.Contexts;
using WebApi.Models;
using WebApi.Models.Entitys;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly SqlDataContext _Context;

        public CommentsController(SqlDataContext context)
        {
            _Context = context;
        }




        [HttpPost]
        public async Task<IActionResult> Create(CommentRequest req)
        {
            try
            {
                var commentEntity = new CommentEntity
                {
                    Comment = req.Comment,
                    Created = DateTime.Now,
                    IssueId = req.IssueId,
                    CustomerId = req.CustomerId
                };

                _Context.Add(commentEntity);
                await _Context.SaveChangesAsync();

                return new OkObjectResult(commentEntity);
            }

            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new BadRequestResult();

        }

    }
}
