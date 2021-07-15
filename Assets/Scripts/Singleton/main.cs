using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class main : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameManager.Instance.a = 5;
        }

        // Update is called once per frame
        void Update()   
        {
            Debug.Log(Singleton.Instance.GetText());
            Debug.Log(GameManager.Instance.a);

        }
    }
}
