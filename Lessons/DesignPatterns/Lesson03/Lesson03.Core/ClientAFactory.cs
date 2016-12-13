namespace Lesson03.Core
{
    class ClientAFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientAComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientATablet();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientASmartPhone();
        }
    }
}
