using FieldHospital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldHospital
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Fighter> People = new List<Fighter>();
        public List<Tuple<Doctor, Fighter>> PeopleOnOperation = new List<Tuple<Doctor, Fighter>>();
        public int deceased = 0;
        public Form1()
        {
            InitializeComponent();                    
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            deceased = 0;
            Doctors.Clear();
            People.Clear();
            PeopleOnOperation.Clear();
            Doctors.Add(new Doctor("Хирург 1"));
            Doctors.Add(new Doctor("Хирург 2"));
            Doctors.Add(new Doctor("Хирург 3"));


            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //генерация нового пациента
            var rnd = random.Next(101);
            if (rnd <= newFigtherRandomUpDown.Value) People.Add(new Fighter((int)healthRangeMinUpDown.Value, (int)healthRangeMaxUpDown.Value));

            //перемещаем пациентов из общей очереди в очередь операций
            if (PeopleOnOperation.Count < 3)
            {
                switch (PeopleOnOperation.Count)
                {
                    case 0:
                        TakeFighter(3);
                        break;
                    case 1:
                        TakeFighter(2);
                        break;
                    case 2:
                        TakeFighter(1);
                        break;
                    default:
                        break;
                }
            }

            //операции            
            for (int i = 0; i < PeopleOnOperation.Count; i++)
            {
                PeopleOnOperation[i].Item1.Operation(PeopleOnOperation[i].Item2);
                //Debug.WriteLine($"PeopleOnOperation i {i} {PeopleOnOperation[i].Item1.Name} IsBusy {PeopleOnOperation[i].Item1.IsBusy} {PeopleOnOperation[i].Item1.Cured}| {PeopleOnOperation[i].Item2.Health}");
                if (PeopleOnOperation[i].Item2.Health == 100)
                {
                    PeopleOnOperation.RemoveAt(i);
                }
            }
            //Debug.WriteLine($"------------------------");

            //статистика докторов
            doctor1SkillLabelValue.Text = Doctors.FirstOrDefault(d=>d.Name == "Хирург 1").GetSkill().ToString("F1");
            doctor1CuredCountLabelValue.Text = Doctors.FirstOrDefault(d => d.Name == "Хирург 1").Cured.ToString();
            doctor2SkillLabelValue.Text = Doctors.FirstOrDefault(d => d.Name == "Хирург 2").GetSkill().ToString("F1");
            doctor2CuredCountLabelValue.Text = Doctors.FirstOrDefault(d => d.Name == "Хирург 2").Cured.ToString();
            doctor3SkillLabelValue.Text = Doctors.FirstOrDefault(d => d.Name == "Хирург 3").GetSkill().ToString("F1");
            doctor3CuredCountLabelValue.Text = Doctors.FirstOrDefault(d => d.Name == "Хирург 3").Cured.ToString();

            //убавление здоровья
            People.ForEach(p => p.RemoveHealth());
            //проверка умерших
            deceased += People.FindAll(p => !p.IsLive).Count;
            deathCountLabelValue.Text = deceased.ToString();
            People.RemoveAll(p => !p.IsLive);
            fightersCountеLabelValue.Text = (People.Count + PeopleOnOperation.Count).ToString();
            if (deceased>=50)
            {
                timer1.Enabled = false;
                MessageBox.Show("Ваш госпиталь закрыт!", "Провал!", MessageBoxButtons.OK);                
            }
            //Debug.WriteLine($"Пациенты {People.Count}");
        }
        private Doctor GetFreeDoctor()
        {
            //return Doctors.FirstOrDefault(d => !d.IsBusy);
            var doctor = Doctors.FirstOrDefault(d => !d.IsBusy);            
            //Doctors.ForEach(d=> {
            //    Debug.WriteLine($"doctor {d.Name} {d.IsBusy}");
            //});
            Debug.WriteLine($"GetFreeDoctor {doctor==null} {doctor?.Name}");
            return doctor;
        }
        private void TakeFighter(int count)
        {
            if (People.Count >= count)
            {
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        var doctor = GetFreeDoctor();
                        doctor.IsBusy = true;
                        PeopleOnOperation.Add(new Tuple<Doctor, Fighter>(doctor, People[i]));

                    }
                    People.RemoveRange(0, count);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Ошибка при перемещении бойца в очередь на операцию \n {ex.Message}");
                }
                
            }
        }

        private void healthRangeMinUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (healthRangeMinUpDown.Value > healthRangeMaxUpDown.Value) healthRangeMinUpDown.Value--;
        }

        private void healthRangeMaxUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (healthRangeMinUpDown.Value > healthRangeMaxUpDown.Value) healthRangeMaxUpDown.Value++;
        }
    }
}
