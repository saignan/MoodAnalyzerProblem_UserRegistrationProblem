﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
     public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className,string constructorName)
        {
            string pattern = @"^" + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType);

                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustumException(MoodAnalyzerCustumException.ExceptionType.NO_SUCH_CLASS, "class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustumException(MoodAnalyzerCustumException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }

        }
    }
}
