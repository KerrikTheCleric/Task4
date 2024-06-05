﻿using System;

namespace SkalProj_Datastrukturer_Minne {
    class Program {
        /// <summary>
        /// The main method, vill handle the menus for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main() {

            // 1. Stacken är en "first in, last out"-hög med minneslådor som staplas ovanpå varandra varje gång exekveringen går en nivå "djupare" i programmet.
            //    Praktiskt sett så betyder det att minne som används i en metod för value type variabler är helt otillgängligt i en annan metod. Och om man ska komma tillbaka till tidigare
            //    minne så måste de nya lådorna "användas upp" genom att låta den nya kontexten (metoden) köra klart och återvända till den tidigare biten av programmet.
            //
            //    Heapen är en sorterad bit av minne, typ en serie bibliotekshyllor där minne kan lagras och kopieras av hela programmet så länge man har rätt address. 
            //    När en bit minne på heapen inte använts på tillräckligt länge så blir den bortrensad av garbage collection. Stacken är säkrare, men mer begränsad, medans heapen är mer osäker och flexibel.
            //    En ytterligare skillnad är att varje tråd i ett program har sin egen stack, men ofta delar på heap, så heapen kan användas för att förmedla information mellan trådar som jobbar tillsammans.
            //
            // 2. Värdetyper är simpla typer av data som kan lagras både på stack och heap. Referenstyper är mer komplexa datatyper som ärver av grund-objektet i C# och endast lagras på heapen.
            //
            // 3. I den första metoden så ändras aldrig värdet på x eftersom int är en värdetyp, så metoden returnerar värdet x sätts till i andra raden.
            //    I den andra metoden så används en egen klass som är en referenstyp, så objektet som y pekar till ändras, vilket gör att när objektet ändras via y så ändras x också till 4 när y gör det.

            while (true) {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                } catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                  {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input) {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList() {
            /*
             * Loop this method until the user inputs something to exit to the main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> examinationList = new List<string>();

            Console.WriteLine("Please input something prepended with '+' to add it to the list and input it again prepended with '-' to remove it again." +
                "\nTo return to the main menu, input something that doesn't start with either '+'or '-'.");

            char nav = ' ';
            string value = " ";

            while (true) {
                string input = Console.ReadLine() ?? " ";
                if (!String.IsNullOrEmpty(input) && input.Length > 1) {
                    nav = input[0];
                    value = input.Substring(1);
                }

                switch (nav) {
                    case '+':
                        Console.WriteLine("Plus Case!");
                        examinationList.Add(value);
                        Console.WriteLine($"Count: {examinationList.Count} - Capacity {examinationList.Capacity}");
                        break;
                    case '-':
                        Console.WriteLine("Minus Case!");
                        examinationList.Remove(value);
                        Console.WriteLine($"Count: {examinationList.Count} - Capacity {examinationList.Capacity}");
                        break;
                    default:
                        return;
                }
            }

            // 2. Kapaciteten ökar när den överskrids.
            // 3. Den dubbleras.
            // 4. Jag gissar att det är för att att en minnesallokering kostar så många resurser att det inte är värt att gör varje gång.
            // 5. Nej.
            // 6. När man vet exakt hur många element som max behöver lagras, t.ex en samling med namn för en meny som bara kan visa 15 namn som mest.
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue() {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack() {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis() {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

