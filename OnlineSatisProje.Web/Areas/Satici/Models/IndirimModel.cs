﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineSatisProje.Web.Areas.Satici.Models
{
    public class IndirimModel
    {
        [Display(Name = "Ürün")]
        public int UrunId { get; set; }
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }
        [Display(Name = "Yüzde kullan")]
        public bool YuzdeKullan { get; set; }
        [Display(Name = "Indirim yüzdesi")]
        public decimal IndirimYuzdesi { get; set; }
        [Display(Name = "Indirim miktarı")]
        public decimal IndirimMiktari { get; set; }
        [Display(Name = "Başlangıç tarihi")]
        public DateTime BaslangicTarihi { get; set; }
        [Display(Name = "Bitiş tarihi")]
        public DateTime BitisTarihi { get; set; }
    }
}