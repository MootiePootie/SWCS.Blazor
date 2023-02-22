using System.Collections.Generic;

namespace SWCS.Blazor.Pages
{
    public class CourseData
    {
        public string CourseName { get; set; }
        public string CourseID { get; set; }
        public bool isDualCredit { get; set; }
        public List<string> CourseCredits { get; set; }
        public List<string> Prerequisites { get; set; }
        public List<string> CreditAmount { get; set; } //double
        public List<string> AvailablePeriods { get; set; } //int
        public List<string> AvailableSemesters { get; set; }
        public bool isYearLongCourse { get; set; }
        public List<string> ConnectedCourses { get; set; }
        public int Index { get; set; }
    }


    public enum CreditNames
    {
        English,
        Math,
        Science,
        SocialStudies,
        Health,
        PE,
        OcEd,
        WorldLanguage,
        FineArts,
        GeneralElective,
    }

    public class Requirements
    {
        public double EngReq { get; } = 4.000;
        public double MathReq { get; } = 3.000;
        public double SciReq { get; } = 3.000;
        public double SocReq { get; } = 3.000;
        public double HealthReq { get; } = 0.500;
        public double PEReq { get; } = 1.500;
        public double OccReq { get; } = 1.000;
        public double LangReq { get; } = 2.000;
        public double ArtsReq { get; } = 2.000;
        public double GenReq { get; } = 4.000;

    }
    public class StudentInfo
    {
        public string StudentName { get; set; }
        //public List<Course> Classes { get; set; }
        public double EngCreds { get; set; }
        public double MathCreds { get; set; }
        public double SciCreds { get; set; }
        public double SocCreds { get; set; }
        public double HealthCreds { get; set; }
        public double PECreds { get; set; }
        public double OccCreds { get; set; }
        public double LangCreds { get; set; }
        public double ArtsCreds { get; set; }
        public double GenCreds { get; set; }
    }


    public class FromJsonCourse
    {
        public string grade9 { get; set; }
        public string grade10 { get; set; }
        public string grade11 { get; set; }
        public string grade12 { get; set; }
        public string courses { get; set; }
        public string courseCodes { get; set; }
        public string length { get; set; }
        public string prerequisite { get; set; }
        public string teacherPermission { get; set; }
        public string repeatableForCredit { get; set; }
        public string cadr { get; set; }
        public string careerTechEd { get; set; }
        public string dualCredit { get; set; }
        public string fineArts { get; set; }
        public string english { get; set; }
        public string mathematics { get; set; }
        public string science { get; set; }
        public string socialStudies { get; set; }
        public string physicalEducation { get; set; }
        public string electiveOnly { get; set; }
        public string specialPrograms { get; set; }
        public string health { get; set; }

    }
    public class FormattedCourse
    {
        public bool isGrade9 { get; set; }
        public bool isGrade10 { get; set; }
        public bool isGrade11 { get; set; }
        public bool isGrade12 { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseLength { get; set; }
        public bool hasPrerequsite { get; set; }
        public bool needsTeacherPermission { get; set; }
        public bool isRepeatableForCredit { get; set; }
        public bool isCADR { get; set; }
        public bool careerTechEd { get; set; }
        public bool isDualCredit { get; set; }
        public bool fineArts { get; set; }
        public bool english { get; set; }
        public bool mathematics { get; set; }
        public bool science { get; set; }
        public bool socialStudies { get; set; }
        public bool physicalEducation { get; set; }
        public bool isElectiveOnly { get; set; }
        public bool isSpecialPrograms { get; set; }
        public bool health { get; set; }
        public string color { get; set; }
    }



}
