﻿namespace webtuyensinh.Models
{
    public class Sommnernote
    {
        public Sommnernote(string iDEditor, bool loadLibrary = true) {
            IDEditor = iDEditor;
            LoadLibrary = loadLibrary;
        }

        public string IDEditor { get; set; }
        public bool LoadLibrary { get; set; }
        public int height { get; set; } = 120;
        public string toolbar { get; set; } = @"
            ['style', ['style']],
            ['font', ['bold', 'underline', 'clear']],
            ['color', ['color']],
            ['para', ['ul', 'ol', 'paragraph']],
            ['table', ['table']],
            ['insert', ['link', 'picture', 'video', 'elfinder'],
            ['view', ['fullscreen', 'codeview', 'help']]
        ";
    }
}
