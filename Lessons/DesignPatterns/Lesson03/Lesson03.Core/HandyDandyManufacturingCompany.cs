﻿using System.Collections.Generic;

namespace Lesson03.Core
{
    public class HandyDandyManufacturingCompany
    {
        private IFactory _factory;
        private readonly List<IComputer> _computers;
        private readonly List<ITablet> _tablets;
        private readonly List<ISmartPhone> _phones;

        //public IEnumerable<IComputer> Computers { get { return _computers.ToArray(); } }
        public IEnumerable<IComputer> Computers => _computers.ToArray();    // expression body
        //public IEnumerable<ITablet> Tablets { get { return _tablets.ToArray(); } }
        public IEnumerable<ITablet> Tablets => _tablets.ToArray();
        //public IEnumerable<ISmartPhone> SmartPhones { get { return _phones.ToArray(); } }
        public IEnumerable<ISmartPhone> SmartPhones => _phones.ToArray();

        public HandyDandyManufacturingCompany(IFactory factory)
        {
            _factory = factory;
            _computers = new List<IComputer>();
            _tablets = new List<ITablet>();
            _phones = new List<ISmartPhone>();
        }

        public void Produce(Order order)
        {
            CreateComputers(order.Computers);
            CreateTablets(order.Tablets);
            CreateSmartPhones(order.SmartPhones);
        }

        private void CreateComputers(int count)
        {
            while (_computers.Count < count)
            {
                _computers.Add(_factory.CreateComputer());
            }
        }

        private void CreateTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(_factory.CreateTablet());
            }
        }

        private void CreateSmartPhones(int count)
        {
            _phones.Add(_factory.CreateSmartPhone());
        }
    }
}