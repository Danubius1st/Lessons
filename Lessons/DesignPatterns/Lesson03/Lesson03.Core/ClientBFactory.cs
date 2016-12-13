namespace Lesson03.Core
{
    class ClientBFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientBComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientBTablet();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientBSmartPhone();
        }
    }
}
