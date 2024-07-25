using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10210396IceTask1PROG6212
{
    public class Wizard
    {
        string wand, name, house;
        int age;
        double magicPower;

        public Wizard(string name, string house, string wand, int age, double magicPower)
        {
            this.name = name;
            this.house = house;
            this.wand = wand;
            this.age = age;
            this.magicPower = magicPower;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.house;
                else if (index == 2)
                    return this.wand;
                else if (index == 3)
                    return this.age;
                else if (index == 4)
                    return this.magicPower;
                return null;
            }
            set
            {
                if (index == 0)
                    this.name = (string)value;
                else if (index == 1)
                    this.house = (string)value;
                else if (index == 2)
                    this.wand = (string)value;
                else if (index == 3)
                    this.age = (int)value;
                else if (index == 4)
                    this.magicPower = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("name"))
                    return this.name;
                if (attrName.ToLower().Equals("house"))
                    return this.house;
                if (attrName.ToLower().Equals("wand"))
                    return this.wand;
                if (attrName.ToLower().Equals("age"))
                    return this.age;
                if (attrName.ToLower().Equals("magicpower"))
                    return this.magicPower;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("house"))
                    this.house = (string)value;
                if (attrName.ToLower().Equals("wand"))
                    this.wand = (string)value;
                if (attrName.ToLower().Equals("age"))
                    this.age = (int)value;
                if (attrName.ToLower().Equals("magicpower"))
                    this.magicPower = (double)value;
            }
        }
    }
}
