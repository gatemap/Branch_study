using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    // 성민철 코드
    public partial class Form1 : Form
    {

        enum Operate //enum문 사용: 연산 유형 정의, 연산자를 눈에 보기 쉬운 문자로 보여주는 함수라고 보면 된다!
        {
            Add, Sub, Mult, Div, Mod // 연산자 정의
        }
        decimal num1, num2; // 연산 가능한 숫자로 변환

        Operate op;

        public Form1()
        {
            InitializeComponent();
            // 입력되는 숫자 초기화
            num1 = 0;
            num2 = 0;

            // 화면이 불러와질 때, 커서의 위치를 숫자 입력창에서 시작되도록 한다
            textBox2.TabIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e) // 더하기 버튼 입력하기, num1 + 형태로 출력
        {
            if(decimal.TryParse(textBox2.Text, out num1))
            {
                textBox1.Text = textBox2.Text + "+"; // 더하기 연산 추가!
                textBox2.Clear(); // num2를 다시 눌러야하니 초기화~!
                op = Operate.Add; // 더하기 연산자 지정
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out num1))
            {
                textBox1.Text = textBox2.Text + "-"; // 빼기 연산 추가!
                textBox2.Clear(); // textBox2 비우기
                op = Operate.Sub; // 빼기 연산자 지정
            }
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out num1))
            {
                textBox1.Text = textBox2.Text + "*"; // 곱하기 연산 추가
                textBox2.Clear(); // textBox2 비우기
                op = Operate.Mult; // 곱하기 연산자 지정
            }
        }

        private void Div_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out num1))
            {
                textBox1.Text = textBox2.Text + "/"; // 나누기 연산 추가
                textBox2.Clear(); // textBox2 비우기
                op = Operate.Div; // 나누기 연산자 지정
            }
        }

        private void Mod_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out num1))
            {
                textBox1.Text = textBox2.Text + "%"; // 나머지 연산 추가
                textBox2.Clear(); // textBox2 비우기
                op = Operate.Mod; // 나머지 연산자 지정
            }
        }

        private void Is_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out num2)) // num2 받고 계산 결과 도출 과정
            {
                // 마이너스 처리
                string strNum = string.Empty;

                if (num2 < 0)
                    strNum = string.Format("({0})", num2);
                else
                    strNum = num2.ToString();

                switch (op)
                {
                    case Operate.Add:
                        textBox1.Text += string.Format("{0:#,0}={1:#,0}", strNum, num1+num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Sub:
                        textBox1.Text += string.Format("{0:#,0}={1:#,0}", strNum, num1-num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Mult:
                        textBox1.Text += string.Format("{0:#,0}={1:#,0}", strNum, num1 * num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Div:
                        textBox1.Text += string.Format("{0:#,0}={1:#,0}", strNum, num1 / num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Mod:
                        textBox1.Text += string.Format("{0:#,0}={1:#,0}", strNum, num1 % num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                }

                calcResult.Text += textBox1.Text + "\r\n";  //결과 출력하기
                textBox2.Clear();
            }
                
        }
        // 성민철 코드 끝

        private void removeButton_Click(object sender, EventArgs e)
        {
            // 입력창이 비어있으면 아무것도 하지 않기
            if (string.IsNullOrEmpty(textBox2.Text))
                return;

            // 입력되어 있는 것만 지운다
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }

        /// <summary>
        /// 마이너스는 플러스로 플러스는 마이너스로
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusChange_Click(object sender, EventArgs e)
        {
            // 입력 칸이 비어있으면 아무것도 하지 않음
            if (string.IsNullOrEmpty(textBox2.Text))
                return;

            // 이미 앞에 마이너스가 붙은 경우, 마이너스 지워줌
            if (textBox2.Text[0].Equals('-'))
                textBox2.Text = textBox2.Text.Remove(0, 1);
            else
                textBox2.Text = "-" + textBox2.Text;
        }
        /*
         * 
         * 여기부터 이지율 작성
         * 
         */
        private void resultDelete_Click(object sender, EventArgs e)
        {
            //내역삭제 버튼 누르면 내역 목록 지우기
            calcResult.Clear();
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            //AC버튼 누르면 결과 화면 지우기
            textBox1.Clear();
            textBox2.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //1버튼 누르면 1추가
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아직 구현 못했습니다ㅠㅠ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //입력된 숫자를 넣을 변수
            decimal num = 0;

            //입력 문자열의 "," 제거
            string strNum = textBox2.Text.Replace(",", "");

            //입력 문자열을 숫자로 변환
            if (decimal.TryParse(strNum, out num))
            {
                //첫번째 0은 ,뒤의 변수들 중 인덱스 0, 즉 num을 뜻합니다.
                // : 뒤의 #,0은 천 단위로 숫자 사이에 쉼표를 삽입합니다.
                textBox2.Text = string.Format("{0:#,0}", num);

                //textBox2의 텍스트의 끝부터 0개의 문자를 선택합니다.
                //커서를 TextBox 텍스트의 끝으로 이동시킬 수 있습니다.
                //여기에 새로운 텍스트를 입력하려면 기존 텍스트의 끝에 추가됩니다.
                textBox2.Select(textBox2.Text.Length, 0);
            }
        }

    }
}
