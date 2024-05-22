namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };

            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};
            Console.WriteLine("Máximo numero en lista: " + lstNumeros.Max());

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente

            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            lstNombres = lstNombres.OrderBy(x => x).ToList();
            Console.WriteLine("--------------------");
            Console.WriteLine("Elementos de la lista ordenados alfabeticamente:");
            foreach (var item in lstNombres)
            {
                Console.WriteLine("  "+item);
            }
            #endregion

            #region Ejercicio3

            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola

            var lstClientesAux = lstClientes.FindAll(x => x.Vip == true);
            Console.WriteLine("--------------------");
            Console.WriteLine("Elementos de lstClientes que poseen vip = true:");
            foreach (var item in lstClientesAux)
            {
                Console.WriteLine("  Cliente: " + item.Apellido + ", " + item.Nombre + ". CodCliente: " + item.CodCliente + ". Vip = " + item.Vip);
            }
            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres

            var lstClientesAux2 = lstClientes.Select(x => x.Nombre).ToList();
            Console.WriteLine("--------------------");
            Console.WriteLine("Elementos de nueva lista con los nombres de los clientes:");
            foreach (var item in lstClientesAux2)
            {
                Console.WriteLine("  Cliente: " + item);
            }
            #endregion

            #region Ejercicio5

            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"

            var lstClientesAux3 = lstClientes.Select(x => new {
                Nombre = x.Nombre.ToUpper(),
                Apellido = x.Apellido.ToUpper(),
                x.CodCliente,
                Vip = x.Vip == true ? "Premium" : "Normal"
            }).ToList();
            Console.WriteLine("--------------------");
            Console.WriteLine("Elementos de nueva lista con los datos de lstClientes modificados:");
            foreach (var item in lstClientesAux3)
            {
                Console.WriteLine("  Cliente: " + item.Apellido + ", " + item.Nombre + ". CodCliente: " + item.CodCliente + ". Vip = " + item.Vip);
            }
            #endregion
        }
    }
}