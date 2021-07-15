using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public class MovementPanel : Subject
    {
        public void ForwardOnClick()
        {
            Notify(NotificationType.ForwardButton);
        }
        public void BackOnClick()
        {
            Notify(NotificationType.BackButton);
        }   
        public void LeftOnClick()
        {
            Notify(NotificationType.LeftButton);
        }
        public void RightOnClick()
        {
            Notify(NotificationType.RightButton);
        }

    }
}
