using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Identity;
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
        public void OnGet() {}
        // ������ �� ���������� ������
        public IActionResult OnPostAddMovie(string name, string director, string style, string description)
        { 
            MSS.AddMovie(name, director, style, description);
            return Page();
        }
        //������ �� ���������� ������
        public IActionResult OnPostAddSession(string name, string date, string time)
        {
            MSS.AddSession(name, date, time);
            return Page();
        }
        // ������ �� ������� ������
        public IActionResult OnPostDeleteMovie(string name)
        {
            MSS.RemoveMovie(name);
            return Page();
        }

    }
}
