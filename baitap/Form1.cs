using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace baitap
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
            DisplayQuestion();
        }
        private void LoadQuestions()
        {
            Question questionFromDatabase = new Question();
            questionFromDatabase.Content = "hello";
            questionFromDatabase.Options = new string[] { "hi", "ok", "yes", "no" };
            questionFromDatabase.CorrectOptionIndex = 1; // Index 1 represents "Paris" as correct answer
            // Đọc câu hỏi và đáp án từ cơ sở dữ liệu hoặc tệp tin
            // Ví dụ: questions = LoadQuestionsFromDatabase();
        }
        private List<Question> questions = new List<Question>();
        private void DisplayQuestion()
        {

            if (questions != null && currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                label1.Text = currentQuestion.Content;
                radioButton1.Text = currentQuestion.Options[0];
                radioButton2.Text = currentQuestion.Options[1];
                radioButton3.Text = currentQuestion.Options[2];
                radioButton4.Text = currentQuestion.Options[3];
            }
            else
            {
                MessageBox.Show("Bạn đã trả lời đúng " + score + " câu hỏi.");
                // Xử lý kết quả sau khi hoàn thành tất cả câu hỏi
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra đáp án và cập nhật điểm số
            // Ví dụ: if (IsAnswerCorrect()) { score++; }
            currentQuestionIndex++;
            DisplayQuestion();

        }
    }
}
