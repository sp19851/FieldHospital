using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldHospital.Models
{
    public class Fighter:Person
    {
        private readonly Random rnd = new Random();

        public Fighter(int min, int max)
        {
        
            Health = rnd.Next(min, max);
        }

        public void AddHealth(int skill)
        {
            Health += (skill+1);
            
        }
        public void RemoveHealth()
        {
            Health -= 1;            
        }
    }
}
