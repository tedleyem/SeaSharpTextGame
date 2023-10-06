using System;
using System.Threading;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string asciiText = @"

  _    _       _   _ _   _          _   _______        _      _____                      
 | |  | |     | | (_) | | |        | | |__   __|      | |    / ____|                     
 | |  | |_ __ | |_ _| |_| | ___  __| |    | | _____  _| |_  | |  __  __ _ _ __ ___   ___ 
 | |  | | '_ \| __| | __| |/ _ \/ _` |    | |/ _ \ \/ / __| | | |_ |/ _` | '_ ` _ \ / _ \
 | |__| | | | | |_| | |_| |  __/ (_| |    | |  __/>  <| |_  | |__| | (_| | | | | | |  __/
  \____/|_| |_|\__|_|\__|_|\___|\__,_|    |_|\___/_/\_\\__|  \_____|\__,_|_| |_| |_|\___|
                                                                                         
                                                                                         

";
            Console.WriteLine(asciiText);
            Console.WriteLine("                           by Yahoo Silverman");
            Thread.Sleep(2000); //Thread delays the output, it's better this way.
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine(userName + ", what a cool name. Such creative parents");
            Thread.Sleep(2000);
            Console.WriteLine("I want to flesh out my Github so enjoy this flesh...");
            Thread.Sleep(2000);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");

             battleSystem();
        }

        static void battleSystem()
        {
            int userHealth = 10;
            int enemyHealth = 20;
            int userMana = 10;
            int userPotions = 2;
            string winText = @"

 __     __          __          ___       
 \ \   / /          \ \        / (_)      
  \ \_/ /__  _   _   \ \  /\  / / _ _ __  
   \   / _ \| | | |   \ \/  \/ / | | '_ \ 
    | | (_) | |_| |    \  /\  /  | | | | |
    |_|\___/ \__,_|     \/  \/   |_|_| |_|
                                          
                                          

";
            string loseText = @"

 __     __           _                    
 \ \   / /          | |                   
  \ \_/ /__  _   _  | |     ___  ___  ___ 
   \   / _ \| | | | | |    / _ \/ __|/ _ \
    | | (_) | |_| | | |___| (_) \__ \  __/
    |_|\___/ \__,_| |______\___/|___/\___|
                                          
                                          

";



            while (userHealth > 0 && enemyHealth > 0)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Your health: " + userHealth);
                Console.WriteLine("Enemy health: " + enemyHealth);
                 if (userMana > 0)
                {
                    Console.WriteLine("Mana: " + userMana);
                }
                 else
                {
                    Console.WriteLine("Mana: Empty");
                }
                if (userPotions > 0)
                {
                    Console.WriteLine("Health potions: " + userPotions);
                }
                else
                    Console.WriteLine("Health potions: Empty");

                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("1.) Melee attack");
                Console.WriteLine("2.) Magic attack (uses mana)");
                Console.WriteLine("3.) Use a health potion");
                Console.WriteLine("4.) Rules");
                Console.WriteLine("Enter your choice 1-4");
                string move = Console.ReadLine();
                int moveConvert = Int32.Parse(move); //such a dumb way to do this. I will fix.  
                int userDamage = new Random().Next(2, 5); //Damage user gives
                int enemyDamage = new Random().Next(2, 5); // Damage enemy gives
                int userMagic = new Random().Next(4, 6); //damage done by users magic attack
                int enemyAttackType = new Random().Next(1, 6); //picks type of attack 1-3 melee, 4-5 magic, 6 uses potion 
                int enemyMagicaAttack = new Random().Next(3, 5);


                if (moveConvert == 1)
                {
                    
                    if (enemyAttackType < 4)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("The enemy melee attacks for " + enemyDamage + " damage");
                        userHealth -= enemyDamage;
                    }
                    if (enemyAttackType > 4 && enemyAttackType < 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("The enemy magic attacks for " + enemyMagicaAttack + " damage");
                        userHealth -= enemyMagicaAttack;
                    }
                    if (enemyAttackType == 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.Write("Enemy uses a potion");
                        enemyHealth += 5;
                    }

                   Console.WriteLine("You melee attack for " + userDamage + " damage");
                    Console.WriteLine("------------------------------------------------------------------------");
                    enemyHealth -= userDamage;
                    
                }

                if (moveConvert == 2)
                {
                    if (enemyAttackType < 4)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("The enemy melee attacks for " + enemyDamage + " damage");
                        userHealth -= enemyDamage;
                    }
                    if (enemyAttackType > 4 && enemyAttackType < 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("The enemy magic attacks for " + enemyMagicaAttack + " damage");
                        userHealth -= enemyMagicaAttack;
                    }
                    if (enemyAttackType == 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.Write("Enemy uses a potion");
                        enemyHealth += 5;
                    }

                    if (userMana > 0)
                    {
                        Console.WriteLine("You magic attack for " + userMagic + " damage");
                        Console.WriteLine("------------------------------------------------------------------------");
                        userMana -= 3;
                        enemyHealth -= userDamage;
                    }
                    else
                        Console.WriteLine("You have no mana");

                }

                if (moveConvert == 3)
                {

                    if (enemyAttackType < 4)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine(" The enemy melee attacks for " + enemyDamage + " damage");
                        userHealth -= enemyDamage;
                    }
                    if (enemyAttackType > 4 && enemyAttackType < 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine(" The enemy magic attacks for " + enemyMagicaAttack + " damage");
                        userHealth -= enemyMagicaAttack;
                    }
                    if (enemyAttackType == 6)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.Write(" Enemy uses a potion");
                        enemyHealth += 5;
                    }
                    if (userPotions > 0)
                    {
                        Console.WriteLine("You use a health potion for +5 health");
                        Console.WriteLine("------------------------------------------------------------------------");
                        userPotions -= 1;
                        userHealth += 5;
                    }
                    else
                        Console.WriteLine("You have no potions left");
                }
                if (moveConvert == 4)
                {
                    Console.WriteLine("I haven't written the rules yet. Whoever has no health first done goofed... guess.");
                }


            }
            if (userHealth > enemyHealth)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(winText);
            }
            else
            {
                Console.WriteLine(loseText);
            }
        }
    }
}
