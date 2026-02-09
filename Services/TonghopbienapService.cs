using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data.EF;
using WebApi.Data.Entites;
using WebApi.Models.BienAp;
using WebApi.Models.Common;
using WebApi.Models.TonghopRole;

namespace WebApi.Services
{
    public interface ITonghopbienapService
    {
        Task<TonghopBienap> Add(TonghopBienap Request);
        Task<List<TonghopbienapVm>> GetAll();
        Task<List<TonghopbienapVm>> getDatailById(int id);
        Task<TonghopBienap> Update([FromBody] TonghopBienap Request);
        Task<bool> Delete(int id);
        Task<ApiResult<int>> DeleteSelect(List<int> ids);
    }
    public class TonghopbienapService : ITonghopbienapService
    {
        private readonly ThietbiDbContext _thietbiDb;
        public TonghopbienapService(ThietbiDbContext thietbiDb)
        {
            _thietbiDb = thietbiDb;
        }
        public async Task<TonghopBienap> Add(TonghopBienap Request)
        {
            if (Request == null)
            {
                return null;
            }
            // validate referenced entities exist
            var bienapExists = await _thietbiDb.DanhmucBienaps.AnyAsync(x => x.Id == Request.BienapId);
            var phongbanExists = await _thietbiDb.PhongBans.AnyAsync(x => x.Id == Request.PhongbanId);
            if (!bienapExists || !phongbanExists)
            {
                return null;
            }

            var items = new TonghopBienap()
            {
                BienapId = Request.BienapId,
                PhongbanId = Request.PhongbanId,
                ViTriLapDat = Request.ViTriLapDat,
                NgayLap = Request.NgayLap,
                DuPhong = Request.DuPhong,
                GhiChu = Request.GhiChu
            };

            try
            {
                await _thietbiDb.TonghopBienaps.AddAsync(items);
                await _thietbiDb.SaveChangesAsync();
                return items;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> Delete(int id)
        {
            var query = await _thietbiDb.TonghopBienaps.FindAsync(id);
            if (query == null)
            {
                return false;
            }
            _thietbiDb.TonghopBienaps.Remove(query);
            await _thietbiDb.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResult<int>> DeleteSelect(List<int> ids)
        {
            if (ids == null || ids.Count == 0)
            {
                return new ApiErrorResult<int>("Danh sách ID rỗng");
            }

            var items = await _thietbiDb.TonghopBienaps
                .Where(x => ids.Contains(x.Id))
                .ToListAsync();

            if (items.Count != ids.Count)
            {
                return new ApiErrorResult<int>("Một số bản ghi không tồn tại");
            }

            _thietbiDb.TonghopBienaps.RemoveRange(items);
            var count = await _thietbiDb.SaveChangesAsync();

            return new ApiSuccessResult<int>(count);
        }

        public async Task<List<TonghopbienapVm>> GetAll()
        {
            var query = _thietbiDb.TonghopBienaps.Include(x => x.DanhmucBienap).Include(x => x.PhongBan);
            return await query.Select(x => new TonghopbienapVm()
            {
                Id = x.Id,
                TenThietBi = x.DanhmucBienap.TenThietBi,
                BienapId = x.BienapId,
                TenPhongBan = x.PhongBan.TenPhong,
                PhongbanId = x.PhongbanId,
                ViTriLapDat = x.ViTriLapDat,
                NgayLap = x.NgayLap,
                DuPhong = x.DuPhong,
                GhiChu = x.GhiChu
            }).ToListAsync();
        }

        public async Task<List<TonghopbienapVm>> getDatailById(int id)
        {
            var Query = from t in _thietbiDb.TonghopBienaps.Where(x => x.Id == id)
                        join p in _thietbiDb.PhongBans on t.PhongbanId equals p.Id
                        join m in _thietbiDb.DanhmucBienaps on t.BienapId equals m.Id


                        select new { t, p, m };
            return await Query.Select(x => new TonghopbienapVm
            {
                Id = x.t.Id,
                TenThietBi = x.m.TenThietBi,
                TenPhongBan = x.p.TenPhong,
                ViTriLapDat = x.t.ViTriLapDat,
                NgayLap = x.t.NgayLap,
                DuPhong = x.t.DuPhong,
                GhiChu = x.t.GhiChu
            }).ToListAsync();
        }

        public async Task<TonghopBienap> Update([FromBody] TonghopBienap Request)
        {
            var entity = await _thietbiDb.TonghopBienaps.FindAsync(Request.Id);
            if (entity == null)
            {
                return null;
            }
            // validate referenced entities exist
            var bienapExists = await _thietbiDb.DanhmucBienaps.AnyAsync(x => x.Id == Request.BienapId);
            var phongbanExists = await _thietbiDb.PhongBans.AnyAsync(x => x.Id == Request.PhongbanId);
            if (!bienapExists || !phongbanExists)
            {
                return null;
            }

            entity.BienapId = Request.BienapId;
            entity.PhongbanId = Request.PhongbanId;
            entity.ViTriLapDat = Request.ViTriLapDat;
            entity.NgayLap = Request.NgayLap;
            entity.DuPhong = Request.DuPhong;
            entity.GhiChu = Request.GhiChu;
            _thietbiDb.Update(entity);
            try
            {
                await _thietbiDb.SaveChangesAsync();
                return entity;
            }
            catch
            {
                return null;
            }
        }
    }
}
