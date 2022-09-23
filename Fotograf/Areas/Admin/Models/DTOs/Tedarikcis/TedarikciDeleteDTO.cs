﻿using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Areas.Admin.Models.DTOs.Tedarikcis
{
    [Area("admin")]
    public class TedarikciDeleteDTO
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string? Email { get; set; }
        
    }
}
