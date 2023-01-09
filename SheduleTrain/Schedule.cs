using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SheduleTrain
{
    public enum WeekDays
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье,
    }
    public class Schedule
    {
        public string nameDepartment;
        List<Lesson> listLessons = new List<Lesson>();

        public Schedule(string name)
        {
            nameDepartment = name;
        }

        public void Add(Lesson lesson)
        {
            listLessons.Add(lesson);
        }
        public Dictionary< string,int > Count(String name)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            foreach (var prop in listLessons)
            {
                if (prop.groupNumber == name && prop.weekDay == WeekDays.Понедельник)
                {
                    count1++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Вторник)
                {
                    count2++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Среда)
                {
                    count3++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Четверг)
                {
                    count4++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Пятница)
                {
                    count5++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Суббота)
                {
                    count6++;
                }
                else if (prop.groupNumber == name && prop.weekDay == WeekDays.Воскресенье)
                {
                    count7++;
                }
            }

            var CountPar = new Dictionary<string, int>()
            {
                ["Понедельник"] = count1,
                ["Вторник"] = count2,
                ["Среда"] = count3,
                ["Четверг"] = count4,
                ["Пятница"] = count5,
                ["Суббота"] = count6,
                ["Воскресенье"] = count7,

            };

            return CountPar;//Возващает словарь с количством пар в каждый день недели для введенной группы
        }

        public new void ToString()
        {
            foreach (var item in listLessons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class Lesson
    {

        public string label;
        public int number;
        public int weekNumber;
        public WeekDays weekDay;
        public string groupNumber;

        private static char symb = 'A';
        private Random random = new Random();

        public Lesson()
        {
            label = symb.ToString();
            symb++;
            number = random.Next(1, 4);
            weekNumber = random.Next(0, 2);
            weekDay = (WeekDays)random.Next(1, 7);
            groupNumber = random.Next(11, 13).ToString();
        }

        public Lesson(string label, int number, int weekNumber, WeekDays weekDay, string groupNumber)
        {
            this.label = label;
            this.number = number;
            this.weekNumber = weekNumber;
            this.weekDay = weekDay;
            this.groupNumber = groupNumber;
        }


        public override string ToString()
        {
            return $"{label}., {number} пара {weekDay}., {groupNumber} группа, {weekNumber}";
        }
    }
}
