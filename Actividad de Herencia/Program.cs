//Alejandro Gomez Escoto (23-0573) 3/1/2024

//Tipos de Herencia

//#1 Herencia Simple
/* La herencia simple, como dice su nombre, es simple.
En ella, una clase hereda de solamente una clase base.

Ejemplo: */

/*

public class Soldado
{
    public string Equipo { get; set; }
    public string Uniforme {  get; set; }

    public Soldado(string equipo, string uniforme)
    {
        Equipo = equipo;
        Uniforme = uniforme;
    }
}


public class Capitan : Soldado
{
    public string Arma { get; set; }
    public Capitan(string equipo, string uniforme, string arma) : base(equipo, uniforme)
    {
        Arma = arma;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Capitan capitan = new Capitan("Estados Unidos", "Verde", "Rifle");
    }
}
*/

//#2 Herencia Virtual
/* La herencia virtual, o herencia de implementacion,
 reutiliza codigo implementando funciones virtuales y anulando
en estos usando clases derivadas.

Ejemplo: */

/*
abstract class Forma
{
    public abstract double CalculoDeArea();
}

class Circulo : Forma
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalculoDeArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(120);

        double areaDelCirculo = circulo.CalculoDeArea();
        Console.WriteLine(areaDelCirculo);
    }
}
*/

//#3 Herencia Multiple de Interfaces

/* La herencia multiple, normalmente, se trata de una herencia
 entre multiples clases. C# no permite este tipo de herencia,
sin embargo, si permite la herencia de multiples interfaces.
En este caso una interfaz define un contrato 
para que una clase lo implemente y una clase pueda implementar
varias interfaces.

Ejemplo: */

/*
public interface InterfazEmpleado
{
    void Trabajar();
}

public interface InterfazGerente
{
    void Trabajar();
}

public class Empleado : InterfazEmpleado
{
    public void Trabajar()
    {
        Console.WriteLine("Hay un empleado trabajando.");
    }
}

public class Gerente : InterfazEmpleado, InterfazGerente
{
    public void Trabajar()
    {
        Console.WriteLine("Hay gerente trabajando y además delegando");
    }
}

class Program
{
    static void Main(string[] args)
    {
        InterfazGerente gerente = new Gerente();
        gerente.Trabajar();

        InterfazEmpleado empleado = new Empleado();
        empleado.Trabajar();
    }

}
*/

//#4 Herencia Hibrida

/* La herncia hibrida tampoco es muy comun en c#. La herencia
 hibrida se trata de hacer que una clase herede de otra clase
mientras que al mismo tiempo implementa una o multiples interfaces.
Esto no es posible en c# pero se puede hacer algo mas o menos similar
usando composicion e interfaces.

 Ejemplo: */

/*
interface Interfaz
{
    void MetodoDeInterfaz();
}

class Base
{
    public void MetodoDeBase()
    {

    }
}

class Derivada : Base, Interfaz
{
    public void MetodoDeInterfaz()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Derivada instancia = new Derivada();

        instancia.MetodoDeInterfaz();
        instancia.MetodoDeBase();
    }
}
*/

//#5 Herencia Jerarquica

/* En una herencia jerarqica, multiples clases
 heredan de la misma clase. Todas estas subclases tienen
una relacion directa con la clase base.

 Ejemplo: */

/*
class Animal
{
    public void HacerSonido()
    {
        Console.WriteLine("- Un animal hace un sonido.");
    }
}

class Perro : Animal
{
    public void ComerHuesos()
    {
        Console.WriteLine("- El Perro come huesos.");
    }
}

class Gato : Animal
{
    public void Mauyar()
    {
        Console.WriteLine("- El gato mauya.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro perro = new Perro();
        perro.HacerSonido();
        perro.ComerHuesos();

        Gato gato = new Gato();
        gato.Mauyar();
        gato.HacerSonido();
    }
}

*/

// Bibliografia
/*
 
BillWagner. (2023, 5 junio). Herencia en C# - C#. Microsoft Learn. 
https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/inheritance

Corvo, H. S. (2020, 15 abril). Herencia en programación: características, tipos, ejemplos. Lifeder. 
https://www.lifeder.com/herencia-programacion/ 

GfG. (2023, 6 abril). C inheritance. GeeksforGeeks. 
https://www.geeksforgeeks.org/c-sharp-inheritance/

 */
