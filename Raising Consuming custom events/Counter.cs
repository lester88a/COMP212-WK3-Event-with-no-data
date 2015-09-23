using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raising_Consuming_custom_events
{
    class Counter
    {
        private int threshold;
        private int total;
        public Counter(int passedThreshold)
        {
            this.threshold = passedThreshold;
        }
        public void Add(int x)
        {
            total += x;
            if (total >=threshold)
            {
                OnThresholdReach(EventArgs.Empty);
            }
        }
        protected virtual void OnThresholdReach(EventArgs e)
        {
            EventHandler hander = ThresholdReached;
            if (hander != null)
            {
                hander(this, e);
            }
        }
        public event EventHandler ThresholdReached;
    }
}
