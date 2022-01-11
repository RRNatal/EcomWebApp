using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcomWeb.Pages.Admin.MainCats;

[BindProperties]
public class EditModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public MainCat MainCat { get; set; }

    public EditModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void OnGet(int id)
    {
        MainCat = _unitOfWork.MainCat.GetFirstOrDefault(u=>u.Id==id);
        //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
        //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
        //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.MainCat.Update(MainCat);
            _unitOfWork.Save();
            TempData["success"] = "MainCat updated successfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
