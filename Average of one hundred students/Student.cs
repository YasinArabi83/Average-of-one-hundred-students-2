namespace Average_of_one_hundred_students
{
    class Student
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double pishrafte1 { get; set; }
        public double tafsir { get; set; }
        public double riazi { get; set; }
        public double kargah { get; set; }
        public double zaban { get; set; }
        public double pishrafte2 { get; set; }
        public double shay_garai { get; set; }
        public double tarbiat_badani { get; set; }
        public double system_amle { get; set; }
        public double Algorithm { get; set; }

        public double totalGPA()
        {

            double result = ((pishrafte1 * 3) + (tafsir * 1) + (riazi * 2) + (kargah * 1) + (zaban * 2) + (pishrafte2 * 3) + (shay_garai * 3) + (tarbiat_badani * 1) + (system_amle * 3) + (Algorithm * 3))
                 / 22;
            return result;

        }
        public double takhsosi()
        {
            double result = ((pishrafte1 * 3) + (pishrafte2 * 3) + (shay_garai * 3)) / 9;
            return result;
        }
        public double nime_takhasosi()
        {
            double result = ((system_amle * 3) + (Algorithm * 3)) / 6;
            return result;
        }
        public double omomi()
        {
            double rerult = ((tafsir * 1) + (riazi * 2) + (kargah * 1) + (zaban * 2) + (tarbiat_badani * 1)) / 7;
            return rerult;
        }

        public void write()
        {
            Console.WriteLine("Choose one of the following(enter number):");
            Console.WriteLine("1.kol moadel ha");
            Console.WriteLine("2.moadel kol");
            Console.WriteLine("3.moadel omomi");
            Console.WriteLine("4.moadel nime takhsosi");
            Console.WriteLine("5.moadel takhsosi");
            Console.WriteLine("6.grade daneshjo");
            Console.WriteLine("7.adad aval nomarat");
            Console.WriteLine("8.exit");
        }

        public int read()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public void list_kol(string fname, string lname, double x1, double x2, double x3, double x4)
        {
            List<(string, string, double, double, double, double)> ScoreList = new List<(string, string, double, double, double, double)>();


            ScoreList.Add((fname, lname, x1, x2, x3, x4));


            foreach (var tuple in ScoreList)
            {
                Console.WriteLine(tuple.Item1 + "  " + tuple.Item2 + ": ");
                Console.WriteLine("kol : " + tuple.Item3.ToString("F2") + " | " + "omomi  " + tuple.Item4.ToString("F2") + " | " + "nime takhsosi  " + tuple.Item5.ToString("F2") + " | " + "takhasosi  " + tuple.Item6.ToString("F2"));
            }
        }
        List<(string, string, double)> moadel = new List<(string, string, double)>();
        public void list(string[] fname, string[] lname, double[] gpa)
        {


            for (int i = 0; i < fname.Length; i++)
            {
                moadel.Add((fname[i], lname[i], gpa[i]));
            }

            moadel.Sort((x, y) => x.Item3.CompareTo(y.Item3));
            foreach (var tuple in moadel)
            {
                Console.WriteLine(tuple.Item1 + " " + tuple.Item2);
                Console.WriteLine("moadl:  " + tuple.Item3.ToString("F2"));
                Console.WriteLine("-----------------------");
            }
        }
        public void adadaval(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {

                if (num % i == 0)
                {
                    sum++;
                }

            }
            if (sum < 2 && num > 1)
                Console.WriteLine(num);
        }

        public string grade(double gpa)
        {
            switch (gpa)
            {
                case double n when (n >= 17 && n <= 20):
                    return "A";
                    break;
                case double n when (n >= 15 && n < 17):
                    return "B";
                    break;
                case double n when (n >= 13 && n < 15):
                    return "C";
                    break;
                case double n when (n >= 10 && n < 13):
                    return "D";
                    break;
                case double n when (n >= 7 && n < 10):
                    return "E";
                    break;
                case double n when (n >= 3 && n < 7):
                    return "F";
                    break;
                case double n when (n >= 0 && n < 3):
                    return "G";
                    break;
                default: return "out of rang";

            }
        }
    }
}

