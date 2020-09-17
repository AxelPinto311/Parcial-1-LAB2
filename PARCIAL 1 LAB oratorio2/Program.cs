using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PARCIAL_1_LAB_oratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;//Variable utilizada en swtich case para seleccionar una opcion
            String opcsalir; //variable utilizada en swtich case para terminar la compra
            int d1 = 0; //Descuento aplicado 10 0 20 a imprimir
            int tamano,totalsind=0; // Variables enteras, tamano me da el tamano de mi arraylist -- Totalsind es mi total sin descuento
            float total=0.0f,descuento1,descuento2; //variables flotantes
            int cantidad = 0; //Cantidad de camisas
            ArrayList CarroDeCompras = new ArrayList();//Declado un Arraylist
            
            try
            {
                do
                {
                    MenuPrincipal(); //Llamada a metodo 
                    Submenu(cantidad, totalsind, d1); //Llamda a metodo 
                    opc = Convert.ToInt32(Console.ReadLine()); //Lectura de dato 

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();//Limpiar pantalla
                          

                            CarroDeCompras.Add(1000); //Adhiere camisa al carro
                            cantidad = cantidad + 1;// Acumulador de camisas
                            tamano = CarroDeCompras.Count; //Tamaño de mi array
                            totalsind = cantidad * 1000; //Calculo del total sin descuento
                            if (cantidad >= 3 && cantidad <= 5) //Condicion para calcular el procentaje a aplicar
                            {
                                d1 = 10;
                                descuento1 = totalsind * 10 / 100;
                                total = totalsind - descuento1;

                            }
                            else
                            if (cantidad > 5)
                            {
                                d1 = 20;
                                descuento2 = totalsind * 20 / 100;
                                total = totalsind - descuento2;
                            }
                            break;
                        case 2:
                            Console.Clear();

                            tamano = CarroDeCompras.Count;
                            CarroDeCompras.RemoveAt(1);
                            cantidad = cantidad - 1;
                            totalsind = totalsind - 1000;
                            if (cantidad < 3)
                            {
                                d1 = 10;
                                
                                total = totalsind * cantidad;

                            }
                            else
                          if (cantidad < 5 && cantidad >3 )
                            {
                                d1 = 20;
                                descuento2 = totalsind * 20 / 100;
                                total = totalsind - descuento2;
                            }
                            

                            break;
                        case 3:
                            Console.Clear();

                            Console.WriteLine("Esta seguro que desea salir? S/N");
                            opcsalir = Console.ReadLine(); 
                            if (opcsalir == "s")//Condicion para seguir en el programa o terminar la compra
                            {
                                Console.WriteLine("Precio final a pagar es de : $" + total);
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                if (opcsalir == "n")
                                {
                                    MenuPrincipal();
                                    opc = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                            }
                            break;
                        default: //En caso de ingresar una opcion incorrecta se ejecuta esta seccion de codigo
                            Console.Clear();
                            Console.WriteLine("Opcion no valida, intente de nuevo ");
                            break;
                    }
                    
                } while (opc != 3); // El programa se repite hasta precionar 3
            }
            catch //En caso de ingresar un tipo de dato de distinto tipo a entero
            {
                Console.WriteLine("Error ingresaste dato tipo no entero");
                Console.ReadKey();

            }

            
        }


        static void Submenu(int cantidad, int totalsind, int d1) // Metodo que muestrar un submenu
        {
            Console.WriteLine("Cantidad de camisas en el carro de compras:" + cantidad);
            Console.WriteLine("Precio unitario: 1000$ ");
            Console.WriteLine("Precio total sin descuento: $" + totalsind);
            Console.WriteLine("Tipo de descuento aplicado: %" + d1);
           
        }
        static void MenuPrincipal() //Metodo que muestra menu principal
        {
            Console.WriteLine("MENU PRINCIPAL: ");
            Console.WriteLine("1: Añadir camisa al carro de compras");
            Console.WriteLine("2: Eliminar camisa al carro de compras");
            Console.WriteLine("3: Salir");

            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
