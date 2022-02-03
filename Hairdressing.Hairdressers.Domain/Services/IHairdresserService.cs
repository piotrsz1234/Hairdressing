using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hairdressing.Hairdressers.Domain.Dtos;

namespace Hairdressing.Hairdressers.Domain.Services {

    public interface IHairdresserService {

        Task<IReadOnlyCollection<HairdresserDto>> BrowseAsync();

        Task<HairdresserDto> GetOneAsync(Guid id);

        Task SaveAsync(HairdresserDto hairdresser);

    }

}