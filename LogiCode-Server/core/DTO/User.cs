using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // אם המשתמש הגיע עם סיסמה רגילה
        public string? Password { get; set; }

        // מזהה חיצוני מ-Google
        public string? Provider { get; set; } // לדוגמה: "Google"
        public string? ProviderId { get; set; } // ה-ID של גוגל
    }

}
