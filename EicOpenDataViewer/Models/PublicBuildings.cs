using Newtonsoft.Json;
namespace EicOpenDataViewer.Models
{
    public class PublicBuildings
    {
        public PublicBuildings()
        {
            this.ColumnNames = new List<string>();
            this.Rows = new List<PublicBuilding>();
        }
        public PublicBuildings(
            List<string> columnNames,
            List<PublicBuilding> rows
        )
        {
            this.ColumnNames = columnNames;
            this.Rows = rows;
        }

        [JsonProperty("column-names", NullValueHandling = NullValueHandling.Ignore)]
       
        public List<string> ColumnNames { get; }

        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
       
        public List<PublicBuilding> Rows { get; }
    }

    public class PublicBuilding
    {
        public PublicBuilding(
            string yr2RenewablesCo2,
            string address,
            string airconPresent,
            string uprnSource,
            string yr1RenewablesCo2,
            string annualElectricalFuelUsage,
            string buildingEnvironment,
            string heatingCo2,
            string yr2OperationalRating,
            string yr1ElectricityCo2,
            string address3,
            string yr1OperationalRating,
            string mainBenchmark,
            string yr2HeatingCo2,
            string occupancyLevel,
            string propertyType,
            string localAuthorityLabel,
            string county,
            string postcode,
            string constituency,
            string renewablesElectrical,
            string orAssessmentEndDate,
            string mainHeatingFuel,
            string yr1HeatingCo2,
            string localAuthority,
            string airconKwRating,
            string estimatedAirconKwRating,
            string inspectionDate,
            string address1,
            string constituencyLabel,
            string renewableSources,
            string totalFloorArea,
            string buildingReferenceNumber,
            string operationalRatingBand,
            string otherFuel,
            string address2,
            string posttown,
            string typicalElectricalFuelUsage,
            string specialEnergyUses,
            string lodgementDatetime,
            string typicalThermalFuelUsage,
            string currentOperationalRating,
            string uprn,
            string annualThermalFuelUsage,
            string nominatedDate,
            string lodgementDate,
            string lmkKey,
            string renewablesCo2,
            string renewablesFuelThermal,
            string yr2ElectricityCo2,
            string acInspectionCommissioned,
            string electricCo2,
            string buildingCategory
        )
        {
            this.Yr2RenewablesCo2 = yr2RenewablesCo2;
            this.Address = address;
            this.AirconPresent = airconPresent;
            this.UprnSource = uprnSource;
            this.Yr1RenewablesCo2 = yr1RenewablesCo2;
            this.AnnualElectricalFuelUsage = annualElectricalFuelUsage;
            this.BuildingEnvironment = buildingEnvironment;
            this.HeatingCo2 = heatingCo2;
            this.Yr2OperationalRating = yr2OperationalRating;
            this.Yr1ElectricityCo2 = yr1ElectricityCo2;
            this.Address3 = address3;
            this.Yr1OperationalRating = yr1OperationalRating;
            this.MainBenchmark = mainBenchmark;
            this.Yr2HeatingCo2 = yr2HeatingCo2;
            this.OccupancyLevel = occupancyLevel;
            this.PropertyType = propertyType;
            this.LocalAuthorityLabel = localAuthorityLabel;
            this.County = county;
            this.Postcode = postcode;
            this.Constituency = constituency;
            this.RenewablesElectrical = renewablesElectrical;
            this.OrAssessmentEndDate = orAssessmentEndDate;
            this.MainHeatingFuel = mainHeatingFuel;
            this.Yr1HeatingCo2 = yr1HeatingCo2;
            this.LocalAuthority = localAuthority;
            this.AirconKwRating = airconKwRating;
            this.EstimatedAirconKwRating = estimatedAirconKwRating;
            this.InspectionDate = inspectionDate;
            this.Address1 = address1;
            this.ConstituencyLabel = constituencyLabel;
            this.RenewableSources = renewableSources;
            this.TotalFloorArea = totalFloorArea;
            this.BuildingReferenceNumber = buildingReferenceNumber;
            this.OperationalRatingBand = operationalRatingBand;
            this.OtherFuel = otherFuel;
            this.Address2 = address2;
            this.Posttown = posttown;
            this.TypicalElectricalFuelUsage = typicalElectricalFuelUsage;
            this.SpecialEnergyUses = specialEnergyUses;
            this.LodgementDatetime = lodgementDatetime;
            this.TypicalThermalFuelUsage = typicalThermalFuelUsage;
            this.CurrentOperationalRating = currentOperationalRating;
            this.Uprn = uprn;
            this.AnnualThermalFuelUsage = annualThermalFuelUsage;
            this.NominatedDate = nominatedDate;
            this.LodgementDate = lodgementDate;
            this.LmkKey = lmkKey;
            this.RenewablesCo2 = renewablesCo2;
            this.RenewablesFuelThermal = renewablesFuelThermal;
            this.Yr2ElectricityCo2 = yr2ElectricityCo2;
            this.AcInspectionCommissioned = acInspectionCommissioned;
            this.ElectricCo2 = electricCo2;
            this.BuildingCategory = buildingCategory;
        }

