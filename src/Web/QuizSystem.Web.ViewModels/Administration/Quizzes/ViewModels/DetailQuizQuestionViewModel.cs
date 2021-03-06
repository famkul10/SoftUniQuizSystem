﻿namespace QuizSystem.Web.ViewModels.Administration.Quizzes.ViewModels
{
    using System.Collections.Generic;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class DetailQuizQuestionViewModel : IMapFrom<Question>
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public List<DetailQuizAnswerViewModel> Answers { get; set; }
    }
}
