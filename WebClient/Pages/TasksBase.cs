using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Abstractions;

namespace WebClient.Pages
{
    public class TasksBase : ComponentBase
    {
        protected List<TaskModel> tasks = new List<TaskModel>();
        protected List<MenuItem> leftMenuItem = new List<MenuItem>();

        protected bool showCreator;
        protected bool isLoaded;

        [Inject]
        public ITaskDataService TaskDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await TaskDataService.GetAllTasks();

            if (result != null && result.Payload != null && result.Payload.Any())
            {
                foreach (var item in result.Payload)
                {
                    tasks.Add(new TaskModel()
                    {
                        id = item.Id,
                        isDone = item.IsComplete,
                        member = new FamilyMember()
                        {
                            firstname = item.AssignedMember.FirstName,
                            lastname = item.AssignedMember.LastName,
                            avtar = item.AssignedMember.Avatar,
                            id = item.AssignedMember.Id,
                            role = item.AssignedMember.Roles
                        },
                        text = item.Subject
                    }); ;
                }
            }
        }
    }
}
