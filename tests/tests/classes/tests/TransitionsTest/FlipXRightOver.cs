using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace tests
{
    public class FlipXRightOver : CCTransitionFlipX
    {
        public static CCTransitionScene transitionWithDuration(float t, CCScene s)
        {
            return CCTransitionFlipX.transitionWithDuration(t, s, tOrientation.kOrientationRightOver);
        }
    }
}
