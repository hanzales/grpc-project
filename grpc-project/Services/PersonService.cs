using Grpc.Core;

namespace grpc_project.Services;

public class PersonService : Person.PersonBase
{
    public override async Task<PersonResponse> CreatePerson(PersonRequest request, ServerCallContext context)
    {
        Console.WriteLine($"{request.Name} {request.Surname} kişisi eklenmiştir.");
        return new PersonResponse()        {
            Message = "Kişi ekleme başarılı..."
        };
    }
}