

using System;

List<Person> persons = new List<Person>();

StreamReader reader = new StreamReader(@"C:\Users\ALIREZA\Desktop\100 stu name and score.txt ");
while (!reader.EndOfStream)
{

    string line = reader.ReadLine();
    string[] fields = line.Split('#');
    Person newPerson = new Person();
    newPerson.FirstName = fields[0];
    newPerson.phishrafte1 = Convert.ToDouble(fields[2]);
    newPerson.tafsir = Convert.ToDouble(fields[3]);
    newPerson.karghah = Convert.ToDouble(fields[4]);
    newPerson.zaban = Convert.ToDouble(fields[5]);
    newPerson.phishrafte2 = Convert.ToDouble(fields[6]);
    newPerson.sheyghara = Convert.ToDouble(fields[7]);
    newPerson.varzesh = Convert.ToDouble(fields[8]);
    newPerson.os = Convert.ToDouble(fields[9]);
    newPerson.algoritm = Convert.ToDouble(fields[10]);



    persons.Add(newPerson);

}
foreach (Person p in persons)

{
    Console.WriteLine(p.TotalAverage());
    }
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double phishrafte1 { get; set; }
    public double tafsir { get; set; }
    public double ritazi { get; set; }
    public double karghah { get; set; }
    public double zaban { get; set; }
    public double phishrafte2 { get; set; }
    public double sheyghara { get; set; }
    public double varzesh { get; set; }
    public double os { get; set; }
    public double algoritm { get; set; }

    public double TotalAverage()
    {
        return (((phishrafte1 * 3) + (tafsir) + (ritazi * 2) + (karghah) + (zaban * 2) + (phishrafte2 * 3) + (sheyghara * 3) + (varzesh) + (os * 3) + (algoritm * 3)) / 22);
    }
}


 