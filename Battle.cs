using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextGame
{
    class Battle
    {
       public static void battleSystem()
        {
            int userHealth = Character.health;
            int enemyHealth = 20;
            int userMana = Character.arcana * 2;
            int userPotions = 2;



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
                int userDamage = new Random().Next(2, 5); //Damage user gives, gets multiplied against character.strength roll
                int enemyDamage = new Random().Next(2, 5); // Damage enemy gives
                int userMagic = new Random().Next(5, 8); //damage done by users magic attack
                int enemyAttackType = new Random().Next(1, 6); //picks type of attack 1-3 melee, 4-5 magic, 6 uses potion 
                int enemyMagicaAttack = new Random().Next(3, 5);


                if (moveConvert == 1)
                {
                    int meleeDamage = (userDamage + Character.strength) / 2;
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
                    int magicDamage = (userMagic + Character.arcana) / 2;
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
                else if (moveConvert == 4)
                {
                    Console.WriteLine("I haven't written the rules yet. Whoever has no health first done goofed... guess.");
                }
            }
            if (userHealth > enemyHealth)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(Style.winText);
            }
            else
            {
                Console.WriteLine(Style.loseText);
            }
        }
    }
}
            

    
        
    

