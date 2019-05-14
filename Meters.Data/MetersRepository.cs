using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meters.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meters.Data
{
    public class MetersRepository : IMetersRepository
    {
        private MeterContext _context;

        public MetersRepository(MeterContext context)
        {
            _context = context;
        }

        public bool MeterExists(int meterId)
        {
            return _context.Meters.Any(m => m.MeterId == meterId);
        }

        public IEnumerable<Meter> GetMeters()
        {
            return _context.Meters.OrderBy(m => m.Location).ToList();
        }

        public Meter GetMeter(int meterId, bool includeIndices)
        {
            if (includeIndices)
            {
                return _context.Meters.Include(i => i.Indexes).Where(m => m.MeterId == meterId).FirstOrDefault();
            }

            return _context.Meters.Where(m => m.MeterId == meterId).FirstOrDefault();
        }

        public IEnumerable<Index> GetIndices(int meterId)
        {
            return _context.Indexes.Where(m => m.MeterId == meterId).ToList();
        }

        public Index GetLastIndex(int meterId)
        {
            return _context.Indexes.Where(m => m.MeterId == meterId).OrderByDescending(i => i.RegisteredDate).FirstOrDefault();
        }
    }
}
