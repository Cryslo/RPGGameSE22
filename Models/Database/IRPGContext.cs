using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Database
{
    public interface IRPGContext
    {

        List<string> GetAllCharacters();

        string GetCharacter(string name);
    }
}
