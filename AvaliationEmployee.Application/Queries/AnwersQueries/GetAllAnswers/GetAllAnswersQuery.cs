using _5W2H.Application.Models;
using MediatR;

namespace _5W2H.Application.Queries.AnwersQueries.GetAllAnswers;

public class GetAllAnswersQuery : IRequest<List<AnswerViewModel>>
{
    public GetAllAnswersQuery(string query)
    {
        Query = query;
    }
    
    public string Query { get; private set; }
}