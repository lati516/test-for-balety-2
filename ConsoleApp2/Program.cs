

using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escoge lo que quieres hacer");
        Console.WriteLine("\ta - Invertir Cadena");
        Console.WriteLine("\tb - Cuantas veces se repite un caracter");
        Console.WriteLine("\tc - Distancia de Hamming");
        Console.WriteLine("\td - Contador de palabras");
        Console.WriteLine("\te - Rutina de Calculo");
        Console.Write("");

        switch (Console.ReadLine())
        {



            //invertir cadena  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            case "a":

                Console.WriteLine("Escoge un metodo para invertir la cadena ");
                Console.WriteLine("\ta - Metodo 1");
                Console.WriteLine("\tb - Metodo 2");
                Console.Write("");

                switch (Console.ReadLine())
                {
                    case "a":

                        string text = "Hola";
                        string textResult = "";

                        for (int i = text.Length - 1; i >= 0; i--)
                        {
                            textResult += text[i];

                        }

                        Console.WriteLine(textResult);

                        break;

                    case "b":

                        string texto = "Adios";
                        string textoResult = "";

                        char[] chars = texto.ToCharArray();
                        Array.Reverse(chars);
                        textoResult = new string(chars);

                        Console.WriteLine(textoResult);
                        break;

                }

                break;

            // cuantas veces se repite un caracter +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            case "b":


                Console.WriteLine("Escoge un metodo para contar las veces que se repite un caracter ");
                Console.WriteLine("\ta - Metodo 1");
                Console.WriteLine("\tb - Metodo 2");
                Console.Write("");

                switch (Console.ReadLine())
                {
                    case "a":

                        string txt = "iausioAAduhsdjqaaaddsdsSJAK88192aasasuidfvpaisdvpfIAFVPIUSYDVFAOLSDFALJVOua";
                        char character = 'a';
                        int n = 0;
                        foreach (var c in txt)
                        {
                            if (c == character)
                                n++;

                        }

                        Console.WriteLine($"se repite la letra {character} {n} veces");

                        break;

                    case "b":

                        string txta = "iausioAAduhsdjqaaaddsdsSJAK88192aasasuidfvpaisdvpfIAFVPIUSYDVFAOLSDFALJVOua";
                        char characters = 'a';
                        int m = 0;

                        n = txta.Where(c => c == characters).Count();

                        Console.WriteLine($"se repite la letra {characters} {m} veces");

                        break;

                }

                break;
            //Distancia de Hamming +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            case "c": 

                static int distanciah(String texta, String textb)
                {
                    int counter = 0;
                    for (int k = 0; k < texta.Length; k++)
                    {
                        if (texta.ElementAt(k) == textb.ElementAt(k)) counter++;

                    }
                    return counter;
                }

                Console.WriteLine("La distancia es: ");
                Console.WriteLine(distanciah("patitosw", "paratosa"));
                

                break; 

            //Contador de palabras +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            case "d":

                

                string tx = "Podemos diseñar nuestras propias clases y valores siguiendo las reglas que están presentes en el CTS. Las reglas están hechas para que el tipo de datos declarado usando un lenguaje de programación pueda ser llamado por una aplicación desarrollada usando un lenguaje diferente.";
                int x = 0;

                tx = Regex.Replace(tx, @"\s+", " ").Trim();

                var words = tx.Split(' ');

                x = words.Length;

                Console.WriteLine("Numero de palabras:" + x);

                break;


            //rutina de calculo++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            case "e":


                int num = 05368;
                int num2 = 4114;
                int num3 = 2777;
                int num4 = 4497;
                

                string s = num.ToString("D5");
                string s2 = num2.ToString("D5");
                string s3 = num3.ToString("D5");
                string s4 = num4.ToString("D5");

                int i1 = Int32.Parse(s.Substring(4, 1));
                int i2 = Int32.Parse(s.Substring(2, 1));
                int i3 = Int32.Parse(s.Substring(0, 1));


                int i4 = Int32.Parse(s2.Substring(4, 1));
                int i5 = Int32.Parse(s2.Substring(2, 1));
                int i6 = Int32.Parse(s2.Substring(0, 1));

                int i7 = Int32.Parse(s3.Substring(4, 1));
                int i8 = Int32.Parse(s3.Substring(2, 1));
                int i9 = Int32.Parse(s3.Substring(0, 1));

                int i10 = Int32.Parse(s4.Substring(4, 1));
                int i11 = Int32.Parse(s4.Substring(2, 1));
                int i12 = Int32.Parse(s4.Substring(0, 1));


                int si = i1 + i2 + i3;
                int times3 = si * 3;
                int p1 = Int32.Parse(s.Substring(1, 1));
                int p2 = Int32.Parse(s.Substring(3, 1));

                int si2 = i4 + i5 + i6;
                int times32 = si2 * 3;
                int p3 = Int32.Parse(s2.Substring(1, 1));
                int p4 = Int32.Parse(s2.Substring(3, 1));

                int si3 = i7 + i8 + i9;
                int times33 = si3 * 3;
                int p5 = Int32.Parse(s3.Substring(1, 1));
                int p6 = Int32.Parse(s3.Substring(3, 1));

                int si4 = i10 + i11 + i12;
                int times34 = si4 * 3;
                int p7 = Int32.Parse(s4.Substring(1, 1));
                int p8 = Int32.Parse(s4.Substring(3, 1));



                int sp = p1 + p2;
                int sp2 = p1 + p2;
                int sp3 = p3 + p4;
                int sp4 = p5 + p6;



                int sum = sp + times3;
                int rest = 0;
                if (sum % 10 != 0)
                    rest = 10 - (sum % 10);

                int resultado = sum + rest;

                int sum2 = sp2 + times32;
                int rest2 = 0;
                if (sum2 % 10 != 0)
                    rest2 = 10 - (sum2 % 10);

                int resultado2 = sum2 + rest2;

                int sum3 = sp3 + times33;
                int rest3 = 0;
                if (sum3 % 10 != 0)
                    rest3 = 10 - (sum3 % 10);

                int resultado3 = sum3 + rest3;

                int sum4 = sp4 + times34;
                int rest4 = 0;
                if (sum4 % 10 != 0)
                    rest4 = 10 - (sum4 % 10);

                int resultado4 = sum4 + rest4;

                Console.WriteLine("Rutina de calculo parte 1: 05368 resultado: " +  si);
                Console.WriteLine("Rutina de calculo parte 1: 4114 resultado: " + si2);
                Console.WriteLine("Rutina de calculo parte 1: 2777 resultado: " + si3);
                Console.WriteLine("Rutina de calculo parte 1: 4497 resultado: " + si4);




                Console.WriteLine("Rutina de calculo parte 2:05368 resultado: " + times3 );
                Console.WriteLine("Rutina de calculo parte 2: 4114 resultado: " + times32 );
                Console.WriteLine("Rutina de calculo parte 2: 2777 resultado: " + times33 );
                Console.WriteLine("Rutina de calculo parte 2: 4497 resultado: " + times34);

                Console.WriteLine("Rutina de calculo parte 3: 05368 resultado: " + sp );
                Console.WriteLine("Rutina de calculo parte 3: 4114 resultado: " + sp2 );
                Console.WriteLine("Rutina de calculo parte 3: 2777 resultado: " + sp3 );
                Console.WriteLine("Rutina de calculo parte 3: 4497 resultado: " + sp4);


                Console.WriteLine("Rutina de calculo parte 4: 05368 resultado: " + sum);
                Console.WriteLine("Rutina de calculo parte 4: 4114 resultado: " + sum2);
                Console.WriteLine("Rutina de calculo parte 4: 2777 resultado: " + sum3);
                Console.WriteLine("Rutina de calculo parte 4: 4497 resultado: " + sum4);


                Console.WriteLine("Rutina de calculo parte 5: 05368 resultado: " + resultado);
                Console.WriteLine("Rutina de calculo parte 5: 4114 resultado: " + resultado2);
                Console.WriteLine("Rutina de calculo parte 5: 2777 resultado: " + resultado3);
                Console.WriteLine("Rutina de calculo parte 5: 4497 resultado: " + resultado4);

               ;



                break;




        }
    }
}
