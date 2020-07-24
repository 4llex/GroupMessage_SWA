using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupMessageApplication.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupMessageApplication.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly GroupChatContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MessageController(GroupChatContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("{group_id}")]
        public IEnumerable<Message> GetById(int group_id)
        {
            return _context.Message.Where(gb => gb.GroupId == group_id);
        }
    }
}