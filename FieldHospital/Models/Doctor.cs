using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldHospital.Models
{
    public class Doctor:Person
    {
        private double Skill;
        public string Name { get; set; }
        public int Cured { get; private set; }
        public bool IsBusy { get; set; }
        public Doctor(string name)
        {
            Name = name;
            IsBusy = false;
            Cured = 0;
            Skill = 0;
        }

        private void AddCured()
        {
            Cured += 1;            
        }

        public void AddSkill()
        {
            Skill += 0.1;
            Skill = Skill > 10 ? 10 : Skill;            
        }

        public double GetSkill()
        {
            return Skill;
        }

        public void Operation(Fighter fighter)
        {
            //Debug.WriteLine($"Operation start doctor {Name} fighter {fighter.Health}");
            

            // Увеличиваем здоровье бойца
            fighter.AddHealth((int)Math.Floor(Skill));

            // Проверяем, достигло ли здоровье максимума
            if (fighter.Health == 100)
            {
                AddSkill();
                AddCured();
                IsBusy = false;
            }

            //Debug.WriteLine($"Operation doctor {Name} fighter {fighter.Health}");
        }
    }
}
