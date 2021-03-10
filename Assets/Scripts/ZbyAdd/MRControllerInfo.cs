using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TiltBrush
{
    public class MRControllerInfo : ControllerInfo
    {
        public MRControllerInfo(BaseControllerBehavior behavior)
          : base(behavior)
        {
            
        }

        public override bool IsTrackedObjectValid { get { return true; }set { } }


        public override float GetGripValue()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public override Vector2 GetPadValue()
        {
            //throw new System.NotImplementedException();
            return Vector2.zero;
        }

        public override Vector2 GetPadValueDelta()
        {
            //throw new System.NotImplementedException();
            return Vector2.zero;
        }

        public override float GetScrollXDelta()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public override float GetScrollYDelta()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public override Vector2 GetThumbStickValue()
        {
            //throw new System.NotImplementedException();
            return Vector2.zero;
        }

        public override float GetTriggerRatio()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public override float GetTriggerValue()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public override bool GetVrInput(VrInput input)
        {
            //throw new System.NotImplementedException();
            return false;
        }

        public override bool GetVrInputDown(VrInput input)
        {
            //throw new System.NotImplementedException();
            return false;
        }

        public override bool GetVrInputTouch(VrInput input)
        {
            //throw new System.NotImplementedException();
            return false;
        }

        public override void TriggerControllerHaptics(float seconds)
        {
            //throw new System.NotImplementedException();
            
        }
    }
}
