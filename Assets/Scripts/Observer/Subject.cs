using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public abstract class Subject : MonoBehaviour
    {
        private List<Observer> _obsevers = null;

        [SerializeField] private SubjectType _subjectType;
        public SubjectType SubjectType => _subjectType;

        public void RegisterObserver(Observer observer)
        {
            if (_obsevers == null)
            {
                _obsevers = new List<Observer>();
            }
            _obsevers.Add(observer);
        }

        private void Start()
        {
            ObserverManager.Insante.RegisterSubject(this);
        }
        public void Notify(NotificationType notificationType)
        {
            foreach (var observer in _obsevers)
            {
                observer.OnNotify(notificationType);
            }
        }
    }
    
}
