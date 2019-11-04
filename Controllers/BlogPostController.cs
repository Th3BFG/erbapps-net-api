using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ErbAppsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        // GET api/blogpost
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // dal.select('*', TABLE_NAME)
            // .then(function (data) {
            //     res.status(200).send(data);
            // })
            // .catch(function (error) {
            //     logger.error(error.message, error);
            // });
            return new string[] { "value1", "value2" };
        }

        // GET api/blogpost/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // dal.selectById('*', TABLE_NAME, req.params['id'])
            // .then(function (data) {
            //     res.status(200).send(data);
            // })
            // .catch(function (error) {
            //     logger.error(error.message, error);
            // });
            return "blogpost";
        }

        // POST api/blogpost
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // if(_.contains(req.perm, 'blogPost:create')) {
            //     dal.insert(TABLE_NAME, req.body)
            //     .then(function (id) {
            //         res.status(201).send(id);
            //     })
            //     .catch(function (error) {
            //         logger.error(error.message, error);
            //     });
            // } else {
            //     res.sendStatus(403);
            // }
        }

        // PUT api/blogpost/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // if(_.contains(req.perm, 'blogPost:modify')) {
            //     res.sendStatus(200);
            // } else {
            //     res.sendStatus(403);
            // }
        }

        // DELETE api/blogpost/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // if(_.contains(req.perm, 'blogPost:delete')) {
            //     dal.delete(TABLE_NAME, req.params['id'])
            //     .then(function () { 
            //         res.sendStatus(204);
            //     })
            //     .catch(function (error) {
            //         logger.error(error.message, error);
            //     });    
            // } else {
            //     res.sendStatus(403);
            // }
        }
    }
}