//inicio del primer punto 



/*punto 4*/


// Console.Write("Por favor, ingrese su nombre: ");
//         string nombre = Console.ReadLine();

//         Console.Write("Por favor, ingrese su edad: ");
//         int edad = Convert.ToInt32(Console.ReadLine());

//         if (edad < 18 || edad > 60)
//         {
//             Console.WriteLine(nombre + ", puedes obtener un descuento en el cine.");
//         }
//         else
//         {
//             Console.WriteLine(nombre + ", no cumples con los requisitos de edad para el descuento en el cine.");
//         }


/*punto 5*/
// Console.Write("Por favor, ingrese su nombre de usuario: ");
//         string nombreUsuario = Console.ReadLine();

//         Console.Write("Por favor, ingrese su contraseña: ");
//         string contrasena = Console.ReadLine();

//         if (nombreUsuario == "admin" && contrasena == "1234")
//         {
//             Console.WriteLine("Acceso concedido");
//         }
//         else
//         {
//             Console.WriteLine("Acceso denegado");
//         }



/*punto 6*/
//  Console.Write("Por favor, ingrese el primer número: ");
//         int numero1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el segundo número: ");
//         int numero2 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el tercer número: ");
//         int numero3 = Convert.ToInt32(Console.ReadLine());

//         if (numero1 < 0 || numero2 < 0 || numero3 < 0)
//         {
//             Console.WriteLine("Al menos uno de los números es negativo.");
//         }
//         else
//         {
//             Console.WriteLine("Todos los números son positivos.");
//         }



/*punto 7*/
// Console.Write("Por favor, ingrese una temperatura en grados Celsius: ");
//         double celsius = Convert.ToDouble(Console.ReadLine());

//         double fahrenheit = celsius * 9 / 5 + 32;

//         Console.WriteLine($"La temperatura en grados Fahrenheit es {fahrenheit}°F."




/*punto 8*/
// Console.Write("Por favor, ingrese un mes: ");
//         string mes = Console.ReadLine().ToLower();

//         switch (mes)
//         {
//             case "octubre":
//                 Console.WriteLine("Este mes corresponde a Halloween.");
//                 break;
//             case "diciembre":
//                 Console.WriteLine("Este mes corresponde a Navidad.");
//                 break;
//             case "enero":
//             case "febrero":
//             case "marzo":
//             case "abril":
//             case "mayo":
//             case "junio":
//             case "julio":
//             case "agosto":
//             case "septiembre":
//             case "noviembre":
//                 Console.WriteLine("Este mes no corresponde ni a Halloween ni a Navidad.");
//                 break;
//             default:
//                 Console.WriteLine("Por favor, ingrese un mes válido.");
//                 break;
//         }




/*punto 9*/
// Console.Write("Por favor, ingrese la longitud del primer lado: ");
//         double lado1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Por favor, ingrese la longitud del segundo lado: ");
//         double lado2 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Por favor, ingrese la longitud del tercer lado: ");
//         double lado3 = Convert.ToDouble(Console.ReadLine());

//         if (lado1 == lado2 && lado2 == lado3)
//         {
//             Console.WriteLine("El triángulo es equilátero.");
//         }
//         else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
//         {
//             Console.WriteLine("El triángulo es isósceles.");
//         }
//         else
//         {
//             Console.WriteLine("El triángulo es escaleno.");
//         }




/*punto 10*/
// Console.Write("Por favor, ingrese el primer número: ");
//         int numero1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el segundo número: ");
//         int numero2 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el tercer número: ");
//         int numero3 = Convert.ToInt32(Console.ReadLine());

//         if (numero1 < 10 && numero2 < 10 && numero3 < 10)
//         {
//             Console.WriteLine("Todos los números son menores a diez.");
//         }
//         else
//         {
//             Console.WriteLine("Al menos uno de los números no es menor a diez.");
//         }





/*punto 11*/
// Console.Write("Por favor, ingrese el monto total de la factura: ");
//         double montoFactura = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Por favor, ingrese el porcentaje de propina que desea dejar: ");
//         double porcentajePropina = Convert.ToDouble(Console.ReadLine());

//         double montoPropina = montoFactura * porcentajePropina / 100;
//         double totalPagar = montoFactura + montoPropina;

//         Console.WriteLine($"El monto de la propina es: {montoPropina}");
//         Console.WriteLine($"El total a pagar es: {totalPagar}");






