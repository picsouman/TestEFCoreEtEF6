using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserBusinessLogic userBusinessLogic;
        private readonly GroupBusinessLogic groupBusinessLogic;

        public IndexModel(ILogger<IndexModel> logger, UserBusinessLogic userBusinessLogic, GroupBusinessLogic groupBusinessLogic)
        {
            _logger = logger;
            this.userBusinessLogic = userBusinessLogic;
            this.groupBusinessLogic = groupBusinessLogic;
        }

        public void OnGet()
        {
            ViewData["UserNames"] = userBusinessLogic.GetAllUserName();
            ViewData["GroupNames"] = groupBusinessLogic.GetAll().Select(x => new GroupUserCount
            {
                GroupName = x.Name,
                UserCount = groupBusinessLogic.GetNumberOfUsersInGroup(x.Id)
            });
        }

        public class GroupUserCount
        {
            public required string GroupName { get; set; }
            public int UserCount { get; set; }
        }
    }
}
