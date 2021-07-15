using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventObserver
{
    public class NewMovementSystem : MonoBehaviour
    {//Observer

        private void Start()
        {
            NewMomentPanel.OnForwardButtonClicked += MoveForward;
            NewMomentPanel.OnBackButtonClicked += MoveBack;
            NewMomentPanel.OnLeftButtonClicked += Moveleft;
            NewMomentPanel.OnRightButtonClicked += MoveRight;
        }

        public void MoveForward() => transform.Translate(Vector3.forward);
        public void MoveBack() => transform.Translate(Vector3.back);
        public void Moveleft() => transform.Translate(Vector3.left);
        public void MoveRight() => transform.Translate(Vector3.right);

    }
}

