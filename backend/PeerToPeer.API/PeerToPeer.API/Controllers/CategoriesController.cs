﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeerToPeer.API.Data;
using PeerToPeer.API.Models.Domain;
using PeerToPeer.API.Models.DTO;

namespace PeerToPeer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CategoriesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;        
        }
        [HttpPost]
        public async Task<IActionResult> CreateCaregory(CreateCategoryRequestDto request) 
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await dbContext.Categories.AddAsync(category);

        }
    }
}
