using System;
using System.Collections.Generic;

namespace Collections
{
    public class LinkedListExample
    {
        private string _msg;
        private string _today = "today", _yesterday = "yesterday";

        public LinkedListExample(string msg)
        {
            _msg = msg;
            int No = 0;
            string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, ++No);

            sentence.AddFirst(_today);
            string Msg = string.Format("\tAdd the word '{0}' to the beginning of the linked list:", _today);
            Display(sentence, ++No, Msg);

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Msg = "\tMove the first node to be the last node";
            Display(sentence, ++No, Msg);

            sentence.RemoveLast();
            sentence.AddFirst(_yesterday);
            Msg = string.Format("\tChange the last node be '{0}'", _yesterday);
            Display(sentence, ++No, Msg);

        }

        private void Display(LinkedList<string> words, int no, string Msg = "")
        {
            Console.WriteLine(string.Format(_msg + ":", no));
            if (!string.IsNullOrWhiteSpace(Msg))
            {
                Console.WriteLine(Msg);
            }
            Console.Write("\t");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            if (no == 1)
            {
                Console.WriteLine("\n\tSentence contains(\"{0}\") = {1}", _today, words.Contains(_today));
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
