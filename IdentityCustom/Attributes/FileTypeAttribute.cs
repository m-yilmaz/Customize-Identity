using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace IdentityCustom.Attributes
{
    public class FileTypeAttribute : ValidationAttribute
    {
        private readonly string _fileType;
        private readonly int _size = 1024;

        public FileTypeAttribute(string fileType)
        {
            _fileType = fileType;
        }

        public FileTypeAttribute(string fileType, int size) : this(fileType)
        {
            _size = size;
        }

        public override bool IsValid(object value)
        {
            IFormFile formFile = value as IFormFile;
            if (formFile == null) return true;

            if (!formFile.ContentType.StartsWith(_fileType + "/"))
            {
                ErrorMessage = $"File type must be {_fileType}";
                return false;
            }
            else if (formFile.Length > _size * 1024)
            {
                ErrorMessage = $"Maximum file size {_size * 1024}";
                return false;
            }

            return true;
        }
    }
}
