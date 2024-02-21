using Newtonsoft.Json;
using ScorePromeAPI.Models.Context;

namespace ScorePromeAPI.Business.ScoreNosis
{
    public class DatosNosisBusiness
    {
        private BasesNegativasContext _context;

        public DatosNosisBusiness(BasesNegativasContext context)
        {
            this._context = context;
        }

        public object GetLeadsScores(List<int> documents)
        {
            try
            {
                var leadScores = new List<LeadScore>();

                foreach (int doc in documents)
                {
                    leadScores.AddRange(GetLeadByDocumentNumber(doc));
                }

                var result = leadScores
                    .GroupBy(x => x.Dni)
                    .ToDictionary(
                        group => group.Key,
                        group => new
                        {
                            Score = group.Select(x => x.Score).ToList(),
                            UpdateDate = group.Select(x => x.UpdateDate).ToList()
                        }
                    );

                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private List<LeadScore> GetLeadByDocumentNumber(int documentNumber)
        {
            string docString = documentNumber.ToString();

            var query = (from data in _context.DatosNosis
                         where data.ViDni == docString
                               && data.ScoVig != "NC"
                         group new { data.ScoVig, data.UpdatedAt } by data.ViDni into groupResult
                         select new LeadScore
                         {
                             Dni = groupResult.Key,
                             UpdateDate = groupResult.OrderByDescending(x => x.UpdatedAt).First().UpdatedAt, // Obtener la fecha de actualización más reciente
                             Score = groupResult.OrderByDescending(x => x.UpdatedAt).First().ScoVig // Obtener el dato más reciente
                         }).ToList();

            return query;
        }
    }
}
