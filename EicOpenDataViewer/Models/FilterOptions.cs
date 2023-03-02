using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace EicOpenDataViewer.Models
{
    public class FilterCriteria
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class FilterCriteriaModel
    {
        public List<SelectListItem> FilterCriterias { get; set; }
        public string? FilterCriteriaCode { get; set; }
    }
    public class FilterCriterias
    {
        public static List<FilterCriteria> Criterias { get; set; }
        static FilterCriterias()
        {
            Criterias = new List<FilterCriteria>();
            Criterias.Add(new FilterCriteria
            {
                Code = "postcode",
                Name = "postcode"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "address",
                Name = "address"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "local-authority",
                Name = "local authority"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "constituency",
                Name = "parliamentary constituency"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "floor-area",
                Name = "type of property"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "energy-band",
                Name = "energy band"
            });
            Criterias.Add(new FilterCriteria
            {
                Code = "lodgementdate",
                Name = "date that the EPC was lodged on the register"
            });

        }
    }
}
