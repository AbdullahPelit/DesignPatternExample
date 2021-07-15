using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventObserver {

    public class NewMomentPanel : MonoBehaviour
    {//Subject

        public static event Action OnForwardButtonClicked;
        public static event Action OnBackButtonClicked;
        public static event Action OnRightButtonClicked;
        public static event Action OnLeftButtonClicked;
        public void OnClickForward()
        {
            OnForwardButtonClicked?.Invoke();
        }
        public void OnClickBack()
        {
            OnBackButtonClicked?.Invoke();
        }
        public void OnClickRight()
        {
            OnRightButtonClicked?.Invoke();
        }
        public void OnClickLeft()
        {
            OnLeftButtonClicked?.Invoke();
        }
    }
}
