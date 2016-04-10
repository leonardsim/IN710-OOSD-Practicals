using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public interface IEncryption
    {
        string Encrypt(string input);
    }
}
