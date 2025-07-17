using Domain.Model;
using System.Net.Http.Json;

const int PORT = 5154;

HttpClient httpClient = new HttpClient()
{
    BaseAddress = new Uri($"http://localhost:{PORT}")
};

var listaAlumnos = new List<Alumno>()
{
    new("Santiago", "Kellemberger", 53000, "Rosario 123"),
    new("Andres", "Diaz", 53500, "Roldan 456"),
    new("Leandro", "Perez", 52000, "Rosario 789"),
    new("Francisco", "Gomez", 18000, "Cordoba 789"),
};

try
{
    foreach (var alumno in listaAlumnos)
    {
        await httpClient.PostAsJsonAsync("alumnos", alumno);
    }
} 
catch(Exception err)
{
    Console.WriteLine(err.Message);
}

try
{
    var alumnos = await httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");

    if (alumnos is not null)
    {
        foreach (var a in alumnos)
        {
            Console.WriteLine($"Alumno: {a.Id}-{a.Apellido} {a.Nombre}, Legajo: {a.Legajo}");
        }

        Console.WriteLine($"Total de alumnos: {alumnos.Count()}");
    }
    else
    {
        Console.WriteLine("No hay alumnos cargados");
    }
}
catch(Exception err)
{
    Console.WriteLine(err.Message);
}

var rtdo = await httpClient.DeleteAsync($"alumnos/4");
Console.WriteLine($"{rtdo.StatusCode}");

try
{
    var alumn = await httpClient.GetFromJsonAsync<Alumno>("alumnos/1");
    Console.WriteLine(alumn.Apellido);
}
catch(Exception err)
{
    Console.WriteLine(err.Message);
}