using Fs.BusinessLogicLayer.Abstract;
using Fs.BusinessLogicLayer.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fs.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(ICategoryService categoryService, IProductService productService, IWebHostEnvironment webHostEnvironment)
        {
            _categoryService = categoryService;
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories= await _categoryService.GetCategoryDictionaryAsync();
            TempData["Categories"] = new SelectList(categories, "Key", "Value");
            AddProductDto addProductDto = new();

            return View(addProductDto);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDto productDto, IList<IFormFile> imagesFile)
        {
            if(imagesFile is not null && imagesFile.Count > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                
                if(Directory.Exists(uploadsFolder) is false)
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                foreach(var image in imagesFile)
                {
                    if (image.Length > 0)
                    {
                        string uniqueImageName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(image.FileName);
                        string filePath=Path.Combine(uploadsFolder, uniqueImageName);
                        using (var fileStream= new FileStream(filePath,FileMode.Create))
                        {
                            await image.CopyToAsync(fileStream);
                        }
                        productDto.UploadedFileDtos.Add(new UploadedFileDto
                        {
                            FileName = uniqueImageName,
                            RelativePath = filePath,
                            ContentType = image.ContentType,
                        }); ;

                    }
                }
                var result=await _productService.AddAsync(productDto);
                if (result.ResponseType == FS.CoreLayer.Enums.ResponseType.ValidationError)
                {
                    foreach(var item in result.ResponseValidationResults)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                    }

                    var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                        .ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                        );
                    return Json(new { success = false, errors });
                }
            }
            return Json(new { success = true});
        }


        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var result = await _productService.GetProductsAsync();
            return Json(result.Data);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            var result = await _productService.RemoveAsync(id);
            if (result.ResponseType == FS.CoreLayer.Enums.ResponseType.NotFound)
            {
                return Json(new { success = false, message = result.Message });
            }
            return Json(new { success = true, message = "Book was deleted successfully" });


        }
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductDto productDto)
        {
            var result = await _productService.UpdateAsync(productDto);
            if (result.ResponseType == FS.CoreLayer.Enums.ResponseType.SuccessResult)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(productDto);
        }
    }
}
