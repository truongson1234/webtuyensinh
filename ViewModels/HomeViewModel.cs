﻿using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<MenuItemModel> Menu { get; set; }
        public IEnumerable<PostModel> ArticleMain { get; set; }
        public IEnumerable<PostModel> ArticleCateOne { get; set; }
        public IEnumerable<PostModel> ArticleCateTwo { get; set; }
        public IEnumerable<PostModel> ArticleCateThree { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<CategoryModel> CateNation { get; set; }
        public AdmissionModel AdmissionModel { get; set; }
    }
}