/*punto 12*/
// Console.Write("Por favor, ingrese el precio del producto: ");
//         double precioProducto = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Por favor, ingrese el porcentaje de descuento aplicable: ");
//         double porcentajeDescuento = Convert.ToDouble(Console.ReadLine());

//         double descuento = precioProducto * porcentajeDescuento / 100;
//         double precioFinal = precioProducto - descuento;

//         Console.WriteLine($"El precio final después del descuento es: {precioFinal}");






/*punto 13*/
//  Console.Write("Por favor, ingrese el primer valor: ");
//         int valor1 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el segundo valor: ");
//         int valor2 = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Por favor, ingrese el tercer valor: ");
//         int valor3 = Convert.ToInt32(Console.ReadLine());

//         if (valor1 == valor2 && valor2 == valor3)
//         {
//             int resultado = (valor1 + valor2) * valor3;
//             Console.WriteLine($"El resultado es: {resultado}");
//         }
//         else
//         {
//             Console.WriteLine("Los valores ingresados no son iguales.");
//         }





/*punto 14*/
// Console.Write("Por favor, ingrese su sueldo: ");
//         double sueldo = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Por favor, ingrese sus años de antigüedad: ");
//         int antiguedad = Convert.ToInt32(Console.ReadLine());

//         if (sueldo < 500 && antiguedad >= 10)
//         {
//             sueldo += sueldo * 0.20;
//         }
//         else if (sueldo < 500 && antiguedad < 10)
//         {
//             sueldo += sueldo * 0.05;
//         }

//         Console.WriteLine($"El sueldo a pagar es: {sueldo}");









//fin del primer punto






