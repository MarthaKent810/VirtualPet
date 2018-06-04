using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {   //declare fields
        private string name;
        private int hunger;
        private int sleep;
        private int activity;
        private bool hungerAlert;
        private bool sleepAlert;
        private bool activityAlert;

        //declare properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool HungerAlert
        {
            get { return this.hungerAlert; }
            set { this.hungerAlert = value; }
        }
        public bool SleepAlert
        {
            get { return this.sleepAlert; }
            set { this.sleepAlert = value; }
        }

        public bool ActivityAlert
        {
            get { return this.activityAlert; }
            set { this.activityAlert = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }

        public int Activity
        {
            get { return this.activity; }
            set { this.activity = value; }
        }

        //Declare constructors
        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string name, int hunger, int sleep, int activity)
        {
            this.name = name;
            this.hunger = hunger;
            this.sleep = sleep;
            this.activity = activity;
        }

        public void Tick()
        {
            Hunger--;
            Sleep--;
            Activity +=2;
        }

        public void Feed()
        {
            Hunger += 3;
        }

        public void Rest()
        {
            Sleep += 3;
        }

        public void Play()
        {
            Activity -= 4;
            Hunger--;
        }


    }
}
