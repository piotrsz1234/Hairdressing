using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Hairdressing.Hairdressers.Domain.Entities;

namespace Hairdressing.Hairdressers.Domain.Repositories {

    public interface IHairdresserRepository {

        Task<Hairdresser> GetOneAsync(Guid id, params Expression<Func<Hairdresser, bool>>[] includes);

        Task<IReadOnlyCollection<Hairdresser>> GetAllAsync(Expression<Func<Hairdresser, bool>> expression,
            params Expression<Func<Hairdresser, bool>>[] includes);

        Task SaveAsync(Hairdresser hairdresser);

    }

}