using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace Halloween
{
    public class ObjectOriented32bitXmlBuglessParserManager
    {

        public void ProcessAllHiddenTags(StringBuilder sbXMLString, ASMStudent student)
        {
            int num = 0;
            int tempNumber2 = 0;
            int tempNumber3 = 0;
            int tempNumber4 = 0;
            int tempNumber5 = 0;
            int tempNumber6 = 0;
            int tempNumber7 = 0;
            int tempNumber8 = 0;
            int tempNumber9 = 0;
            object iD = student.ID;
            if (sbXMLString.ToString().IndexOf("<w:body>") > 0)
            {
                string input = "";
                string pageText = string.Empty;
                if (((sbXMLString.ToString().IndexOf("<w:body>") >= 0) && (sbXMLString.ToString().IndexOf("<w:body>") <= sbXMLString.Length)) && ((((sbXMLString.ToString().IndexOf("</w:body>") - sbXMLString.ToString().IndexOf("<w:body>")) + 9) >= 0) && (((sbXMLString.ToString().IndexOf("</w:body>") - sbXMLString.ToString().IndexOf("<w:body>")) + 9) <= sbXMLString.Length)))
                {
                    pageText = sbXMLString.ToString().Substring(sbXMLString.ToString().IndexOf("<w:body>"), (sbXMLString.ToString().IndexOf("</w:body>") - sbXMLString.ToString().IndexOf("<w:body>")) + 9).ToString().Trim();
                }
                pageText = this.getBodyTextForEachPage(pageText, "w:sectPr");
                pageText = this.getBodyTextForEachPage(pageText, "w:pict");
                MatchCollection matchs = new Regex("<w:p>").Matches(pageText);
                for (int i = 0; i < matchs.Count; i++)
                {
                    if (pageText.IndexOf("<w:p>") > 0)
                    {
                        string tempStr3 = "";
                        string tempStr4 = "";
                        input = string.Empty;
                        int index = pageText.IndexOf("<w:p>");
                        int tempNumber12 = pageText.IndexOf("</w:p>");
                        if (((index >= 0) && (index <= pageText.Length)) && ((((tempNumber12 - index) + 6) >= 0) && (((tempNumber12 - index) + 6) < pageText.Length)))
                        {
                            input = pageText.Substring(index, (tempNumber12 - index) + 6).ToString().Trim();
                        }
                        tempStr3 = input;
                        MatchCollection patternMatches2 = new Regex("<w:t>").Matches(tempStr3);
                        for (int j = 0; j < patternMatches2.Count; j++)
                        {
                            if (tempStr3.IndexOf("<w:t>") > 0)
                            {
                                string tempStr5 = string.Empty;
                                if (((tempStr3.IndexOf("<w:t>") >= 0) && (tempStr3.IndexOf("<w:t>") <= tempStr3.Length)) && ((((tempStr3.IndexOf("</w:t>") - tempStr3.IndexOf("<w:t>")) + 6) >= 0) && (((tempStr3.IndexOf("</w:t>") - tempStr3.IndexOf("<w:t>")) + 6) <= tempStr3.Length)))
                                {
                                    tempStr5 = tempStr3.Substring(tempStr3.IndexOf("<w:t>"), (tempStr3.IndexOf("</w:t>") - tempStr3.IndexOf("<w:t>")) + 6);
                                }
                                tempStr3 = tempStr3.Remove(tempStr3.IndexOf(tempStr5), tempStr5.Length);
                                tempStr4 = (tempStr4 + tempStr5.Replace("<w:t>", "")).Replace("</w:t>", "");
                            }
                        }
                        tempStr4 = tempStr4.ToString().Trim();
                        Regex pattern3 = new Regex("&lt;&lt;Result:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern4 = new Regex(this.sbResultRegEx.ToString());
                        Regex pattern5 = new Regex("&lt;&lt;ResultDesc:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern6 = new Regex(this.sbResultDescRegEx.ToString());
                        Regex pattern7 = new Regex("‡DataValue=&lt;&lt;Result:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern8 = new Regex(this.sbGraphResultRegEx.ToString());
                        Regex pattern9 = new Regex("&lt;&lt;GroupResult:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern10 = new Regex(this.sbGroupResultRegEx.ToString());
                        Regex pattern11 = new Regex("&lt;&lt;Class:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern12 = new Regex(this.sbClassTagRegex.ToString());
                        Regex pattern13 = new Regex("&lt;&lt;ClassTeacher:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern14 = new Regex(this.sbClassTeacherTagRegex.ToString());
                        Regex pattern15 = new Regex("&lt;&lt;LessonAttendance:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern16 = new Regex(this.sbLessonAttendanceRegEx.ToString());
                        Regex pattern17 = new Regex("&lt;&lt;MinutesLate:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern18 = new Regex(this.sbMinutesLateRegEx.ToString());
                        Regex pattern19 = new Regex("&lt;&lt;ClassesLate:[[\\\x00b7\\]*0-9 a-zA-Z\\\\+~`’”“'_\\(\\^\\|\\)\\[\\]\\{\\}=\\\"\\/<:>@#\\*\\$%&amp;\\.;!?– ,-]+?&gt;&gt;");
                        Regex pattern20 = new Regex(this.sbClassesLateRegEx.ToString());
                        Regex pattern21 = new Regex("&lt;&lt;Behaviour Points&gt;&gt;");
                        Regex pattern22 = new Regex("&lt;&lt;Achievement Points&gt;&gt;");
                        if (pattern8.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches3 = pattern7.Matches(input);
                            for (int n = 0; n < patternMatches3.Count; n++)
                            {
                                object obj3 = null;
                                if ((tempNumber3 < this.GraphResultTags.Count) && (this.GraphResultTags.Count > 0))
                                {
                                    obj3 = this.GraphResultTags[tempNumber3].HashTableStudents[iD];
                                    if (obj3 != null)
                                    {
                                        obj3 = obj3.ToString().Replace("=", "");
                                    }
                                    if (patternMatches3[n].Value.Length >= 11)
                                    {
                                        sbXMLString.Replace(patternMatches3[n].Value.Substring(11, patternMatches3[n].Value.Length - 11), obj3.ToString());
                                    }
                                }
                                tempNumber3++;
                            }
                        }
                        else if (pattern4.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches4 = pattern3.Matches(input);
                            for (int tempNumber15 = 0; tempNumber15 < patternMatches4.Count; tempNumber15++)
                            {
                                object obj4 = null;
                                if ((num < this.ResultTags.Count) && (this.ResultTags.Count > 0))
                                {
                                    obj4 = this.ResultTags[num].HashTableStudents[iD];
                                }
                                if (obj4 != null)
                                {
                                    List<int> list = new List<int>();
                                    List<int> tempList2 = new List<int>();
                                    List<int> tempList3 = new List<int>();
                                    List<int> tempList4 = new List<int>();
                                    List<int> tempList5 = new List<int>();
                                    List<int> tempList6 = new List<int>();
                                    int item = -1;
                                    int startIndex = -1;
                                    int tempNumber18 = -1;
                                    int tempNumber19 = -1;
                                    int tempNumber20 = -1;
                                    string tempStr6 = string.Empty;
                                    string tempStr7 = string.Empty;
                                    object obj5 = null;
                                    string tempStr8 = string.Empty;
                                    string tempStr9 = string.Empty;
                                    obj5 = this.ResultTags[num].HashTableResultColour[obj4];
                                    if ((obj5 != null) && (Convert.ToInt32(obj5) != 0))
                                    {
                                        tempStr8 = ColorTranslator.ToHtml(Color.FromArgb((int)obj5));
                                    }
                                    startIndex = sbXMLString.ToString().IndexOf(patternMatches4[tempNumber15].Value);
                                    if (startIndex >= 0)
                                    {
                                        tempNumber18 = sbXMLString.ToString().LastIndexOf("<w:t>", startIndex);
                                        tempNumber19 = sbXMLString.ToString().LastIndexOf("<w:r>", startIndex);
                                        tempNumber20 = sbXMLString.ToString().LastIndexOf("<w:p>", startIndex);
                                    }
                                    if (((tempNumber18 - tempNumber19) - 5) > 0)
                                    {
                                        tempStr6 = sbXMLString.ToString().Substring(tempNumber19 + 5, (tempNumber18 - tempNumber19) - 5);
                                    }
                                    if (((tempNumber19 - tempNumber20) - 5) > 0)
                                    {
                                        tempStr7 = sbXMLString.ToString().Substring(tempNumber20 + 5, (tempNumber19 - tempNumber20) - 5);
                                    }
                                    MatchCollection patternMatches5 = new Regex("<w:t>").Matches(tempStr7);
                                    for (int tempNumber21 = 0; tempNumber21 < patternMatches5.Count; tempNumber21++)
                                    {
                                        int tempNumber22 = tempStr7.IndexOf("<w:t>");
                                        int tempNumber23 = tempStr7.IndexOf("</w:t>");
                                        if (tempNumber22 > 0)
                                        {
                                            string tempStr10 = string.Empty;
                                            if (((tempNumber22 >= 0) && (tempNumber22 <= tempStr7.Length)) && ((((tempNumber23 - tempNumber22) + 6) >= 0) && (((tempNumber23 - tempNumber22) + 6) <= tempStr7.Length)))
                                            {
                                                tempStr10 = tempStr7.Substring(tempNumber22, (tempNumber23 - tempNumber22) + 6);
                                            }
                                            tempStr7 = tempStr7.Remove(tempStr7.IndexOf(tempStr10), tempStr10.Length);
                                        }
                                    }
                                    while (true)
                                    {
                                        item = sbXMLString.ToString().IndexOf(patternMatches4[tempNumber15].Value, (int)(item + 1));
                                        if (item < 0)
                                        {
                                            break;
                                        }
                                        list.Add(item);
                                    }
                                    for (int tempNumber24 = 0; tempNumber24 < list.Count; tempNumber24++)
                                    {
                                        tempList4.Add(sbXMLString.ToString().LastIndexOf("<w:p>", list[tempNumber24]));
                                        tempList2.Add(sbXMLString.ToString().LastIndexOf("<w:tcPr>", list[tempNumber24]));
                                        tempList3.Add(sbXMLString.ToString().LastIndexOf("</w:tcPr>", list[tempNumber24]));
                                        tempList5.Add(sbXMLString.ToString().LastIndexOf("<w:tc>", list[tempNumber24]));
                                        tempList6.Add(sbXMLString.ToString().IndexOf("</w:tc>", list[tempNumber24]));
                                    }
                                    if (this.IndividualReport.PrintResultColour && (tempStr8 != null))
                                    {
                                        int tempNumber25 = -1;
                                        for (int tempNumber26 = 0; tempNumber26 < tempList3.Count; tempNumber26++)
                                        {
                                            if (((tempList5[tempNumber26] >= 0) && (tempList6[tempNumber26] >= 0)) && ((list[tempNumber26] > tempList5[tempNumber26]) && (list[tempNumber26] < tempList6[tempNumber26])))
                                            {
                                                tempNumber25++;
                                                tempStr9 = "<w:shd w:val=\"clear\" w:color=\"auto\" w:fill=\"" + tempStr8 + "\"/>";
                                                sbXMLString.Insert(tempList3[tempNumber26] + (tempStr9.Length * tempNumber25), tempStr9);
                                            }
                                        }
                                    }
                                    obj4 = obj4.ToString().Substring(0, obj4.ToString().LastIndexOf("~"));
                                    obj4 = obj4.ToString().Substring(obj4.ToString().IndexOf("~") + 1, obj4.ToString().Length - (obj4.ToString().IndexOf("~") + 1));
                                    sbXMLString.Replace(patternMatches4[tempNumber15].Value, "\x00a7" + obj4.ToString().Trim().Replace("\n", "</w:t></w:r></w:p><w:p>" + tempStr7 + "<w:r>" + tempStr6 + "<w:t>") + "\x00a7");
                                }
                                else
                                {
                                    sbXMLString.Replace(patternMatches4[tempNumber15].Value, "\x00a7NULL\x00a7");
                                }
                                num++;
                            }
                        }
                        if (pattern6.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches6 = pattern5.Matches(input);
                            for (int tempNumber27 = 0; tempNumber27 < patternMatches6.Count; tempNumber27++)
                            {
                                object obj6 = null;
                                if ((tempNumber2 < this.ResultDescTags.Count) && (this.ResultDescTags.Count > 0))
                                {
                                    obj6 = this.ResultDescTags[tempNumber2].HashTableStudents[iD];
                                }
                                if (obj6 == null)
                                {
                                    goto donull;
                                }
                                List<int> tmepList7 = new List<int>();
                                List<int> tempList8 = new List<int>();
                                List<int> tempList9 = new List<int>();
                                List<int> tempList10 = new List<int>();
                                List<int> tempList11 = new List<int>();
                                List<int> tempList12 = new List<int>();
                                object obj7 = null;
                                string tempStr11 = string.Empty;
                                int tempNumber28 = -1;
                                string tempStr12 = string.Empty;
                                obj7 = this.ResultDescTags[tempNumber2].HashTableResultColour[obj6];
                                if ((obj7 != null) && (Convert.ToInt32(obj7) != 0))
                                {
                                    tempStr11 = ColorTranslator.ToHtml(Color.FromArgb((int)obj7));
                                }
                                gohere:
                                tempNumber28 = sbXMLString.ToString().IndexOf(patternMatches6[tempNumber27].Value, (int)(tempNumber28 + 1));
                                if (tempNumber28 >= 0)
                                {
                                    tmepList7.Add(tempNumber28);
                                    goto gohere;
                                }
                                for (int tempNumber29 = 0; tempNumber29 < tmepList7.Count; tempNumber29++)
                                {
                                    tempList10.Add(sbXMLString.ToString().LastIndexOf("<w:p>", tmepList7[tempNumber29]));
                                    tempList8.Add(sbXMLString.ToString().LastIndexOf("<w:tcPr>", tmepList7[tempNumber29]));
                                    tempList9.Add(sbXMLString.ToString().LastIndexOf("</w:tcPr>", tmepList7[tempNumber29]));
                                    tempList11.Add(sbXMLString.ToString().LastIndexOf("<w:tc>", tmepList7[tempNumber29]));
                                    tempList12.Add(sbXMLString.ToString().IndexOf("</w:tc>", tmepList7[tempNumber29]));
                                }
                                if (this.IndividualReport.PrintResultColour && (tempStr11 != null))
                                {
                                    int tempNumber30 = -1;
                                    for (int tempNumber31 = 0; tempNumber31 < tempList9.Count; tempNumber31++)
                                    {
                                        if (((tempList11[tempNumber31] >= 0) && (tempList12[tempNumber31] >= 0)) && ((tmepList7[tempNumber31] > tempList11[tempNumber31]) && (tmepList7[tempNumber31] < tempList12[tempNumber31])))
                                        {
                                            tempNumber30++;
                                            tempStr12 = "<w:shd w:val=\"clear\" w:color=\"auto\" w:fill=\"" + tempStr11 + "\"/>";
                                            sbXMLString.Insert(tempList9[tempNumber31] + (tempStr12.Length * tempNumber30), tempStr12);
                                        }
                                    }
                                }
                                obj6 = obj6.ToString().Substring(0, obj6.ToString().LastIndexOf("~"));
                                obj6 = obj6.ToString().Substring(obj6.ToString().IndexOf("~") + 1, obj6.ToString().Length - (obj6.ToString().IndexOf("~") + 1));
                                sbXMLString.Replace(patternMatches6[tempNumber27].Value, "\x00a7" + obj6.ToString().Trim() + "\x00a7");
                                goto end;
                                donull:
                                sbXMLString.Replace(patternMatches6[tempNumber27].Value, "\x00a7NULL\x00a7");
                                end:
                                tempNumber2++;
                            }
                        }
                        if (pattern10.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches7 = pattern9.Matches(input);
                            for (int tempNumber32 = 0; tempNumber32 < patternMatches7.Count; tempNumber32++)
                            {
                                sbXMLString.Replace(patternMatches7[tempNumber32].Value, "\x00a7" + this.GroupResultTags[tempNumber4].GroupResultValue.ToString().Trim() + "\x00a7");
                                tempNumber4++;
                            }
                        }
                        if (pattern12.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches8 = pattern11.Matches(input);
                            for (int tempNumber33 = 0; tempNumber33 < patternMatches8.Count; tempNumber33++)
                            {
                                object obj8 = null;
                                if ((tempNumber5 < this.ClassTags.Count) && (this.ClassTags.Count > 0))
                                {
                                    obj8 = this.ClassTags[tempNumber5].HashTableStudents[iD];
                                }
                                if (obj8 != null)
                                {
                                    sbXMLString.Replace(patternMatches8[tempNumber33].Value, obj8.ToString().Trim());
                                }
                                else
                                {
                                    sbXMLString.Replace(patternMatches8[tempNumber33].Value, " ");
                                }
                                tempNumber5++;
                            }
                        }
                        if (pattern14.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches9 = pattern13.Matches(input);
                            for (int tempNumber34 = 0; tempNumber34 < patternMatches9.Count; tempNumber34++)
                            {
                                object obj9 = null;
                                if ((tempNumber6 < this.ClassTeacherTags.Count) && (this.ClassTeacherTags.Count > 0))
                                {
                                    obj9 = this.ClassTeacherTags[tempNumber6].HashTableStudents[iD];
                                }
                                if (obj9 != null)
                                {
                                    sbXMLString.Replace(patternMatches9[tempNumber34].Value, obj9.ToString().Trim());
                                }
                                else
                                {
                                    sbXMLString.Replace(patternMatches9[tempNumber34].Value, " ");
                                }
                                tempNumber6++;
                            }
                        }
                        if (pattern20.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches10 = pattern19.Matches(input);
                            for (int tempNumber35 = 0; tempNumber35 < patternMatches10.Count; tempNumber35++)
                            {
                                string courseCode = string.Empty;
                                string courseName = string.Empty;
                                this.getCourseCodeAndName(patternMatches10[tempNumber35].Value, out courseCode, out courseName);
                                if ((courseCode != string.Empty) && (courseName != string.Empty))
                                {
                                    PerfAttendanceTag attendance = null;
                                    attendance = this.ClassesLateTags.GetAttendance(courseCode);
                                    if (attendance != null)
                                    {
                                        sbXMLString.Replace(patternMatches10[tempNumber35].Value, attendance.GetAttendanceValue(student.PersonID));
                                    }
                                    else
                                    {
                                        sbXMLString.Replace(patternMatches10[tempNumber35].Value, "");
                                    }
                                }
                                tempNumber7++;
                            }
                        }
                        if (pattern18.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches11 = pattern17.Matches(input);
                            for (int tempNumber36 = 0; tempNumber36 < patternMatches11.Count; tempNumber36++)
                            {
                                string tempStr15 = string.Empty;
                                string tempStr16 = string.Empty;
                                this.getCourseCodeAndName(patternMatches11[tempNumber36].Value, out tempStr15, out tempStr16);
                                if ((tempStr15 != string.Empty) && (tempStr16 != string.Empty))
                                {
                                    PerfAttendanceTag tag2 = null;
                                    tag2 = this.LessonMinutesLateTags.GetAttendance(tempStr15);
                                    if (tag2 != null)
                                    {
                                        sbXMLString.Replace(patternMatches11[tempNumber36].Value, tag2.GetAttendanceValue(student.PersonID));
                                    }
                                    else
                                    {
                                        sbXMLString.Replace(patternMatches11[tempNumber36].Value, "");
                                    }
                                }
                                tempNumber9++;
                            }
                        }
                        if (pattern16.IsMatch(tempStr4))
                        {
                            MatchCollection patternMatches12 = pattern15.Matches(input);
                            for (int tempNumber37 = 0; tempNumber37 < patternMatches12.Count; tempNumber37++)
                            {
                                string tempStr17 = string.Empty;
                                string tempStr18 = string.Empty;
                                this.getCourseCodeAndName(patternMatches12[tempNumber37].Value, out tempStr17, out tempStr18);
                                if ((tempStr17 != string.Empty) && (tempStr18 != string.Empty))
                                {
                                    PerfAttendanceTag tag3 = null;
                                    tag3 = this.LessonAttendanceTags.GetAttendance(tempStr17);
                                    if (tag3 != null)
                                    {
                                        sbXMLString.Replace(patternMatches12[tempNumber37].Value, tag3.GetAttendanceValue(student.PersonID));
                                    }
                                    else
                                    {
                                        sbXMLString.Replace(patternMatches12[tempNumber37].Value, "");
                                    }
                                }
                                tempNumber8++;
                            }
                        }
                        MatchCollection patternMatches13 = pattern22.Matches(input);
                        for (int k = 0; k < patternMatches13.Count; k++)
                        {
                            if (this.StudentAchievementTags.Count > 0)
                            {
                                string newValue = "0";
                                PerfStudentBehaviour behaviour = null;
                                behaviour = this.StudentAchievementTags.GetBehaviour(PerfStudentBehaviour.TOTAL_ACHIEVEMENT_CODE);
                                if (behaviour != null)
                                {
                                    newValue = behaviour.GetBehaviourPointValue(student.PersonID);
                                }
                                sbXMLString.Replace(patternMatches13[k].Value, newValue);
                            }
                        }
                        MatchCollection patternMatches14 = pattern21.Matches(input);
                        for (int m = 0; m < patternMatches14.Count; m++)
                        {
                            if (this.StudentBehaviourTags.Count > 0)
                            {
                                string behaviourPointValue = "0";
                                PerfStudentBehaviour behaviour2 = null;
                                behaviour2 = this.StudentBehaviourTags.GetBehaviour(PerfStudentBehaviour.TOTAL_BEHAVIOUR_CODE);
                                if (behaviour2 != null)
                                {
                                    behaviourPointValue = behaviour2.GetBehaviourPointValue(student.PersonID);
                                }
                                sbXMLString.Replace(patternMatches14[m].Value, behaviourPointValue);
                            }
                        }
                    }
                    if (input.Trim().Length > 0)
                    {
                        pageText = pageText.Replace(input, "").ToString().Trim();
                    }
                }
            }
            this.moreThanOneTaginCell(sbXMLString);
        }

        private void moreThanOneTaginCell(StringBuilder sbXmlString)
        {
            Console.Write(sbXmlString);
        }

        public PerfStudentBehaviour StudentBehaviourTags { get; set; }

        public PerfStudentBehaviour StudentAchievementTags { get; set; }

        public PerfStudentBehaviour LessonMinutesLateTags { get; set; }

        public PerfStudentBehaviour ClassesLateTags { get; set; }

        public PerfStudentBehaviour LessonAttendanceTags { get; set; }

        private void getCourseCodeAndName(string value, out string courseCode, out string courseName)
        {
            throw new NotImplementedException();
        }

        public IList<ResultTag> ClassTeacherTags { get; set; }

        public IList<ResultTag> ClassTags { get; set; }

        public IList<ResultTag> GroupResultTags { get; set; }

        public IndividualReport IndividualReport { get; set; }

        public IList<ResultTag> ResultDescTags { get; set; }

        public IList<ResultTag> ResultTags { get; set; }

        public IList<ResultTag> GraphResultTags { get; set; }

        public object sbClassesLateRegEx { get; set; }

        public object sbMinutesLateRegEx { get; set; }

        public object sbLessonAttendanceRegEx { get; set; }

        public object sbClassTeacherTagRegex { get; set; }

        public object sbClassTagRegex { get; set; }

        public object sbGroupResultRegEx { get; set; }

        public object sbGraphResultRegEx { get; set; }

        public object sbResultDescRegEx { get; set; }

        public object sbResultRegEx { get; set; }

        private string getBodyTextForEachPage(string pageText, string wSectpr)
        {
            throw new NotImplementedException();
        }
    }
}
