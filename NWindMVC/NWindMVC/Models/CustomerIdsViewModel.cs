using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVC.Models
{
    public class CustomerIdsViewModel
    {
        public int  Id { get; set; }
        public readonly List<SelectListItem> CustomerIdSelectedList;
        public CustomerIdsViewModel(List<String> CustomerIds)
        {
            CustomerIdSelectedList = new List<SelectListItem>();
            foreach (String no in CustomerIds)
            {
                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
