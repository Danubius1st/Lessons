using System;

namespace Collections
{

    public class GenericListsExample<T>
    {
        public void Add(object value)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Generics
    {
        //var p = new GenericListsExample<Pet>();
        public Generics()
        {
            Compare<int> obj = new Compare<int>();
            bool equalObj = obj.Check(2, 3);

            Compare<string> stringObject = new Compare<string>();
            equalObj = stringObject.Check("a", "b");
        }
    }

    class Compare<AnyDataType>
    {
        public bool Check(AnyDataType data1, AnyDataType data2)
        {
            if (data1.Equals(data2))
            {
                return true;
            }
            return false;
        }
    }
}
