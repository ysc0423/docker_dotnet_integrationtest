using jenkin_test.Domain;
using jenkin_test.Repository;
using System.Collections.Generic;

namespace jenkin_test.Service
{
	public class ValueService : IValueService
	{
		private readonly IValueRepository _valueRepository;

		public ValueService(IValueRepository valueRepository)
		{
			_valueRepository = valueRepository;
		}

		public IEnumerable<User> Get()
		{
			return _valueRepository.Get();
		}
	}
}
