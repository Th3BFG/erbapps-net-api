using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ErbAppsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/user
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/user/login
        [HttpPost("login")]
        public void Login([FromBody] string value)
        {
            // const params = _.pick(req.body, 'un', 'pw', 'id');
            // if (!params.un || !params.pw || !params.id) {
            //     logger.error('Required parameters: un, pw and id');
            //     res.status(400).send({error: 'Required parameters: un, pw and id'});
            // }
            // else {
            //     // Retrieve the user if possible
            //     dal.selectBySearchTerm('*', TABLE_NAME, 'username', params.un)
            //     .then(function (user) {
            //         if(_.isNull(user)) { res.status(403).send({error: 'Invalid credentials'}); }
            //         // Validate Credentials
            //         const hash = crypto.createHmac('sha256', user.salt);
            //         if(user.password === hash.update(params.pw).digest('hex')) {
            //             keyService.createToken(user, params.id).then(function(token) {
            //                 // return to sender
            //                 res.status(200).send('{ token: ' + token + ' }');
            //             });
            //         } else {
            //             res.status(403).send({error: 'Invalid credentials'});
            //         }
            //     })
            //     .catch(function (error) {
            //         logger.error(error.message, error);
            //     });
            // }
        }

        // POST api/user/logout
        [HttpPost("logout")]
        public void Logout([FromBody] string value)
        {
            // const params = _.pick(req.params, 'id');
            // if (!params.id) {
            //     logger.error('Required parameters: id');
            //     res.status(400).send({error: 'Required parameters: id'});
            // }
            // else {
            //     keyService.deleteToken(params.id).then(function(result) {
            //         if (!result) {
            //             return res.status(404).send();
            //         }
            //         res.status(204).send();
            //     }).catch(function(error) {
            //         logger.error(error.message, error);
            //         next(error);
            //     });
            // }
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}