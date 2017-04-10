using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSE22.Classes
{
    public interface IPickupable
    {
        bool isPickedup { get; set; }

        void pickUpInteraction();
    }
}
