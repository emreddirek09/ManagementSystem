using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Repositories
{
    public interface ICipherService
    {
        public string Encrypt(string cipherText);
        public string Decrypt(string cipherText);
    }
}
