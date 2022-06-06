using System;

namespace Console_Game
{
    internal class Program
    {
        //play feild
        static char[,] playFeild = new char[,]
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        
        static int turn = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            int player = 2;
            int inputValue = 0;
            Boolean isCheck = true;
           
            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    ChangePlayField('X', inputValue);
                  
                    
                }
                else if(player == 1)
                {
                    player = 2;
                    ChangePlayField('Y',inputValue);
                    
                }
                SetField();

                #region check winning condition
                char[] playerValues = { 'X', 'Y' };

                foreach(char value in playerValues)
                {
                    if ((playFeild[0, 0] == value) && (playFeild[0, 1] == value) && (playFeild[0, 2] == value)
                        || (playFeild[1, 0] == value) && (playFeild[1, 1] == value) && (playFeild[1, 2] == value)
                        || (playFeild[2, 0] == value) && (playFeild[2, 1] == value) && (playFeild[2, 2] == value)
                        || (playFeild[0, 0] == value) && (playFeild[1, 0] == value) && (playFeild[2, 0] == value)
                        || (playFeild[0, 1] == value) && (playFeild[1, 1] == value) && (playFeild[2, 1] == value)
                        || (playFeild[0, 2] == value) && (playFeild[1, 2] == value) && (playFeild[2, 2] == value)
                        || (playFeild[0, 0] == value) && (playFeild[1, 1] == value) && (playFeild[2, 2] == value)
                        || (playFeild[0, 2] == value) && (playFeild[1, 1] == value) && (playFeild[2, 0] == value))
                    {
                        if(value == 'X')
                        {
                            Console.WriteLine("\nCongradulations Player One Win !! ");
                        }

                        else
                        {
                            Console.WriteLine("\nCongradulations Player Two are Win !! ");
                        }
                        Console.WriteLine("Please enter any key to reset the game");
                        Console.ReadKey();
                        Reset();
                        break;
                    }
                    else if (turn == 10)
                    {
                        Console.WriteLine("Game is draw!!");
                        Console.WriteLine("Please enter any key to reset the game");
                        Console.ReadKey();
                        Reset();
                        break;
                    }
                   
                }

                #endregion

                #region check correct field
                do
                {
                   
                    try
                    {
                        Console.Write("\n Player {0}: Please enter value for feild: ", player);
                        inputValue = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter an Integer");
                    }

                    if ((inputValue == 1) && (playFeild[0, 0] == '1')) isCheck = true;
                    else if ((inputValue == 2) && (playFeild[0, 1] == '2')) isCheck = true;
                    else if ((inputValue == 3) && (playFeild[0, 2] == '3')) isCheck = true;
                    else if ((inputValue == 4) && (playFeild[1, 0] == '4')) isCheck = true;
                    else if ((inputValue == 5) && (playFeild[1, 1] == '5')) isCheck = true;
                    else if ((inputValue == 6) && (playFeild[1, 2] == '6')) isCheck = true;
                    else if ((inputValue == 7) && (playFeild[2, 0] == '7')) isCheck = true;
                    else if ((inputValue == 8) && (playFeild[2, 1] == '8')) isCheck = true;
                    else if ((inputValue == 9) && (playFeild[2, 2] == '9')) isCheck = true;
                    else
                    {
                        Console.WriteLine("Please choose another feild");
                        isCheck = false;
                    }

                } while (!isCheck);

            } while (true);
        }

        #endregion

        //To set the field
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playFeild[0,0], playFeild[0, 1], playFeild[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playFeild[1, 0], playFeild[1, 1], playFeild[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playFeild[2, 0], playFeild[2, 1], playFeild[2, 2]);
            turn++;


        }

        //reset the game
        public static void Reset()
        {
            char[,] playFeildIntial = new char[,]
            {
              {'1','2','3' },
              {'4','5','6' },
              {'7','8','9' }
            };

            playFeild = playFeildIntial;
            SetField();
            turn = 0;
        }

        // change the playfeild values with user input
        public static void ChangePlayField(char singed, int inputValue)
        {
            switch (inputValue)
            {
                case 1: playFeild[0, 0] = singed; break;
                case 2: playFeild[0, 1] = singed; break;
                case 3: playFeild[0, 2] = singed; break;
                case 4: playFeild[1, 0] = singed; break;
                case 5: playFeild[1, 1] = singed; break;
                case 6: playFeild[1, 2] = singed; break;
                case 7: playFeild[2, 0] = singed; break;
                case 8: playFeild[2, 1] = singed; break;
                case 9: playFeild[2, 2] = singed; break;
            }
        }
    }
}
