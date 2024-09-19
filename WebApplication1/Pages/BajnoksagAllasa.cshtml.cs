using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{

    public class BajnoksagAllasaModel : PageModel
    {
        private readonly FociDbContext _context;

        public BajnoksagAllasaModel(FociDbContext context) { _context = context; }

        public List<Meccs> meccsek;
        public List<CsapatEredmenyei> CsapatEredmenyei;
        public void OnGet()
        {
            meccsek = _context.Meccsek.ToList();
            CsapatEredmenyei = new List<CsapatEredmenyei> { };
            foreach (var cs in meccsek.Select(x=>x.HazaiCsapat).Distinct())
            {
                CsapatEredmenyei ujCsapat = new();
                ujCsapat.CsapatNev = cs;
                CsapatEredmenyei.Add(ujCsapat);
            }
            foreach (var cs in CsapatEredmenyei)
            {
                cs.Gyozelmek = meccsek.Where(x => x.GyoztesCsapatNeve() == cs.CsapatNev).Count();
                cs.Veresegek = meccsek.Where(x=>(x.HazaiCsapat==cs.CsapatNev || x.VendegCsapat==cs.CsapatNev) && x.GyoztesCsapatNeve() != cs.CsapatNev && x.GyoztesCsapatNeve() != "").Count();
            }
        }
    }
}
