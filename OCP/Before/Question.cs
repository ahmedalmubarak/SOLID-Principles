﻿using SRP.Before;

namespace OCP.Before
{
    public class Question
    {
        public string Title { get; set; }

        public int Mark { get; set; }
        public QuestionType QuestionType { get; set; }

        public List<string> Choices { get; set; } = new List<string>();
    }
}
