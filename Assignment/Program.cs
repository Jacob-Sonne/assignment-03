using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();
var connectionString = configuration.GetConnectionString("ConnectionString");

var optionsBuilder = new DbContextOptionsBuilder<KanbanContext>();
optionsBuilder.UseSqlServer(connectionString);

var options = optionsBuilder.Options;

Console.Write("Enter query to search for character: ");

string? name;
do
{
    Console.Write("Enter query to search for character: ");
    name = Console.ReadLine();
}
while (string.IsNullOrWhiteSpace(name));

using var context = new KanbanContext(options);