using Api.Protos;
using Grpc.Core;

namespace Api.Services;

public class PersonServiceImpl : PersonService.PersonServiceBase
{
    public override async Task ExchangePersons(
        IAsyncStreamReader<Person> requestStream,
        IServerStreamWriter<Person> responseStream,
        ServerCallContext context)
    {
        await foreach (var person in requestStream.ReadAllAsync())
        {
            Console.WriteLine($"Recebido: {person.Name}, {person.Age} anos");

            var response = new Person
            {
                Name = person.Name.ToUpper(),
                DateOfBirth = person.DateOfBirth,
                Age = person.Age + 1,
                Active = person.Active
            };

            await responseStream.WriteAsync(response);
            await Task.Delay(500);
        }
    }
}