//iniicio del punto 2
		// /*punto 1*/
		// Console.Write("porfavor ingrese un numero; ");	
		
		// var numero = Convert.ToInt32(Console.ReadLine());

    //     if (numero < 0)
    //     {
    //        Console.Write($"el numero {numero} es negativo");
    //     }
    //     else
    //     {
    //       Console.Write($"el numero {numero} no es negativo");  
    //     }

        /*punto 2*/

        /*if (numero > 0)
        {
           Console.Write($"el numero {numero} es positivo");
        }
        else
        {
          Console.Write($"el numero {numero} no positivo");  
        }*/


      /*punto 3*/

        /*if (numero %2 == 0) 
        {
           Console.Write($"el numero {numero} es par");
        }
        else
        {
            Console.Write($"el numero {numero} no es par");
        }*/

        /*punto 4*/

        /*if (numero %2 != 0) 
        {
           Console.Write($"el numero {numero} es inpar");
        }
        else
        {
            Console.Write($"el numero {numero} no es inpar");
        }*/


        /*punto 5*/

        /*if (numero %5 == 0)
        {
            Console.Write($"el numero {numero} es multiplo de 5");
        }
        else
        {
            Console.Write($"el numero {numero} no es multiplo de 5 ");
        }*/


        /*punto 6*/

        /*if (numero %3 == 0)
        {
            Console.Write($"el numero {numero} es divisible por 3");
        }
        else
        {
            Console.Write($"el numero {numero} no es divisible por 3 ");
        }*/

        /*punto 7*/

        /*if (numero > 100)
        {
            Console.Write($"el numero {numero} es mayor que 100");
        }else if(numero == 100){
            Console.Write($"el numero {numero} es igual a 100");
        }
        else
        {
            Console.Write($"el numero {numero} no es mayor que 100");
        }*/


        /*punto 8*/

        /*if (numero < -50)
        {
            Console.Write($"el numero {numero} es menor a -50");
        }else if(numero == -50){
            Console.Write($"el numero {numero} es igual a -50");
        }
        else
        {
            Console.Write($"el numero {numero} es mayor que -50");
        }*/


        /*punto 9*/

        /*if (numero >= 20 && numero <= 50)
        {
            Console.Write($"el numero {numero} esta en el rango de 20 a 50");
        }
        else
        {
            Console.Write($"el numero {numero} no esta en el rango de 20 a 50");
        }*/


        /*punto 10*/

        /*if (numero == 0)
        {
            Console.Write($"el numero {numero} es igual a 0");
        }
        else
        {
            Console.Write($"el numero {numero} no es igual a 0");
        }*/


       /*punto 11*/

        /*if (numero > -10 && numero < 10)
        {
          Console.Write($"el numero {numero} es mayor que -10 y menor a 10");
        }
        else
        {
            Console.Write($"el numero {numero} no es mayor que -10 y menor a 10");
        }*/

        /*punto 12*/

        /* Console.WriteLine("Calcular si un año es bisiesto");
         Console.WriteLine("Ingresa el año a calcular:");
         string inputYear = Console.ReadLine();

         if (int.TryParse(inputYear, out int year))
         {
             if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
             {
                 Console.WriteLine($"El año {year} es bisiesto.");
             }
             else
             {
                 Console.WriteLine($"El año {year} no es bisiesto.");
             }
         }
         else
         {
             Console.WriteLine("Por favor, ingresa un año válido.");
         }
     }*/


        //otra forma de hacerlo 

        /*Console.Write("Ingresa un año: ");
        int año = int.Parse(Console.ReadLine());

        bool esBisiesto = DateTime.IsLeapYear(año);
        Console.WriteLine($"El año {año} {(esBisiesto ? "es" : "no es")} bisiesto.");*/


        /*punto 13*/


        /*if (numero >= 18)
        {
            Console.Write("heres mayor de edad");
        }
        else
        {
            Console.Write("no heres mayor de edad");
        }*/

        /*punto 14*/


        /*if (Math.Sqrt(numero) % 1 == 0)
        {
            Console.Write($"el numero {numero} si es un cudrado perfecto");
        }
        else
        {
            Console.Write($"el numero {numero} no es un cudrado perfecto");
        }*/

        /*punto 16*/

        /*double fi = (1 + Math.Sqrt(5)) / 2.0; // Proporción áurea
        int n = (int)Math.Floor(Math.Log(numero * Math.Sqrt(5) + 0.5, fi));

        // Encuentra el número real correspondiente al índice (n)
        int actualFibonacciNumber = (int)Math.Floor(Math.Pow(fi, n) / Math.Sqrt(5) + 0.5);

        if (numero == actualFibonacciNumber)
        {
            Console.WriteLine($"el numero {numero} está dentro de la secuencia de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"el numero {numero} NO está dentro de la secuencia de Fibonacci.");
        }*/


        /*punto 17*/

		
        /*if (numero != 0 && ((numero & (numero - 1)) == 0))
        {
            Console.Write("si");
        }
        else
        {
            Console.Write("no");
        }*/
		
		
		/*punto 18*/
		
		/*string numero = Console.ReadLine();
		string numeroReverso = new string(numero.Reverse().ToArray());

		if (numero == numeroReverso)	
		{
    		Console.Write($"el numero {numero} si es palindromo");
		}
		else
		{
    		Console.Write($"el numero {numero} no es palindromo");
		}*/
		
		
		
		/*punto 19*/
		
		//var texto = "Devuelve un valor que indica si un carácter especificado aparece dentro de esta cadena, mediante las reglas de comparación especificadas.";
		/*Console.WriteLine("ingresa la palabra que quierar buscar en el texto");
		var palabra = Console.ReadLine();
		
	    
        if ( texto.Contains(palabra) == true)
        {
          Console.Write($"la palabra {palabra} si se encuentra");
        }
        else
        {
            Console.Write($"la palabra {palabra} no se encuentra");
        }*/
		
		
		/*punto 20*/
		
	// 	string? cadena = "hola soy samuel!";
    // if (cadena.Length > 10){
    //   Console.WriteLine("su sting tiene mas de 10 caracteres" +  cadena);
    // }else{
    //   Console.WriteLine("su sting tiene menos de 10 catacteres" + cadena);
    // }


        /*punto 21*/
    // string? minusculas = "asdsdads";
    // if(minusculas.Equals(minusculas.ToLower())){
    //     Console.WriteLine("su texto esta en minusculas");
    // }else{
    //     Console.WriteLine("su texto no contiene minusculas");
    // }

         /*punto 22*/
    // string cadena = "Hola mundo 31231";
    // bool contieneNumero = false;

    // foreach(char d in cadena)
    // {
    //     if(char.IsDigit(d))
    //     {
    //         contieneNumero = true;
    //         break; // Salimos del ciclo una vez que encontramos un número
    //     }
    // };

    // if(contieneNumero)
    // {
    //     Console.WriteLine("La cadena contiene al menos un número.");
    // }else
    // {
    //     Console.WriteLine("La cadena no contiene números.");
    // };

         /*punto 23*/



    //fin del punto 2