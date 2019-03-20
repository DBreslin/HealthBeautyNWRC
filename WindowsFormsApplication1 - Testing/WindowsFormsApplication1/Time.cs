using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairBeautyNWRC
{
    class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public Time(uint h, uint m)
        {
            if (h > 23 || m > 59)
            {
                throw new ArgumentException("Invalid time specified");
            }
            Hours = (int)h; Minutes = (int)m;;
        }

        public Time(DateTime dt)
        {
            Hours = dt.Hour;
            Minutes = dt.Minute;
        }

        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}",
                this.Hours, this.Minutes);
        }

        public void AddHours(uint h)
        {
            this.Hours += (int)h;
        }

        public void AddInteval()
        {
            this.Minutes += 15;
            if (this.Minutes > 59)
            {
                Minutes -= 60;
                this.AddHours(1);
            }
        }

    }
    }
