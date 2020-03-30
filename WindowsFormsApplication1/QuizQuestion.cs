using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class QuizQuestion
    {
        public QuestionCategories Category { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string FirstIncorrectAnswer { get; set; }
        public string SecondIncorrectAnswer { get; set; }
    }

    public enum QuestionCategories
    {
        general_knowledge,
        math_science,
        sports,
        entertainment,
    }
}
