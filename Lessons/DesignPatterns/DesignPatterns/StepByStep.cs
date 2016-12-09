using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class StepByStep
    {
    }

    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public abstract class Duck
    {
        IFlyBehavior _flyBehavior;
        IQuackBehavior _quackBehavior;

        public abstract void Display();
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }
        public void PerformSwim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I’m flying!!");
            ;
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can’t fly");
            ;
        }
    }

    public class Quack : IQuackBehavior
    {
        public void Quack()
        {
            throw new NotImplementedException();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
}
