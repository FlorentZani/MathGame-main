using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Program
    {


        static void Main(string[] args)
        {

                //Declaration of variables we need to use to keep track of correct answers
                int xAdd = 0;
                int yAdd = 0;
                

                int xSub = 0;
                int ySub = 0;
                

                int xMul = 0;
                int yMul = 0;
                

                int xDiv = 0;
                int yDiv = 0;
                
                int xRand = 0;
                int yRand = 0;


                
                int difficulity = 1;//Declaration of Difficulity 
                int numberOfQuestions = 5;

                Stopwatch timer = new Stopwatch();
                


                Console.WriteLine("WELCOME TO THE MATH GAME ");
                
                Console.WriteLine("Press ENTER to continue");

                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                
            //We open a while loop which can be broken only if user decides to press 0-QUIT
            while (true)
            {

                Console.WriteLine("Choose what type of game do you want to play:\n 0-QUIT \n 1-ADDITION \n 2-SUBSTRACTION" +
                    " \n 3-MULTIPLICATION \n 4-DIVISION \n 5-RandomGame \n 6-Change Difficulity \n 7-Change number of questions \n 8-ViewScore");


                string userInput = Console.ReadLine(); //Gets user input
                int number;

                bool isNum = int.TryParse(userInput, out number); //checks if the user input is a number
                while (!isNum)
                {
                    Console.WriteLine("Input a number from 0 to 5");
                    userInput = Console.ReadLine();
                    isNum = int.TryParse(userInput, out number);
                }
                int i = 0;
                

                while (true)//Checks if the number is from 0 to 5
                {

                    if (number == 0 || number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6
                        || number == 7 || number == 8)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input a number from 0 to 6");
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out number);
                    }

                    

                }


                if (number == 0)//Quits the program
                {
                    break;
                }

                //Handels Addition
                else if (number == 1)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    //Reset and start the timer 
                    timer.Reset();
                    timer.Start();

                    while(i < numberOfQuestions)
                    {
                        i++;
                        Console.WriteLine("You choose the Addition Game ");
                        if(difficulity == 1 )
                        {
                            firstNum = random.Next(0, 33);
                            secondNum = random.Next(0, 33);
                        }
                        else if (difficulity == 2 )
                        {
                            firstNum = random.Next(0, 66);
                            secondNum = random.Next(0, 66);
                        }
                        else
                        {
                            firstNum = random.Next(0, 100);
                            secondNum = random.Next(0, 100);
                        }
                        
                        result = firstNum + secondNum;
                        Console.WriteLine($"{firstNum} + {secondNum}");

                        


                        userInput = Console.ReadLine();
                        while(!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine() ;
                        }

                        


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xAdd++;
                            yAdd++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yAdd++;
                        }

                        
                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    //Stop timer and print the time taken
                    Console.Clear();
                    timer.Stop();
                    TimeSpan additionTime = timer.Elapsed;
                    Console.WriteLine("TIME TAKEN :" + additionTime.TotalSeconds);
                    Console.ReadKey();
                    Console.Clear();

                }

                //Handels substraction
                else if (number == 2)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    //Reset and start the timer 
                    timer.Reset();
                    timer.Start();

                    while (i < numberOfQuestions)
                    {
                        i++;
                        Console.WriteLine("You choose the Substraction Game ");
                        if (difficulity == 1)
                        {
                            firstNum = random.Next(0, 33);
                            secondNum = random.Next(0, 33);
                        }
                        else if (difficulity == 2)
                        {
                            firstNum = random.Next(0, 66);
                            secondNum = random.Next(0, 66);
                        }
                        else
                        {
                            firstNum = random.Next(0, 100);
                            secondNum = random.Next(0, 100);
                        }
                        result = firstNum - secondNum;
                        Console.WriteLine($"{firstNum} - {secondNum}");

                        userInput = Console.ReadLine();
                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xSub++;
                            ySub++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            ySub++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    //Stop timer and print the time taken
                    Console.Clear();
                    timer.Stop();
                    TimeSpan additionTime = timer.Elapsed;
                    Console.WriteLine("TIME TAKEN :" + additionTime.TotalSeconds);
                    Console.ReadKey();
                    Console.Clear();


                }

                //Handles Multiplication
                else if (number == 3)
                {

                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    //Reset and start the timer 
                    timer.Reset();
                    timer.Start();

                    while (i < numberOfQuestions)
                    {
                        i++;
                        Console.WriteLine("You choose the Multiplication Game ");
                        if (difficulity == 1)
                        {
                            firstNum = random.Next(0, 33);
                            secondNum = random.Next(0, 33);
                        }
                        else if (difficulity == 2)
                        {
                            firstNum = random.Next(0, 66);
                            secondNum = random.Next(0, 66);
                        }
                        else
                        {
                            firstNum = random.Next(0, 100);
                            secondNum = random.Next(0, 100);
                        }
                        result = firstNum * secondNum;
                        Console.WriteLine($"{firstNum} * {secondNum}");

                        userInput = Console.ReadLine();

                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xMul++;
                            yMul++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yMul++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //Stop timer and print the time taken
                    Console.Clear();
                    timer.Stop();
                    TimeSpan additionTime = timer.Elapsed;
                    Console.WriteLine("TIME TAKEN :" + additionTime.TotalSeconds);
                    Console.ReadKey();
                    Console.Clear();


                }

                //Handels Division
                else if (number == 4)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    float result;
                    string user;
                    int userAnswer;

                    //Reset and start the timer 
                    timer.Reset();
                    timer.Start();

                    while (i < numberOfQuestions)
                    {
                        i++;
                        Console.WriteLine("You choose the Division Game ");
                        do 
                        {
                            if (difficulity == 1)
                            {
                                firstNum = random.Next(0, 33);
                                secondNum = random.Next(1, 33);
                            }
                            else if (difficulity == 2)
                            {
                                firstNum = random.Next(0, 66);
                                secondNum = random.Next(1, 66);
                            }
                            else
                            {
                                firstNum = random.Next(0, 100);
                                secondNum = random.Next(1, 100);
                            }
                            result = (float) firstNum / secondNum;
                        }
                        while(Math.Round(result) != result);
                        

                        Console.WriteLine($"{firstNum} / {secondNum}");

                        userInput = Console.ReadLine();
                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xDiv++;
                            yDiv++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yDiv++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //Stop timer and print the time taken
                    Console.Clear();
                    timer.Stop();
                    TimeSpan additionTime = timer.Elapsed;
                    Console.WriteLine("TIME TAKEN :" + additionTime.TotalSeconds);
                    Console.ReadKey();
                    Console.Clear();


                }

                //Random Game
                else if (number == 5)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    float result;
                    string user;
                    int userAnswer;

                    //Reset and start the timer 
                    timer.Reset();
                    timer.Start();

                    while (i < numberOfQuestions)
                    {
                        i++;
                        int operationChoosen = random.Next(1, 4);
                        Console.WriteLine($"{operationChoosen}");
                        Console.WriteLine("You choose the Random Game ");
                        do
                        {
                            if (difficulity == 1)
                            {
                                firstNum = random.Next(0, 33);
                                secondNum = random.Next(1, 33);
                            }
                            else if (difficulity == 2)
                            {
                                firstNum = random.Next(0, 66);
                                secondNum = random.Next(1, 66);
                            }
                            else
                            {
                                firstNum = random.Next(0, 100);
                                secondNum = random.Next(1, 100);
                            }


                            if (operationChoosen == 1)
                            {
                                result = (float)firstNum + secondNum;
                                Console.WriteLine($"{firstNum} + {secondNum}");
                            }
                            else if (operationChoosen == 2)
                            {
                                result = (float)firstNum - secondNum;
                                Console.WriteLine($"{firstNum} - {secondNum}");
                            }
                            else if (operationChoosen == 3)
                            {
                                result = (float)firstNum * secondNum;
                                Console.WriteLine($"{firstNum} * {secondNum}");
                            }
                            else
                            {
                                result = (float)firstNum / secondNum;
                                Console.WriteLine($"{firstNum} / {secondNum}");
                            }
                        }
                        while (Math.Round(result) != result);




                        userInput = Console.ReadLine();
                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xRand++;
                            yRand++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yRand++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //Stop timer and print the time taken
                    Console.Clear();
                    timer.Stop();
                    TimeSpan additionTime = timer.Elapsed;
                    Console.WriteLine("TIME TAKEN :" + additionTime.TotalSeconds);
                    Console.ReadKey();
                    Console.Clear();




                }

                //Handels difficultiy levels
                else if( number == 6) 
                {

                    Console.Clear();
                    Console.WriteLine("Change difficulity : ");
                    Console.WriteLine("\nEasy : 1");
                    Console.WriteLine("\nMedimum : 2 ");
                    Console.WriteLine("\nHard : 3");

                    bool isCorrect = false;
                    Console.WriteLine("\nInput a number from 1 to 3 to change difficulty");
                    
                    do
                    {
                        
                        userInput = Console.ReadLine();
                        isCorrect = int.TryParse(userInput, out number);

                        if (isCorrect && (number <= 0 || number > 3))
                        {
                            Console.WriteLine("Please enter a number between 1 and 3.");
                            isCorrect = false; // Resetting to false to continue the loop
                        }
                        difficulity = number;//setting the difficulity 

                    } while (!isCorrect);

                    Console.Clear();


                }

                //Change Number of questions 
                else if(number == 7) 
                {

                    Console.Clear();
                    Console.WriteLine("Set number of questions : ");
                    bool isCorrect = false;
                    while(!isCorrect) {
                        userInput = Console.ReadLine();
                        if(int.TryParse(userInput, out numberOfQuestions))
                        {
                            break;
                        }

                    }

                    
                    
                }
                //Handels Scoring system
                else if (number == 8)
                {
                    Console.Clear();
                    Console.WriteLine($"Addition Score: {xAdd} / {yAdd}  ");
                    Console.WriteLine($"Substraction Score:{xSub} / {ySub} ");
                    Console.WriteLine($"Multiplication Score:{xMul} / {yMul} ");
                    Console.WriteLine($"Division Score:{xDiv} / {yDiv}");
                    Console.WriteLine($"RandomGame Score:{xRand} / {yRand}");

                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    Console.Clear();

                }
                

            }
        }
    }
}
