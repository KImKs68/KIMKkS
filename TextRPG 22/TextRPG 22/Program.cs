namespace TextRPG_22
{
    using System;
    using System.Globalization;


    namespace TextRPG
    {
        class Player
        {
            
            static string name = "전사";
            static int level = 1;
            static int attack = 10;
            static int armor = 5;
            static int health = 100;
            static int gold = 1500;

            static void Main(string[] args)
            {
                ShowMainMenu();


            }

            static void ShowMainMenu()
            {
                string choice = "";

                while (choice != "0")
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                    Console.WriteLine("이곳에서는 던전으로 가기 전 활동을 할 수 있습니다.");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("1. 상태창 보기");
                    Console.WriteLine("2. 인벤토리");
                    Console.WriteLine("3. 상점");
                    Console.WriteLine("4. 휴식하기");
                    Console.WriteLine("0. 게임 종료");
                    Console.WriteLine("----------------------------------");
                    Console.Write("원하는 선택을 입력해주세요\n>> ");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Stats();
                            break;
                        case "2":
                            Inventory();
                            break;
                        case "3":
                            Shop();
                            break;
                        case "4":
                            rest(); 
                            break;
                        case "0":
                            Console.WriteLine("\n게임을 종료합니다.");
                            break;
                        default:
                            Console.WriteLine("\n잘못된 입력입니다.");
                            Pause();
                            break;
                    }
                }
            }

            static void Stats()
            {
                Console.Clear();
                Console.WriteLine("[상태창 보기]");
                Console.WriteLine($"이름 : {name}");
                Console.WriteLine($"레벨 : {level}");
                Console.WriteLine($"공격력 : {attack} (+7)");
                Console.WriteLine($"방어력 : {armor} (+5)");
                Console.WriteLine($"체력 : {health}");
                Console.WriteLine($"재화 : {gold}g");
                Console.WriteLine("\n0. 나가기 ");
                Console.ReadLine(); 
            }

            static void Inventory()
            {
                Console.Clear();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("1.작창관리");
                Console.WriteLine("0. 나가기");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        EquipManagement();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("\n잘못된 입력입니다.");
                        Pause();
                        break;
                }
            }
            static void EquipManagement()
            {
                String input = "";

                while (input != "0")
                {
                    Console.Clear();
                    Console.WriteLine("[인벤토리 - 장착관리]");
                    Console.WriteLine("보유중인 아이템을 관리 할 수 있습니다.");
                    Console.WriteLine("\n아이템 목록");

                    Console.WriteLine("- 1 [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                    Console.WriteLine("- 2 [E]스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
                    Console.WriteLine("- 3 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
                    Console.WriteLine("\n 0. 나가기");
                    Console.WriteLine("\n>>");
                    input = Console.ReadLine();
                }
            }

            static void Shop()
            {
                Console.Clear();
                Console.WriteLine("[상점]");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("\n[보유골드]");
                Console.WriteLine("800G");
                Console.WriteLine("\n[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
                Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
                Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
                Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
                Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
                Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");

                Console.WriteLine("\n1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.Write("\n 원하는 선택을 입력해주세요");
                Console.ReadLine();

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        BuyItem(); 
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Pause();
                        break;

                }

            }

            static void BuyItem()
            {
                String choice = "";
                while (choice != "0")
                {
                    Console.Clear();
                    Console.WriteLine("[아이템목록]");
                    Console.WriteLine("-1. 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
                    Console.WriteLine("-2. 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
                    Console.WriteLine("-3. 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
                    Console.WriteLine("-4. 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
                    Console.WriteLine("-5. 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
                    Console.WriteLine("-6. 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
                    Console.WriteLine("\n 0. 나가기");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("골드가 부족합니다.");
                            break;
                        case "2":
                            Console.WriteLine("이미 구매한 아이템입니다.");
                            break;
                            case "3":
                            Console.WriteLine("골드가 부족합니다.");
                            break;
                            case "4":
                            if(gold >= 600)
                            {
                                gold = 600;
                                Console.WriteLine("구매완료");
                            }
                            else
                            {
                                Console.WriteLine("골드가 부족합니다.");
                            }
                            break;
                            case "5":
                            Console.WriteLine("골드가 부족합니다");
                            break;
                            case "6":
                            Console.WriteLine("이미 구매한 아이템입니다.");
                            break;
                            case "0":
                            break;
                            default:
                            Console.WriteLine("잘못된 입력입니다.");
                            break;
                    }
                    Pause();
                }
            }
            static void  rest()
            {
                string choice;
                Console.Clear();
                Console.WriteLine("휴식하기");
                Console.WriteLine("500G 를 내면 체력을 회복할 수 있습니다. (보유골드 : 500G)");
                Console.WriteLine("\n1. 휴식하기");
                Console.WriteLine("0. 나가기");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        if(gold >= 500)
                        {
                            gold = 500;
                            Console.WriteLine("휴식을 완료했습니다.");
                        }
                        else
                        {
                            Console.WriteLine("골드가 부족합니다.");
                        }
                        break;
                        case "0":
                        break;
                        default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
                Pause();
            }
            static void Pause()
            {
                Console.WriteLine("\n계속하려면 아무 키나 누르세요...");
                Console.ReadKey();
            }
        }
    }
}
