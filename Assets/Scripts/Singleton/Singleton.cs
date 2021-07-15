using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{

    public class Singleton : MonoBehaviour
    {
        private static Singleton instance = null;
        private string text;


        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameObject("Singleton").AddComponent<Singleton>();
                }
                return instance;
            }
        }

        private void OnEnable()
        {
            instance = this;
            text = "Hello Mf";
        }
       public string GetText()
        {
            return text;
        }
    }
}
