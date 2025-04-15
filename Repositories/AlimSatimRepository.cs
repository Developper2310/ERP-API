using Demo1.Data;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Demo1.Repositories
{
    public class AlimSatimRepository : GenericRepository<AlimSatim>, IAlimSatimRepository
    {
        private readonly AppDbContext _ass;
 
        public AlimSatimRepository(AppDbContext ass) : base(ass)
        {
            _ass = ass;
            
        }


        public async Task<List<UrunAdetDto>> GetByDepoAsync(int depoid)
        {
            //var os= _ass.FisDestekler.Include(a=> a.AlimSatim).Include(a=> a.Urun).Where(a=>a.AlimSatim.DepoID==depoid).Select(a=>new {a.Urun.UrunAdi,a.Adet} );

            //var dene = await _ass.AlimSatimlar.Include(a=>a.Calisan).ToListAsync();
            //dene.Where(x => x.DepoID == depoid).Include(x => x.FisDestekler).ThenInclude(x => x.Urun).Select(x => x.FisDestekler).ToListAsync();


            var ov = await _ass.AlimSatimlar.Where(x => x.DepoID == depoid).Include(x => x.Calisan).Include(x => x.FisDestekler).ThenInclude(x=>x.Urun).ToListAsync();
           
            var list = new List<UrunAdetDto>();

            foreach (var item in ov)
            {
                
                foreach (var fisDestek in item.FisDestekler)
                {
                        
                    var urunadet = new UrunAdetDto();
                    urunadet.Adet = fisDestek.Adet;
                    urunadet.UrunAdi = fisDestek.Urun.UrunAdi;
                    urunadet.CalisanAdi = item.Calisan.Ad + " " + item.Calisan.Soyad;
                   
                    //Urun urun = await _ass.Urunler.FindAsync(fisDestek.UrunID);
                    //urunadet.UrunAdi = urun.UrunAdi;
                    list.Add(urunadet);
                }
            }
            
            list.GroupBy(x => x.CalisanAdi).ToList();

            return list;


            //var oo = _ass.FisDestekler.Where(a => a.DepoID==ow.Id));
            //IEnumerable<AlimSatim> aa = _ass.AlimSatimlar.Where(a => a.DepoID == depoid);
            //DbSet<FisDestek> cc = new DbSet<FisDestek>();

            //foreach (AlimSatim a in aa)
            //{
            //    cc.Add(_ass.FisDestekler.Where(c => c.AlimSatimID == a.Id).FirstAsync());
            //}


            //return cc;



            //     var list = await _ass.FisDestekler
            //.Include(f => f.AlimSatim)
            //.Include(f => f.Urun)
            //.Where(f => f.AlimSatim.DepoID == depoid)
            //.Select(f => new UrunAdetDto
            //{
            //    UrunAdi = f.Urun.UrunAdi,
            //    Adet = f.Adet
            //})
            //.ToListAsync();
        }

        public async Task<List<AlimSatim>> GetFisDestekByAlimSatimlarAsync(int asid)
        {
            return await _ass.AlimSatimlar.Where(a => a.Id == asid).Include(a => a.FisDestekler).ToListAsync();//emin değilim denenmesi gerek

        }
    }
}
