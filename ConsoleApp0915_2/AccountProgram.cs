using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915_2
{
    class AccountManager
    {
        BankAccount account ;


        public void PrintMenu()         //계좌관리프로그램 메뉴
        {
            Console.WriteLine("\n---Menu--------");
            Console.WriteLine("1.계좌 개설");
            Console.WriteLine("2.입금");
            Console.WriteLine("3.출금");
            Console.WriteLine("4.잔액조회");
            Console.WriteLine("5.프로그램 종료");
        }

        public void MakeAccount()  //1.계좌 개설
        {
            
            Console.WriteLine("계좌번호:");
            string accNum = Console.ReadLine();
            Console.WriteLine("예금주명");
            string accName = Console.ReadLine();


            account = new BankAccount(accNum,accName);
        }

        bool Checkaccount()         //내부에서만 쓸 거면 프라이빗으로 하는 것이 좋다
        {
            if (account == null)
            {
                Console.WriteLine("계좌개설을 먼저 해주세요.");
                return false;
            }
            else 
            {
                return true;
            }
        }

        public void Deposit()  //2.입금
        {

            if (Checkaccount() == false) return;     //같은 클래스 내의 함수는 이름만 불러주어도 호출이 가능하다. 스태틱이면 클래스명을 붙여주어야 한다

            Console.WriteLine("입금하실 금액은?:");
            int money = int.Parse(Console.ReadLine());      //지역변수는 접근제한자 ㄴㄴ해
            account.InputMoney(money);
        }

        public void GetMoneyOut()  //3.출금
        {
            if (Checkaccount() == false) return;

            Console.WriteLine("출금하실 금액은? 수수료는 500원입니다.:");
            int money = int.Parse(Console.ReadLine());
            account.OutputMoney(money);
        }

        public void SearchBalance()  //4.잔액조회
        {

        }
        public void SearchProgram()  //5.프로그램조회
        {

        }
    }
    class AccountProgram
    {
        static void Main()
        {
            AccountManager manager = new AccountManager();
            Console.WriteLine(manager.ToString());

            int choice;

            while (true)
            {
                manager.PrintMenu();
                Console.WriteLine("선택 : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        manager.MakeAccount(); break;
                    case 2:
                        manager.Deposit(); break;
                    case 3: break;
                    case 4: break;
                    case 5: return;      //return은 메서드를 나가겠다는 뜻, 프로그램의 제어권을 호출한 쪽으로 넘기겠다는 뜻
                    default:
                        Console.WriteLine("다시 선택하세요"); break;
                }
            }

        }
    }
}
