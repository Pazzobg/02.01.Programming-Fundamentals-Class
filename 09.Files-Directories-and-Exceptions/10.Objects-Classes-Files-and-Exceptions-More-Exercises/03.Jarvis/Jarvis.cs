namespace _03.Jarvis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Jarvis
    {
        public static void Main()
        {
            var head = new List<Head>();
            var torso = new List<Torso>();
            var arms = new List<Arm>();
            var legs = new List<Leg>();

            long jarvisEnergy = long.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "Assemble!")
            {
                string typeOfComponent = input[0];
                int energyConsumption = int.Parse(input[1]);

                switch (typeOfComponent)
                {
                    case "Head":
                        int iq = int.Parse(input[2]);
                        string skin = input[3];

                        var currentHead = new Head
                        {
                            EnergyConsumption = energyConsumption,
                            Iq = iq,
                            SkinMaterial = skin
                        };

                        if (head.Count == 0)
                        {
                            head.Add(currentHead);
                        }
                        else
                        {
                            if (currentHead.EnergyConsumption < head[0].EnergyConsumption)
                            {
                                head[0] = currentHead;
                            }
                        }

                        break;

                    case "Torso":
                        double processorSize = double.Parse(input[2]);
                        string housing = input[3];

                        var currentTorso = new Torso
                        {
                            EnergyConsumption = energyConsumption,
                            ProcessorSize = processorSize,
                            HousingMaterial = housing
                        };

                        if (torso.Count == 0)
                        {
                            torso.Add(currentTorso);
                        }
                        else
                        {
                            if (currentTorso.EnergyConsumption < torso[0].EnergyConsumption)
                            {
                                torso[0] = currentTorso;
                            }
                        }

                        break;

                    case "Arm":
                        int armReachDist = int.Parse(input[2]);
                        int fingers = int.Parse(input[3]);

                        var currentArm = new Arm
                        {
                            EnergyConsumption = energyConsumption,
                            ArmReachDistance = armReachDist,
                            FingersCount = fingers
                        };

                        if (arms.Count < 2)
                        {
                            arms.Add(currentArm);
                        }
                        else
                        {
                            if (currentArm.EnergyConsumption < arms[1].EnergyConsumption)
                            {
                                if (arms[1].EnergyConsumption < arms[0].EnergyConsumption)
                                {
                                    arms[0] = arms[1];
                                }

                                arms[1] = currentArm;
                            }
                        }

                        break;

                    case "Leg":
                        int strength = int.Parse(input[2]);
                        int speed = int.Parse(input[3]);

                        var currentLeg = new Leg
                        {
                            EnergyConsumption = energyConsumption,
                            Strength = strength,
                            Speed = speed
                        };

                        if (legs.Count < 2)
                        {
                            legs.Add(currentLeg);
                        }
                        else
                        {
                            if (currentLeg.EnergyConsumption < legs[1].EnergyConsumption)
                            {
                                if (legs[1].EnergyConsumption < legs[0].EnergyConsumption)
                                {
                                    legs[0] = legs[1];
                                }

                                legs[1] = currentLeg;
                            }
                        }

                        break;
                }

                input = Console.ReadLine().Split(' ');
            }

            bool jarvisCanBeBuilt = false;

            long currentEnergyConsumption = CalculateCurrentEnergyConsumption(head, torso, arms, legs);

            bool energyIsEnough = jarvisEnergy >= currentEnergyConsumption;
            bool allPartsPresent = CheckIfAllBodypartsPresent(head, torso, arms, legs);

            if (energyIsEnough && allPartsPresent)
            {
                jarvisCanBeBuilt = true;
            }

            if (jarvisCanBeBuilt)
            {
                Console.WriteLine($"Jarvis: ");
                Console.WriteLine(head[0]);
                Console.WriteLine(torso[0]);

                // Overriding ToString() method of a class: 
                // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method

                foreach (var arm in arms.OrderBy(x => x.EnergyConsumption))
                {
                    Console.WriteLine(arm);
                }

                foreach (var leg in legs.OrderBy(x => x.EnergyConsumption))
                {
                    Console.WriteLine(leg);
                }
            }
            else
            {
                if (!energyIsEnough)
                {
                    Console.WriteLine("We need more power!");
                }

                if (!allPartsPresent)
                {
                    Console.WriteLine("We need more parts!");
                }
            }
        }

        public static long CalculateCurrentEnergyConsumption(
            List<Head> head, List<Torso> torso, List<Arm> arms, List<Leg> legs)
        {
            long consumption = 0;

            if (head.Count == 1)
            {
                consumption += head[0].EnergyConsumption;
            }

            if (torso.Count == 1)
            {
                consumption += torso[0].EnergyConsumption;
            }

            foreach (var arm in arms)
            {
                consumption += arm.EnergyConsumption;
            }

            foreach (var leg in legs)
            {
                consumption += leg.EnergyConsumption;
            }

            return consumption;
        }

        public static bool CheckIfAllBodypartsPresent(
            List<Head> head, List<Torso> torso, List<Arm> arms, List<Leg> legs)
        {
            return head.Count == 1 && torso.Count == 1 && arms.Count == 2 && legs.Count == 2;
        }
    }
}
