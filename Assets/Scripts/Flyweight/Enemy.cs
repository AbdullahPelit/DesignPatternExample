using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyData _enemyData;
        
        private float _currentSpeed = 0;
        private int _currentHp = 100;

        private void Start()
        {
            var speed =_enemyData.MaxSpeed;
        }
    }
}
