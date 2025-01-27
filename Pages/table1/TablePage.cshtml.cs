using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class TablePageModel : PageModel
{

[BindProperty]
    public string FirstName { get; set; }
    [BindProperty]
    public string LastName { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string PhoneNumber { get; set; }
    [BindProperty]
    public string Address { get; set; }

    public List<User> Data { get; set; }

    public void OnGet()
    {
        // Sample data
        Data = new List<User>
        {
            new User { Id = 1, Name = "Alice", Age = 25, Email = "alice@example.com" },
            new User { Id = 2, Name = "Bob", Age = 30, Email = "bob@example.com" },
            new User { Id = 3, Name = "Charlie", Age = 28, Email = "charlie@example.com" }
        };
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            // Process the form data here (e.g., save to a database)
            return RedirectToPage("Success");  // Redirect to a success page or show a message
        }
        return Page();  // Return the same page if validation fails
    }
}
