﻿using System.Linq;
using System.Web.Mvc;
using OnlineSatisProje.Core.Entities;
using OnlineSatisProje.Data;
using OnlineSatisProje.Web.Models;

namespace OnlineSatisProje.Web.Controllers
{
    [Authorize]
    public class HesabimController : BaseController
    {
        private readonly IRepository<KullaniciAdresMapping> _kullaniciAdresRepository;

        public HesabimController(IRepository<KullaniciAdresMapping> kullaniciAdresRepository)
        {
            _kullaniciAdresRepository = kullaniciAdresRepository;
        }

        public ActionResult Index()
        {
            var user = GetCurrentUser();
            var model = new HesapModel
            {
                Email = user.Email,
                KullaniciAdi = user.UserName,
                SaticiMi = IsSatici(),
                CreatedDate = user.CreatedDate
            };
            return View(model);
        }

        public ActionResult Adreslerim()
        {
            var user = GetCurrentUser();
            var kullaniciAdresler = _kullaniciAdresRepository.Table.Where(k => k.KullaniciId == user.Id).ToList();
            return View(kullaniciAdresler);
        }
    }
}