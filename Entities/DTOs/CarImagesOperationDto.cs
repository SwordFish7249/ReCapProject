using Core;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Entities.DTOs
{
    public class CarImagesOperationDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}