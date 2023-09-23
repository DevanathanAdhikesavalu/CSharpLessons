using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVC.Models
{
    public class OrderIdsViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdsViewModel(List<int> OrderIds) 
        {
            OrderIdSelectedList = new List<SelectListItem>();   
            foreach (int Id in OrderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{Id}", Value = $"{Id}" });
            }
        }
    }
}
