﻿using System.ComponentModel.DataAnnotations;

namespace OnlineSatisProje.Web.Areas.Admin.Models
{
    public class KategoriModel
    {
        public KategoriModel()
        {
        }

        public KategoriModel(string modalId)
        {
            ModalId = modalId;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olmalı")]
        public string Ad { get; set; }

        public bool Aktif { get; set; }
        public string Aciklama { get; set; }
        public string ModalId { get; set; }
    }
}