using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G26W07WFCardDealer
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e)
        {
            string[] suits = ["spades", "hearts", "diamonds", "clubs"];
            string[] values = ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"];

            Random random = new Random();
            HashSet<int> drawnCards = new HashSet<int>(); //ai가 만든 코드 중복방지용 체크리스트, 일반 리스트보다 처리 속도가 빠름

            Image RandomCard()
            {

                int card;
                do
                {
                    card = random.Next(suits.Length * values.Length);
                } while (drawnCards.Contains(card));//ai가 만든 코드, 중복방지 체크리스트와 겹치지 않는 카드가 나올때까지 돌린다

                drawnCards.Add(card);//결과 카드 저장

                string suit = suits[card / values.Length];
                string value = values[card % values.Length];

                if (value == "jack" || value == "queen" || value == "king")
                {
                    suit += "2";
                }

                return Properties.Resources
                    .ResourceManager
                    .GetObject($"{value}_of_{suit}")
                    as Image;
            }


            Card1.Image = RandomCard();
            Card2.Image = RandomCard();
            Card3.Image = RandomCard();
            Card4.Image = RandomCard();
            Card5.Image = RandomCard();

            Poker Rank = new Poker();
            string result = Rank.Judgment(drawnCards);

            RankText.Text = result;
        }

        private void RankText_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Poker
    {
        public string Judgment(HashSet<int> drawnCards)
        {
            List<int> numbers = new List<int>();
            List<int> emblem = new List<int>();
            foreach (int num in drawnCards)
            {
                numbers.Add(num % 13);
                emblem.Add(num / 13);
            }

            numbers.Sort(); //ai가 알려준 코드, numbers리스트 안의 숫자 5개가 오름차순 정렬
            
            //MessageBox.Show(string.Join(", ", numbers)); //테스트코드
            
            int FlushJudgement = 0; //0은 참 1은 거짓
            for (int i = 0; i < 4; i++)
            {
                if (emblem[i] != emblem[i + 1])
                {
                    FlushJudgement = 1;
                    break;
                }
            }
            //이 시점 FlushJudgment가 0이면 플러시 1이면 아님
            string Rank = "";
            if (FlushJudgement == 0)
            {
                //로티플, 스티플인지만 검사
                if (numbers[0] == 0 && numbers[1] == 9 && numbers[2] == 10 && numbers[3] == 11 && numbers[4] == 12
                    || numbers[0] == 0 && numbers[1] == 1 && numbers[2] == 2 && numbers[3] == 3 && numbers[4] == 4)
                {
                    //로티플, 백스티플 검사(무조건 리스트 0번이 0
                    if (numbers[4] == 12)
                    {
                        //로티플
                        Rank = "로열 스트레이트 플러시";
                    }
                    else
                    {
                        //백스티플
                        Rank = "백 스트레이트 플러시";
                    }
                }
                else
                {
                    Rank = "스트레이트 플러시";
                    for (int i = 0; i < 4; i++)
                    {
                        if (numbers[i] + 1 != numbers[i+1])
                        {
                            Rank = "플러시";
                            break;
                        }
                    }
                }
            }
            else
            {
                //숫자들로 검사
                if (numbers[0] == numbers[3] || numbers[1] == numbers[4])
                {
                    Rank = "포카드";
                }
                else if ((numbers[0] == numbers[2] && numbers[3] == numbers[4]) || (numbers[0] == numbers[1] && numbers[2] == numbers[4]))
                {
                    Rank = "풀하우스";
                }
                else if (numbers[0] == 0 && numbers[1] == 9 && numbers[2] == 10 && numbers[3] == 11 && numbers[4] == 12)
                {
                    Rank = "마운틴";
                }
                else if (numbers[0] == 0 && numbers[1] == 1 && numbers[2] == 2 && numbers[3] == 3 && numbers[4] == 4)
                {
                    Rank = "백스트레이트"; 
                }
                else if (numbers[0] + 1 == numbers[1] && numbers[1] + 1 == numbers[2] && numbers[2] + 1 == numbers[3] && numbers[3] + 1 == numbers[4])
                {
                    Rank = "스트레이트";
                }
                else if ((numbers[0] == numbers[2]) || (numbers[1] == numbers[3]) || (numbers[2] == numbers[4]))
                {
                    Rank = "트리플";
                }
                else if ((numbers[0] == numbers[1] && numbers[2] == numbers[3]) || (numbers[1] == numbers[2] && numbers[3] == numbers[4]) || (numbers[0] == numbers[1] && numbers[3] == numbers[4]))
                {
                    Rank = "투페어";
                }
                else if ((numbers[0] == numbers[1]) || (numbers[1] == numbers[2]) || (numbers[2] == numbers[3]) || (numbers[3] == numbers[4]))
                {
                    Rank = "원페어";
                }
                else
                {
                    Rank = "하이카드";
                }
            }
            return Rank;
        }
    }
}
