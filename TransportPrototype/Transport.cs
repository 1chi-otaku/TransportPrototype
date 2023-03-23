using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrototype
{
    abstract class ITransport
    {
        protected string name { get; set; }
        protected string type { get; set; }

        public ITransport() { }
        public ITransport(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        abstract public ITransport Clone();
    }
    class Engine
    {
        public string engine { get; set; }
        public Engine() { }
        public Engine(string engine)
        {
            this.engine = engine;
        }

        public Engine Clone()
        {
            Engine new_engine = new Engine();
            new_engine.engine = engine;
            return new_engine;
        }
 
    }
    class Vessel : ITransport
    {
        public Engine engine { get; set; }
        public double cargo_capacity { get; set; }

        public Vessel()
        {
        }
        public Vessel(string name, string type, Engine engine, double cargo_capacity):base(name,type)
        {
            this.engine = engine;
            this.cargo_capacity = cargo_capacity;
        }
        
        public void Print()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Type - " + type);
            Console.WriteLine("Engine - " + engine.engine);
            Console.WriteLine("Cargo capacity - " + cargo_capacity);
        }
        public override ITransport Clone()
        {
            Vessel new_vessel = new Vessel();
            new_vessel.name = (string)name.Clone();
            new_vessel.type = (string)type.Clone();
            new_vessel.cargo_capacity = this.cargo_capacity;
            new_vessel.engine = engine.Clone();
            return new_vessel;

        }
    }

    class Car : ITransport
    {
        public Engine engine { get; set; }
        public string car_body { get; set; }

        public Car()
        {
        }
        public Car(string name, string type, Engine engine, string car_body) : base(name, type)
        {
            this.engine = engine;
            this.car_body = car_body;
        }

        public void Print()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Type - " + type);
            Console.WriteLine("Engine - " + engine.engine);
            Console.WriteLine("Car Body - " + car_body);
        }
        public override ITransport Clone()
        {
            Car new_car = new Car();
            new_car.name = (string)name.Clone();
            new_car.type = (string)type.Clone();
            new_car.car_body = this.car_body;
            new_car.engine = engine.Clone();
            return new_car;

        }
    }

    class Airplane : ITransport
    {
        public Engine engine { get; set; }
        public string wing { get; set; }

        public Airplane()
        {
        }
        public Airplane(string name, string type, Engine engine, string wing) : base(name, type)
        {
            this.engine = engine;
            this.wing = wing;
        }

        public void Print()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Type - " + type);
            Console.WriteLine("Engine - " + engine.engine);
            Console.WriteLine("Car Body - " + wing);
        }
        public override ITransport Clone()
        {
            Airplane new_car = new Airplane();
            new_car.name = (string)name.Clone();
            new_car.type = (string)type.Clone();
            new_car.wing = this.wing;
            new_car.engine = engine.Clone();
            return new_car;

        }
    }
}
