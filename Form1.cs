using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // [과제 2] 엔터키 입력을 처리하기 위해 KeyDown 이벤트를 연결합니다.
            txtInput.KeyDown += txtInput_KeyDown;
        }

        // 전송 버튼 클릭 이벤트
        private void btnSend_Click(object sender, EventArgs e)
        {
            // [과제 4] 글자 수 제한: 50자가 넘으면 경고 메시지를 띄우고 중단합니다.
            if (txtInput.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해주세요.");
                return;
            }

            // [과제 2] 빈 메시지 입력 방지: 공백만 있거나 비어있으면 함수를 종료합니다.
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return;
            }

            // [과제 3] 현재 시간 정보를 "년-월-일 시:분:초" 형식의 문자열로 생성합니다.
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // [과제 3] 문자열 가공: 시간 정보를 붙이고, 입력값의 앞뒤 공백을 Trim으로 제거합니다.
            string formattedMsg = $"[{time}] {txtInput.Text.Trim()}";

            // [과제 1] 리스트박스에 텍스트 추가: 가공된 메시지를 ListBox 항목으로 추가합니다.
            lstChat.Items.Add(formattedMsg);

            // [과제 1] 입력창 비우기: 추가 직후 TextBox의 내용을 비워 다음 입력을 준비합니다.
            txtInput.Clear();

            // [과제 2] 포커스 유지: 전송 후 자동으로 입력창에 커서를 위치시킵니다.
            txtInput.Focus();

            // [과제 3] 상태 표시: 현재 리스트박스에 쌓인 아이템의 개수를 라벨에 표시합니다.
            UpdateCount();
        }

        // [과제 4] 삭제 버튼 클릭 이벤트: 선택된 항목을 삭제합니다.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 리스트박스에서 항목이 선택되어 있는지 확인합니다. (-1은 선택 안 됨)
            if (lstChat.SelectedIndex != -1)
            {
                // 선택된 인덱스의 항목을 삭제합니다.
                lstChat.Items.RemoveAt(lstChat.SelectedIndex);

                // 삭제 후 개수를 다시 계산하여 표시합니다.
                UpdateCount();
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.");
            }
        }

        // [과제 4] 전체 삭제 버튼 클릭 이벤트: 모든 대화 내용을 초기화합니다.
        private void btnClear_Click(object sender, EventArgs e)
        {
            // 리스트박스의 모든 항목을 지웁니다.
            lstChat.Items.Clear();

            // 초기화 후 개수를 0으로 업데이트합니다.
            UpdateCount();
        }

        // [과제 3, 4 공통] 개수 표시 라벨 업데이트 전용 함수
        private void UpdateCount()
        {
            // [과제 3] 현재 리스트박스 아이템 개수를 라벨(lblResult)에 표시합니다.
            lblResult.Text = "현재 대화: " + lstChat.Items.Count.ToString() + "개";
        }

        // [과제 2] 텍스트박스에서 키가 눌렸을 때 실행되는 함수
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            // 누른 키가 엔터(Enter) 키인지 확인합니다.
            if (e.KeyCode == Keys.Enter)
            {
                // 엔터키를 누르면 전송 버튼(btnSend)을 클릭한 것과 동일한 로직을 실행합니다.
                btnSend_Click(sender, e);

                // 엔터키 입력 시 발생하는 시스템 경고음('띵' 소리)을 방지합니다.
                e.SuppressKeyPress = true;
            }
        }
    }
}