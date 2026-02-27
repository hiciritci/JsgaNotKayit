using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotKayit.Models.DataContext;
using NotKayit.Models.Entities;
using NotKayit.Models.ViewModels;
using static NotKayit.Models.ViewModels.OgrenciAdresTmlViewModel;

namespace NotKayit.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly NotKayitDbContext _context;
        private readonly IMapper _mapper;

        public OgrenciController(NotKayitDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // 1) LIST
        public async Task<IActionResult> Index()
        {
            var entities = await _context.OgrenciTml.Where(x=>x.Deleted==false).AsNoTracking().ToListAsync();
            var model = _mapper.Map<List<OgrenciTmlViewModel>>(entities);
            return View(model);
        }

        

        // 3) CREATE - GET
        public IActionResult Create() => View();

        // 3b) CREATE - POST
        [HttpPost]
     
        public async Task<IActionResult> Create(OgrenciTmlViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Ad)) return View(model);
            
            var entity = _mapper.Map<OgrenciTml>(model);
            _context.OgrenciTml.Add(entity);
            var effect= await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // 4) EDIT - GET
        public async Task<IActionResult> Edit(long id)
        {
            var entity = await _context.OgrenciTml.FindAsync(id);
            if (entity == null) return NotFound();

            var model = _mapper.Map<OgrenciTmlViewModel>(entity);
            return View(model);
        }

        // 4b) EDIT - POST
        [HttpPost] 
        public async Task<IActionResult> Edit(long id, OgrenciTmlViewModel model)
        {
            if (id != model.Id) return BadRequest();
            if (!ModelState.IsValid) return View(model);

            var entity = await _context.OgrenciTml.FindAsync(id);
            if (entity == null) return NotFound();

            // Mevcut entity üstüne model'den değerleri basar
            _mapper.Map(model, entity);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // 5) DELETE - GET
        public async Task<IActionResult> Delete(long id)
        {
            var entity = await _context.OgrenciTml.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return NotFound();

            var model = _mapper.Map<OgrenciTmlViewModel>(entity);
            return View(model);
        }

        // 5b) DELETE - POST
        [HttpPost]
     
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var entity = await _context.OgrenciTml.FindAsync(id);
            if (entity == null) return NotFound();
            entity.Deleted = true; // Silme işlemi yerine silindi olarak işaretleme
            _context.Update(entity); // Değişikliği kaydetmek için Update çağırıyoruz 
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        // 2) DETAILS
        public async Task<IActionResult> Details(long id)
        {
            var entity = await _context.OgrenciTml.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return NotFound();

            var model = _mapper.Map<OgrenciTmlViewModel>(entity);
            return View(model);
        } 

        // GET: /Ogrenci/AdresCreate
        public async Task<IActionResult> AdresCreate(long ogrenciId)
        {
            var ogrenciExists = await _context.OgrenciTml.AnyAsync(x => x.Id == ogrenciId);
            if (!ogrenciExists) return NotFound("Öğrenci bulunamadı.");

            var adresler = await _context.Set<OgrenciAdres>() 
                .AsNoTracking()
                .Where(x => x.OgrenciTmlId == ogrenciId)
                .OrderByDescending(x => x.Id)
                .Select(x => new OgrenciAdresItemVm
                {
                    Id = x.Id,
                    Adres = x.Adres
                })
                .ToListAsync();

            var vm = new OgrenciAdresTmlViewModel
            {
                OgrenciTmlId = ogrenciId,
                AdresListesi = adresler
            };

            return View(vm);
        }




        // POST: /Ogrenci/AdresCreate
        [HttpPost] 
        public async Task<IActionResult> AdresCreate(OgrenciAdresTmlViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Hata varsa listeyi tekrar doldurup aynı view'a dön
                model.AdresListesi = await _context.Set<OgrenciAdres>()
                    .AsNoTracking()
                    .Where(x => x.OgrenciTmlId == model.OgrenciTmlId)
                    .OrderByDescending(x => x.Id)
                    .Select(x => new OgrenciAdresItemVm { Id = x.Id, Adres = x.Adres })
                    .ToListAsync();

                return View(model);
            }

            var entity = new OgrenciAdres
            {
                OgrenciTmlId = model.OgrenciTmlId,
                Adres = model.Adres
            };

            _context.Set<OgrenciAdres>().Add(entity);
            await _context.SaveChangesAsync();

            // aynı sayfaya geri dön, yeni listeyle
            return RedirectToAction(nameof(AdresCreate), new { ogrenciId = model.OgrenciTmlId });
        }


    }
}
