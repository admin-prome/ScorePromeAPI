using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ScorePromeAPI.Business.ScoreNosis;
using ScorePromeAPI.Models.Context;
using ScorePromeAPI.ResponseModels;

namespace ScorePromeAPI.Controllers.ScoreNosis
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosNosisController : ControllerBase
    {
        private DatosNosisBusiness nosisBusiness;

        public DatosNosisController(BasesNegativasContext basesNegativasContext)
        {
            this.nosisBusiness = new DatosNosisBusiness(basesNegativasContext);
        }

        [HttpGet]
        public ActionResult<APIResponse> GetScoresByDocuments([FromQuery] List<int> documents)
        {
            try
            {
                APIResponse response = new APIResponse();

                if (!documents.Any())
                {
                    throw new Exception("Documents list is empty");
                }

                response.Result = nosisBusiness.GetLeadsScores(documents);

                if (response.Result == null)
                {
                    response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    return BadRequest("Empty result");
                }

                response.StatusCode = System.Net.HttpStatusCode.OK;

                return response;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
