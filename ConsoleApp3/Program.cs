using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SpyInMessage
    {

        public static int[] message;
        public static int[] spy;

        static void Main(String[] args)
        {
            SpyInMessage spyInMessage = new SpyInMessage();

            message = spyInMessage.getMessage();
            spy = spyInMessage.getSpy();


            if (spyInMessage.isSpyInMessage(spy))
            {
                Console.WriteLine("Message does contain the spy: ");
                foreach (int item in spy)
                {
                    Console.Write(item);
                }
            }

            else Console.WriteLine("Message does not contain the spy!");

        }


        public int[] getMessage()
        {
            Console.WriteLine("Enter massage(e.g. 000000...): ");
            String messageString = Console.ReadLine();
            Char[] messageCharArr = messageString.ToCharArray();
            return setArray(messageCharArr, message);
        }

        public int[] getSpy()
        {
            Console.WriteLine("Enter spy (three numbers e.g: 123");
            String spyString = Console.ReadLine();
            Char[] spyCharArr = spyString.ToCharArray();
            while (!(spyCharArr.Length == 3))
            {
                Console.WriteLine("Enter three numbers for spy: ");
                spyString = Console.ReadLine();
                spyCharArr = spyString.ToCharArray();
            }
            return setArray(spyCharArr, spy);
        }

        public int[] setArray(Char[] messageCharArr, int[] array)
        {
            array = new int[messageCharArr.Length];

            for (int i = 0; i < messageCharArr.Length; i++)
            {

                array[i] = Convert.ToInt32(messageCharArr[i].ToString());

            }

            return array;
        }

        public Boolean isSpyInMessage(int[] spyCode)
        {
            int i;

            for (i = 0; i < message.Length; i++)
            {
                if (message[i] == spyCode[0] && i < message.Length - 1)
                {

                    for (i += 1; i < message.Length; i++)
                    {
                        if (message[i] == spyCode[1] && i < message.Length - 1)
                        {

                            for (i += 1; i < message.Length; i++)
                            {
                                if (message[i] == spyCode[2])
                                {
                                    return true;
                                }

                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
