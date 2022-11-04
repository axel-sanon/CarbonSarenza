﻿using CarbonSarenza.Web.Domain.Entities;
using CarbonSarenza.Web.Domain.Repositories.Base;

namespace CarbonSarenza.Web.Domain.Repositories;

public interface ITemperatureHistoryRepository : IRepository<History>
{
     Task<IReadOnlyList<double>> FindLastEntries(int entriesNumber);
     Task<double> FindLastEntry();
}