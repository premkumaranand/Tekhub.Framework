using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekhub.Framework
{
    public interface IHashService
    {
        string CreateHash(string clearText);
        bool ValidateClearText(string clearText, string correctHash);
    }
}
