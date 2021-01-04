using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access.Primitives.Extensions.ObjectExtensions;
using Access.Primitives.IO;
using Microsoft.AspNetCore.Mvc;
using StackUnderflow.Domain.Core;
using StackUnderflow.Domain.Core.Contexts;
using StackUnderflow.Domain.Schema.Backoffice.CreateTenantOp;
using StackUnderflow.EF.Models;
using Access.Primitives.EFCore;
using StackUnderflow.Domain.Schema.Backoffice.InviteTenantAdminOp;
using StackUnderflow.Domain.Schema.Backoffice;
using LanguageExt;
using Microsoft.AspNetCore.Http;
using Orleans;
using GrainInterfaces;
using StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion;
using StackUnderflow.Domain.Core.Contexts.Question;
using StackUnderflow.DatabaseModel.Models;

namespace StackUnderflow.API.Rest.Controllers
{
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        private readonly IInterpreterAsync _interpreter;
        private readonly StackUnderflowContext _dbContext;

        public QuestionController(IInterpreterAsync interpreter, StackUnderflowContext dbContext, IClusterClient client)
        {
            _interpreter = interpreter;
            _dbContext = dbContext;
        }

        [HttpPost("createQuestion")]
        public async Task<IActionResult> CreateQuestion([FromBody] QuestionCmd cmd)
        {
            var dep = new QuestionDependencies();

            //var question = await _dbContext.QuestionDB.ToListAsync();

            var ctx = new WriteContext();
            
            var expr = from CreateTenantResult in QuestionContext.CreateQuestion(cmd)
                       select CreateTenantResult;

            var r = await _interpreter.Interpret(expr, ctx, dep);

            await _dbContext.SaveChangesAsync();
            return r.Match(
                succ=>(IActionResult)Ok(succ),
                fail=>BadRequest("Error")
            );
        }

    }
}
