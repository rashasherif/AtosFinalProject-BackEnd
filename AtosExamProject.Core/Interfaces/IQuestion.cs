using AtosExamProject.Core.Models;

namespace AtosExamProject.Core.Interfaces
{
    public interface IQuestion
    {
       public  Task<IEnumerable<Question>> GetAllQuestions();
      public  Task<Question> GetQuestionById(int questionId);
      public  Task<bool> DeleteQuestion(int QuestionId);
    }
}
