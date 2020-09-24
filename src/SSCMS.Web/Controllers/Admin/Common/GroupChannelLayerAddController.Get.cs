﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSCMS.Web.Controllers.Admin.Common
{
    public partial class GroupChannelLayerAddController
    {
        [HttpGet, Route(Route)]
        public async Task<ActionResult<GetResult>> Get([FromQuery] GetRequest request)
        {
            var group = await _channelGroupRepository.GetAsync(request.SiteId, request.GroupId);

            return new GetResult
            {
                GroupName = group.GroupName,
                Description = group.Description
            };
        }
    }
}
