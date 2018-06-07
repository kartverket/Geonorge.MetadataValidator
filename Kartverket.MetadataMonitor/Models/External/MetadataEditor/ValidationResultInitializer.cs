using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Kartverket.MetadataMonitor.Models.External.MetadataEditor
{
    public static class ValidationResultInitializer
    {
        // @TODO: these string values should be removed in all of the related projects later if there is no any serious reason to keep them.
        private const string Invalid = "ERRORS";
        private const string Valid = "OK";

        public static void Initialize(this ValidationResult validationResult, MetadataEntry metadataEntry)
        {
            validationResult.Messages = JoinErrorMessages(metadataEntry.Errors);

            switch (metadataEntry.Status)
            {
                case Valid:
                    validationResult.Status = ValidationStatus.Valid;
                    break;
                case Invalid:
                    validationResult.Status = ValidationStatus.Invalid;
                    break;
                default:
                    validationResult.Status = ValidationStatus.NotValidated;
                    break;
            }
            string str = metadataEntry.Errors.ToString();
        }

        private static string JoinErrorMessages(List<Error> errors)
        {
            StringBuilder messages = new StringBuilder();

            errors.ForEach(e => messages.Append($"{e.Key}: {e.Message}\r\n"));

            return messages.ToString();
        }
    }
}
