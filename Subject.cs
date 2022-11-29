using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    internal struct Subject
    {
        public string LessonName { get; set; }
        public string LecturerName { get; set; }
        public int AudienceNumber { get; set; }
        public int HoursCount { get; set; }

        public Subject(string lessonName, string lecturerName, int audienceNumber, int hoursCount)
        {
            LessonName = lessonName;
            LecturerName = lecturerName;
            AudienceNumber = audienceNumber;
            HoursCount = hoursCount;
        }
    }
}
