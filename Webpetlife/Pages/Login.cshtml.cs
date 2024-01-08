using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

public class LoginModel : PageModel
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
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Burada giri� yapma i�lemleri yap�labilir.
        // �rnek bir giri� i�lemi:
        // var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, lockoutOnFailure: false);
        // if (result.Succeeded)
        // {
        //     return RedirectToPage("/Index");
        // }
        // else
        // {
        //     ModelState.AddModelError(string.Empty, "Ge�ersiz giri� denemesi.");
        //     return Page();
        // }

        return RedirectToPage("/Index"); // Giri� yap�ld�ktan sonra hangi sayfaya y�nlendirilece�ini belirtin.
    }
}
