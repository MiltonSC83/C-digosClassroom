using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class conde
    {
        private int threshold;

        public event EventHandler ThresholdReached;
        
        public conde(int passedThreshold )
        {
            threshold = passedThreshold;
        }

        public void Add(int x )
        {
            if(x >= threshold)
            {
                onThresholdReached(EventArgs.Empty);
            }
        }

        public virtual void onThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;

            handler(this, e);

        }

    }
}
