using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class QuestionLoader
    {
        public static List<QuizQuestion> LoadAllQuestions()
        {
            List<QuizQuestion> masterQuestionList = new List<QuizQuestion>();
            IEnumerable<QuestionCategories> categories = Enum.GetValues(typeof(QuestionCategories)).Cast<QuestionCategories>();

            // loads all questions, but requires that you created an enum for the category
            //   and that you added the text file to the switch in LoadQuestionCategory
            foreach (QuestionCategories category in categories)
            {
                masterQuestionList.Union(LoadQuestionCategory(category).ToList());
            }

            return masterQuestionList;
        }

        public static List<QuizQuestion> LoadQuestionCategory(QuestionCategories category)
        {
            switch (category)
            {
                case QuestionCategories.general_knowledge:
                    return LoadQuestions(category, "generalKnowledge.txt");
                case QuestionCategories.math_science:
                    return LoadQuestions(category, "mathAndScience.txt");
                case QuestionCategories.sports:
                    return LoadQuestions(category, "sports.txt");
                case QuestionCategories.entertainment:
                    return LoadQuestions(category, "entertainment.txt");
                default:
                    throw new ArgumentException("Invalid question category!");
            }
        }

        private static List<QuizQuestion> LoadQuestions(QuestionCategories category, string filePath)
        {
            List<QuizQuestion> questions = new List<QuizQuestion>();

            using (StreamReader questionLoader = new StreamReader(filePath, true))
            {
                while (!questionLoader.EndOfStream)
                {
                    string[] questionInfo = questionLoader.ReadLine().Split('~').ToArray();
                    questions.Add(new QuizQuestion()
                    {
                        Category = category,
                        Question = questionInfo[0],
                        CorrectAnswer = questionInfo[1],
                        FirstIncorrectAnswer = questionInfo[2],
                        SecondIncorrectAnswer = questionInfo[3],
                    });
                }
            }

            return questions;
        }
    }
}
