using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    [CreateAssetMenu(menuName = "Enemy Data/Enemy Scriptable Data")]
    public class EnemyData : ScriptableObject
    {
        private float _maxSpeed = 10f;
        private float _attackRange = 40f;
        private float _attackDamage = 10f;
        private float _attackInterval = 3f;

        
        private int _maxHp = 100;

        //yukarýyý publicte yapabilirsin. Encapsulation yapýldý.
        public float MaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }
        public float AttackRange { get => _attackRange; set => _attackRange = value; }
        public float AttackDamage { get => _attackDamage; set => _attackDamage = value; }
        public float AttackInterval { get => _attackInterval; set => _attackInterval = value; }
        public int MaxHp { get => _maxHp; set => _maxHp = value; }
    }
}
