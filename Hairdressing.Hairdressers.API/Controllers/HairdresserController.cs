using System;
using System.Net;
using System.Threading.Tasks;
using Hairdressing.Hairdressers.Domain.Services;
using Hairdressing.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hairdressing.Hairdressers.API.Controllers {

    internal class HairdresserController : ControllerBase {

        private readonly IHairdresserService _hairdresserService;
        private readonly ILogger<HairdresserController> _logger;

        public HairdresserController(IHairdresserService hairdresserService, ILogger<HairdresserController> logger) {
            _hairdresserService = hairdresserService;
            _logger = logger;
        }

        public async Task<IActionResult> Browse() {
            try {
                return Ok(await _hairdresserService.BrowseAsync());
            } catch (Exception e) {
                _logger.LogError(e.ToString());
                return StatusCode(500);
            }
        }

    }

}