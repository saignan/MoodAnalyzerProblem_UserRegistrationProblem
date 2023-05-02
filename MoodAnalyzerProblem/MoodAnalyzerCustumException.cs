using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustumException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_FIELD,NO_SUCH_METHOD,NO_SUCH_CLASS,OBJECT_CREATION_IISUE
        }
        private readonly ExceptionType type;

        public MoodAnalyzerCustumException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
