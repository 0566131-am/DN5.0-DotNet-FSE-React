// BUILDER PATTERN
// Separates the construction of a complex object from its representation,
// so the same construction process can create different representations.
using System;

namespace Patterns.Creational.Builder
{
    public class House
    {
        public string? Foundation { get; set; }
        public string? Structure { get; set; }
        public string? Roof { get; set; }
        public bool HasGarage { get; set; }
        public bool HasSwimmingPool { get; set; }

        public override string ToString() =>
            $"House [Foundation={Foundation}, Structure={Structure}, Roof={Roof}, " +
            $"Garage={HasGarage}, Pool={HasSwimmingPool}]";
    }

    public class HouseBuilder
    {
        private readonly House _house = new();

        public HouseBuilder BuildFoundation(string foundation)
        {
            _house.Foundation = foundation;
            return this; // Enables fluent chaining
        }

        public HouseBuilder BuildStructure(string structure)
        {
            _house.Structure = structure;
            return this;
        }

        public HouseBuilder BuildRoof(string roof)
        {
            _house.Roof = roof;
            return this;
        }

        public HouseBuilder AddGarage()
        {
            _house.HasGarage = true;
            return this;
        }

        public HouseBuilder AddSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }

        public House Build() => _house;
    }

    class Program
    {
        static void Main()
        {
            House simpleHouse = new HouseBuilder()
                .BuildFoundation("Concrete")
                .BuildStructure("Brick")
                .BuildRoof("Tiles")
                .Build();

            House luxuryHouse = new HouseBuilder()
                .BuildFoundation("Reinforced Concrete")
                .BuildStructure("Steel Frame")
                .BuildRoof("Solar Tiles")
                .AddGarage()
                .AddSwimmingPool()
                .Build();

            Console.WriteLine(simpleHouse);
            Console.WriteLine(luxuryHouse);
        }
    }
}
