using System;


       class Program
    {
        static void Main()
        {
            const double PI = 3.14159265358979;
            Console.WriteLine("введите фигуру: треугольник, прямоугольник или круг");
            string Fig = Console.ReadLine();
            {
                switch (Fig)
                { case "треугольник":
                        Console.WriteLine("введите первую сторону");
                        double SideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите вторую сторону");
                        double SideB = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите третью сторону");
                        double SideC = double.Parse(Console.ReadLine());
                Console.WriteLine("площадь или периметр");
                string PP1 = Console.ReadLine();
                        {
                            switch (PP1)
                            {
                                case "площадь":
                                    double SquareTriangle = Math.Sqrt((SideA + SideB + SideC) / 2 * ((SideA + SideB + SideC) / 2 - SideA) * ((SideA + SideB + SideC) / 2 - SideB) * ((SideA + SideB + SideC) / 2 - SideC));
                                    Console.WriteLine("Площадь треугольника =" + SquareTriangle);
                                    double PerimetrRectangle = Math.Sqrt(SquareTriangle) * 2;
                                    Console.WriteLine("Периметр прямоугольника =" + PerimetrRectangle);
                                    double PerimetrRound = Math.Sqrt(SquareTriangle/PI) * 2 * PI;
                                    Console.WriteLine("Периметр круга =" + PerimetrRound);
                                    break;
                                case "периметр":
                                    double PerimetrTriangle = (SideA + SideB + SideC);
                                    Console.WriteLine("Периметр треугольника =" + PerimetrTriangle);
                                    double SquareRectangle = Math.Pow(PerimetrTriangle/4,2);
                                    Console.WriteLine("Площадь прямоугольника =" + SquareRectangle);
                                    double SquareRound = Math.Pow((PerimetrTriangle / 2/PI),2) * PI;
                                    Console.WriteLine("Площадь круга =" + SquareRound);
                                    break;
                            }
                        }
                        break;
                     case "прямоугольник":
                        Console.WriteLine("введите ширину");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите длину");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("площадь или периметр");
                        string PP3 = Console.ReadLine();
                        {
                            switch (PP3)
                            {
                                case "площадь":
                                    double SquareRectangle = width * height;
                                    Console.WriteLine("Площадь прямоугольника =" + SquareRectangle);
                                    double PerimetrTriangle = (SquareRectangle / 3);
                                    Console.WriteLine("Периметр треугольника =" + PerimetrTriangle);
                                    double PerimetrRound = Math.Sqrt(SquareRectangle / PI) * 2 * PI;
                                    Console.WriteLine("Периметр круга =" + PerimetrRound);
                                    break;
                                case "периметр":
                                    double PerimetrRectangle = ((width+ height) * 2);
                                    Console.WriteLine("Периметр прямоугольника =" + PerimetrRectangle);
                                    double SquareTriangle = Math.Sqrt(Math.Pow(PerimetrRectangle,3)/72);
                                    Console.WriteLine("Площадь треугольника =" + SquareTriangle);
                                    double SquareRound = Math.Pow((PerimetrRectangle / 2 / PI), 2) * PI;
                                    Console.WriteLine("Площадь круга =" + SquareRound);
                                    break;
                            }
                        }
                        break;
                    case "круг":
                        Console.WriteLine("введите радиус");
                        double Radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("площадь или периметр");
                        string PP4 = Console.ReadLine();
                        {
                            switch (PP4)
                            {
                                case "площадь":
                                    double SquareRound = (Math.Pow(Radius, 2) * PI);
                                    Console.WriteLine("Площадь круга =" + SquareRound);
                                    double PerimetrRectangle = Math.Sqrt(SquareRound) * 2;
                                    Console.WriteLine("Периметр прямоугольника =" + PerimetrRectangle);
                                    double PerimetrTriangle = (SquareRound / 3);
                                    Console.WriteLine("Периметр треугольника =" + PerimetrTriangle);
                                break;
                                case "периметр":
                                    double PerimetrRound = (Radius * 2* PI);
                                    Console.WriteLine("Периметр круга =" + PerimetrRound);
                                    double SquareTriangle = Math.Sqrt(Math.Pow(PerimetrRound, 3) / 72);
                                    Console.WriteLine("Площадь треугольника =" + SquareTriangle);
                                    double SquareRectangle = Math.Pow(PerimetrRound / 4, 2);
                                    Console.WriteLine("Площадь прямоугольника =" + SquareRectangle);
                                break;
                            }
                        }
                        break;
                        }
            }
            Console.ReadKey();
        }
    }

