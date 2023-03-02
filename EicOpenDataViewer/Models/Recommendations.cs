using Newtonsoft.Json;

namespace EicOpenDataViewer.Models
{


    // Recommendations myDeserializedClass = JsonConvert.DeserializeObject<Recommendations>(myJsonResponse);
    public class Recommendations
    {
        [JsonProperty("column-names")]
        public List<string> ColumnNames;

        [JsonProperty("rows")]
        public List<Recommendation> Rows;

        public Recommendations(List<string> columnNames, List<Recommendation> rows)
        {
            this.ColumnNames = columnNames;
            this.Rows = rows;
        }

        public Recommendations()
        {
            ColumnNames = new List<string>();
            Rows = new List<Recommendation>();
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
   

    public class Recommendation
    {
        [JsonConstructor]
        public Recommendation(
            [JsonProperty("low-energy-fixed-light-count")] string lowEnergyFixedLightCount,
            [JsonProperty("address")] string address,
            [JsonProperty("uprn-source")] string uprnSource,
            [JsonProperty("floor-height")] string floorHeight,
            [JsonProperty("heating-cost-potential")] string heatingCostPotential,
            [JsonProperty("unheated-corridor-length")] string unheatedCorridorLength,
            [JsonProperty("hot-water-cost-potential")] string hotWaterCostPotential,
            [JsonProperty("construction-age-band")] string constructionAgeBand,
            [JsonProperty("potential-energy-rating")] string potentialEnergyRating,
            [JsonProperty("mainheat-energy-eff")] string mainheatEnergyEff,
            [JsonProperty("windows-env-eff")] string windowsEnvEff,
            [JsonProperty("lighting-energy-eff")] string lightingEnergyEff,
            [JsonProperty("environment-impact-potential")] string environmentImpactPotential,
            [JsonProperty("glazed-type")] string glazedType,
            [JsonProperty("heating-cost-current")] string heatingCostCurrent,
            [JsonProperty("address3")] string address3,
            [JsonProperty("mainheatcont-description")] string mainheatcontDescription,
            [JsonProperty("sheating-energy-eff")] string sheatingEnergyEff,
            [JsonProperty("property-type")] string propertyType,
            [JsonProperty("local-authority-label")] string localAuthorityLabel,
            [JsonProperty("fixed-lighting-outlets-count")] string fixedLightingOutletsCount,
            [JsonProperty("energy-tariff")] string energyTariff,
            [JsonProperty("mechanical-ventilation")] string mechanicalVentilation,
            [JsonProperty("hot-water-cost-current")] string hotWaterCostCurrent,
            [JsonProperty("county")] string county,
            [JsonProperty("postcode")] string postcode,
            [JsonProperty("solar-water-heating-flag")] string solarWaterHeatingFlag,
            [JsonProperty("constituency")] string constituency,
            [JsonProperty("co2-emissions-potential")] string co2EmissionsPotential,
            [JsonProperty("number-heated-rooms")] string numberHeatedRooms,
            [JsonProperty("floor-description")] string floorDescription,
            [JsonProperty("energy-consumption-potential")] string energyConsumptionPotential,
            [JsonProperty("local-authority")] string localAuthority,
            [JsonProperty("built-form")] string builtForm,
            [JsonProperty("number-open-fireplaces")] string numberOpenFireplaces,
            [JsonProperty("windows-description")] string windowsDescription,
            [JsonProperty("glazed-area")] string glazedArea,
            [JsonProperty("inspection-date")] string inspectionDate,
            [JsonProperty("mains-gas-flag")] string mainsGasFlag,
            [JsonProperty("co2-emiss-curr-per-floor-area")] string co2EmissCurrPerFloorArea,
            [JsonProperty("address1")] string address1,
            [JsonProperty("heat-loss-corridor")] string heatLossCorridor,
            [JsonProperty("flat-storey-count")] string flatStoreyCount,
            [JsonProperty("constituency-label")] string constituencyLabel,
            [JsonProperty("roof-energy-eff")] string roofEnergyEff,
            [JsonProperty("total-floor-area")] string totalFloorArea,
            [JsonProperty("building-reference-number")] string buildingReferenceNumber,
            [JsonProperty("environment-impact-current")] string environmentImpactCurrent,
            [JsonProperty("co2-emissions-current")] string co2EmissionsCurrent,
            [JsonProperty("roof-description")] string roofDescription,
            [JsonProperty("floor-energy-eff")] string floorEnergyEff,
            [JsonProperty("number-habitable-rooms")] string numberHabitableRooms,
            [JsonProperty("address2")] string address2,
            [JsonProperty("hot-water-env-eff")] string hotWaterEnvEff,
            [JsonProperty("posttown")] string posttown,
            [JsonProperty("mainheatc-energy-eff")] string mainheatcEnergyEff,
            [JsonProperty("main-fuel")] string mainFuel,
            [JsonProperty("lighting-env-eff")] string lightingEnvEff,
            [JsonProperty("windows-energy-eff")] string windowsEnergyEff,
            [JsonProperty("floor-env-eff")] string floorEnvEff,
            [JsonProperty("sheating-env-eff")] string sheatingEnvEff,
            [JsonProperty("lighting-description")] string lightingDescription,
            [JsonProperty("roof-env-eff")] string roofEnvEff,
            [JsonProperty("walls-energy-eff")] string wallsEnergyEff,
            [JsonProperty("photo-supply")] string photoSupply,
            [JsonProperty("lighting-cost-potential")] string lightingCostPotential,
            [JsonProperty("mainheat-env-eff")] string mainheatEnvEff,
            [JsonProperty("multi-glaze-proportion")] string multiGlazeProportion,
            [JsonProperty("main-heating-controls")] string mainHeatingControls,
            [JsonProperty("lodgement-datetime")] string lodgementDatetime,
            [JsonProperty("flat-top-storey")] string flatTopStorey,
            [JsonProperty("current-energy-rating")] string currentEnergyRating,
            [JsonProperty("secondheat-description")] string secondheatDescription,
            [JsonProperty("walls-env-eff")] string wallsEnvEff,
            [JsonProperty("transaction-type")] string transactionType,
            [JsonProperty("uprn")] string uprn,
            [JsonProperty("current-energy-efficiency")] string currentEnergyEfficiency,
            [JsonProperty("energy-consumption-current")] string energyConsumptionCurrent,
            [JsonProperty("mainheat-description")] string mainheatDescription,
            [JsonProperty("lighting-cost-current")] string lightingCostCurrent,
            [JsonProperty("lodgement-date")] string lodgementDate,
            [JsonProperty("extension-count")] string extensionCount,
            [JsonProperty("mainheatc-env-eff")] string mainheatcEnvEff,
            [JsonProperty("lmk-key")] string lmkKey,
            [JsonProperty("wind-turbine-count")] string windTurbineCount,
            [JsonProperty("tenure")] string tenure,
            [JsonProperty("floor-level")] string floorLevel,
            [JsonProperty("potential-energy-efficiency")] string potentialEnergyEfficiency,
            [JsonProperty("hot-water-energy-eff")] string hotWaterEnergyEff,
            [JsonProperty("low-energy-lighting")] string lowEnergyLighting,
            [JsonProperty("walls-description")] string wallsDescription,
            [JsonProperty("hotwater-description")] string hotwaterDescription
        )
        {
            this.LowEnergyFixedLightCount = lowEnergyFixedLightCount;
            this.Address = address;
            this.UprnSource = uprnSource;
            this.FloorHeight = floorHeight;
            this.HeatingCostPotential = heatingCostPotential;
            this.UnheatedCorridorLength = unheatedCorridorLength;
            this.HotWaterCostPotential = hotWaterCostPotential;
            this.ConstructionAgeBand = constructionAgeBand;
            this.PotentialEnergyRating = potentialEnergyRating;
            this.MainheatEnergyEff = mainheatEnergyEff;
            this.WindowsEnvEff = windowsEnvEff;
            this.LightingEnergyEff = lightingEnergyEff;
            this.EnvironmentImpactPotential = environmentImpactPotential;
            this.GlazedType = glazedType;
            this.HeatingCostCurrent = heatingCostCurrent;
            this.Address3 = address3;
            this.MainheatcontDescription = mainheatcontDescription;
            this.SheatingEnergyEff = sheatingEnergyEff;
            this.PropertyType = propertyType;
            this.LocalAuthorityLabel = localAuthorityLabel;
            this.FixedLightingOutletsCount = fixedLightingOutletsCount;
            this.EnergyTariff = energyTariff;
            this.MechanicalVentilation = mechanicalVentilation;
            this.HotWaterCostCurrent = hotWaterCostCurrent;
            this.County = county;
            this.Postcode = postcode;
            this.SolarWaterHeatingFlag = solarWaterHeatingFlag;
            this.Constituency = constituency;
            this.Co2EmissionsPotential = co2EmissionsPotential;
            this.NumberHeatedRooms = numberHeatedRooms;
            this.FloorDescription = floorDescription;
            this.EnergyConsumptionPotential = energyConsumptionPotential;
            this.LocalAuthority = localAuthority;
            this.BuiltForm = builtForm;
            this.NumberOpenFireplaces = numberOpenFireplaces;
            this.WindowsDescription = windowsDescription;
            this.GlazedArea = glazedArea;
            this.InspectionDate = inspectionDate;
            this.MainsGasFlag = mainsGasFlag;
            this.Co2EmissCurrPerFloorArea = co2EmissCurrPerFloorArea;
            this.Address1 = address1;
            this.HeatLossCorridor = heatLossCorridor;
            this.FlatStoreyCount = flatStoreyCount;
            this.ConstituencyLabel = constituencyLabel;
            this.RoofEnergyEff = roofEnergyEff;
            this.TotalFloorArea = totalFloorArea;
            this.BuildingReferenceNumber = buildingReferenceNumber;
            this.EnvironmentImpactCurrent = environmentImpactCurrent;
            this.Co2EmissionsCurrent = co2EmissionsCurrent;
            this.RoofDescription = roofDescription;
            this.FloorEnergyEff = floorEnergyEff;
            this.NumberHabitableRooms = numberHabitableRooms;
            this.Address2 = address2;
            this.HotWaterEnvEff = hotWaterEnvEff;
            this.Posttown = posttown;
            this.MainheatcEnergyEff = mainheatcEnergyEff;
            this.MainFuel = mainFuel;
            this.LightingEnvEff = lightingEnvEff;
            this.WindowsEnergyEff = windowsEnergyEff;
            this.FloorEnvEff = floorEnvEff;
            this.SheatingEnvEff = sheatingEnvEff;
            this.LightingDescription = lightingDescription;
            this.RoofEnvEff = roofEnvEff;
            this.WallsEnergyEff = wallsEnergyEff;
            this.PhotoSupply = photoSupply;
            this.LightingCostPotential = lightingCostPotential;
            this.MainheatEnvEff = mainheatEnvEff;
            this.MultiGlazeProportion = multiGlazeProportion;
            this.MainHeatingControls = mainHeatingControls;
            this.LodgementDatetime = lodgementDatetime;
            this.FlatTopStorey = flatTopStorey;
            this.CurrentEnergyRating = currentEnergyRating;
            this.SecondheatDescription = secondheatDescription;
            this.WallsEnvEff = wallsEnvEff;
            this.TransactionType = transactionType;
            this.Uprn = uprn;
            this.CurrentEnergyEfficiency = currentEnergyEfficiency;
            this.EnergyConsumptionCurrent = energyConsumptionCurrent;
            this.MainheatDescription = mainheatDescription;
            this.LightingCostCurrent = lightingCostCurrent;
            this.LodgementDate = lodgementDate;
            this.ExtensionCount = extensionCount;
            this.MainheatcEnvEff = mainheatcEnvEff;
            this.LmkKey = lmkKey;
            this.WindTurbineCount = windTurbineCount;
            this.Tenure = tenure;
            this.FloorLevel = floorLevel;
            this.PotentialEnergyEfficiency = potentialEnergyEfficiency;
            this.HotWaterEnergyEff = hotWaterEnergyEff;
            this.LowEnergyLighting = lowEnergyLighting;
            this.WallsDescription = wallsDescription;
            this.HotwaterDescription = hotwaterDescription;
        }

        [JsonProperty("low-energy-fixed-light-count")]
        public string LowEnergyFixedLightCount { get; }

        [JsonProperty("address")]
        public string Address { get; }

        [JsonProperty("uprn-source")]
        public string UprnSource { get; }

        [JsonProperty("floor-height")]
        public string FloorHeight { get; }

        [JsonProperty("heating-cost-potential")]
        public string HeatingCostPotential { get; }

        [JsonProperty("unheated-corridor-length")]
        public string UnheatedCorridorLength { get; }

        [JsonProperty("hot-water-cost-potential")]
        public string HotWaterCostPotential { get; }

        [JsonProperty("construction-age-band")]
        public string ConstructionAgeBand { get; }

        [JsonProperty("potential-energy-rating")]
        public string PotentialEnergyRating { get; }

        [JsonProperty("mainheat-energy-eff")]
        public string MainheatEnergyEff { get; }

        [JsonProperty("windows-env-eff")]
        public string WindowsEnvEff { get; }

        [JsonProperty("lighting-energy-eff")]
        public string LightingEnergyEff { get; }

        [JsonProperty("environment-impact-potential")]
        public string EnvironmentImpactPotential { get; }

        [JsonProperty("glazed-type")]
        public string GlazedType { get; }

        [JsonProperty("heating-cost-current")]
        public string HeatingCostCurrent { get; }

        [JsonProperty("address3")]
        public string Address3 { get; }

        [JsonProperty("mainheatcont-description")]
        public string MainheatcontDescription { get; }

        [JsonProperty("sheating-energy-eff")]
        public string SheatingEnergyEff { get; }

        [JsonProperty("property-type")]
        public string PropertyType { get; }

        [JsonProperty("local-authority-label")]
        public string LocalAuthorityLabel { get; }

        [JsonProperty("fixed-lighting-outlets-count")]
        public string FixedLightingOutletsCount { get; }

        [JsonProperty("energy-tariff")]
        public string EnergyTariff { get; }

        [JsonProperty("mechanical-ventilation")]
        public string MechanicalVentilation { get; }

        [JsonProperty("hot-water-cost-current")]
        public string HotWaterCostCurrent { get; }

        [JsonProperty("county")]
        public string County { get; }

        [JsonProperty("postcode")]
        public string Postcode { get; }

        [JsonProperty("solar-water-heating-flag")]
        public string SolarWaterHeatingFlag { get; }

        [JsonProperty("constituency")]
        public string Constituency { get; }

        [JsonProperty("co2-emissions-potential")]
        public string Co2EmissionsPotential { get; }

        [JsonProperty("number-heated-rooms")]
        public string NumberHeatedRooms { get; }

        [JsonProperty("floor-description")]
        public string FloorDescription { get; }

        [JsonProperty("energy-consumption-potential")]
        public string EnergyConsumptionPotential { get; }

        [JsonProperty("local-authority")]
        public string LocalAuthority { get; }

        [JsonProperty("built-form")]
        public string BuiltForm { get; }

        [JsonProperty("number-open-fireplaces")]
        public string NumberOpenFireplaces { get; }

        [JsonProperty("windows-description")]
        public string WindowsDescription { get; }

        [JsonProperty("glazed-area")]
        public string GlazedArea { get; }

        [JsonProperty("inspection-date")]
        public string InspectionDate { get; }

        [JsonProperty("mains-gas-flag")]
        public string MainsGasFlag { get; }

        [JsonProperty("co2-emiss-curr-per-floor-area")]
        public string Co2EmissCurrPerFloorArea { get; }

        [JsonProperty("address1")]
        public string Address1 { get; }

        [JsonProperty("heat-loss-corridor")]
        public string HeatLossCorridor { get; }

        [JsonProperty("flat-storey-count")]
        public string FlatStoreyCount { get; }

        [JsonProperty("constituency-label")]
        public string ConstituencyLabel { get; }

        [JsonProperty("roof-energy-eff")]
        public string RoofEnergyEff { get; }

        [JsonProperty("total-floor-area")]
        public string TotalFloorArea { get; }

        [JsonProperty("building-reference-number")]
        public string BuildingReferenceNumber { get; }

        [JsonProperty("environment-impact-current")]
        public string EnvironmentImpactCurrent { get; }

        [JsonProperty("co2-emissions-current")]
        public string Co2EmissionsCurrent { get; }

        [JsonProperty("roof-description")]
        public string RoofDescription { get; }

        [JsonProperty("floor-energy-eff")]
        public string FloorEnergyEff { get; }

        [JsonProperty("number-habitable-rooms")]
        public string NumberHabitableRooms { get; }

        [JsonProperty("address2")]
        public string Address2 { get; }

        [JsonProperty("hot-water-env-eff")]
        public string HotWaterEnvEff { get; }

        [JsonProperty("posttown")]
        public string Posttown { get; }

        [JsonProperty("mainheatc-energy-eff")]
        public string MainheatcEnergyEff { get; }

        [JsonProperty("main-fuel")]
        public string MainFuel { get; }

        [JsonProperty("lighting-env-eff")]
        public string LightingEnvEff { get; }

        [JsonProperty("windows-energy-eff")]
        public string WindowsEnergyEff { get; }

        [JsonProperty("floor-env-eff")]
        public string FloorEnvEff { get; }

        [JsonProperty("sheating-env-eff")]
        public string SheatingEnvEff { get; }

        [JsonProperty("lighting-description")]
        public string LightingDescription { get; }

        [JsonProperty("roof-env-eff")]
        public string RoofEnvEff { get; }

        [JsonProperty("walls-energy-eff")]
        public string WallsEnergyEff { get; }

        [JsonProperty("photo-supply")]
        public string PhotoSupply { get; }

        [JsonProperty("lighting-cost-potential")]
        public string LightingCostPotential { get; }

        [JsonProperty("mainheat-env-eff")]
        public string MainheatEnvEff { get; }

        [JsonProperty("multi-glaze-proportion")]
        public string MultiGlazeProportion { get; }

        [JsonProperty("main-heating-controls")]
        public string MainHeatingControls { get; }

        [JsonProperty("lodgement-datetime")]
        public string LodgementDatetime { get; }

        [JsonProperty("flat-top-storey")]
        public string FlatTopStorey { get; }

        [JsonProperty("current-energy-rating")]
        public string CurrentEnergyRating { get; }

        [JsonProperty("secondheat-description")]
        public string SecondheatDescription { get; }

        [JsonProperty("walls-env-eff")]
        public string WallsEnvEff { get; }

        [JsonProperty("transaction-type")]
        public string TransactionType { get; }

        [JsonProperty("uprn")]
        public string Uprn { get; }

        [JsonProperty("current-energy-efficiency")]
        public string CurrentEnergyEfficiency { get; }

        [JsonProperty("energy-consumption-current")]
        public string EnergyConsumptionCurrent { get; }

        [JsonProperty("mainheat-description")]
        public string MainheatDescription { get; }

        [JsonProperty("lighting-cost-current")]
        public string LightingCostCurrent { get; }

        [JsonProperty("lodgement-date")]
        public string LodgementDate { get; }

        [JsonProperty("extension-count")]
        public string ExtensionCount { get; }

        [JsonProperty("mainheatc-env-eff")]
        public string MainheatcEnvEff { get; }

        [JsonProperty("lmk-key")]
        public string LmkKey { get; }

        [JsonProperty("wind-turbine-count")]
        public string WindTurbineCount { get; }

        [JsonProperty("tenure")]
        public string Tenure { get; }

        [JsonProperty("floor-level")]
        public string FloorLevel { get; }

        [JsonProperty("potential-energy-efficiency")]
        public string PotentialEnergyEfficiency { get; }

        [JsonProperty("hot-water-energy-eff")]
        public string HotWaterEnergyEff { get; }

        [JsonProperty("low-energy-lighting")]
        public string LowEnergyLighting { get; }

        [JsonProperty("walls-description")]
        public string WallsDescription { get; }

        [JsonProperty("hotwater-description")]
        public string HotwaterDescription { get; }
    }


}
