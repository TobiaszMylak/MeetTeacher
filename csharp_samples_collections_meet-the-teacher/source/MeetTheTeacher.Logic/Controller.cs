using System;
using System.Collections.Generic;
using System.Text;

namespace MeetTheTeacher.Logic
{
    /// <summary>
    /// Verwaltung der Lehrer (mit und ohne Detailinfos)
    /// </summary>
    public class Controller
    {
        private readonly List<Teacher> _teachers;
        private readonly Dictionary<string, int> _details;
        private int _count = teacherLines.Length;
        private int _counttwd = teacherLines.Length - ignoredNames.Length; //CountTeachersWithoutDetails
        private int _counttwod = names.Length; //CountTeachersWithoutDetails

        /// <summary>
        /// Liste für Sprechstunden und Dictionary für Detailseiten anlegen
        /// </summary>
        public Controller(string[] teacherLines, string[] detailsLines)
        {
            _teachers = teacherLines;
            _details = detailsLines;
        }

        public int Count
        {
            get { return _count; }
        }

        public int CountTeachersWithoutDetails
        {
            get { return _counttwod; }
        }

        /// <summary>
        /// Anzahl der Lehrer mit Detailinfos in der Liste
        /// </summary>
        public int CountTeachersWithDetails
        {
            get { return _counttwd; }
        }

        /// <summary>
        /// Aus dem Text der Sprechstundendatei werden alle Lehrersprechstunden 
        /// eingelesen. Dabei wird für Lehrer, die eine Detailseite haben
        /// ein TeacherWithDetails-Objekt und für andere Lehrer ein Teacher-Objekt angelegt.
        /// </summary>
        /// <returns>Anzahl der eingelesenen Lehrer</returns>
        private void InitTeachers(string[] lines)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Lehrer, deren Name in der Datei IgnoredTeachers steht werden aus der Liste 
        /// entfernt
        /// </summary>
        public void DeleteIgnoredTeachers(string[] names)
        {
            for (int i = 0; i < teacherLines.length; i++)
			{
                for (int j = 0; j < ignoredNames.length; j++)
			    {
                    if (teacherLines[i].Name.Equals(ignoredNames[j].Name))
	                {

	                }
			    }
			}
        }

        /// <summary>
        /// Sucht Lehrer in Lehrerliste nach dem Namen
        /// </summary>
        /// <param name="teacherName"></param>
        /// <returns>Index oder -1, falls nicht gefunden</returns>
        private int FindIndexForTeacher(string teacherName)
        {
            for (int i = 0; i < teacherLines.Length; i++)
			{

			}
        }


        /// <summary>
        /// Ids der Detailseiten für Lehrer die eine
        /// derartige Seite haben einlesen.
        /// </summary>
        private void InitDetails(string[] lines)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// HTML-Tabelle der ganzen Lehrer aufbereiten.
        /// </summary>
        /// <returns>Text für die Html-Tabelle</returns>
        public string GetHtmlTable()
        {
            throw new NotImplementedException();
        }

    }
}
