using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    //Class to create a character
    class Character
    {
        private string _name;                      //character name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length >= 4)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("The name: {0} is short. minimal lenght is 4", _name);
                }
            }
        }
        public string Gender { get; private set; }  //character sex
        public int Strength { get; private set; }   //character strength 0-10
        private int _hp;                            //character health 0-50
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
                if(_hp <= 0)
                {
                    IsAlive = false;
                    Console.WriteLine("{0} is dead.\n", Name);
                }
                else
                {
                    IsAlive = true;
                }
            }
        }
        public bool IsAlive { get; private set; }   //Character is alive true/false

        public Character(string name, string gender, int strength, int hp)
        {
            Name = name;
            Gender = gender;
            Strength = strength;
            Hp = hp;
            IsAlive = true;
        }

        //Write atributes of a characters
        public void Stats()
        {
            Console.WriteLine("\nCharacter stats" +
                              "\nname: {0}" +
                              "\ngender: {1}" +
                              "\npower: {2}" +
                              "\nhealth: {3}" +
                              "\nalive: {4}\n"
                              ,Name,Gender,Strength,Hp, IsAlive);
        }

        public void Attack(Character enemy)
        {
            Console.WriteLine("{0} attacked {1}:", Name, enemy.Name);
            enemy.Hp = enemy.Hp - Strength;
        }
    }
}