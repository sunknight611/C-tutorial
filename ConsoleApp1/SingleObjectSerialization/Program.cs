using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SingleObjectSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeStudent stu = new CollegeStudent();
            SerializeObj("test.dat", stu);

            string input;
            input = Console.ReadLine();
            if (input == "de")
            {
                CollegeStudent Stu = DeserializeObj("test.dat");
                Console.WriteLine(Stu.Name);
                Console.WriteLine(Stu.ScoreForExamination);
            }
            
        }

        private static void SerializeObj(string FileName,CollegeStudent stu)
        {   //相当于调用IDisposable.Dispose，显式地释放非托管资源
            using (FileStream writer = new FileStream(FileName, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer, stu);
                Console.WriteLine("成功保存文件");
            }
        }

        private static CollegeStudent DeserializeObj(string FileName)
        {
            using(FileStream reader = new FileStream(FileName, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                return (CollegeStudent)formatter.Deserialize(reader);  
            }
        }
    }

    [Serializable]
    class CollegeStudent
    {
        public String Name = "空";
        public bool IsMale = true;
        public int ScoreForExamination = 0;
    }
}