using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;

namespace Gym.Core
{
    public class Controller : IController
    {
        //equipment - EquipmentRepository
        private EquipmentRepository equipments;
        //    gyms - a collection of IGym
        private ICollection<IGym> gyms;

        public Controller()
        {
            this.equipments = new EquipmentRepository();
            this.gyms = new List<IGym>();
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gymToAdd = null;

            switch (gymType)
            {
                case nameof(BoxingGym):
                    gymToAdd = new BoxingGym(gymName);
                    break;
                case nameof(WeightliftingGym):
                    gymToAdd = new WeightliftingGym(gymName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            gyms.Add(gymToAdd);

            return string.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment = null;

            switch (equipmentType)
            {
                case nameof(BoxingGloves):
                    equipment = new BoxingGloves();
                    break;
                case nameof(Kettlebell):
                    equipment = new Kettlebell();
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }

            this.equipments.Add(equipment);

            return string.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment equipmentToAdd = equipments
                .FindByType(equipmentType);

            if (equipmentToAdd == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }

            IGym gym = gyms
                .FirstOrDefault(x => x.Name == gymName);

            gym.AddEquipment(equipmentToAdd);
            equipments.Remove(equipmentToAdd);

            return string.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete currentAthlete = null;

            switch (athleteType)
            {
                case nameof(Boxer):
                    currentAthlete = new Boxer(athleteName, motivation, numberOfMedals);
                    break;
                case nameof(Weightlifter):
                    currentAthlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            IGym gym = gyms
                .FirstOrDefault(g => g.Name == gymName);

            if (gym.GetType().Name == nameof(BoxingGym))
            {
                if (currentAthlete.GetType().Name == nameof(Weightlifter))
                {
                    return OutputMessages.InappropriateGym;
                }
            }

            if (gym.GetType().Name == nameof(WeightliftingGym))
            {
                if (currentAthlete.GetType().Name == nameof(Boxer))
                {
                    return OutputMessages.InappropriateGym;
                }
            }

            gym.AddAthlete(currentAthlete);

            return string.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string TrainAthletes(string gymName)
        {
            IGym currentGym = gyms.FirstOrDefault(x => x.Name == gymName);

            currentGym.Exercise();

            return string.Format(OutputMessages.AthleteExercise, currentGym.Athletes.Count);
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = gyms
                .FirstOrDefault(g => g.Name == gymName);

            return string.Format(OutputMessages.EquipmentTotalWeight, gymName, Math.Round(gym.EquipmentWeight, 2));
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var gym in gyms)
            {
                sb.AppendLine($"{gym.GymInfo()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
