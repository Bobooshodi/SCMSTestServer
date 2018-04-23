using SCMSTestServer.Models;
using SCMSTestServer.Services;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    public class BaseController<Model, Service> : ApiController
        where Service : BaseService<Model, Service>, new()
        where Model : BaseModel
    {
        private readonly Service service = BaseService<Model, Service>.ServiceInstance;

        [HttpGet]
        [Route("get/all")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAll()

        {
            try
            {
                // await Task.Delay(15000);

                return Ok(await Task.Run(() => service.GetAll()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Get(string id)
        {
            try
            {
                return Ok(await Task.Run(() => service.Get(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Post(Model model)
        {
            try
            {
                return Ok(await Task.Run(() => service.Add(model)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Put(Model model)
        {
            try
            {
                return Ok(await Task.Run(() => service.Update(model)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Delete(string id)
        {
            try
            {
                return Ok(await Task.Run(() => service.Delete(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}