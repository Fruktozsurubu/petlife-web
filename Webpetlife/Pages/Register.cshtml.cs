using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

public class RegisterModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Burada kay�t olma i�lemleri yap�labilir.
        // �rnek bir kay�t i�lemi:
        // var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
        // var result = await _userManager.CreateAsync(user, Input.Password);
        // if (result.Succeeded)
        // {
        //     return RedirectToPage("/Login");
        // }
        // else
        // {
        //     foreach (var error in result.Errors)
        //     {
        //         ModelState.AddModelError(string.Empty, error.Description);
        //     }
        //     return Page();
        // }

        return RedirectToPage("/Login"); // Kay�t yap�ld�ktan sonra hangi sayfaya y�nlendirilece�ini belirtin.
    }
}
