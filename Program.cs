
/*formato de switch and case tanto con letras and numers osea char and int*/

// Console.WriteLine("elija una opcion con la letra que se indica");
// Console.WriteLine("a) para plasmar hola mundo");
// Console.WriteLine("b) para una suma simple ");
// Console.WriteLine("c) para literalmente diga nada");

// char opcion = Convert.ToChar(Console.ReadLine());

// switch (opcion){
//   case 'a' : Console.WriteLine("hola mundo");
//     break;

//   case 'b' : int numero1 = 2;
//     int numero2 = 5;
//     int suma = numero1 + numero2;
//     Console.WriteLine(suma);
//     break;

//   case 'c' : Console.WriteLine("literalmente diga nada");
//     break;  

//   default : Console.WriteLine("usuario porfavor elija lo que se encuntra dentro dela lista");
//     break;
// }


// Console.WriteLine("elija una opcion con la letra que se indica");
// Console.WriteLine("1) para plasmar hola mundo");
// Console.WriteLine("2) para una suma simple ");
// Console.WriteLine("3) para literalmente diga nada");

// int opcion_numerada = Convert.ToInt32(Console.ReadLine());

// switch (opcion_numerada)
// {
//   case 1:
//     Console.WriteLine("hola mundo");
//     break;

//   case 2:
//     int numero1 = 100;
//     int numero2 = 321321;
//     int suma = numero1 * numero2;
//     Console.WriteLine(suma);
//     break;

//   case 3:
//     Console.WriteLine("literalmente diga nada");
//     break;

//   default:
//     Console.WriteLine("usuario porfavor elija lo que se encuntra dentro dela lista");
//     break;
// }










/*formato de filas*/

// using System.Collections;


// Queue fila_super = new Queue();

// fila_super.Enqueue("robinson");
// fila_super.Enqueue("ronald");
// fila_super.Enqueue("andres");
// fila_super.Enqueue("lopera");

// for (int i = 0; i < 3; i++)
// {
//   Console.WriteLine($"el usuario esta en sura sera atendido despues de {fila_super.Dequeue()}");
// }
// Console.WriteLine(fila_super.Count);






/* mi primera pila */

//esto es para traer la "libreria" siempre se usa!!
// using System.Collections;

// Stack mipila = new Stack();

// //declaracion de los valores que se encontraran en la pila
// mipila.Push("rolando");
// mipila.Push("rolando1");
// mipila.Push("rolando2");

// //declaracion para el conteo
// int tamañodemipila = mipila.Count;

// //ciclo para saber el la cantidad que hara el ciclo para sacarme la info
// for (int i = 0; i < 3; i++)
// {
//   Console.WriteLine("el valor de mi pila es" + mipila.Pop());
// }



/*mi primeara lista*/

//lista dode le fui agregando el valor con add
List<string> lista_de_alumnos = new List<string>();

lista_de_alumnos.Add("alonso");
lista_de_alumnos.Add("pepito");
lista_de_alumnos.Add("vizio");

//lista donde le di los valores iniciales
List<string> lista_de_alumnos2 = new List<string>{
  "pedro",
  "alfonso",
  "stiven"
};

//metodo para insertar un nuevo estudiante directamente en una pocision especifica
lista_de_alumnos2.Insert(3, "kevin");
lista_de_alumnos2.Insert(3, "valeria");
lista_de_alumnos.Insert(3, "luis");

//metodo para remover a un estudiante 

lista_de_alumnos2.RemoveAt(0);


foreach (string alunos in lista_de_alumnos)
{
  Console.WriteLine(alunos);
}

Console.WriteLine("/n");

for (int contador = 0; contador < lista_de_alumnos2.Count; contador++)
{
  Console.WriteLine(lista_de_alumnos2[contador]);
}

