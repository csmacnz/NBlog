using System.Collections.Generic;
using System.Web.Http;

namespace NBlog.Web.Controllers
{
    public class BlogApiController : ApiController
    {
        protected readonly NBlog.Web.Application.Service.IServices Services;

        public BlogApiController(NBlog.Web.Application.Service.IServices services)
        {
            Services = services;
        }


        public List<NBlog.Web.Application.Service.Entity.Entry> GetAllEntries()
        {
            return Services.Entry.GetList();
        }

        public NBlog.Web.Application.Service.Entity.Entry GetEntry(string slug)
        {
            return Services.Entry.GetBySlug(slug);
        }
    }
}
