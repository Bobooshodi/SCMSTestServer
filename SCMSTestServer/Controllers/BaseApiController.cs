﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using SCMSTestServer.Controllers.Auth;
using SCMSTestServer.Repository;
using System.Net.Http;
using System.Web.Http;

namespace SCMSTestServer.Controllers
{
    public class BaseApiController : ApiController
    {
        private ModelFactory _modelFactory;
        private AuthProvider _AppUserManager = null;

        protected AuthProvider AppUserManager
        {
            get
            {
                return _AppUserManager ?? Request.GetOwinContext().GetUserManager<AuthProvider>();
            }
        }

        public BaseApiController()
        {
        }

        protected ModelFactory TheModelFactory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(this.Request, this.AppUserManager);
                }
                return _modelFactory;
            }
        }

        protected IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}