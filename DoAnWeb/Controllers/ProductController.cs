using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly ISupplierRepository _SupplierRepository;
        public ProductController(IProductRepository productRepository, IProductTypeRepository productTypeRepository, ISupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _productTypeRepository = productTypeRepository;
            _SupplierRepository = supplierRepository;
        }
        // Hiển thị danh sách sản phẩm
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }
    }
}
