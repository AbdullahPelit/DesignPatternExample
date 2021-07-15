using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class GameManager : MonoSingleton<GameManager>
    {
        public int a = 0;
    }
}
    
