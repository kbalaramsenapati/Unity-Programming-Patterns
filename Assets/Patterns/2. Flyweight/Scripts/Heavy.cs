using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    //[System.Serializable]
    //This class doesn't share any data among all objects
    public class Heavy
    {
        public float health;

        public Data data;


        public Heavy()
        {
            health = Random.Range(10f, 100f);

            data = new Data();
        }
    }
}
