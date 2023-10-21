using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VoroshilovNA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int year = g;
            int month = m;
            int day = n;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (day == 31)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day++;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day == 30)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day++;
                    }
                    break;
                case 12:
                    if (day == 31)
                    {
                        day = 1;
                        month = 1;
                        year++;
                    }
                    else
                    {
                        day++;
                    }
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        if (day == 29)
                        {
                            day = 1;
                            month++;
                        }
                        else
                        {
                            day++;
                        }
                    }
                    else
                    {
                        if (day == 28)
                        {
                            day = 1;
                            month++;
                        }
                        else
                        {
                            day++;
                        }
                    }
                    break;

            }

            return $"{year}-{month.ToString("00")}-{day.ToString("00")}";
        }
    }
}
