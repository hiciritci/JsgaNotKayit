using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NotKayit.Models.DataContext;
using NotKayit.Models.Entities;
using NotKayit.Models.ViewModels;
using System;
using System.Buffers.Text;

public class NotController : Controller
{
    private readonly NotKayitDbContext _context;
    private readonly IMapper _mapper;

    public NotController(NotKayitDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<IActionResult> Index(int ogrenciId)
    {
        var ogrenci = await _context.OgrenciTml
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == ogrenciId);

        if (ogrenci == null)
            return NotFound();

        var notlar = await _context.NotTml
            .AsNoTracking()
            .Include(x => x.Ders)
            .Include(x => x.NotKod)
            .Where(x => x.OgrenciTmlId == ogrenciId)
            .ToListAsync();

        var vm = new OgrenciNotListViewModel
        {
            OgrenciId = ogrenci.Id,
            OgrenciAdSoyad = ogrenci.Ad + " " + ogrenci.Soyad,
            Notlar = _mapper.Map<List<OgrenciNotItemVm>>(notlar)
        };

        return View(vm);
    }
    // GET
    public async Task<IActionResult> Create(int ogrenciId)
    {
        var ogrenci = await _context.OgrenciTml
            .FirstOrDefaultAsync(x => x.Id == ogrenciId);

        if (ogrenci == null)
            return NotFound();

        var vm = new NotCreateViewModel
        {
            OgrenciTmlId = ogrenci.Id,
            OgrenciAdSoyad = ogrenci.Ad + " " + ogrenci.Soyad,
            Dersler = await _context.DersTml
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.DersAd
                }).ToListAsync(),

            NotTurleri = await _context.NotKodTml
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Tur
                }).ToListAsync()
        };

        return View(vm);
    }


    [HttpPost] 
    public async Task<IActionResult> Create(NotCreateViewModel vm)
    {
        var ogrenci = await _context.OgrenciTml
            .FirstOrDefaultAsync(x => x.Id == vm.OgrenciTmlId);

        if (ogrenci == null)
            return NotFound();

        if (!ModelState.IsValid)
        {
            vm.OgrenciAdSoyad = ogrenci.Ad + " " + ogrenci.Soyad;

            vm.Dersler = await _context.DersTml
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.DersAd
                }).ToListAsync();

            vm.NotTurleri = await _context.NotKodTml
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Tur
                }).ToListAsync();

            return View(vm);
        }

        var entity = _mapper.Map<NotTml>(vm);

        _context.NotTml.Add(entity);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index", "Ogrenci");
    }
}