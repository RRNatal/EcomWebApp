using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcomWeb.Pages.Admin.Categories;

public class IndexModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public IEnumerable<Category> Categories{ get; set; }

    public IndexModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork= unitOfWork;
    }

    public void OnGet()
    {
        Categories = _unitOfWork.Category.GetAll();
    }
}
