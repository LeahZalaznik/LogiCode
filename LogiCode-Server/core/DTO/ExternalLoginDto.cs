using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class ExternalLoginDto
    {
            public string Provider { get; set; } = null!;
            public string ProviderId { get; set; } = null!;
            public string Email { get; set; } = null!;
            public string Name { get; set; } = null!;

    }
}
