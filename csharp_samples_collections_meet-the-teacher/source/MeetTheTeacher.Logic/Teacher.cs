using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltet einen Eintrag in der Sprechstundentabelle
    /// Basisklasse für TeacherWithDetail
    /// </summary>
    public class Teacher : IComparable
    {
        #region Fields

        string _lastname;
        string _day;
        int _hour;
        string _time;
        string _room;
        string _comment;

        #endregion
        
        #region Properties

        public string Fullname
        {
            get
            {
                return _fullname;
            }
        }

        public string Day
        {
            get
            {
                return _day;
            }
        }

        public int Hour
        {
            get
            {
                return _hour;
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }
        }

        public string Room
        {
            get
            {
                return _room;
            }
        }

        public string Comment
        {
            get
            {
                return _comment;
            }
        }
        
        #endregion
        
        #region Constructors

        public Teacher(string fullname, string day, int hour, string room, string comment)
        {
            _fullname = fullname;
            _day = day;
            _hour = hour;
            _room = room;
            _comment = comment;
        }

        #endregion
    }
}
