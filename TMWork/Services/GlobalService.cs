using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace TMWork.Services
{
    public class GlobalService
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;

        public GlobalService(
            ILoggerFactory loggerFactory, IConfiguration config)
        {
            _config = config;
            _logger = loggerFactory.CreateLogger<GlobalService>();

        }
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("D");
        }

        public bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        public bool AttachmentExist(int eventId)
        {
            bool attachmentExists = false;
            if (eventId > 0)
            {
                string uploadFolder = _config.GetSection("SiteSettings")["uploadFolder"];
                string uploadSystemPath = _config.GetSection("SiteSettings")["uploadSystemPath"];
                string newPath = Path.Combine(uploadSystemPath, uploadFolder);

                //create folder for invoiceId
                string path = string.Format(@"{0}\{1}", newPath, eventId); //uploadVM.FilePath;
                if (System.IO.Directory.Exists(path))
                {
                    foreach (var file in System.IO.Directory.GetFiles(path))
                    {
                        var filepath = Path.GetFullPath(file);
                        if (System.IO.File.Exists(filepath))
                            attachmentExists = true;

                    }
                }
            }
            return attachmentExists;
        }

    }
}
