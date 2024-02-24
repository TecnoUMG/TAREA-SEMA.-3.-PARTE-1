using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        //1) CALCULAR EL MAYOR NUMERO DE 3
        int num1, num2, num3;
        Console.WriteLine("Ingrese su primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su tercer numero:");
        num3 = Convert.ToInt32(Console.ReadLine());
        try {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Su primer numero es mayor");
            }

            if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("Su segundo numero es mayor");
            }

            if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("Su tercer numero es mayor");
            }

        }
        catch (DivideByZeroException error)
        {
            Console.WriteLine("Ha ocurrido un error" + error.Message);
        };

        //2) VALIDAR PARA INGRESAR A UN CLUB
        int edad;

        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        try {
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad por lo tanto puede ingresar al club bienvenido");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad por lo tanto no puede ingresar");
            }
        }
        catch (DivideByZeroException error)
        {
            Console.WriteLine("Ocurrio un error vuelva a intentarlo" + error.Message);
        }

        //3)CALCULAR PRECIO FINAL DE UN PRODUCTO
        Console.WriteLine("Ingrese el precio del producto");
        double precio = Convert.ToDouble(Console.ReadLine());
        try {
            if (precio > 100)
            {
                double descuento = precio * 0.10;
                Console.WriteLine("Su precio final con descuento del 10% es:" + descuento);
            }
            else
            {
                Console.WriteLine("Descuento no aplicado su precio final es:" + precio);
            }
        }
        catch
        {
            Console.WriteLine("Lo siento a ocurrido un error vuelva a intentarlo");
        }
        //4) VALIDAR USUARIO Y CONTRASEÑA
        string usuario, contraseña;

        usuario = "TecnoUMG";
        contraseña = "umg";

        Console.WriteLine("Ingrese su usuario:");
        string nameusuario = Console.ReadLine();

        Console.WriteLine("Ingrese la contraseña:");
        string contrausuario = Console.ReadLine();
        try
        {
            if (nameusuario == usuario && contrausuario == contraseña)
            {
                Console.WriteLine("Usuario y contraseña correctos");
            }
            else
            {
                Console.WriteLine("Usuario y contraseña incorrectos vuelva a intentarlo");
            }
        }
        catch
        {
            Console.WriteLine("Hubo un error en el proceso vuelva a intentarlo");
        }
        //5) NUMERO IMPAR O PAR
        int number;
        Console.WriteLine("Ingrese un numero:");
        number = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        catch
        {
            Console.WriteLine("Hubo un error en el proceso");
        }

        //6) MOSTRAR UN MENSAJE DE APROBACION O RECHAZO DE UN PRESTAMO

        Console.WriteLine("Ingrese su edad:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el monto del prestamo que desea");
        int prest = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (prest < 5000 || age > 60)
            {
                Console.WriteLine("Su prestamo a sido aprobado");

            }
            else
            {
                Console.WriteLine("Su prestamo a sido rechazado");
            }
        }
        catch
        {
            Console.WriteLine("A ocurrido un error");
        }
        //7) CALCULAR EL AREA DE UNA FIGURA GEOMETRICA
        try
        {
            Console.WriteLine("Ingrese una figura geometrica como un triangulo o cuadrado o circulo:");
        string figuregeo = Console.ReadLine().ToUpper(); 

        double zone = 0;
        
            switch (figuregeo)
            {
                case "TRIANGULO":
                    Console.WriteLine("Ingrese la base del triangulo:");
                    double bace = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo:");
                    double altu = Convert.ToDouble(Console.ReadLine());
                    zone = bace * altu / 2;
                    break;
                case "CUADRADO":
                    Console.WriteLine("Ingrese un lado del cuadrado:");
                    double lado1 = Convert.ToDouble(Console.ReadLine());
                    zone = lado1 * lado1;
                    break;
                case "CIRCULO":
                    Console.WriteLine("Ingrese una cantidad para el radio del circulo:");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    zone = Math.PI * Math.Pow(rad, 2);
                    break;
                default:
                    Console.WriteLine("Ocurrio un error o ingreso alguna otra figura no permitida");
                    return;
                     }
            Console.WriteLine("El area de la figura circulo es:" + zone);
             }
            catch {
            Console.WriteLine("Ocurrio un error vuelva a intentarlo");
                    }

        }
    



    }
