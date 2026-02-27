using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NotKayit.Models.DataContext;
using NotKayit.Models.Entities;
using NotKayit.Models.ViewModels;

namespace NotKayit.Controllers
{
    public class DersController : Controller
    {
        private readonly NotKayitDbContext _context;
        private readonly IMapper _mapper;
        public DersController(NotKayitDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var entityList = await _context.DersTml.AsNoTracking().Include(x => x.DersAlanKodTml).ToListAsync();

            var vmList = _mapper.Map<List<DersTmlViewModel>>(entityList);
            return View(vmList);
        }


        public async Task<IActionResult> Create()
        {
            var vm = new CreateDersTmlViewModel
            {
                Alanlar = await _context.DersAlanKodTml.AsNoTracking()
                    .Select(x => new SelectListItem
                    {
                        Value = x.Id.ToString(),
                        Text = x.Tur
                    })
                    .ToListAsync()
            };

            return View(vm);
        }

      
        [HttpPost] 
        public async Task<IActionResult> Create(CreateDersTmlViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Alanlar = await _context.DersAlanKodTml.AsNoTracking().Select(x => new SelectListItem
                    {
                        Value = x.Id.ToString(),
                        Text = x.Tur
                    })
                    .ToListAsync();

                return View(model);
            }

            var entity = _mapper.Map<DersTml>(model);

            _context.DersTml.Add(entity);
            await _context.SaveChangesAsync(); 
            return RedirectToAction(nameof(Index));
        }
    }
}

