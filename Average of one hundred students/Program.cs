using Average_of_one_hundred_students;
using System.Xml.Linq;

List<Student> students = new List<Student>();

StreamReader read = new StreamReader(@"C:\Users\Acer\Desktop\c#\Average of one hundred students\num.txt");

while (!read.EndOfStream)
{

    string line = read.ReadLine();
    Student student = new Student();
    student.Fname = line.Split(',')[0];
    student.Lname = line.Split(",")[0];
    student.pishrafte1 = Convert.ToDouble(line.Split(',')[1]);
    student.tafsir = Convert.ToDouble(line.Split(',')[2]);
    student.riazi = Convert.ToDouble(line.Split(',')[3]);
    student.kargah = Convert.ToDouble(line.Split(',')[4]);
    student.zaban = Convert.ToDouble(line.Split(',')[5]);
    student.pishrafte2 = Convert.ToDouble(line.Split(',')[6]);
    student.shay_garai = Convert.ToDouble(line.Split(',')[7]);
    student.tarbiat_badani = Convert.ToDouble(line.Split(',')[8]);
    student.system_amle = Convert.ToDouble(line.Split(',')[9]);
    student.Algorithm = Convert.ToDouble(line.Split(',')[10]);


    students.Add(student);

}
bool exit = false;
do
{
    Student student = new Student();

    student.write();
    int choice = Convert.ToInt32(Console.ReadLine());
    //1.kol moadel ha
    if (choice == 1)
    {
        foreach (var item in students)
        {
            student.list_kol(item.Fname, item.Lname, item.totalGPA(), item.omomi(), item.nime_takhasosi(), item.takhsosi());
            Console.WriteLine("=======================================================================");
        }

    }
    //2.moadel kol
    else if (choice == 2)
    {
        string[]fname=new string[100];
        string[] lname = new string[100];
        double[] kol = new double[100];
        int index = 0; // a counter for the arrays
        foreach (var item in students)
        {
            fname[index] = item.Fname;
            lname[index] = item.Lname;
            kol[index] = item.totalGPA();
            index++;
           
        }
        student.list(fname, lname, kol);
        
    }
    //3.moadel omomi
    else if (choice == 3)
    {
        string[] fname = new string[100];
        string[] lname = new string[100];
        double[] omomi = new double[100];
        int index = 0; // a counter for the arrays
        foreach (var item in students)
        {
            fname[index] = item.Fname;
            lname[index] = item.Lname;
            omomi[index] = item.omomi();
            index++;

        }
        student.list(fname, lname, omomi);
    }
    //4.moadel nime takhsosi
    else if (choice == 4)
    {
        string[] fname = new string[100];
        string[] lname = new string[100];
        double[] nime = new double[100];
        int index = 0; // a counter for the arrays
        foreach (var item in students)
        {
            fname[index] = item.Fname;
            lname[index] = item.Lname;
            nime[index] = item.nime_takhasosi();
            index++;

        }
        student.list(fname, lname, nime);
    }
    //5.moadel takhsosi
    else if (choice == 5)
    {
        string[] fname = new string[100];
        string[] lname = new string[100];
        double[] takhasosi = new double[100];
        int index = 0; // a counter for the arrays
        foreach (var item in students)
        {
            fname[index] = item.Fname;
            lname[index] = item.Lname;
            takhasosi[index] = item.takhsosi();
            index++;

        }
        student.list(fname, lname, takhasosi);
    }
    //6.grade daneshjo
    else if (choice == 6)
    {
        foreach (var item in students)
        {
            Console.WriteLine(item.Fname + "  " + item.Lname);
            Console.WriteLine("grad kol:  " + item.grade(item.totalGPA()));
            Console.WriteLine("grad omomi:  " + item.grade(item.omomi()));
            Console.WriteLine("grad nime takhsosi:  " + item.grade(item.nime_takhasosi()));
            Console.WriteLine("grad takhsosi:  " + item.grade(item.takhsosi()));
            Console.WriteLine("-------------------");
        }
    }
    else if (choice == 7)
    {
        foreach (var item in students)
        {
            item.adadaval(Convert.ToInt32(item.pishrafte1));
           
            item.adadaval(Convert.ToInt32(item.pishrafte2));
            item.adadaval(Convert.ToInt32(item.tarbiat_badani));
            item.adadaval(Convert.ToInt32(item.tafsir));
            item.adadaval(Convert.ToInt32(item.riazi));
            item.adadaval(Convert.ToInt32(item.shay_garai));
            item.adadaval(Convert.ToInt32(item.system_amle));
            item.adadaval(Convert.ToInt32(item.Algorithm));
            item.adadaval(Convert.ToInt32(item.zaban));
            item.adadaval(Convert.ToInt32(item.kargah));
        }
    }
    else if (choice == 8)
    {
        exit = true;
    }
} while (!exit);
