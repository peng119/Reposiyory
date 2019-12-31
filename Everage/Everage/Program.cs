using System;
using System.Collections.Generic;
using System.Linq;
using CDS000.Common;

namespace Everage
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var totalDays = 0;  // 所有人员的全部天数
            var now = DateTime.Now;
            foreach (var item in PersonRepository.InitialPersonCollection())
            {
                totalDays = totalDays + Math.Abs(((TimeSpan)(now - item.Birthday)).Days);
            }

            var ageTotaldays = totalDays / PersonRepository.InitialPersonCollection().Count();
            var ageYears = ageTotaldays / 365;
            var ageDays = ageTotaldays - ageYears * 365;
            Console.WriteLine("平均年龄：" + ageYears + "周岁" + " - " + ageDays + "天");
            Console.ReadKey();



            NameCount(PersonRepository.InitialPersonCollection());

        }

        public static void NameCount(List<Person> people)
        {

            var a = from i in people
                    where !i.Name.Contains("欧阳")
                    group i by i.Name.Substring(0, 1) into s
                    select new { s.Key, sum= s.Count() };
            var b = from i in people
                    where i.Name.Contains("欧阳")
                    group i by i.Name.Substring(0, 2) into s
                    select new { s.Key, sum = s.Count() };
            foreach (var item in a)
            {
                Console.WriteLine("姓氏：{0} {1}", item.Key, item.sum);
            }
            foreach (var item in b)
            {
                Console.WriteLine("姓氏：{0} {1}", item.Key, item.sum);
            }
        }
    }

}
