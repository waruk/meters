using System;
using System.Collections.Generic;
using System.Text;
using Meters.Data.Entities;

namespace Meters.Data
{
    public interface IMetersRepository
    {
        bool MeterExists(int meterId);

        IEnumerable<Meter> GetMeters();

        Meter GetMeter(int meterId, bool includeIndices);

        IEnumerable<Index> GetIndices(int meterId);

        Index GetLastIndex(int meterId);
    }
}
