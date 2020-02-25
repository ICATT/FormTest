using Microsoft.AspNetCore.Http;

namespace FormTest
{
    public class FormModel
    {
        public Files Files { get; set; }
    }

    public class Files
    {
        public FormFileWrapper FileOne { get; set; }
        public FormFileWrapper FileTwo { get; set; }
        public FormFileWrapper FileThree { get; set; }
    }

    public class FormFileWrapper
    {
        public IFormFile File { get; set; }
    }
}
