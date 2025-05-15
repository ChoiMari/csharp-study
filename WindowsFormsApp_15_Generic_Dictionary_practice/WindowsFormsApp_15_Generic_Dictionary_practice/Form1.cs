using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_15_Generic_Dictionary_practice
{
    public partial class FormLogin : Form
    {
        // 필드
        string _line;
        string[] _lines;

        // 아이디/비밀번호 데이터 저장
        Dictionary<string, int> _idAndPwd = new Dictionary<string, int>();

        // 아이디/전화번호 데이터 저장(전화번호는 없을 시에 null저장함)
        Dictionary<string, string> _idAndPhone = new Dictionary<string, string>();


        public FormLogin()
        {
            InitializeComponent();
        }

        // OpenFile 버튼 클릭 이벤트 핸들러
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // ShowDialog()는 파일 선택 대화상자를 화면에 띄움,
            // 사용자가 확인을 누르면 DialogResult.OK를 반환함
            // 그래서 DialogResult.OK와 같은 경우 실행하도록 설정
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //FileName속성 : 사용자가 선택한 파일의 전체 경로 + 파일명.확장자를 가져옴
                string selectedFile = openFileDialog1.FileName;
                MessageBox.Show("파일 불러오기 완료","성공"); // 메세지 박스 띄움

                StreamReader sr = new StreamReader(selectedFile);
                // 생성자 호출 시에 아규먼트로 FileName속성값(파일의 경로 + 파일명.확장자) 넣어주고
                // 스트림리더의 객체 생성함



                // 반복문 돌림
                while ((_line = sr.ReadLine()) != null) {
                    // ReadLine() 한 줄 읽고 문자열을 데이터로 반환
                    // 입력스트림의 끝에 도달할 경우 null을 리턴한다고 함
                    _lines = _line.Split(','); //한 줄씩 읽은 걸 ,로 잘라서 string 배열로 반환
                    int.TryParse(_lines[1], out int pwd); // 비밀번호 int타입으로 변경
                    _idAndPwd.Add(_lines[0],pwd); // 딕셔너리객체에 key - 아이디, value - 비밀번호 저장

                    // lines배열의 길이가 3인가요?(= 아이디,비밀번호,전화번호 모두 다 있는 경우인가요?)
                    // 맞다! 그럼 lines[2] 전화번호에 해당하는 인덱스 2번 요소를 phoneTxt에 저장함
                    // 아니다! 그럼 phoneTxt에 null을 저장함
                    string phoneTxt = _lines.Length == 3 ? _lines[2] : null;
                    
                    _idAndPhone.Add(_lines[0], phoneTxt);
                    //key - id , value - phoneTxt
                }
            }
            else {
                MessageBox.Show("파일 불러오기 실패","Error"); // 메세지 박스 띄움
            }

           
        }

        // 로그인 버튼 클릭 이벤트 핸들러
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tryId = textBoxID.Text; // 사용자가 입력한 id값을 tryId에 저장
            int.TryParse(textBoxPwd.Text, out int tryPwd); // 사용자가 입력한 pwd를 int로 변환해 tryPwd에 저장 

            bool result = _idAndPwd.TryGetValue(tryId, out int pwd);
            // 키 값으로 value값을 찾아 해당 키 값이 있으면 pwd에 저장하고 true를 반환
            // 해당 키 값이 없으면 pwd는 0으로 초기화하고 false를 리턴함

            _idAndPhone.TryGetValue(tryId, out string phoneNum);
            // 아규먼트로 넣은 값에 해당하는 키가 있으면
            // 키와 연결된 값을 phoneNum에 저장함

            string phonenumber = (phoneNum == null) ? "없음" : phoneNum;
            // phoneNum이 null이면 없음을 phonenumber에 저장하고
            // null이 아니면 그냥 phoneNum값 그대로 phonenumber에 저장함

            if (result && tryPwd == pwd) // 해당되는 키 값이 있고 시도한 비밀번호가 맞으면 실행됨
            {
                MessageBox.Show($"로그인 성공\nID : {tryId}\n" +
                    $"Phone Number : {phonenumber}", "성공");
            }
            else {
                if (!_idAndPwd.ContainsKey(tryId))
                { // 아이디가 없으면 실행
                    MessageBox.Show("Error : 아이디가 존재하지 않습니다.", "실패");
                }
                else if (tryPwd != pwd)
                {  // 로그인을 시도한 비밀번호가 일치하지 않으면 실행
                    MessageBox.Show("Error : 비밀번호가 틀렸습니다.", "실패");
                }
                else {
                    MessageBox.Show("Error!!", "실패");
                } 
                
            }
        }
    }
}
