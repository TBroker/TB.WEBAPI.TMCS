using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Voluntarys
{
    public class VoluntaryPolicyDetailResponse
    {
        [JsonPropertyName("BRANCH_CODE")]
        public string? BranchCode { get; set; }

        [JsonPropertyName("REC_TYPE")]
        public string? RecType { get; set; }

        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("AGENT_NAME")]
        public string? AgentName { get; set; }

        [JsonPropertyName("INS_COMP")]
        public string? InsCompanyCode { get; set; }

        [JsonPropertyName("INS_COMP_NAME_T")]
        public string? InsCompanyName { get; set; }

        [JsonPropertyName("POLICY_TYPE")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("SUBPOLICY")]
        public string? SubPolicy { get; set; }

        [JsonPropertyName("INS_START_DATE")]
        public string? InsStartDate { get; set; }

        [JsonPropertyName("INS_END_DATE")]
        public string? InsEndDate { get; set; }

        [JsonPropertyName("ALLDAY")]
        public int CoverToltalDay { get; set; }

        [JsonPropertyName("POLICY_NO")]
        public string? PolicyNo { get; set; }

        [JsonPropertyName("APP_NO")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("POL_FLAG_NEW")]
        public string? FlagPolicyNew { get; set; }

        [JsonPropertyName("POL_RENEW_FROM")]
        public object? PolicyRenewFrom { get; set; }

        [JsonPropertyName("POL_RENEW_TO")]
        public object? PolicyRenewTo { get; set; }

        [JsonPropertyName("PRENAME_INS")]
        public string? PrenameIns { get; set; }

        [JsonPropertyName("NAME_INS")]
        public string? NameIns { get; set; }

        [JsonPropertyName("SURNAME_INS")]
        public string? SurNameIns { get; set; }

        [JsonPropertyName("ID_CARD_1")]
        public string? CardID { get; set; }

        [JsonPropertyName("ADDR")]
        public string? Addr { get; set; }

        [JsonPropertyName("SUBDISTRIC")]
        public string? SubDistrict { get; set; }

        [JsonPropertyName("DISTRICT_NAME_INS")]
        public string? DistrictNameIns { get; set; }

        [JsonPropertyName("PROV_NAME_INS")]
        public string? ProvinceNameIns { get; set; }

        [JsonPropertyName("ZIPCODE")]
        public string? ZipCode { get; set; }

        [JsonPropertyName("PHONE1")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("DIST_CODE")]
        public string? DistrictCode { get; set; }

        [JsonPropertyName("PROV_CODE")]
        public string? ProvinceCode { get; set; }

        [JsonPropertyName("SEND_PREFIX")]
        public object? SendPrefix { get; set; }

        [JsonPropertyName("SEND_NAME")]
        public string? SendName { get; set; }

        [JsonPropertyName("SEND_SURNAME")]
        public string? SendSurName { get; set; }

        [JsonPropertyName("SEND_ADDR1")]
        public string? SendAddr1 { get; set; }

        [JsonPropertyName("SEND_ADDR2")]
        public string? SendAddr2 { get; set; }

        [JsonPropertyName("SEND_DISTRICT")]
        public string? SendDistrict { get; set; }

        [JsonPropertyName("SEND_PROVINCE")]
        public string? SendProvince { get; set; }

        [JsonPropertyName("SEND_POSTCODE")]
        public string? SendPostCode { get; set; }

        [JsonPropertyName("SEND_TEL")]
        public string? SendTel { get; set; }

        [JsonPropertyName("SENDPOLICY_DIST")]
        public string? SendPolicyDistrict { get; set; }

        [JsonPropertyName("SENDPOLICY_PROV")]
        public string? SendPolicyProvince { get; set; }

        [JsonPropertyName("PREN_NAME_DRI1")]
        public object? Driver1PreName { get; set; }

        [JsonPropertyName("DRIVER1_NAME")]
        public object? Driver1Name { get; set; }

        [JsonPropertyName("DRIVER1_SURNAME")]
        public object? Driver1Surname { get; set; }

        [JsonPropertyName("PREN_NAME_DRI2")]
        public object? Driver2Prename { get; set; }

        [JsonPropertyName("DRIVER2_NAME")]
        public object? Driver2Name { get; set; }

        [JsonPropertyName("DRIVER2_SURNAME")]
        public object? Driver2Surname { get; set; }

        [JsonPropertyName("PROFIT_NAME")]
        public string? ProfitName { get; set; }

        [JsonPropertyName("CODECAR")]
        public string? CodeCar { get; set; }

        [JsonPropertyName("CAR_DOCUMENT")]
        public string? CarDocument { get; set; }

        [JsonPropertyName("CARNAME")]
        public string? CarName { get; set; }

        [JsonPropertyName("CARCLASS")]
        public string? CarClass { get; set; }

        [JsonPropertyName("CAR_CODE")]
        public string? CarCode { get; set; }

        [JsonPropertyName("CARCLASS_CODE")]
        public string? CarClassCode { get; set; }

        [JsonPropertyName("CARREG_NO_PRE")]
        public string? CarRegisNoPre { get; set; }

        [JsonPropertyName("CARREG_NO")]
        public string? CarRegNo { get; set; }

        [JsonPropertyName("PROV_CAR")]
        public string? ProvinceCar { get; set; }

        [JsonPropertyName("PROV_CAR_CODE")]
        public string? ProvinceCarCode { get; set; }

        [JsonPropertyName("COLOUR_CODE")]
        public string? ColourCode { get; set; }

        [JsonPropertyName("COLOUR")]
        public string? Colour { get; set; }

        [JsonPropertyName("COACH_NO")]
        public string? CoachNo { get; set; }

        [JsonPropertyName("MOTOR_NUM")]
        public object? MotorNum { get; set; }

        [JsonPropertyName("NUMBER_GAS")]
        public object? NumBerGas { get; set; }

        [JsonPropertyName("CAR_YEAR")]
        public string? CarYear { get; set; }

        [JsonPropertyName("CAR_REGIST")]
        public string? CarRegis { get; set; }

        [JsonPropertyName("CAR_MODEL")]
        public string? CarModel { get; set; }

        [JsonPropertyName("CAR_SEAT_V")]
        public string? CarSeatV { get; set; }

        [JsonPropertyName("CAR_SIZE_V")]
        public string? CarSizeV { get; set; }

        [JsonPropertyName("CAR_WEIGH_V")]
        public string? CarWeighV { get; set; }

        [JsonPropertyName("WOUNDRATEH")]
        public object? WoundRateH { get; set; }

        [JsonPropertyName("WOUNDRATET")]
        public object? WoundRateT { get; set; }

        [JsonPropertyName("WOUNDRATEA")]
        public object? WoundRateA { get; set; }

        [JsonPropertyName("OTHDAMAGE")]
        public object? OthDamage { get; set; }

        [JsonPropertyName("MONEYCOST")]
        public int MoneyCost { get; set; }

        [JsonPropertyName("CARDAMAGE")]
        public int CarDamage { get; set; }

        [JsonPropertyName("CARLOSS")]
        public int CarLoss { get; set; }

        [JsonPropertyName("FLAGCARDAMAGE")]
        public object? FlagCarDamage { get; set; }

        [JsonPropertyName("REPAIR_DESC")]
        public string? RepairDesc { get; set; }

        [JsonPropertyName("REPAIR_CODE")]
        public string? RepairCode { get; set; }

        [JsonPropertyName("NET_PREM_AMT")]
        public int NetPremiumAmt { get; set; }

        [JsonPropertyName("STAMP_DUTY_AMT")]
        public int TaxPremiumAmt { get; set; }

        [JsonPropertyName("VAT_AMT")]
        public double VatPremiumAmt { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT")]
        public double TotalPremiumAmt { get; set; }

        [JsonPropertyName("ENDORSE_SEQ")]
        public int EndorseSeq { get; set; }

        [JsonPropertyName("POL_CANCEL_DATE")]
        public object? PolicyCancleDate { get; set; }

        [JsonPropertyName("REMARKCANCLE")]
        public object? REMARKCANCLE { get; set; }

        [JsonPropertyName("APP_NO_COMP")]
        public object? AppNoCMI { get; set; }

        [JsonPropertyName("PRENAME_CODE")]
        public string? PreNameCode { get; set; }

        [JsonPropertyName("FLG_PERSON")]
        public string? FlagPerson { get; set; }

        [JsonPropertyName("INS_IDCARD")]
        public object? InsCardID { get; set; }

        [JsonPropertyName("CUST_TYPECARD_CODE")]
        public object? CustTypeCardCode { get; set; }

        [JsonPropertyName("INS_BIRTHDATE")]
        public object? InsBirthDate { get; set; }

        [JsonPropertyName("OCCUP_CODE")]
        public object? OccupationCode { get; set; }

        [JsonPropertyName("BENEFIC_NAME")]
        public object? BeneficName { get; set; }

        [JsonPropertyName("SUBINS_TYPE")]
        public string? SubInsureType { get; set; }
    }
}