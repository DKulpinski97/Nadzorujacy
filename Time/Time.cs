using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Keyloger.Time
{
    class Time
    {
        public long  takeTimeInMilliseconds()
        {
            return  DateTimeOffset.Now.ToUnixTimeMilliseconds();
            
            
        }

        public long ClickTime(long oldMilliseconds,long nowMilliseconds,long badTime)
        {
            if((nowMilliseconds - oldMilliseconds) > badTime)
            {
                return -1;
            }
            else
            {
                return ((nowMilliseconds - oldMilliseconds));
            }
        }

    }
}
