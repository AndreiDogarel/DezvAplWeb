Console.WriteLine("Tema 1 Dezvoltarea Aplicatiilor Web");
List<Tema1.Student> studenti = new List<Tema1.Student>();
bool k = true;
while (k)
{
    Console.WriteLine("1. Adauga student\n2. Afiseaza lista studenti\n3. Exit\nRaspuns: ");
    int response = Convert.ToInt32(Console.ReadLine());
    switch (response)
    {
        case 1:
            Console.WriteLine("Nume: ");
            string Nume = Console.ReadLine();

            Console.WriteLine("Prenume: ");
            string Prenume = Console.ReadLine();

            Console.WriteLine("Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Data Nasterii: ");
            string st = Console.ReadLine();
            DateTime data = Convert.ToDateTime(st);

            List<Tema1.Materie> materii = new List<Tema1.Materie>();
            Console.WriteLine("Numarul de materii: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Numele cursului: ");
                string nume = Console.ReadLine();

                Console.WriteLine("Durata cursului: ");
                int durata = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Forma de examinare: ");
                string examinare = Console.ReadLine();

                Console.WriteLine("Data examinarii: ");
                DateTime dataExaminare = Convert.ToDateTime(Console.ReadLine());

                Tema1.Materie materie = new Tema1.Materie(nume, durata, examinare, dataExaminare);
                materii.Add(materie);
            }

            Tema1.Student student = new Tema1.Student()
            {
                Nume = Nume,
                Prenume = Prenume,
                Id = Id,
                DataNasterii = data,
                Materii = materii
            };
            studenti.Add(student);
            break;

        case 2:
            foreach(var s in studenti)
            {
                Console.WriteLine("Student: {0},{1},{2},{3}", s.Nume, s.Prenume, s.Id, s.DataNasterii);
                foreach(var s2 in s.Materii)
                {
                    Console.WriteLine("Curs: {0}\nDurata: {1}\nForma Examinare: {2}\nData Examinare: {3}", s2.Nume, s2.Durata, s2.FormaExaminare, s2.DataExaminarii);
                }
            }
            break;

        case 3:
            k = false;
            break;
    }
}