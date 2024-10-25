using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldHospital.Models
{
    public class Person
    {
        private int health = 100;

        public int Health
        {
            get { return health; }
            set
            {
                health = value >= 100 ? 100 : (value <= 0 ? 0 : value); // Используем тернарный оператор для установки значения
                if (health == 0) IsLive = false;
            }
        }
        public bool IsLive { get; set; } = true;


    }
}
