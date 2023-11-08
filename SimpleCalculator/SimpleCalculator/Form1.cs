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
            num1 = 0;
            num2 = 0;
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

                switch (op)
                {
                    case Operate.Add:
                        textBox1.Text += string.Format("{0}={1}", num2, num1+num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Sub:
                        textBox1.Text += string.Format("{0}={1}", num2, num1-num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Mult:
                        textBox1.Text += string.Format("{0}={1}", num2, num1 * num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Div:
                        textBox1.Text += string.Format("{0}={1}", num2, num1 / num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                    case Operate.Mod:
                        textBox1.Text += string.Format("{0}={1}", num2, num1 % num2); // 연산 진행 {0}: num1 + 연산자, {1}: num2
                        break;

                }

                calcResult.Text += textBox1.Text + "\r\n";  //결과 출력하기
            }
                
        }
        // 성민철 코드 끝
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void resultDelete_Click(object sender, EventArgs e)
        {

        }

        private void calcResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
