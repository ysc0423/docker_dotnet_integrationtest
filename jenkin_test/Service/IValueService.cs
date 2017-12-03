using jenkin_test.Domain;
using System.Collections.Generic;

namespace jenkin_test.Service
{
	public interface IValueService
    {
		IEnumerable<User> Get();
    }
}
