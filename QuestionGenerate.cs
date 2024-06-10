using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 44);

            if (questionNumber == 1)
            {
          
                QuestionDisplay.newQuestion = "승용자동차의 운전자가 보도를 횡단하는 방법을 위반한 경우 벌칙금은?";
                QuestionDisplay.newA = "3만원";
                QuestionDisplay.newB = "4만원";
                QuestionDisplay.newC = "5만원";
                QuestionDisplay.newD = "6만원";
                actualAnswer = "D";
            }
            if (questionNumber == 2)
            {
            
                QuestionDisplay.newQuestion = "운전자가 진행방향 신호등이 적색일 때 정지선을 초과하여 정지한 경우 처벌 기준은?";
                QuestionDisplay.newA = "교차로 통행방법 위반";
                QuestionDisplay.newB = "일시정지 위반";
                QuestionDisplay.newC = "신호위반";
                QuestionDisplay.newD = "서행위반";
                actualAnswer = "C";

            }
            if (questionNumber == 3)
            {
           
                QuestionDisplay.newQuestion = "긴급자동차가 운전하는 사람을 대상으로 실시하는 정기 교통안전교육은(  )년마다 받아야한다. (  )안에 맞는 것은?";
                QuestionDisplay.newA = "1";
                QuestionDisplay.newB = "2";
                QuestionDisplay.newC = "3";
                QuestionDisplay.newD = "5";
                actualAnswer = "B";

            }
            if (questionNumber == 4)
            {
         
                QuestionDisplay.newQuestion = "승용차 운전자가 13:00경 어린이 보호구역에서 신호위반 한 경우 범칙금은?";
                QuestionDisplay.newA = "5만원";
                QuestionDisplay.newB = "7만원";
                QuestionDisplay.newC = "12만원";
                QuestionDisplay.newD = "15만원";
                actualAnswer = "C";

            }
            if (questionNumber == 5)
            {
              
                QuestionDisplay.newQuestion = "자동차 운전자가 난폭운전으로 형사입건되었다. 운전면허 행정처분은?";
                QuestionDisplay.newA = "면허취소";
                QuestionDisplay.newB = "면허 정지 100일";
                QuestionDisplay.newC = "면허 정지 60일";
                QuestionDisplay.newD = "면허 정지 40일";
                actualAnswer = "D";

            }
            if (questionNumber == 6)
            {

                QuestionDisplay.newQuestion = "도로교통법렬상 운전면허 취소처분에 대한 이의가 있는 겨우, 운전면허행정처분 이의심의위원회에 신청할 수 있는 기간은?";
                QuestionDisplay.newA = "그 처분을 받은 날로부터 90일 이내";
                QuestionDisplay.newB = "그 처분을 안 날로부터 90일 이내";
                QuestionDisplay.newC = "그 처분을 받은 날로부터 60일 이내";
                QuestionDisplay.newD = "그 처분을 안날로부터 60일 이내";
                actualAnswer = "C";

            }
            if (questionNumber == 7)
            {

                QuestionDisplay.newQuestion = "교차로*횡단보도*건널목이나 보도와 차도가 구분된 도로의 보도에 2시간 이상 주차한 승용차자동차의 소유자에게 부과되는 과태료 금액은?";
                QuestionDisplay.newA = "4만원";
                QuestionDisplay.newB = "5만원";
                QuestionDisplay.newC = "6만원";
                QuestionDisplay.newD = "7만원";
                actualAnswer = "B";

            }
            if (questionNumber == 8)
            {

                QuestionDisplay.newQuestion = "도로에서 자동차 운전자가 물적 피해 교통사고를 일으킨 후 조치 등 불이행에 따른 벌점기준은?";
                QuestionDisplay.newA = "15점";
                QuestionDisplay.newB = "20점";
                QuestionDisplay.newC = "30점";
                QuestionDisplay.newD = "40점";
                actualAnswer = "A";

            }
            if (questionNumber == 9)
            {

                QuestionDisplay.newQuestion = "도로교통법상 운행기록계를 설치하지 않은 견인형 특수자동차를 운전한 경우 운전자 처벌 규정은?";
                QuestionDisplay.newA = "과태료10만원";
                QuestionDisplay.newB = "범칙금 10만원";
                QuestionDisplay.newC = "과태료 7만원";
                QuestionDisplay.newD = "범칙금 7만원";
                actualAnswer = "D";

            }
            if (questionNumber == 10)
            {

                QuestionDisplay.newQuestion = "자동차관리법상 유형별로 구분한 특수자동차에 해당하지 않는 것은?";
                QuestionDisplay.newA = "견인형";
                QuestionDisplay.newB = "구난형";
                QuestionDisplay.newC = "일반형";
                QuestionDisplay.newD = "특수용도형";
                actualAnswer = "C";

            }
            if (questionNumber == 11)
            {

                QuestionDisplay.newQuestion = "교통사고 발생 현장에 도착한 구난차 운전자가 부상자에게 응급조치를 해야 하는 이유로 가장 거리가 먼 것은?";
                QuestionDisplay.newA = "부상자의 빠른 호송을 위하여";
                QuestionDisplay.newB = "부상자의 고통을 줄여주기 위하여";
                QuestionDisplay.newC = "부상자의 재산을 보호하기 위하여";
                QuestionDisplay.newD = "부상자의 구명률을 높이기 위하여";
                actualAnswer = "C";

            }
            if (questionNumber == 12)
            {

                QuestionDisplay.newQuestion = "교차로를 통과하던 중 차량신호가 녹색에서 황색으로 변경된 경우 가장 안전한 운전 방법은?";
                QuestionDisplay.newA = "교차로 밖으로 신속하게 빠져나가야 한다";
                QuestionDisplay.newB = "즉시 정지하여야한다";
                QuestionDisplay.newC = "서행하면서 진행하여야 한다";
                QuestionDisplay.newD = "일시정지 후 진행하여야한다";
                actualAnswer = "A";

            }
            if (questionNumber == 13)
            {

                QuestionDisplay.newQuestion = "총중량 1.5톤 피견인 승용자동차를 4.5톤 화물자동차로 견인하는 경우 필요한 운전면허에 해당하지 않은 것은?";
                QuestionDisplay.newA = "제1종 대형먼허 및 소형견인차면허";
                QuestionDisplay.newB = "제1종 보통면허 및 대형견인차면허";
                QuestionDisplay.newC = "제1종 보통면허 및 소형견인차면허";
                QuestionDisplay.newD = "제2종 보통면허 및 대형견인차면허";
                actualAnswer = "D";

            }
            if (questionNumber == 14)
            {

                QuestionDisplay.newQuestion = "도로교통법령상 운전면허 발급에 대한 설명으로 옳지 않은 것은?";
                QuestionDisplay.newA = "운전면허시험 합격일로부터 30일 이내에 운전면허증을 발급받아야 한다";
                QuestionDisplay.newB = "영문운전면허증을 발급받을 수 있다";
                QuestionDisplay.newC = "모바일운전면허증을 발급받을 수 있다";
                QuestionDisplay.newD = "운전면허증을 잃어버린 경우에는 재발급 받을 수 있다";
                actualAnswer = "B";

            }
            if (questionNumber == 15)
            {

                QuestionDisplay.newQuestion = "시*도경찰청장이 발급한 국제운전면허증의 유효기간은 발급받은 날부터 몇 년인가?";
                QuestionDisplay.newA = "1년";
                QuestionDisplay.newB = "2년";
                QuestionDisplay.newC = "3년";
                QuestionDisplay.newD = "4년";
                actualAnswer = "A";

            }
            if (questionNumber == 16)
            {

                QuestionDisplay.newQuestion = "도로교통법상 승차정원 15인승의 긴급 승합자동차를 처음 운전하려고 할 때 필요한 조건으로 맞는 것은?";
                QuestionDisplay.newA = "제1종 보통면허,교통안전교육 3시간";
                QuestionDisplay.newB = "제1종 특수면허(대형견인차), 교통안전교육 2시간";
                QuestionDisplay.newC = "제1종 특수면허(구난차), 교통안전교육 2시간";
                QuestionDisplay.newD = "제2종 보통면허, 교통안전교육 3시간";
                actualAnswer = "A";

            }
            if (questionNumber == 17)
            {

                QuestionDisplay.newQuestion = "도로교통법상 연습운전면허의 유효기간은?";
                QuestionDisplay.newA = "받은 날부터 6개원";
                QuestionDisplay.newB = "받은 날부터 1년";
                QuestionDisplay.newC = "받은 날부터 2년";
                QuestionDisplay.newD = "받은 날부터 3년";
                actualAnswer = "B";

            }
            if (questionNumber == 18)
            {

                QuestionDisplay.newQuestion = "도로교통법상 운전면허의 조건 부과기준 중 운전면허 기재방법으로 바르지 않는 것은?";
                QuestionDisplay.newA = "A: 수동변속기";
                QuestionDisplay.newB = "E: 청각장애인 표지 및 볼록거울";
                QuestionDisplay.newC = "G: 특수제작 및 승인차";
                QuestionDisplay.newD = "H: 우측 방향지시기";
                actualAnswer = "A";

            }
            if (questionNumber == 19)
            {

                QuestionDisplay.newQuestion = "승차정원이 11명인 승합자동차로 총중량 780킬로그램의 피견인자동차를 견인하고자 한다. 운전자가 취득해야하는 운전면허의 종류는?";
                QuestionDisplay.newA = "제1종 보통면허 및 소형견인차면허";
                QuestionDisplay.newB = "제2종 보통면허 및 제1종 소형견인차면허";
                QuestionDisplay.newC = "제1종 보통면허 및 구난차면허";
                QuestionDisplay.newD = "제2종 보통면허 및 제1종 구난차면허";
                actualAnswer = "A";

            }
            if (questionNumber == 20)
            {

                QuestionDisplay.newQuestion = "승차정원이 12명인 승합자동차를 도로에서 운전하려고 한다. 운전자가 취득해야하는 운전면허의 종류는?";
                QuestionDisplay.newA = "제1종 대형견인차면허";
                QuestionDisplay.newB = "제1종 구난차면허";
                QuestionDisplay.newC = "제1종 보통면허";
                QuestionDisplay.newD = "제2종 보통면허";
                actualAnswer = "C";

            }
            if (questionNumber == 21)
            {

                QuestionDisplay.newQuestion = "다음 중 제2종 보통면허를 취득할 수 있는 사람은?";
                QuestionDisplay.newA = "한쪽 눈은 보지 못하나 다른 쪽 눈의 시력이 0.5인 사람";
                QuestionDisplay.newB = "붉은색, 녹색, 노란색의 색채 식별이 불가능한 사람";
                QuestionDisplay.newC = "17세인 사람";
                QuestionDisplay.newD = "듣지 못하는 사람";
                actualAnswer = "D";

            }
            if (questionNumber == 22)
            {

                QuestionDisplay.newQuestion = "다음 중 도로교통법상 원동기장치자전거의 정의(기준)에 대한 설명으로 옳은 것은?";
                QuestionDisplay.newA = "배기량 50시시 이하 - 최고정격출력 0.59킬로와트 이하";
                QuestionDisplay.newB = "배기량 50시시 이하 - 최고정격출력 0.59킬로와트 이하";
                QuestionDisplay.newC = "배기량 125시시 이하 - 최고정격출력 11킬로와트 이하";
                QuestionDisplay.newD = "배기량 125시시 미만 - 최고정격출력 11킬로와트 미만";
                actualAnswer = "C";

            }
            if (questionNumber == 23)
            {

                QuestionDisplay.newQuestion = " 거짓 그밖에 부정한 수단으로 운전면허를 받아 벌금이상의 형이 확정된 경우 얼마동안 운전면허를 취득할 수 없는가?\r\n";
                QuestionDisplay.newA = "취소일로부터 1년";
                QuestionDisplay.newB = "취소일로부터 2년";
                QuestionDisplay.newC = "취소일로부터 3년";
                QuestionDisplay.newD = "취소일로부터 4년";
                actualAnswer = "A";

            }
            if (questionNumber == 24)
            {

                QuestionDisplay.newQuestion = "원동기 장치자전거 중 개인형 이동장치의 정의에 대한 설명으로 바르지 않은 것은?";
                QuestionDisplay.newA = "오르막 각도가 25도 미만이어야 한다";
                QuestionDisplay.newB = "차체 중량이 30킬로그램 미만이어야 한다";
                QuestionDisplay.newC = "자전거등이란 자전거와 개인형 이동장치를 말한다";
                QuestionDisplay.newD = "시속 25킬로미터 이상으로 운행할 경우 전동기가 작동하지 않아야 한다";
                actualAnswer = "A";

            }
            if (questionNumber == 25)
            {

                QuestionDisplay.newQuestion = "다음 중 도로교통법상 제1종 대형면허 시험에 응시할 수 있는 기준은? (이륜자동차 운전경력은 제외)";
                QuestionDisplay.newA = "자동차의 운전경력이 6개월 이상이면서 18세인 사람";
                QuestionDisplay.newB = "자동차의 운전경력이 1년 이상이면서 18세인 사람";
                QuestionDisplay.newC = "자동차의 운전경력이 6개월 이상이면서 19세인 사람";
                QuestionDisplay.newD = "자동차의 운전경력이 1년 이상이면서 19세인 사람";
                actualAnswer = "D";

            }
            if (questionNumber == 26)
            {

                QuestionDisplay.newQuestion = "도로교통법상 원동기장치자전거는 전기를 동력으로 하는 경우에는 최고정격출력 ( )이하의 이륜자동차 이다. ( )에 기준으로 맞는 것은?";
                QuestionDisplay.newA = "11킬로와트";
                QuestionDisplay.newB = "9킬로와트";
                QuestionDisplay.newC = "5킬로와트";
                QuestionDisplay.newD = "0.59킬로와트";
                actualAnswer = "A";

            }
            if (questionNumber == 27)
            {

                QuestionDisplay.newQuestion = "개인형 이동장치의 기준에 대한 설명이다. 바르게 설명된 것은 ?\r\n";
                QuestionDisplay.newA = "원동기를 단 차 중 시속 20킬로미터 이상으로 운행할 경우 전동기가 작동하지 아니하여야 한다";
                QuestionDisplay.newB = "최고 정격출력 11킬로와트 이하의 원동기를 단 차로 전기자전거를 포함한다";
                QuestionDisplay.newC = "최고 정격출력 11킬로와트 이하의 원동기를 단 차로 차체 중량이 35킬로그램 미만인 것을 말한다";
                QuestionDisplay.newD = "차체 중량은 30킬로그램 미만이어야 한다";
                actualAnswer = "D";

            }
            if (questionNumber == 28)
            {

                QuestionDisplay.newQuestion = " 다음 중 도로교통법령상에서 규정하고 있는 \"연석선\" 정의로 맞는 것은?";
                QuestionDisplay.newA = "차마의 통행방향을 명확하게 구분하기 위한 선";
                QuestionDisplay.newB = "자동차가 한 줄로 도로의 정하여진 부분을 통행하도록 한 선";
                QuestionDisplay.newC = "차도와 보도를 구분하는 돌 등으로 이어진 선";
                QuestionDisplay.newD = "차로와 차로를 구분하기 위한 선";
                actualAnswer = "C";

            }
            if (questionNumber == 29)
            {

                QuestionDisplay.newQuestion = "도로교통법상 개인형 이동장치와 관련된 내용으로 맞는 것은?";
                QuestionDisplay.newA = "승차정원을 초과하여 운전할 수 있다";
                QuestionDisplay.newB = "운전면허를 반납한 65세 이상인 사람이 운전할 수 있다";
                QuestionDisplay.newC = "13세 이상인 사람이 운전면허 취득 없이 운전할 수 있다";
                QuestionDisplay.newD = "횡단보도에서 개인형 이동장치를 끌거나 들고 횡단할 수 있다";
                actualAnswer = "D";

            }
            if (questionNumber == 30)
            {

                QuestionDisplay.newQuestion = "도로교통법령상 고령자 면허 갱신 및 적성검사의 주기가 3년인 사람의 연령 기준으로 맞는 것은?";
                QuestionDisplay.newA = "65세 이상";
                QuestionDisplay.newB = "70세 이상";
                QuestionDisplay.newC = "75세 이상";
                QuestionDisplay.newD = "80세 이상";
                actualAnswer = "C";

            }
            if (questionNumber == 31)
            {

                QuestionDisplay.newQuestion = " 다음 중 수소대형승합자동차(승차정원 35인승 이상)를 신규로 운전하려는 운전자에 대한 특별교육을 실시하는 기관은? ";
                QuestionDisplay.newA = "한국가스안전공사";
                QuestionDisplay.newB = "한국산업안전공단";
                QuestionDisplay.newC = "한국도로교통공단";
                QuestionDisplay.newD = "한국도로공사";
                actualAnswer = "A";

            }
            if (questionNumber == 32)
            {

                QuestionDisplay.newQuestion = "제1종 운전면허를 발급받은 65세 이상 75세 미만인 사람(한쪽 눈만 보지 못하는 사람은 제외)은 몇 년마다 정기적성검사를 받아야 하나?";
                QuestionDisplay.newA = "3년마다";
                QuestionDisplay.newB = "5년마다";
                QuestionDisplay.newC = "10년마다";
                QuestionDisplay.newD = "15년마다";
                actualAnswer = "B";

            }
            if (questionNumber == 33)
            {

                QuestionDisplay.newQuestion = "다음 중 도로교통법령상 영문운전면허증을 발급 받을 수 없는 사람은?";
                QuestionDisplay.newA = "운전면허시험에 합격하여 운전면허증을 신청하는 경우";
                QuestionDisplay.newB = "운전면허 적성검사에 합격하여 운전면허증을 신청하는 경우";
                QuestionDisplay.newC = "외국면허증을 국내면허증으로 교환 발급 신청하는 경우";
                QuestionDisplay.newD = "연습운전면허증으로 신청하는 경우";
                actualAnswer = "D";

            }
            if (questionNumber == 34)
            {

                QuestionDisplay.newQuestion = "도로교통법령상 제2종 보통면허로 운전할 수 없는 차는?";
                QuestionDisplay.newA = "구난자동차";
                QuestionDisplay.newB = "승차정원 10인 미만의 승합자동차";
                QuestionDisplay.newC = "승용자동차";
                QuestionDisplay.newD = "적재중량 2.5톤의 화물자동차";
                actualAnswer = "A";

            }
            if (questionNumber == 35)
            {

                QuestionDisplay.newQuestion = "다음 중 도로교통법령상 운전면허증 갱신발급이나 정기 적성검사의 연기 사유가 아닌 것은?";
                QuestionDisplay.newA = "해외 체류 중인 경우";
                QuestionDisplay.newB = "질병으로 인하여 거동이 불가능한 경우";
                QuestionDisplay.newC = "군인사법에 따른 육․해․공군 부사관 이상의 간부로 복무중인 경우";
                QuestionDisplay.newD = "재해 또는 재난을 당한 경우";
                actualAnswer = "C";

            }
            if (questionNumber == 36)
            {

                QuestionDisplay.newQuestion = " 다음 수소자동차 운전자 중 고압가스관리법령상 특별교육 대상으로 맞는 것은?";
                QuestionDisplay.newA = "수소승용자동차 운전자";
                QuestionDisplay.newB = "수소대형승합자동차(승차정원 36인승 이상) 운전자";
                QuestionDisplay.newC = "수소화물자동차 운전자";
                QuestionDisplay.newD = "수소특수자동차 운전자";
                actualAnswer = "B";

            }
            if (questionNumber == 37)
            {

                QuestionDisplay.newQuestion = "다음 타이어 특성 중 자동차 에너지 소비효율에 가장 큰 영향을 주는 것은 무엇인가?";
                QuestionDisplay.newA = "노면 제동력";
                QuestionDisplay.newB = "내마모성";
                QuestionDisplay.newC = "회전저항";
                QuestionDisplay.newD = "노면 접지력";
                actualAnswer = "C";

            }
            if (questionNumber == 38)
            {

                QuestionDisplay.newQuestion = "운전자가 가짜 석유제품임을 알면서 차량 연료로 사용할 경우 처벌기준은?";
                QuestionDisplay.newA = "과태료 5만 원 ∼ 10만 원";
                QuestionDisplay.newB = "과태료 50만 원 ∼ 1백만 원";
                QuestionDisplay.newC = "과태료 2백만 원 ∼ 2천만 원";
                QuestionDisplay.newD = "처벌되지 않는다";
                actualAnswer = "C";

            }
            if (questionNumber == 39)
            {

                QuestionDisplay.newQuestion = "일반적으로 무보수(MF：Maintenance Free)배터리 수명이 다한 경우, 점검창에 나타나는 색깔은?";
                QuestionDisplay.newA = "황색";
                QuestionDisplay.newB = "백색";
                QuestionDisplay.newC = "검은색";
                QuestionDisplay.newD = "녹색";
                actualAnswer = "B";

            }
            if (questionNumber == 40)
            {

                QuestionDisplay.newQuestion = "수소가스 누출을 확인할 수 있는 방법이 아닌 것은? ";
                QuestionDisplay.newA = "가연성 가스검지기 활용 측정";
                QuestionDisplay.newB = "비눗물을 통한 확인";
                QuestionDisplay.newC = "가스 냄새를 맡아 확인";
                QuestionDisplay.newD = "수소검지기로 확인";
                actualAnswer = "C";

            }
            if (questionNumber == 41)
            {

                QuestionDisplay.newQuestion = "다음 중 수소차량에서 누출을 확인하지 않아도 되는 곳은?";
                QuestionDisplay.newA = "밸브와 용기의 접속부";
                QuestionDisplay.newB = "조정기";
                QuestionDisplay.newC = "가스 호스와 배관 연결부";
                QuestionDisplay.newD = "연료전지 부스트 인버터";
                actualAnswer = "D";

            }
            if (questionNumber == 42)
            {

                QuestionDisplay.newQuestion = "법령상 자동차의 등화 종류와 그 등광색을 연결한 것으로 맞는 것은?";
                QuestionDisplay.newA = "후퇴등 - 호박색";
                QuestionDisplay.newB = "번호등 - 청색";
                QuestionDisplay.newC = "후미등 - 백색";
                QuestionDisplay.newD = "제동등 - 적색";
                actualAnswer = "D";

            }
            if (questionNumber == 43)
            {

                QuestionDisplay.newQuestion = "자동차의 제동력을 저하하는 원인으로 가장 거리가 먼 것은?";
                QuestionDisplay.newA = "마스터 실린더 고장";
                QuestionDisplay.newB = "휠 실린더 불량";
                QuestionDisplay.newC = "릴리스 포크 변형";
                QuestionDisplay.newD = "베이퍼 록 발생";
                actualAnswer = "C";

            }
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
