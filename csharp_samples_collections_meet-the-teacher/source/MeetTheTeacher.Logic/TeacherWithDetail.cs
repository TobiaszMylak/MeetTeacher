using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Klasse, die einen Detaileintrag mit Link auf dem Namen realisiert.
    /// </summary>
    public class TeacherWithDetail : Teacher
    {
        int _id;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public TeacherWithDetail(string fullname, string day, int hour, string room, string comment, int id) : base(fullname, day, hour, room, comment)
        {
            _id = id;
        }
    }
}