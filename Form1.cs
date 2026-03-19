using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 전송 버튼 클릭 이벤트
        private void btnSend_Click(object sender, EventArgs e)
        {
            // [과제 1] 리스트박스에 텍스트 추가
            lstChat.Items.Add(txtInput.Text);

            // [과제 1] 입력창 비우기
            txtInput.Clear();
        }
    }
}