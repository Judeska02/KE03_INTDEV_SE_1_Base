using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPartRepository _partRepository;

        public IList<Part> Parts { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IPartRepository partRepository)
        {
            _logger = logger;
            _partRepository = partRepository;
            Parts = new List<Part>();
        }

        public void OnGet()
        {
            Parts = _partRepository.GetAllParts().ToList();
            _logger.LogInformation($"Aantal onderdelen geladen: {Parts.Count}");
        }
    }
}
