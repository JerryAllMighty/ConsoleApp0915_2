using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915_2
{

    class Drama
    {
        public string title;

        private string maleActor = "";

        public string MaleActor
        {
            get { return MaleActor1; }
            set { MaleActor1 = value; }
            
        }

        //private string femaleActor;

        //public string FemaleActor
        //{
        //    get { return femaleActor; }
        //    set { femaleActor = value; }

        //}
        
        public string femaleActor { get; set; }
        public string MaleActor1 { get => maleActor; set => maleActor = value; }       // 람다식(화살표가 보이면 걍 람다식이다)
        public string MaleActor2 { get => maleActor; set => maleActor = value; }
    }
    class Class2
    {

        static void Main()
        {
            Drama d1 = new Drama();
            d1.title = "악의 꽃";
            d1.MaleActor = "이준기";
            d1.femaleActor = "문채원";
        }
    }
}
