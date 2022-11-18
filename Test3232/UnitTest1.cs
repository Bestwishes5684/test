using FluentAssertions;
using Library;


namespace Test
{
    public class UnitTest1 {

        public void AddButton()
        {
            ipdz SCL = new();
            var result = SCL.Get();
            Student test1 = new()
            {
                FullName = "Рома",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 100,
                Math = 100,
                Russ = 100,
                total = 300
            };
            SCL.Add(test1);
            test1.FullName.Should().Be("Рома");


            Student test4 = new()
            {
                FullName = "Гена",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 50,
                Math = 10,
                Russ = 50,
                total = 110
            };
            test4.FullName.Should().Be("Лёша");
            test4.total.Should().Be(test4.inf + test4.Russ + test4.Math);
        }

        [Fact]
        public void ChangeButton()
        {
            ipdz SCL = new();
            var result = SCL.Get();
            Student test = new()
            {
                FullName = "Лёша",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 40,
                Math = 60,
                Russ = 70,
                total = 170
            };
            SCL.Add(test);
            test.FullName.Should().Be("Лёша");
            test.total.Should().Be(test.inf + test.Russ + test.Math);


            Student test2 = new()
            {
                FullName = "Гена",
                Datarod = DateTime.Now.ToString("d"),
                Gender = Gender.Male.ToString("d"),
                FormOB = FormOB.fulltime.ToString("d"),
                inf = 50,
                Math = 10,
                Russ = 50,
                total = 110
            };
                 test2.total.Should().Be(test2.inf+test2.Russ+test2.Math);
                test2.FullName.Should().Be("Гена");

        }
            [Fact]
                public void DeleteButton()
            {
                ipdz SCL = new();
                var result = SCL.Get();
                Student test1 = new()
                {
                    FullName = "Никита",
                    Datarod = DateTime.Now.ToString("d"),
                    Gender = Gender.Male.ToString("d"),
                    FormOB = FormOB.fulltime.ToString("d"),
                    inf = 50,
                    Math = 50,
                    Russ = 50,
                    total = 150
                };
                         test1.FullName.Should().Be("Никита");
                        test1.total.Should().Be(test1.inf + test1.Russ + test1.Math);
                    SCL.Add(test1);
                 SCL.Remove(test1);
                    Assert.Empty(result);
            }

       
    } 
}
