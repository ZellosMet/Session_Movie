using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sessions.Model;

namespace Sessions.Pages
{
    public class SessionModel : PageModel
    {
        public readonly MovieSessionService MSS;
        public SessionModel(MovieSessionService mss) 
        {
            this.MSS = mss;
        }
        public void OnGet()
        {
            
        }
    }
}
