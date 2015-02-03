using Kartverket.MetadataMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Kartverket.MetadataMonitor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class Api1Controller : ApiController
    {

        [Route("api/validate/{uuid}")]
        [HttpGet]
        public MetadataEntry Validate(string uuid)
        {

            if (string.IsNullOrEmpty(uuid))
                return null;
            ValidatorService _validatorService = new ValidatorService();

            MetadataEntry metadataEntry = _validatorService.ValidateMetadata(uuid);

            return metadataEntry;

        }

        [Route("api/metadata/{uuid}")]
        [HttpGet]
        public MetadataEntry Get(string uuid)
        {

            if (string.IsNullOrEmpty(uuid))
                return null;

            MetadataRepository _metadataRepository = new MetadataRepository();
            List<MetadataEntry> result = _metadataRepository.GetMetadataListWithLatestValidationResult(null, null, null, null, uuid);

            return result.First();

        }
    }
}
