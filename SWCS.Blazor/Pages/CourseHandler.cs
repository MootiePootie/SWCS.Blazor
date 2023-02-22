using System.Text.Json;

namespace SWCS.Blazor.Pages
{
    public class CourseHandler
    {
        static string gcheck = "√";
        static string ccheck = "♦";
        public static List<FormattedCourse> FormatCourses(string[] strs)
        {
            List<FromJsonCourse> cs = new List<FromJsonCourse>();
            List<FormattedCourse> fcs = new List<FormattedCourse>();
            FromJsonCourse jc;
            foreach (string str in strs) 
            {               
                jc = JsonSerializer.Deserialize<FromJsonCourse>(str);
                cs.Add(jc);
            }

            foreach (FromJsonCourse jcs in cs) 
            {
                FormattedCourse fc = new FormattedCourse();

                fc.CourseName = jcs.courses;
                fc.CourseCode = jcs.courseCodes;
                fc.CourseLength = jcs.length;



                if (jcs.grade9 == gcheck) 
                {
                    fc.isGrade9 = true;
                }
                if (jcs.grade10 == gcheck)
                {
                    fc.isGrade10 = true;
                }
                if (jcs.grade11 == gcheck)
                {
                    fc.isGrade11 = true;
                }
                if (jcs.grade12 == gcheck)
                {
                    fc.isGrade12 = true;
                }

                if (jcs.prerequisite == ccheck) 
                {
                    fc.hasPrerequsite = true;
                }
                if (jcs.cadr == ccheck)
                {
                    fc.isCADR = true;
                }
                if (jcs.teacherPermission == ccheck)
                {
                    fc.needsTeacherPermission = true;
                }
                if (jcs.dualCredit == ccheck)
                {
                    fc.isDualCredit = true;
                }
                if (jcs.specialPrograms == ccheck)
                {
                    fc.isSpecialPrograms = true;
                }
                if (jcs.electiveOnly == ccheck)
                {
                    fc.isElectiveOnly = true;
                }
                if (jcs.repeatableForCredit == ccheck)
                {
                    fc.isRepeatableForCredit = true;
                }



                if (jcs.english == ccheck)
                {
                    fc.english = true;
                }
                if (jcs.mathematics == ccheck)
                {
                    fc.mathematics = true;
                }
                if (jcs.socialStudies == ccheck)
                {
                    fc.socialStudies = true;
                }
                if (jcs.science == ccheck)
                {
                    fc.science = true;
                }
                if (jcs.health == ccheck)
                {
                    fc.health = true;
                }
                if (jcs.physicalEducation == ccheck)
                {
                    fc.physicalEducation = true;
                }
                if (jcs.careerTechEd == ccheck)
                {
                    fc.careerTechEd = true;
                }
                if (jcs.fineArts == ccheck)
                {
                    fc.fineArts = true;
                }


                fcs.Add(fc);





            }


            return fcs;
        }
    }
}
