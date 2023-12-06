using MuhasebeNET.Domain.Entities.Base;
using MuhasebeNET.Domain.Interfaces;

namespace MuhasebeNET.Infrastructure.EFCore
{
	public class EFCoreRepository<T> : IRepository<T> where T : BaseEntity
	{
		public T Add(T entity)
		{
			throw new NotImplementedException();
		}

		public T GetBeyId(int id)
		{
			throw new NotImplementedException();
		}

		public ICollection<T> GetList(Func<T, bool> expression = null)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Remove(T entity)
		{
			throw new NotImplementedException();
		}

		public T Update(int id, T entity)
		{
			throw new NotImplementedException();
		}
	}
}
