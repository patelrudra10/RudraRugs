using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RudraRug.Models
{
    public class RugPropertyViewModel
    {
        public List<Rug> Rugs { get; set; }
        public SelectList Property { get; set; }
        public string RugProperty { get; set; }
        public string SearchString { get; set; }
    }
}
