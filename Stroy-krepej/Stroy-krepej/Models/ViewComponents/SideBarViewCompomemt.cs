using Microsoft.AspNetCore.Mvc;
using Stroy_krepej.Domain;
using System.Threading.Tasks;

namespace Stroy_krepej.Models.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public SideBarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
