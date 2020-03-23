using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationPracticeServer.Utility {
    
    public static class LoadDb {

        static readonly string MajorTable = "Majors";
        static readonly string[] MajorColumns = { "Id", "Code", "Name", "MinSat" };

        static readonly string StudentTable = "Students";
        static readonly string[] StudentColumns = { "Id", "Name", "Sat", "Gpa", "MajorId" };

        public static void Initialize(MigrationBuilder migrationBuilder) {

            LoadMajors(migrationBuilder);
            LoadStudents(migrationBuilder);

        }
        private static void LoadMajors(MigrationBuilder migrationBuilder) {

            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 1, "GENSTDY", "General Studies", 800 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 2, "MATH", "Math", 1200 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 3, "CS", "Computer Science", 1100 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 4, "BUSADM", "Business Administration", 1000 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 5, "EDUC", "Education", 800 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 6, "CHEM", "Chemistry", 1050 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 7, "PHYSCS", "Physics", 1350 });
            migrationBuilder.InsertData(
                table: MajorTable, columns: MajorColumns,
                values: new object[] { 8, "SOCWRK", "Social Work", 850 });

        }
        private static void LoadStudents(MigrationBuilder migrationBuilder) {

            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 1, "Jane Doe", 1600, 4.5, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 2, "Kamari Butler", 861, 2.6, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 3, "Talon Haley", 1112, 4.3, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 4, "Lilliana Reid", 1155, 4.5, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 5, "Maddox Buck", 421, 2.4, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 6, "Ayanna Ingram", 1528, 3.4, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 7, "Sydnee Fields", 1305, 1.1, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 8, "Yandel Mendoza", 1546, 4.9, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 9, "Grayson Esparza", 1040, 2.8, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 10, "Omari Peck", 953, 1.6, 3 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 11, "Dakota Leach", 881, 1.0, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 12, "Jeffery Cordova", 837, 3.9, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 13, "Madalynn Banks", 647, 1.6, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 14, "Rosemary Chung", 1459, 2.6, 3 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 15, "Madisyn Lambert", 876, 4.0, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 16, "Keith Tapia", 487, 2.4, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 17, "Ricardo Barr", 767, 4.3, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 18, "Vincent Olsen", 868, 2.4, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 19, "Alan Powell", 497, 4.1, 6 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 20, "Patrick Adams", 1493, 1.1, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 21, "Matias Pennington", 1152, 4.1, 5 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 22, "Noah Morales", 673, 1.3, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 23, "Penelope Mueller", 1496, 2.9, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 24, "Walter Boyer", 726, 1.7, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 25, "Campbell Collins", 825, 4.2, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 26, "Riley Rice", 1014, 4.7, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 27, "Danielle Melton", 1025, 4.6, 3 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 28, "Cecelia Waters", 1414, 3.4, 5 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 29, "Donavan Cochran", 910, 1.8, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 30, "Dixie Ibarra", 1258, 3.5, 5 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 31, "Cailyn Lutz", 923, 2.9, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 32, "Lydia Reese", 1052, 1.1, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 33, "Isaias Ingram", 541, 2.4, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 34, "Claudia Taylor", 633, 2.7, 2 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 35, "Hezekiah Stephenson", 1397, 2.7, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 36, "Sean Franklin", 1093, 2.8, 3 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 37, "Gisselle Wu", 896, 1.6, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 38, "Elle Lester", 1264, 5.0, 3 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 39, "Vicente Solomon", 660, 3.4, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 40, "Walter Schmitt", 482, 4.1, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 41, "Cameron Farrell", 995, 3.8, null });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 42, "Armani Hatfield", 1142, 2.5, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 43, "Harper Branch", 1367, 4.4, 4 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 44, "Ivy Frank", 1045, 1.1, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 45, "Braedon Walls", 1062, 3.0, 6 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 46, "Elliana Mercado", 468, 1.1, 2 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 47, "Kiera Mueller", 857, 1.8, 2 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 48, "Jose Leon", 1507, 4.6, 8 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 49, "Shawn Irwin", 1316, 4.8, 7 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 50, "Odin Sullivan", 1095, 1.9, 1 });
            migrationBuilder.InsertData(
                table: StudentTable, columns: StudentColumns,
                values: new object[] { 51, "Stacy Faulkner", 585, 2.0, 3 });
        }
    }
}
