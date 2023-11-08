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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {

        }

        private void multiButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        private void button7_Click(object sender, EventArgs e)
        {
            //AC버튼 누르면 결과 화면 지우기
            textBox1.Clear();
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
                
                textBox2.Select(textBox2.Text.Length, 0);
                //textBox2의 텍스트의 끝부터 0개의 문자를 선택합니다.
                //커서를 TextBox 텍스트의 끝으로 이동시킬 수 있습니다.
                //여기에 새로운 텍스트를 입력하려면 기존 텍스트의 끝에 추가됩니다.
                
            }
        }
    }
}
