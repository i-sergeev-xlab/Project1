using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
    // Start is called before the first frame update
    public class MyClass
    {
        public int i;
        public int j;
    }
    public struct MyStruct
    {
        public string name;
        public int age;
    }


    public class MyList<TItem>
    {
        private TItem[] array = new TItem[4];

        public int count { get; }

        public void Push(TItem i)

        {

        }

        public void Insert(int index, TItem item)

        {

        }

        public void Remove(TItem item) { }

        public void Clear() { }

        public void Index0f(TItem item)
        {
            return;
        }

        public void RemoveAt(int index) { }
    }
    
    public void Test<T>(ref T i)
    {

    }

    void Start()
    {
        var mc = new MyClass();
        var ms = new MyStruct();
        var ms2 = new MyStruct();
        ms = ms2;
        int i = 10;

        List<MyClass> standartList = new List<MyClass>();

        Test<int>(ref i);
        MyList<MyClass> myList = new MyList<MyClass>();
        myList.Push(new MyClass());

    }
}
