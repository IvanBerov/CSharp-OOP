using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private List<IEquipment> equipments;
        private List<IAthlete> athletes;

        protected Gym(string name, int capacity)
        {
            this.name = name;
            this.Capacity = capacity;
            this.equipments = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }

                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public double EquipmentWeight => this.equipments.Sum(x=>x.Weight);

        public ICollection<IEquipment> Equipment => this.equipments;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {

            if (this.Capacity == this.athletes.Count)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }

            this.athletes.Add(athlete);
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return this.athletes.Remove(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipments.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name} is a {GetType().Name}:");

            // { athleteName1}, { athleteName2}, { athleteName3} (…) / No athletes
            //sb.AppendLine("Athletes: ");

            //if (athletes.Count == 0)
            //{
            //    sb.Append("No athletes");
            //}
            //else
            //{
            //    foreach (var athlete in athletes)
            //    {
            //        sb.Append($"{athlete.FullName}");
            //    }
            //}

            sb.AppendLine(this.athletes.Count > 0 ? $"Athletes: {string.Join(", ", this.athletes.Select(x => x.FullName))}" : "Athletes: No athletes");

            sb.AppendLine($"Equipment total count: {this.equipments.Count}");

            sb.AppendLine($"Equipment total weight: {this.EquipmentWeight:F2} grams");

            return sb.ToString().TrimEnd();
        }
    }
}
