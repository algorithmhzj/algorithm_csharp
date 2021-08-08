using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace algorithm_csharp.std
{
    public class DictTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDictPaas()
        {
            Dictionary<string,string> dict = new Dictionary<String, String>();
            method(dict);
            System.Console.WriteLine(dict);
            Assert.Pass();
        }
        
        public void method(Dictionary<string, string> dictionary)
        {
            dictionary.Add("1", "one");
        }
        
    }
}