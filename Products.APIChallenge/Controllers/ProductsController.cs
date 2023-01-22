using Microsoft.AspNetCore.Mvc;
using Products.Core.Interfaces;

namespace Products.APIChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private IProductRepository _productRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        // GET: ProductsController
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(_productRepository.GetProductsList());
        }

        // GET: ProductsController/Details/5
        [HttpGet(Name = "Details")]
        public ActionResult Details(int id)
        {
            return Ok();
        }

        // GET: ProductsController/Create
        [HttpGet(Name = "Create")]
        public ActionResult Create()
        {
            return Ok();
        }

        // POST: ProductsController/Create
        [HttpPost(Name = "Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: ProductsController/Edit/5
        [HttpGet(Name = "Edit")]
        public ActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: ProductsController/Edit/5
        [HttpPost(Name = "Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: ProductsController/Delete/5
        [HttpGet(Name = "Delete")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }

        // POST: ProductsController/Delete/5
        [HttpPost(Name = "Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }
    }
}
