//Creamos una clase llamada libreta
public class Libreta{

//Creamos un producto Main y creamos dos libros 
 public static void Main(string[] args){
//creamos un libro llamado pinocho
    Libros Pinocho= new Libros();
    //ultilizamos un setnumpaginas para conectar las dos hojas y darle un valor de paginas
    Pinocho.Setnumpaginas(169);
    //ultilizamos un SetISBN para conectar las dos hoja Y darle un valor de ISBN
    Pinocho.SetISBN("312546764532");
    //ultilizamos un setAutor para conectar las dos hoja y darle el nombre del autor dle libro
    Pinocho.SetAutor("Carlos collodi");
    //ultilizamos un setitulo para conectar las dos hoja y darle un titulo al libro
    Pinocho.SetTitulo("Pinocho");
    //por ultmo en ese fase ultizamos un tostring para que nos muestre en pantalla
    Pinocho.tostring();

    //creamos otro libro llamado NACHO
    Libros NACHO = new Libros ();
    //ultilizamos un setnumpaginas para conectar las dos hoja Y dar un valor a las hojas
    NACHO.Setnumpaginas(50);
    //ultilizamos un setISBN para conectar las dos hoja y dar un valor de ISBN
    NACHO.SetISBN("312897654323");
    //ultilizamos un setAutor para conectar las dos hoja y dar un nombre de autor
    NACHO.SetAutor("Melanio Hernandez");
    //ultilizamos un settitulo para conectar las dos hoja y dar titulo al libro
   NACHO.SetTitulo("Nacho");
   //por ultmo en ese fase ultizamos un tostring para que nos muestre en pantalla
    NACHO.tostring();
  
  //utilizamos un si para definir que libro tiene mas paginas
if (NACHO.Consultarnumpaginas() >= Pinocho.Consultarnumpaginas())  {

//consolewriteline para que muestre en pantalla
   Console.WriteLine("Pinocho tiene mas paginas");
}
//un else para decir que el otro libro tiene menos
   else
   {
      //consolewriteline para que muestre en pantalla
    Console.WriteLine("NACHO tiene menos paginas");
   }
   }

 }