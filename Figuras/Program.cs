
namespace Figuras
{
    public class Programa
    {
        public class Figura
        {
            public float area { get; set; }
            public float perimetro { get; set; }

            public String nome = ""; 

            public String Nome
            {
                get
                {
                    return nome;
                }
            }
        }

        public class Circulo : Figura
        {
            
            public float raio;

            public Circulo(float raio)
            {
                nome = "Círculo";
                this.raio = raio;
                area = (float) Math.PI * raio * raio;
                
            }
        }

        public class Retangulo : Figura
        {
            private float ladoA;
            private float ladoB;
            

            public Retangulo(float ladoA, float ladoB) 
            {
                nome = "Retângulo";
                this.ladoA = ladoA;
                this.ladoB = ladoB;
                area = ladoA * ladoB;
                perimetro = 2 * (ladoA + ladoB);
            }

            public float Diagonal()
            {
                return (float)Math.Sqrt(ladoA * ladoA + ladoB * ladoB);
            }
            
        }

        public class Hexagono : Equilatero
        {
            

            public Hexagono(float lado) :base(lado) 
            {
                nome = "Hexágono";
                this.lado = lado;
                area = 3 * (lado * lado) * (float)Math.Sqrt(3) / 2;
                perimetro = 6 * lado;

            }


        }

        public class Quadrado : Retangulo
        {
            public Quadrado(float lado) : base(lado, lado)
            {
                nome = "Quadrado";

            }
        }

        public class TrianguloRetangulo
        {
            private Retangulo r;


            public String Nome
            {
                get
                {
                    return "Triângulo Retângulo";
                }
            }
            public float area
            {
                get
                {
                    return r.area / 2;
                }
            }

            public float Hipotenusa
            {
                get
                {
                    return r.Diagonal();
                }
            }
            

            
            public TrianguloRetangulo(float catetoA, float catetoB)
            {
                r = new Retangulo(catetoA, catetoB);
            }
        }



        public class Equilatero : Figura
        {
            public float lado;
            public float altura;

            public Equilatero (float lado)
            {
                nome = "Triângulo Equilátero";
                this.lado = lado;
                altura = lado * (float)Math.Sqrt(3) / 2;
                perimetro = 3 * lado;
                area = lado * altura / 2;

            }

            public float Altura
            {
                get
                {
                    return altura;
                }
            }
        }


        public static int Main(String[] args)
        {
            

            Retangulo r = new Retangulo(4, 5);
            Console.WriteLine("Nome: " + r.Nome + ", " +
            "Area: " + r.area + ", " +
            "Perímetro: " + r.perimetro + ", " +
            "Diagonal: " + r.Diagonal());
           

            Circulo c = new Circulo(6);
            Console.WriteLine("Nome: " + c.Nome + ", " +
             "Area: " + c.area + ", " +
             "Perímetro: " + c.perimetro);

            Quadrado q = new Quadrado(4);
            Console.WriteLine("Nome: " + q.Nome + ", " +
           "Area: " + q.area + ", " +
           "Perímetro: " + q.perimetro + ", " +
           "Diagonal: " + q.Diagonal());

            Equilatero e = new Equilatero (10);
            Console.WriteLine("Nome: " + e.Nome + ", " +
           "Area: " + e.area + ", " +
           "Perímetro: " + q.perimetro);

            TrianguloRetangulo te = new TrianguloRetangulo(3, 4);
            Quadrado tr = new Quadrado(4);
            Console.WriteLine("Nome: " + q.Nome + ", " +
           "Area: " + tr.area + ", " +
           "Perímetro: " + tr.perimetro + ", " +
           "Hipotenusa " + tr.Diagonal());

            Hexagono h = new Hexagono(6);
            Console.WriteLine("Nome: " + h.Nome + ", " +
           "Area: " + h.area + ", "  +
           "Perímetro: " + h.perimetro);


            return 0;
        }
    }
}