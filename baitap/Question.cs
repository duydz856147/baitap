using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitap
{
    class Question
    {
        public string Content { get; set; } // Nội dung của câu hỏi
        public string[] Options { get; set; } // Mảng chứa các lựa chọn đáp án
        public int CorrectOptionIndex { get; set; } // Chỉ mục của đáp án đúng trong mảng lựa chọn đáp án
    }
}
