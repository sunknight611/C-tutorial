using System.Dynamic;
using Test;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test c = new Test();
            //Type t = c.GetType();
            //Type t = Type.GetType("Reflection.Test");

            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.Assembly);
            //Console.WriteLine(t.BaseType);

            //Console.WriteLine("---------------获取类中字段");
            //var fields = t.GetFields();

            //foreach(var temp in fields)
            //{
            //    Console.WriteLine(temp.Name);
            //}
            //Console.WriteLine("--------------获取类中属性");
            //var properties = t.GetProperties();
            //foreach(var temop in properties){
            //    Console.WriteLine(temop.Name);
            //}

            //Console.WriteLine("----------获取类中方法");
            //var methods = t.GetMethods();
            //foreach (var temp in methods)
            //{
            //    Console.WriteLine(temp.Name);
            //}

            //Console.WriteLine("----------获取类中成员");
            //var members = t.GetMembers();
            //foreach (var temp in members)
            //{
            //    Console.WriteLine(temp.Name);
            //}

            //Console.WriteLine("----------获取类中嵌套类");
            //var nesteds = t.GetNestedTypes();
            //foreach (var temp in nesteds)
            //{
            //    Console.WriteLine(temp.Name);
            //}

            //Console.WriteLine("----------获取类中构造函数");
            //var constructors = t.GetConstructors();
            //foreach (var temp in constructors)
            //{
            //    Console.WriteLine(temp.Name);
            //}

            TestParent test = SimpleClassFactory.CreateInstance();
            test.Test();
        }
    }

    public class SimpleClassFactory
    {
        public static TestParent CreateInstance()
        {
            //string ReflectionConfig = CustomConfigManager.GetConfig("ReflectionConfig");
            string ReflectionConfig = FileReader.Reader("ReflectionConfig.txt");
            string typeName = ReflectionConfig.Split(",")[0];
            string dllName = ReflectionConfig.Split(",")[1];

            Assembly assembly = Assembly.LoadFrom(dllName);
            Type type = assembly.GetType(typeName);

            object? oInstance = Activator.CreateInstance(type);

            TestParent test = oInstance as TestParent;

            return test;
        }
    }

    public static class CustomConfigManager
    {
        public static string GetConfig(string key)
        {   //默认读取  当前运行目录
            //var builder = new ConfigurationBuilder()
            //        .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            //        .AddJsonFile("appsettings.json", optional: false);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            if (builder != null)
            {
                Console.WriteLine("TRUE");
            }
            IConfigurationRoot configuration = builder.Build();
            string configValue = configuration.GetSection(key).Value;
            Console.WriteLine("config: "+configValue);
            return configValue;
        }
    }

    public class FileReader
    {
        public static string Reader(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string output = sr.ReadLine();
            Console.WriteLine(output);
            return output;
        }
    }
}