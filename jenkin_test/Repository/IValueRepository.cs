using jenkin_test.Domain;
using System.Collections.Generic;

namespace jenkin_test.Repository
{
	public interface IValueRepository
	{
		IEnumerable<User> Get();
	}
}