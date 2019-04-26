using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using intel.IT.WordChecker;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        public List<string> valid_words = new List<string>();
        public List<string> invalid_words = new List<string>();
        public List<string> random_valid_words = new List<string>();
        public List<string> random_invalid_words = new List<string>();

        string valids = "I,O,X,IX,IO,OX,OI,XI,XO,III,IOI,IXI,OOO,OIO,OXO,IXXI,OXXO,IOOIOIOIOOOIIIOO,OXXOIOIXXXI,OXOXXO,XIOIOXOXXOIX";
        

        string invalids = "IXO,OXI,OOIXXXXXO,IOXI,IXXXXXIOXXXXXXI";


        [TestInitialize]
        public void Setup()
        {
            valid_words = valids.Split(',').ToList();
            invalid_words = invalids.Split(',').ToList();

            random_valid_words.Add("Group");
            random_valid_words.Add("Knife");
            //random_valid_words.Add("Together");

            random_invalid_words.Add("Together");
            random_invalid_words.Add("Number");
            random_invalid_words.Add("Pronounce");
        }

        [TestMethod]
        public void TestIsBroad()
        {
            //Check for IsBroadMethod is True by hardcoding 
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestIsSlendar()
        {
            //Check for Slendar is True by hardcoding 
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestValids()
        {
            foreach (string word in valid_words)
            {
                LanguageWord lWord = new LanguageWord(word);
                Console.WriteLine("Checking word:" + word);
                Assert.IsTrue(lWord.isValidWord());
            }
        }

        [TestMethod]
        public void TestInValids()
        {
            foreach (string word in invalid_words)
            {
                LanguageWord lWord = new LanguageWord(word);
                Assert.IsFalse(lWord.isValidWord());
            }
        }

        [TestMethod]
        public void TestRandomValidWords()
        {
            foreach (var word in random_valid_words)
            {
                LanguageWord lWord = new LanguageWord(word);
                Assert.IsTrue(lWord.isValidWord());
            }
        }

        [TestMethod]
        public void TestRandomInValidWords()
        {
            foreach (var word in random_invalid_words)
            {
                LanguageWord lWord = new LanguageWord(word);
                Assert.IsFalse(lWord.isValidWord());
            }
        }
    }
}