        [JsonProperty("yr2-renewables-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr2RenewablesCo2 { get; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; }

        [JsonProperty("aircon-present", NullValueHandling = NullValueHandling.Ignore)]
        public string AirconPresent { get; }

        [JsonProperty("uprn-source", NullValueHandling = NullValueHandling.Ignore)]
        public string UprnSource { get; }

        [JsonProperty("yr1-renewables-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr1RenewablesCo2 { get; }

        [JsonProperty("annual-electrical-fuel-usage", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnualElectricalFuelUsage { get; }

        [JsonProperty("building-environment", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingEnvironment { get; }

        [JsonProperty("heating-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string HeatingCo2 { get; }

        [JsonProperty("yr2-operational-rating", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr2OperationalRating { get; }

        [JsonProperty("yr1-electricity-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr1ElectricityCo2 { get; }

        [JsonProperty("address3", NullValueHandling = NullValueHandling.Ignore)]
        public string Address3 { get; }

        [JsonProperty("yr1-operational-rating", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr1OperationalRating { get; }

        [JsonProperty("main-benchmark", NullValueHandling = NullValueHandling.Ignore)]
        public string MainBenchmark { get; }

        [JsonProperty("yr2-heating-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr2HeatingCo2 { get; }

        [JsonProperty("occupancy-level", NullValueHandling = NullValueHandling.Ignore)]
        public string OccupancyLevel { get; }

        [JsonProperty("property-type", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyType { get; }

        [JsonProperty("local-authority-label", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalAuthorityLabel { get; }

        [JsonProperty("county", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; }

        [JsonProperty("postcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Postcode { get; }

        [JsonProperty("constituency", NullValueHandling = NullValueHandling.Ignore)]
        public string Constituency { get; }

        [JsonProperty("renewables-electrical", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewablesElectrical { get; }

        [JsonProperty("or-assessment-end-date", NullValueHandling = NullValueHandling.Ignore)]
        public string OrAssessmentEndDate { get; }

        [JsonProperty("main-heating-fuel", NullValueHandling = NullValueHandling.Ignore)]
        public string MainHeatingFuel { get; }

        [JsonProperty("yr1-heating-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr1HeatingCo2 { get; }

        [JsonProperty("local-authority", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalAuthority { get; }

        [JsonProperty("aircon-kw-rating", NullValueHandling = NullValueHandling.Ignore)]
        public string AirconKwRating { get; }

        [JsonProperty("estimated-aircon-kw-rating", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedAirconKwRating { get; }

        [JsonProperty("inspection-date", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionDate { get; }

        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; }

        [JsonProperty("constituency-label", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstituencyLabel { get; }

        [JsonProperty("renewable-sources", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewableSources { get; }

        [JsonProperty("total-floor-area", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFloorArea { get; }

        [JsonProperty("building-reference-number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingReferenceNumber { get; }

        [JsonProperty("operational-rating-band", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationalRatingBand { get; }

        [JsonProperty("other-fuel", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherFuel { get; }

        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; }

        [JsonProperty("posttown", NullValueHandling = NullValueHandling.Ignore)]
        public string Posttown { get; }

        [JsonProperty("typical-electrical-fuel-usage", NullValueHandling = NullValueHandling.Ignore)]
        public string TypicalElectricalFuelUsage { get; }

        [JsonProperty("special-energy-uses", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialEnergyUses { get; }

        [JsonProperty("lodgement-datetime", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgementDatetime { get; }

        [JsonProperty("typical-thermal-fuel-usage", NullValueHandling = NullValueHandling.Ignore)]
        public string TypicalThermalFuelUsage { get; }

        [JsonProperty("current-operational-rating", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentOperationalRating { get; }

        [JsonProperty("uprn", NullValueHandling = NullValueHandling.Ignore)]
        public string Uprn { get; }

        [JsonProperty("annual-thermal-fuel-usage", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnualThermalFuelUsage { get; }

        [JsonProperty("nominated-date", NullValueHandling = NullValueHandling.Ignore)]
        public string NominatedDate { get; }

        [JsonProperty("lodgement-date", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgementDate { get; }

        [JsonProperty("lmk-key", NullValueHandling = NullValueHandling.Ignore)]
        public string LmkKey { get; }

        [JsonProperty("renewables-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewablesCo2 { get; }

        [JsonProperty("renewables-fuel-thermal", NullValueHandling = NullValueHandling.Ignore)]
        public string RenewablesFuelThermal { get; }

        [JsonProperty("yr2-electricity-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string Yr2ElectricityCo2 { get; }

        [JsonProperty("ac-inspection-commissioned", NullValueHandling = NullValueHandling.Ignore)]
        public string AcInspectionCommissioned { get; }

        [JsonProperty("electric-co2", NullValueHandling = NullValueHandling.Ignore)]
        public string ElectricCo2 { get; }

        [JsonProperty("building-category", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingCategory { get; }
    }


}

